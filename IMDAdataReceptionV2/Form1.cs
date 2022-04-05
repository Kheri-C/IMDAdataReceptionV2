using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using System.Net;
using System.Net.Sockets;

namespace IMDAdataReceptionV2 {
    public partial class Form1 : Form {

        List<int> xValues = new List<int>();
        List<int> yValues = new List<int>();
        int n = 1;
        IPAddress ip;
        int port;

        public Form1() {
            InitializeComponent();
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.Gainsboro;
            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.Gainsboro;
            chart1.Series[0].BorderWidth = 5;
            getAvailablePorts();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(OnDataReceived);
        }

        void getAvailablePorts() {
            String[] ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);
        }

        private void button3_Click(object sender, EventArgs e) {
            try {
                if(comboBox1.Text == "" || comboBox2.Text == "") {
                    textBox2.Text = "Please select port settings";
                }
                else {
                    serialPort1.PortName = comboBox1.Text;
                    serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
                    serialPort1.Open();
                    serialOpenButton.Enabled = false;
                    serialCloseButton.Enabled = true;
                }
            }
            catch (UnauthorizedAccessException) {
                textBox2.Text = "Unauthorized Access";
            }
        }

        private void button4_Click(object sender, EventArgs e) {
            serialPort1.Close();
            serialCloseButton.Enabled = false;
            serialOpenButton.Enabled = true;
        }

        private void OnDataReceived(object sender, SerialDataReceivedEventArgs e) {
            this.Invoke((MethodInvoker)delegate {
                textBox2.Text = serialPort1.ReadLine();
                if (n < 11) {
                    xValues.Add(n);
                    yValues.Add(Convert.ToInt32(textBox2.Text));
                    n++;
                    chart1.Series["Series1"].Points.DataBindXY(xValues, yValues);
                    chart1.Invalidate();
                }
                else {
                    for(int i=1; i<10; i++) {
                        yValues[i - 1] = yValues[i];
                    }
                    yValues[9] = Convert.ToInt32(serialPort1.ReadLine());
                    chart1.Series["Series1"].Points.DataBindXY(xValues, yValues);
                    chart1.Invalidate();
                }
                
            });
        }

        private void udpOnButton_Click(object sender, EventArgs e) {
            if(IPAddress.TryParse(textBox3.Text, out ip) && int.TryParse(textBox4.Text, out port)) {

            }
            else {
                textBox1.Text = "Please enter a correct IP address and port";
            }
        }
    }
}
