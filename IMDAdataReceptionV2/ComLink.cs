using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Timers;
using System.Linq;

namespace IMDAdataReceptionV2 {

    //TODO - Make WiFi connection using UDP
    //TODO - create buffered chart handler (udp connection too fast)
    //TODO - asnyc wait for input data to send data throug UDP to Animod -> Optimization
    public partial class ComLink : Form {

        //--BACKEND--

        // Input variables from Serial or WiFi/UDP
        Queue<double> inputValues = new Queue<double>();

        // UDP variables
        int port;
        String hostAddress;
        UdpClient udpServer;
        [ThreadStatic]
        public static IPEndPoint remoteEP;      //Thread static tag allows to modify this from a thread (no port reading => solution fix)

        // UDP Flags and threads
        Thread serverThread;
        bool status, started = false, turnedOff;

        //--GUI--

        //Chart variables
        int xChartRange = 10;
        Queue<double> chartValues = new Queue<double>();

        //UDP Chat variables
        Queue<String> udpchatqueue = new Queue<String>();
        int udpchatRows = 25;
         
        //Misc and testingvariables
        Random random = new Random();
        private static System.Timers.Timer aTimer;
        bool timerOn = false;



        public ComLink() {
            InitializeComponent();
            InitSerial();
            InitUDP();
            CustomizeInterface();

        }

        #region Init Functions
        private void CustomizeInterface()
        {
            // Serial Chart
            serialChart.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
            serialChart.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.Gainsboro;
            serialChart.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.Gainsboro;
            serialChart.Series[0].BorderWidth = 5;
        }
        private void InitSerial()
        {
            String[] ports = SerialPort.GetPortNames();                                             // Get availabre Serial ports
            availableportBox.Items.AddRange(ports);                                                 // Display the ports
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(OnSerialDataRecieved);
        }
        private void InitUDP()
        {
            hostAddress = Dns.GetHostEntry(Dns.GetHostName()).AddressList[0].ToString();            // Get server's IP Address
            ipaddressTextBox.Text = hostAddress;                                                       // Display the server's IP Address
        }
        #endregion

        #region Input Methods
        private void OnSerialDataRecieved(object sender, SerialDataReceivedEventArgs e) {
            this.Invoke((MethodInvoker)delegate {
                serialrecieveTextBox.Text = serialPort1.ReadLine();
                double value = Double.Parse(serialrecieveTextBox.Text);
                inputValues.Enqueue(value);
                serialchartUpdate(inputValues,xChartRange);
                //bufferedchartUpdate(value, xChartRange);
            });
        }
        private void UDPListen() {

            while (true)
            {

                //TODO -- This is hardcoded fix it!
                remoteEP = new IPEndPoint(IPAddress.Any, port);


                // Output Data - Initialize
                String outputString = "";
                byte[] outputData = Encoding.ASCII.GetBytes(outputString);

                // Input Data - Recieve OnAwait
                byte[] inputData = udpServer.Receive(ref remoteEP);
                String inputString = Encoding.ASCII.GetString(inputData);

                if (turnedOff) { // If the server was turned off and is now turned on
                    inputString = "";
                    inputData = Encoding.ASCII.GetBytes(""); // Delete what was stored in the buffer when the server was off
                    turnedOff = false;
                }
                else {
                    switch (inputString.ToLower())
                    {
                        case "r":
                            if (inputValues.Count > 0)
                            {
                                outputString = inputValues.Dequeue().ToString();        //NOTE: inputValues come from serial or WiFi     
                            }
                            else
                            {
                                outputString = "w";                                     //On Await Tag
                            }
                            outputData = Encoding.ASCII.GetBytes(outputString);
                            break;
                        case "x":
                            outputString = "X DATA";        
                            outputData = Encoding.ASCII.GetBytes(outputString);
                            break;
                        case "y":
                            outputString = "Y DATA";       
                            outputData = Encoding.ASCII.GetBytes(outputString);
                            break;

                            default:
                            outputString = "NO VALID REQUEST!";
                            outputData = Encoding.ASCII.GetBytes(outputString);
                            break;
                    }
                        // Send data
                        try {
                        Console.WriteLine("Sending data...");
                        udpServer.Send(outputData, outputString.Length, remoteEP);
                        
                        }
                        catch
                        {
                            Console.WriteLine("No data to send!");
                             
                    }
                    udpchatqueue.Enqueue(remoteEP.Address.ToString() + " at " + DateTime.Now.ToString("hh:mm:ss.fff tt") + ": " + inputString + " | sending in response: " + outputString);
                    //Invoke udp chat update
                    Invoke((MethodInvoker)delegate {
                        udpchatUpdate();
                    });
                }
                
            }
        }
        #endregion

        #region Updaters
        private void serialchartUpdate(Queue<double> values, int xAxisSteps)
        {
            //--DECOUPLING-- UI ONLY
            // Chart variables
            List<double> valuesToChart = new List<double>();                                         //Values we want to show in chart
            List<int> xChartStep = new List<int>();                                                  //X step for x axis

            //Array manipulatinon for grabing the last (xRange) values on the (values Queue) and showing them into the chart
            double[] valuesArray = values.ToArray();
            int count = valuesArray.Length;
            int startindex = count - xAxisSteps;

            for (int i = 0; i < xAxisSteps; i++)                        //Fill x axis values 
            {
                xChartStep.Add(i);
            }
            if (count > xAxisSteps)
            {
                for (int i = startindex; i < count; i++)                 //Fill with the last (xAxisStep) from the (values Queue)
                {
                    valuesToChart.Add(valuesArray[i]);
                }
            }

            if (valuesToChart.Count > 0)                                //Check if we have enough data to show
            {
                serialChart.Series["Series1"].Points.DataBindXY(xChartStep, valuesToChart);
                serialChart.Invalidate();
            }


        }
        //TODO - fix this!
        private void bufferedchartUpdate(double value, int xAxisSteps)
        {
            List<int> xChartStep = new List<int>();

            for (int i = 0; i < xAxisSteps; i++)                        //Fill x axis values 
            {
                xChartStep.Add(i);
            }
                chartValues.Enqueue(value);

            if(chartValues.Count > xAxisSteps)
            {
                chartValues.Dequeue();
            }

            serialChart.Series["Series1"].Points.DataBindXY(xChartStep, chartValues);
            serialChart.Invalidate();


        }
        private void udpchatUpdate()
        {
            while (udpchatqueue.Count > udpchatRows) udpchatqueue.Dequeue();
            udpchatListBox.Items.Clear();
            udpchatListBox.Items.AddRange(udpchatqueue.ToArray());
        }

