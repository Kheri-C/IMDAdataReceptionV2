
namespace IMDAdataReceptionV2 {
    partial class ComLink {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComLink));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.serialcloseButton = new System.Windows.Forms.Button();
            this.serialChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.serialrecieveTextBox = new System.Windows.Forms.TextBox();
            this.baudrateLabel = new System.Windows.Forms.Label();
            this.serialopenButton = new System.Windows.Forms.Button();
            this.availableportBox = new System.Windows.Forms.ComboBox();
            this.baudrateBox = new System.Windows.Forms.ComboBox();
            this.availableportLabel = new System.Windows.Forms.Label();
            this.udpGroupBox = new System.Windows.Forms.GroupBox();
            this.udpnotificationLabel = new System.Windows.Forms.Label();
            this.udpchatListBox = new System.Windows.Forms.ListBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusIndicator = new System.Windows.Forms.ProgressBar();
            this.portinputTextBox = new System.Windows.Forms.TextBox();
            this.ipaddressTextBox = new System.Windows.Forms.TextBox();
            this.messagehistoryLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.udpOnOffButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.manualdataButton = new System.Windows.Forms.Button();
            this.testingGroupBox = new System.Windows.Forms.GroupBox();
            this.manualdataGroupBox = new System.Windows.Forms.GroupBox();
            this.randommanualdatacCheckBox = new System.Windows.Forms.CheckBox();
            this.manualdataUpDown = new System.Windows.Forms.NumericUpDown();
            this.timerrandomdataGroupBox = new System.Windows.Forms.GroupBox();
            this.timermilisecondsLabel = new System.Windows.Forms.Label();
            this.timermilisecondsUpDown = new System.Windows.Forms.NumericUpDown();
            this.timerrandomdataButtonOn = new System.Windows.Forms.Button();
            this.timerrandomdataoffButton = new System.Windows.Forms.Button();
            this.serialGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serialChart)).BeginInit();
            this.udpGroupBox.SuspendLayout();
            this.testingGroupBox.SuspendLayout();
            this.manualdataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manualdataUpDown)).BeginInit();
            this.timerrandomdataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timermilisecondsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // serialGroupBox
            // 
            this.serialGroupBox.Controls.Add(this.label4);
            this.serialGroupBox.Controls.Add(this.serialcloseButton);
            this.serialGroupBox.Controls.Add(this.serialChart);
            this.serialGroupBox.Controls.Add(this.serialrecieveTextBox);
            this.serialGroupBox.Controls.Add(this.baudrateLabel);
            this.serialGroupBox.Controls.Add(this.serialopenButton);
            this.serialGroupBox.Controls.Add(this.availableportBox);
            this.serialGroupBox.Controls.Add(this.baudrateBox);
            this.serialGroupBox.Controls.Add(this.availableportLabel);
            this.serialGroupBox.Location = new System.Drawing.Point(12, 12);
            this.serialGroupBox.Name = "serialGroupBox";
            this.serialGroupBox.Size = new System.Drawing.Size(378, 401);
            this.serialGroupBox.TabIndex = 2;
            this.serialGroupBox.TabStop = false;
            this.serialGroupBox.Text = "Serial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Received data";
            // 
            // serialcloseButton
            // 
            this.serialcloseButton.Enabled = false;
            this.serialcloseButton.Location = new System.Drawing.Point(196, 372);
            this.serialcloseButton.Name = "serialcloseButton";
            this.serialcloseButton.Size = new System.Drawing.Size(157, 23);
            this.serialcloseButton.TabIndex = 4;
            this.serialcloseButton.Text = "Close Port";
            this.serialcloseButton.UseVisualStyleBackColor = true;
            this.serialcloseButton.Click += new System.EventHandler(this.serialcloseButton_Click);
            // 
            // serialChart
            // 
            chartArea1.Name = "ChartArea1";
            this.serialChart.ChartAreas.Add(chartArea1);
            this.serialChart.Location = new System.Drawing.Point(6, 139);
            this.serialChart.Name = "serialChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.serialChart.Series.Add(series1);
            this.serialChart.Size = new System.Drawing.Size(366, 227);
            this.serialChart.TabIndex = 10;
            this.serialChart.Text = "chart1";
            // 
            // serialrecieveTextBox
            // 
            this.serialrecieveTextBox.Enabled = false;
            this.serialrecieveTextBox.Location = new System.Drawing.Point(6, 98);
            this.serialrecieveTextBox.Multiline = true;
            this.serialrecieveTextBox.Name = "serialrecieveTextBox";
            this.serialrecieveTextBox.ReadOnly = true;
            this.serialrecieveTextBox.Size = new System.Drawing.Size(366, 23);
            this.serialrecieveTextBox.TabIndex = 0;
            // 
            // baudrateLabel
            // 
            this.baudrateLabel.AutoSize = true;
            this.baudrateLabel.Location = new System.Drawing.Point(193, 26);
            this.baudrateLabel.Name = "baudrateLabel";
            this.baudrateLabel.Size = new System.Drawing.Size(58, 13);
            this.baudrateLabel.TabIndex = 8;
            this.baudrateLabel.Text = "Baud Rate";
            // 
            // serialopenButton
            // 
            this.serialopenButton.Location = new System.Drawing.Point(6, 372);
            this.serialopenButton.Name = "serialopenButton";
            this.serialopenButton.Size = new System.Drawing.Size(158, 23);
            this.serialopenButton.TabIndex = 3;
            this.serialopenButton.Text = "Open Port";
            this.serialopenButton.UseVisualStyleBackColor = true;
            this.serialopenButton.Click += new System.EventHandler(this.serialopenButton_Click);
            // 
            // availableportBox
            // 
            this.availableportBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.availableportBox.FormattingEnabled = true;
            this.availableportBox.Location = new System.Drawing.Point(6, 43);
            this.availableportBox.Name = "availableportBox";
            this.availableportBox.Size = new System.Drawing.Size(121, 21);
            this.availableportBox.TabIndex = 5;
            // 
            // baudrateBox
            // 
            this.baudrateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudrateBox.FormattingEnabled = true;
            this.baudrateBox.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.baudrateBox.Location = new System.Drawing.Point(196, 43);
            this.baudrateBox.Name = "baudrateBox";
            this.baudrateBox.Size = new System.Drawing.Size(121, 21);
            this.baudrateBox.TabIndex = 6;
            // 
            // availableportLabel
            // 
            this.availableportLabel.AutoSize = true;
            this.availableportLabel.Location = new System.Drawing.Point(3, 27);
            this.availableportLabel.Name = "availableportLabel";
            this.availableportLabel.Size = new System.Drawing.Size(77, 13);
            this.availableportLabel.TabIndex = 7;
            this.availableportLabel.Text = "Available Ports";
            // 
            // udpGroupBox
            // 
            this.udpGroupBox.Controls.Add(this.udpnotificationLabel);
            this.udpGroupBox.Controls.Add(this.udpchatListBox);
            this.udpGroupBox.Controls.Add(this.statusLabel);
            this.udpGroupBox.Controls.Add(this.statusIndicator);
            this.udpGroupBox.Controls.Add(this.portinputTextBox);
            this.udpGroupBox.Controls.Add(this.ipaddressTextBox);
            this.udpGroupBox.Controls.Add(this.messagehistoryLabel);
            this.udpGroupBox.Controls.Add(this.label5);
            this.udpGroupBox.Controls.Add(this.udpOnOffButton);
            this.udpGroupBox.Controls.Add(this.label6);
            this.udpGroupBox.Location = new System.Drawing.Point(410, 12);
            this.udpGroupBox.Name = "udpGroupBox";
            this.udpGroupBox.Size = new System.Drawing.Size(462, 401);
            this.udpGroupBox.TabIndex = 11;
            this.udpGroupBox.TabStop = false;
            this.udpGroupBox.Text = "UDP";
            // 
            // udpnotificationLabel
            // 
            this.udpnotificationLabel.AutoSize = true;
            this.udpnotificationLabel.Enabled = false;
            this.udpnotificationLabel.Location = new System.Drawing.Point(170, 377);
            this.udpnotificationLabel.Name = "udpnotificationLabel";
            this.udpnotificationLabel.Size = new System.Drawing.Size(13, 13);
            this.udpnotificationLabel.TabIndex = 16;
            this.udpnotificationLabel.Text = "_";
            // 
            // udpchatListBox
            // 
            this.udpchatListBox.FormattingEnabled = true;
            this.udpchatListBox.Location = new System.Drawing.Point(6, 102);
            this.udpchatListBox.Name = "udpchatListBox";
            this.udpchatListBox.Size = new System.Drawing.Size(450, 264);
            this.udpchatListBox.TabIndex = 14;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(313, 377);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(37, 13);
            this.statusLabel.TabIndex = 12;
            this.statusLabel.Text = "Status";
            // 
            // statusIndicator
            // 
            this.statusIndicator.Location = new System.Drawing.Point(356, 372);
            this.statusIndicator.Name = "statusIndicator";
            this.statusIndicator.Size = new System.Drawing.Size(100, 23);
            this.statusIndicator.TabIndex = 11;
            // 
            // portinputTextBox
            // 
            this.portinputTextBox.Location = new System.Drawing.Point(196, 43);
            this.portinputTextBox.Name = "portinputTextBox";
            this.portinputTextBox.Size = new System.Drawing.Size(100, 20);
            this.portinputTextBox.TabIndex = 10;
            // 
            // ipaddressTextBox
            // 
            this.ipaddressTextBox.Enabled = false;
            this.ipaddressTextBox.Location = new System.Drawing.Point(6, 44);
            this.ipaddressTextBox.Name = "ipaddressTextBox";
            this.ipaddressTextBox.Size = new System.Drawing.Size(158, 20);
            this.ipaddressTextBox.TabIndex = 9;
            // 
            // messagehistoryLabel
            // 
            this.messagehistoryLabel.AutoSize = true;
            this.messagehistoryLabel.Location = new System.Drawing.Point(3, 82);
            this.messagehistoryLabel.Name = "messagehistoryLabel";
            this.messagehistoryLabel.Size = new System.Drawing.Size(83, 13);
            this.messagehistoryLabel.TabIndex = 8;
            this.messagehistoryLabel.Text = "Message history";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Port";
            // 
            // udpOnOffButton
            // 
            this.udpOnOffButton.Location = new System.Drawing.Point(6, 372);
            this.udpOnOffButton.Name = "udpOnOffButton";
            this.udpOnOffButton.Size = new System.Drawing.Size(158, 23);
            this.udpOnOffButton.TabIndex = 3;
            this.udpOnOffButton.Text = "Turn ON / OFF";
            this.udpOnOffButton.UseVisualStyleBackColor = true;
            this.udpOnOffButton.Click += new System.EventHandler(this.udponoffButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "IP Address";
            // 
            // manualdataButton
            // 
            this.manualdataButton.Location = new System.Drawing.Point(6, 19);
            this.manualdataButton.Name = "manualdataButton";
            this.manualdataButton.Size = new System.Drawing.Size(123, 23);
            this.manualdataButton.TabIndex = 12;
            this.manualdataButton.Text = "Add input value";
            this.manualdataButton.UseVisualStyleBackColor = true;
            this.manualdataButton.Click += new System.EventHandler(this.manualdataButton_Click);
            // 
            // testingGroupBox
            // 
            this.testingGroupBox.Controls.Add(this.manualdataGroupBox);
            this.testingGroupBox.Controls.Add(this.timerrandomdataGroupBox);
            this.testingGroupBox.Location = new System.Drawing.Point(410, 419);
            this.testingGroupBox.Name = "testingGroupBox";
            this.testingGroupBox.Size = new System.Drawing.Size(462, 130);
            this.testingGroupBox.TabIndex = 13;
            this.testingGroupBox.TabStop = false;
            this.testingGroupBox.Text = "Testing Area";
            // 
            // manualdataGroupBox
            // 
            this.manualdataGroupBox.Controls.Add(this.randommanualdatacCheckBox);
            this.manualdataGroupBox.Controls.Add(this.manualdataUpDown);
            this.manualdataGroupBox.Controls.Add(this.manualdataButton);
            this.manualdataGroupBox.Location = new System.Drawing.Point(6, 24);
            this.manualdataGroupBox.Name = "manualdataGroupBox";
            this.manualdataGroupBox.Size = new System.Drawing.Size(213, 100);
            this.manualdataGroupBox.TabIndex = 14;
            this.manualdataGroupBox.TabStop = false;
            this.manualdataGroupBox.Text = "Manual Data";
            // 
            // randommanualdatacCheckBox
            // 
            this.randommanualdatacCheckBox.AutoSize = true;
            this.randommanualdatacCheckBox.Location = new System.Drawing.Point(68, 64);
            this.randommanualdatacCheckBox.Name = "randommanualdatacCheckBox";
            this.randommanualdatacCheckBox.Size = new System.Drawing.Size(90, 17);
            this.randommanualdatacCheckBox.TabIndex = 13;
            this.randommanualdatacCheckBox.Text = "Random data";
            this.randommanualdatacCheckBox.UseVisualStyleBackColor = true;
            this.randommanualdatacCheckBox.CheckedChanged += new System.EventHandler(this.randommanualdatacCheckBox_CheckedChanged);
            // 
            // manualdataUpDown
            // 
            this.manualdataUpDown.Location = new System.Drawing.Point(155, 22);
            this.manualdataUpDown.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.manualdataUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.manualdataUpDown.Name = "manualdataUpDown";
            this.manualdataUpDown.Size = new System.Drawing.Size(42, 20);
            this.manualdataUpDown.TabIndex = 4;
            this.manualdataUpDown.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // timerrandomdataGroupBox
            // 
            this.timerrandomdataGroupBox.Controls.Add(this.timermilisecondsLabel);
            this.timerrandomdataGroupBox.Controls.Add(this.timermilisecondsUpDown);
            this.timerrandomdataGroupBox.Controls.Add(this.timerrandomdataButtonOn);
            this.timerrandomdataGroupBox.Controls.Add(this.timerrandomdataoffButton);
            this.timerrandomdataGroupBox.Location = new System.Drawing.Point(235, 24);
            this.timerrandomdataGroupBox.Name = "timerrandomdataGroupBox";
            this.timerrandomdataGroupBox.Size = new System.Drawing.Size(221, 100);
            this.timerrandomdataGroupBox.TabIndex = 13;
            this.timerrandomdataGroupBox.TabStop = false;
            this.timerrandomdataGroupBox.Text = "Timer Random Data";
            // 
            // timermilisecondsLabel
            // 
            this.timermilisecondsLabel.AutoSize = true;
            this.timermilisecondsLabel.Location = new System.Drawing.Point(108, 34);
            this.timermilisecondsLabel.Name = "timermilisecondsLabel";
            this.timermilisecondsLabel.Size = new System.Drawing.Size(87, 13);
            this.timermilisecondsLabel.TabIndex = 3;
            this.timermilisecondsLabel.Text = "Period cycle (ms)";
            // 
            // timermilisecondsUpDown
            // 
            this.timermilisecondsUpDown.Location = new System.Drawing.Point(121, 58);
            this.timermilisecondsUpDown.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.timermilisecondsUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.timermilisecondsUpDown.Name = "timermilisecondsUpDown";
            this.timermilisecondsUpDown.Size = new System.Drawing.Size(64, 20);
            this.timermilisecondsUpDown.TabIndex = 2;
            this.timermilisecondsUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // timerrandomdataButtonOn
            // 
            this.timerrandomdataButtonOn.Location = new System.Drawing.Point(17, 29);
            this.timerrandomdataButtonOn.Name = "timerrandomdataButtonOn";
            this.timerrandomdataButtonOn.Size = new System.Drawing.Size(75, 23);
            this.timerrandomdataButtonOn.TabIndex = 1;
            this.timerrandomdataButtonOn.Text = "On";
            this.timerrandomdataButtonOn.UseVisualStyleBackColor = true;
            this.timerrandomdataButtonOn.Click += new System.EventHandler(this.timerrandomdataButtonOn_Click);
            // 
            // timerrandomdataoffButton
            // 
            this.timerrandomdataoffButton.Location = new System.Drawing.Point(17, 58);
            this.timerrandomdataoffButton.Name = "timerrandomdataoffButton";
            this.timerrandomdataoffButton.Size = new System.Drawing.Size(75, 23);
            this.timerrandomdataoffButton.TabIndex = 0;
            this.timerrandomdataoffButton.Text = "Off";
            this.timerrandomdataoffButton.UseVisualStyleBackColor = true;
            this.timerrandomdataoffButton.Click += new System.EventHandler(this.timerrandomdataoffButton_Click);
            // 
            // ComLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.testingGroupBox);
            this.Controls.Add(this.udpGroupBox);
            this.Controls.Add(this.serialGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ComLink";
            this.Text = "ComLinK";
            this.serialGroupBox.ResumeLayout(false);
            this.serialGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serialChart)).EndInit();
            this.udpGroupBox.ResumeLayout(false);
            this.udpGroupBox.PerformLayout();
            this.testingGroupBox.ResumeLayout(false);
            this.manualdataGroupBox.ResumeLayout(false);
            this.manualdataGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manualdataUpDown)).EndInit();
            this.timerrandomdataGroupBox.ResumeLayout(false);
            this.timerrandomdataGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timermilisecondsUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox serialGroupBox;
        private System.Windows.Forms.TextBox serialrecieveTextBox;
        private System.Windows.Forms.Button serialopenButton;
        private System.Windows.Forms.Button serialcloseButton;
        private System.Windows.Forms.ComboBox availableportBox;
        private System.Windows.Forms.ComboBox baudrateBox;
        private System.Windows.Forms.Label availableportLabel;
        private System.Windows.Forms.Label baudrateLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart serialChart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox udpGroupBox;
        private System.Windows.Forms.Label messagehistoryLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button udpOnOffButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox portinputTextBox;
        private System.Windows.Forms.TextBox ipaddressTextBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ProgressBar statusIndicator;
        private System.Windows.Forms.Button manualdataButton;
        private System.Windows.Forms.ListBox udpchatListBox;
        private System.Windows.Forms.Label udpnotificationLabel;
        private System.Windows.Forms.GroupBox testingGroupBox;
        private System.Windows.Forms.GroupBox manualdataGroupBox;
        private System.Windows.Forms.GroupBox timerrandomdataGroupBox;
        private System.Windows.Forms.Button timerrandomdataButtonOn;
        private System.Windows.Forms.Button timerrandomdataoffButton;
        private System.Windows.Forms.Label timermilisecondsLabel;
        private System.Windows.Forms.NumericUpDown timermilisecondsUpDown;
        private System.Windows.Forms.CheckBox randommanualdatacCheckBox;
        private System.Windows.Forms.NumericUpDown manualdataUpDown;
    }
}