        #endregion

        #region Buttons
        #region Serial Buttons
        private void serialopenButton_Click(object sender, EventArgs e)
        { 
            try
            {
                if (availableportBox.Text == "" || baudrateBox.Text == "")
                {
                    serialrecieveTextBox.Text = "Please select port settings";
                }
                else
                {
                    serialPort1.PortName = availableportBox.Text;
                    serialPort1.BaudRate = Convert.ToInt32(baudrateBox.Text);
                    serialPort1.Open();
                    serialopenButton.Enabled = false;
                    serialcloseButton.Enabled = true;
                }
            }
            catch (UnauthorizedAccessException)
            {
                serialrecieveTextBox.Text = "Unauthorized Access";
            }
        }
        private void serialcloseButton_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            serialcloseButton.Enabled = false;
            serialopenButton.Enabled = true;
        }
        #endregion

        #region UDP Buttons

        //TODO - A little bit clean off
        private void udponoffButton_Click(object sender, EventArgs e)
        {
            if (!started)
            { // If the initial hasn't been done
                if (int.TryParse(portinputTextBox.Text, out int port))
                {
                    //TODO - For some reason this in the Listen() thread does not work properly.....
                    remoteEP = new IPEndPoint(IPAddress.Any,port);
                    udpServer = new UdpClient(remoteEP);
                    // Start the thread
                    serverThread = new Thread(() => UDPListen());
                    serverThread.Start();
                    statusIndicator.Value = 100;
                    status = true;
                    started = true;

                    HideNotification(udpnotificationLabel);
                }
                else
                {
                    ShowNotification(udpnotificationLabel, "Please input a correct port", NotificationType.warning);
                }
            }
            else
            { // Once the initial configuration has been done
                if (status)
                { // If the server's turned off
                    serverThread.Abort();
                    statusIndicator.Value = 0;
                    status = false;
                    turnedOff = true;
                }
                else
                { // If the server's turned on
                    serverThread = new Thread(() => UDPListen());
                    serverThread.Start();
                    statusIndicator.Value = 100;
                    status = true;
                }
            }
        }
        #endregion

        #endregion

        #region Notifications
        private void ShowNotification(Label label,String str, NotificationType notificationType)
        {
            Color color = Color.Black;
            switch (notificationType)
            {
                case NotificationType.neutral:
                    color = Color.Black;
                    break;
                case NotificationType.warning:
                    color = Color.DarkOrange;
                    break;
                case NotificationType.critical:
                    color = Color.Red;
                    break;
            }
            label.ForeColor = color;
            label.Text = str;
            if (!label.Enabled) label.Enabled = true;
        }

        private void HideNotification(Label label)
        {
            if(label.Enabled) label.Enabled = false;
            label.Text = "";
        }

        #endregion

        #region Testing

        #region Timer
 
        private  void SetTimer(int miliseconds)
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(miliseconds);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate {
                int temp = random.Next(1, 9);
                inputValues.Enqueue(temp);
                Console.WriteLine(inputValues.Count.ToString() + " Value: " + temp);
                serialchartUpdate(inputValues, xChartRange);
                //bufferedchartUpdate(temp, xChartRange);
            });
            
        }

        private void timerrandomdataButtonOn_Click(object sender, EventArgs e)
        {
            if (timerOn) return;
            timerOn = true;
            //Disable other box and elements
            manualdataGroupBox.Enabled = false;
            timermilisecondsUpDown.Enabled = false;

            //Get useful variables
            int milis = Decimal.ToInt32(timermilisecondsUpDown.Value);

            //Init timer
            SetTimer(milis);

        }

        private void timerrandomdataoffButton_Click(object sender, EventArgs e)
        {
            if (!timerOn) return;
            timerOn= false;
            manualdataGroupBox.Enabled = true;
            timermilisecondsUpDown.Enabled = true;
            aTimer.Stop();
        }
        #endregion

        #region Manual
        private void manualdataButton_Click(object sender, EventArgs e)
        {
            int manualdata;
            Console.WriteLine("Added Value");
            if (randommanualdatacCheckBox.Checked)
            {
                manualdata = random.Next(0, 10);
            }else
            {
                manualdata = Decimal.ToInt32(manualdataUpDown.Value);
            }
            inputValues.Enqueue(manualdata);
            Console.WriteLine(inputValues.Count.ToString() + " Value: " + manualdata);
            serialchartUpdate(inputValues, xChartRange);
            //bufferedchartUpdate(manualdata, xChartRange);
        }
        
        private void randommanualdatacCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (randommanualdatacCheckBox.Checked)
            {
                manualdataUpDown.Enabled = false;
            }
            else
            {
                manualdataUpDown.Enabled = true;
            }
        }

        #endregion

        #endregion
    }


}
