namespace ADCGraphTool
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DebugOutputTextBox = new System.Windows.Forms.TextBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.PIN5CheckBox = new System.Windows.Forms.CheckBox();
            this.PIN4CheckBox = new System.Windows.Forms.CheckBox();
            this.PIN3CheckBox = new System.Windows.Forms.CheckBox();
            this.PIN2CheckBox = new System.Windows.Forms.CheckBox();
            this.PIN1CheckBox = new System.Windows.Forms.CheckBox();
            this.PIN0CheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.ClearGraphIntervalLabel = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.ClearGraphIntervalTrackBar = new System.Windows.Forms.TrackBar();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.SpeedTrackBar = new System.Windows.Forms.TrackBar();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.readModeCheckbox = new System.Windows.Forms.CheckBox();
            this.AverageLabel = new System.Windows.Forms.Label();
            this.AmmountOfDataPointsLabel = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.ComPortOutput = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ApplyTriggerValueToAllPins = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ApplyTriggerButton = new System.Windows.Forms.Button();
            this.TriggerPinComboBox = new System.Windows.Forms.ComboBox();
            this.Trigger1IfValueIsBelowCheckbox = new System.Windows.Forms.CheckBox();
            this.Trigger1Label = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Trigger1TrackBar = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.ComPortSelect = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BaudRateSelect = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Pin5TriggerState = new System.Windows.Forms.GroupBox();
            this.Pin4TriggerState = new System.Windows.Forms.GroupBox();
            this.Pin3TriggerState = new System.Windows.Forms.GroupBox();
            this.Pin2TriggerState = new System.Windows.Forms.GroupBox();
            this.Pin1TriggerState = new System.Windows.Forms.GroupBox();
            this.Pin0TriggerState = new System.Windows.Forms.GroupBox();
            this.FlexibleChartWindow = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LineChart)).BeginInit();
            this.groupBox12.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClearGraphIntervalTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTrackBar)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Trigger1TrackBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.FlexibleChartWindow);
            this.groupBox2.Controls.Add(this.LineChart);
            this.groupBox2.Location = new System.Drawing.Point(210, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(662, 393);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Graph";
            // 
            // LineChart
            // 
            this.LineChart.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea1.Name = "ChartArea1";
            this.LineChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.LineChart.Legends.Add(legend1);
            this.LineChart.Location = new System.Drawing.Point(9, 16);
            this.LineChart.Name = "LineChart";
            this.LineChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.DimGray;
            series1.Legend = "Legend1";
            series1.Name = "PIN0";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "PIN1";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series3.Legend = "Legend1";
            series3.Name = "PIN2";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Teal;
            series4.Legend = "Legend1";
            series4.Name = "PIN3";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.DarkGreen;
            series5.Legend = "Legend1";
            series5.Name = "PIN4";
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.Indigo;
            series6.Legend = "Legend1";
            series6.Name = "PIN5";
            this.LineChart.Series.Add(series1);
            this.LineChart.Series.Add(series2);
            this.LineChart.Series.Add(series3);
            this.LineChart.Series.Add(series4);
            this.LineChart.Series.Add(series5);
            this.LineChart.Series.Add(series6);
            this.LineChart.Size = new System.Drawing.Size(647, 346);
            this.LineChart.TabIndex = 0;
            this.LineChart.Text = "LineChart";
            this.LineChart.DoubleClick += new System.EventHandler(this.LineChart_DoubleClick);
            // 
            // DebugOutputTextBox
            // 
            this.DebugOutputTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DebugOutputTextBox.Location = new System.Drawing.Point(8, 597);
            this.DebugOutputTextBox.Name = "DebugOutputTextBox";
            this.DebugOutputTextBox.Size = new System.Drawing.Size(984, 20);
            this.DebugOutputTextBox.TabIndex = 36;
            // 
            // groupBox12
            // 
            this.groupBox12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox12.Controls.Add(this.PIN5CheckBox);
            this.groupBox12.Controls.Add(this.PIN4CheckBox);
            this.groupBox12.Controls.Add(this.PIN3CheckBox);
            this.groupBox12.Controls.Add(this.PIN2CheckBox);
            this.groupBox12.Controls.Add(this.PIN1CheckBox);
            this.groupBox12.Controls.Add(this.PIN0CheckBox);
            this.groupBox12.Location = new System.Drawing.Point(878, 23);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(111, 393);
            this.groupBox12.TabIndex = 35;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Show ADC Values";
            // 
            // PIN5CheckBox
            // 
            this.PIN5CheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PIN5CheckBox.AutoSize = true;
            this.PIN5CheckBox.Checked = true;
            this.PIN5CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PIN5CheckBox.Location = new System.Drawing.Point(33, 153);
            this.PIN5CheckBox.Name = "PIN5CheckBox";
            this.PIN5CheckBox.Size = new System.Drawing.Size(50, 17);
            this.PIN5CheckBox.TabIndex = 31;
            this.PIN5CheckBox.Text = "PIN5";
            this.PIN5CheckBox.UseVisualStyleBackColor = true;
            this.PIN5CheckBox.CheckedChanged += new System.EventHandler(this.PIN5CheckBox_CheckedChanged);
            // 
            // PIN4CheckBox
            // 
            this.PIN4CheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PIN4CheckBox.AutoSize = true;
            this.PIN4CheckBox.Checked = true;
            this.PIN4CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PIN4CheckBox.Location = new System.Drawing.Point(33, 130);
            this.PIN4CheckBox.Name = "PIN4CheckBox";
            this.PIN4CheckBox.Size = new System.Drawing.Size(50, 17);
            this.PIN4CheckBox.TabIndex = 30;
            this.PIN4CheckBox.Text = "PIN4";
            this.PIN4CheckBox.UseVisualStyleBackColor = true;
            this.PIN4CheckBox.CheckedChanged += new System.EventHandler(this.PIN4CheckBox_CheckedChanged);
            // 
            // PIN3CheckBox
            // 
            this.PIN3CheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PIN3CheckBox.AutoSize = true;
            this.PIN3CheckBox.Checked = true;
            this.PIN3CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PIN3CheckBox.Location = new System.Drawing.Point(33, 107);
            this.PIN3CheckBox.Name = "PIN3CheckBox";
            this.PIN3CheckBox.Size = new System.Drawing.Size(50, 17);
            this.PIN3CheckBox.TabIndex = 29;
            this.PIN3CheckBox.Text = "PIN3";
            this.PIN3CheckBox.UseVisualStyleBackColor = true;
            this.PIN3CheckBox.CheckedChanged += new System.EventHandler(this.PIN3CheckBox_CheckedChanged);
            // 
            // PIN2CheckBox
            // 
            this.PIN2CheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PIN2CheckBox.AutoSize = true;
            this.PIN2CheckBox.Checked = true;
            this.PIN2CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PIN2CheckBox.Location = new System.Drawing.Point(33, 85);
            this.PIN2CheckBox.Name = "PIN2CheckBox";
            this.PIN2CheckBox.Size = new System.Drawing.Size(50, 17);
            this.PIN2CheckBox.TabIndex = 28;
            this.PIN2CheckBox.Text = "PIN2";
            this.PIN2CheckBox.UseVisualStyleBackColor = true;
            this.PIN2CheckBox.CheckedChanged += new System.EventHandler(this.PIN2CheckBox_CheckedChanged);
            // 
            // PIN1CheckBox
            // 
            this.PIN1CheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PIN1CheckBox.AutoSize = true;
            this.PIN1CheckBox.Checked = true;
            this.PIN1CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PIN1CheckBox.Location = new System.Drawing.Point(33, 62);
            this.PIN1CheckBox.Name = "PIN1CheckBox";
            this.PIN1CheckBox.Size = new System.Drawing.Size(50, 17);
            this.PIN1CheckBox.TabIndex = 27;
            this.PIN1CheckBox.Text = "PIN1";
            this.PIN1CheckBox.UseVisualStyleBackColor = true;
            this.PIN1CheckBox.CheckedChanged += new System.EventHandler(this.PIN1CheckBox_CheckedChanged);
            // 
            // PIN0CheckBox
            // 
            this.PIN0CheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PIN0CheckBox.AutoSize = true;
            this.PIN0CheckBox.Checked = true;
            this.PIN0CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PIN0CheckBox.Location = new System.Drawing.Point(33, 39);
            this.PIN0CheckBox.Name = "PIN0CheckBox";
            this.PIN0CheckBox.Size = new System.Drawing.Size(50, 17);
            this.PIN0CheckBox.TabIndex = 26;
            this.PIN0CheckBox.Text = "PIN0";
            this.PIN0CheckBox.UseVisualStyleBackColor = true;
            this.PIN0CheckBox.CheckedChanged += new System.EventHandler(this.PIN0CheckBox_CheckedChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox8.Controls.Add(this.SaveButton);
            this.groupBox8.Controls.Add(this.PauseButton);
            this.groupBox8.Controls.Add(this.ClearGraphIntervalLabel);
            this.groupBox8.Controls.Add(this.label27);
            this.groupBox8.Controls.Add(this.label26);
            this.groupBox8.Controls.Add(this.label23);
            this.groupBox8.Controls.Add(this.ClearGraphIntervalTrackBar);
            this.groupBox8.Controls.Add(this.label25);
            this.groupBox8.Controls.Add(this.label24);
            this.groupBox8.Controls.Add(this.SpeedLabel);
            this.groupBox8.Controls.Add(this.label22);
            this.groupBox8.Controls.Add(this.SpeedTrackBar);
            this.groupBox8.Location = new System.Drawing.Point(5, 186);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(199, 230);
            this.groupBox8.TabIndex = 33;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Graph Settings";
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveButton.Location = new System.Drawing.Point(33, 182);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(135, 21);
            this.SaveButton.TabIndex = 31;
            this.SaveButton.Text = "Save Data";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PauseButton.Location = new System.Drawing.Point(33, 157);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(135, 23);
            this.PauseButton.TabIndex = 28;
            this.PauseButton.Text = "Pause Graph";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // ClearGraphIntervalLabel
            // 
            this.ClearGraphIntervalLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClearGraphIntervalLabel.AutoSize = true;
            this.ClearGraphIntervalLabel.Location = new System.Drawing.Point(143, 93);
            this.ClearGraphIntervalLabel.Name = "ClearGraphIntervalLabel";
            this.ClearGraphIntervalLabel.Size = new System.Drawing.Size(31, 13);
            this.ClearGraphIntervalLabel.TabIndex = 30;
            this.ClearGraphIntervalLabel.Text = "1000";
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(21, 141);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(13, 13);
            this.label27.TabIndex = 29;
            this.label27.Text = "1";
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(143, 141);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(37, 13);
            this.label26.TabIndex = 28;
            this.label26.Text = "10000";
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(21, 93);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(66, 13);
            this.label23.TabIndex = 27;
            this.label23.Text = "X- Axle Size:";
            // 
            // ClearGraphIntervalTrackBar
            // 
            this.ClearGraphIntervalTrackBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClearGraphIntervalTrackBar.LargeChange = 500;
            this.ClearGraphIntervalTrackBar.Location = new System.Drawing.Point(21, 109);
            this.ClearGraphIntervalTrackBar.Maximum = 10000;
            this.ClearGraphIntervalTrackBar.Minimum = 1;
            this.ClearGraphIntervalTrackBar.Name = "ClearGraphIntervalTrackBar";
            this.ClearGraphIntervalTrackBar.Size = new System.Drawing.Size(160, 45);
            this.ClearGraphIntervalTrackBar.SmallChange = 100;
            this.ClearGraphIntervalTrackBar.TabIndex = 26;
            this.ClearGraphIntervalTrackBar.Value = 1000;
            this.ClearGraphIntervalTrackBar.ValueChanged += new System.EventHandler(this.ClearGraphIntervalTrackBar_ValueChanged);
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(21, 71);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(13, 13);
            this.label25.TabIndex = 25;
            this.label25.Text = "1";
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(143, 71);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(25, 13);
            this.label24.TabIndex = 22;
            this.label24.Text = "100";
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Location = new System.Drawing.Point(148, 24);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(26, 13);
            this.SpeedLabel.TabIndex = 23;
            this.SpeedLabel.Text = "1 /s";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(21, 24);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 13);
            this.label22.TabIndex = 22;
            this.label22.Text = "Speed:";
            // 
            // SpeedTrackBar
            // 
            this.SpeedTrackBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SpeedTrackBar.Location = new System.Drawing.Point(21, 45);
            this.SpeedTrackBar.Maximum = 1000;
            this.SpeedTrackBar.Minimum = 1;
            this.SpeedTrackBar.Name = "SpeedTrackBar";
            this.SpeedTrackBar.Size = new System.Drawing.Size(160, 45);
            this.SpeedTrackBar.TabIndex = 9;
            this.SpeedTrackBar.Value = 1;
            this.SpeedTrackBar.ValueChanged += new System.EventHandler(this.SpeedTrackBar_ValueChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox6.Controls.Add(this.readModeCheckbox);
            this.groupBox6.Controls.Add(this.AverageLabel);
            this.groupBox6.Controls.Add(this.AmmountOfDataPointsLabel);
            this.groupBox6.Controls.Add(this.label29);
            this.groupBox6.Controls.Add(this.label28);
            this.groupBox6.Controls.Add(this.ComPortOutput);
            this.groupBox6.Location = new System.Drawing.Point(5, 415);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(199, 176);
            this.groupBox6.TabIndex = 31;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Data Received / Status";
            // 
            // readModeCheckbox
            // 
            this.readModeCheckbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.readModeCheckbox.AutoSize = true;
            this.readModeCheckbox.Location = new System.Drawing.Point(3, 144);
            this.readModeCheckbox.Name = "readModeCheckbox";
            this.readModeCheckbox.Size = new System.Drawing.Size(186, 17);
            this.readModeCheckbox.TabIndex = 30;
            this.readModeCheckbox.Text = "Use Slow But Readable ComData";
            this.readModeCheckbox.UseVisualStyleBackColor = true;
            this.readModeCheckbox.CheckedChanged += new System.EventHandler(this.readModeCheckbox_CheckedChanged);
            // 
            // AverageLabel
            // 
            this.AverageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AverageLabel.AutoSize = true;
            this.AverageLabel.Location = new System.Drawing.Point(170, 123);
            this.AverageLabel.Name = "AverageLabel";
            this.AverageLabel.Size = new System.Drawing.Size(13, 13);
            this.AverageLabel.TabIndex = 29;
            this.AverageLabel.Text = "0";
            this.AverageLabel.UseMnemonic = false;
            // 
            // AmmountOfDataPointsLabel
            // 
            this.AmmountOfDataPointsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AmmountOfDataPointsLabel.AutoSize = true;
            this.AmmountOfDataPointsLabel.Location = new System.Drawing.Point(170, 98);
            this.AmmountOfDataPointsLabel.Name = "AmmountOfDataPointsLabel";
            this.AmmountOfDataPointsLabel.Size = new System.Drawing.Size(13, 13);
            this.AmmountOfDataPointsLabel.TabIndex = 28;
            this.AmmountOfDataPointsLabel.Text = "0";
            this.AmmountOfDataPointsLabel.UseMnemonic = false;
            // 
            // label29
            // 
            this.label29.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(0, 123);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(50, 13);
            this.label29.TabIndex = 27;
            this.label29.Text = "Average:";
            this.label29.UseMnemonic = false;
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(0, 98);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(121, 13);
            this.label28.TabIndex = 26;
            this.label28.Text = "Ammount of datapoints: ";
            this.label28.UseMnemonic = false;
            // 
            // ComPortOutput
            // 
            this.ComPortOutput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComPortOutput.Location = new System.Drawing.Point(3, 17);
            this.ComPortOutput.Name = "ComPortOutput";
            this.ComPortOutput.Size = new System.Drawing.Size(180, 75);
            this.ComPortOutput.TabIndex = 9;
            this.ComPortOutput.Text = "";
            this.ComPortOutput.MouseLeave += new System.EventHandler(this.ComPortOutput_MouseLeave);
            this.ComPortOutput.MouseHover += new System.EventHandler(this.ComPortOutput_MouseHover);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.ApplyTriggerValueToAllPins);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.ApplyTriggerButton);
            this.groupBox3.Controls.Add(this.TriggerPinComboBox);
            this.groupBox3.Controls.Add(this.Trigger1IfValueIsBelowCheckbox);
            this.groupBox3.Controls.Add(this.Trigger1Label);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.Trigger1TrackBar);
            this.groupBox3.Location = new System.Drawing.Point(210, 415);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(850, 176);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Setup Trigger Per Pin";
            // 
            // ApplyTriggerValueToAllPins
            // 
            this.ApplyTriggerValueToAllPins.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ApplyTriggerValueToAllPins.Location = new System.Drawing.Point(474, 129);
            this.ApplyTriggerValueToAllPins.Name = "ApplyTriggerValueToAllPins";
            this.ApplyTriggerValueToAllPins.Size = new System.Drawing.Size(317, 23);
            this.ApplyTriggerValueToAllPins.TabIndex = 30;
            this.ApplyTriggerValueToAllPins.Text = "Set Current Trigger Value To All Pins";
            this.ApplyTriggerValueToAllPins.UseVisualStyleBackColor = true;
            this.ApplyTriggerValueToAllPins.Click += new System.EventHandler(this.ApplyTriggerValueToAllPins_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Select Analog Pin:";
            this.label1.UseMnemonic = false;
            // 
            // ApplyTriggerButton
            // 
            this.ApplyTriggerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ApplyTriggerButton.Location = new System.Drawing.Point(148, 129);
            this.ApplyTriggerButton.Name = "ApplyTriggerButton";
            this.ApplyTriggerButton.Size = new System.Drawing.Size(317, 23);
            this.ApplyTriggerButton.TabIndex = 28;
            this.ApplyTriggerButton.Text = "Set Current Trigger Value To Pin";
            this.ApplyTriggerButton.UseVisualStyleBackColor = true;
            this.ApplyTriggerButton.Click += new System.EventHandler(this.ApplyTriggerButton_Click);
            // 
            // TriggerPinComboBox
            // 
            this.TriggerPinComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TriggerPinComboBox.FormattingEnabled = true;
            this.TriggerPinComboBox.Items.AddRange(new object[] {
            "PIN0",
            "PIN1",
            "PIN2",
            "PIN3",
            "PIN4",
            "PIN5"});
            this.TriggerPinComboBox.Location = new System.Drawing.Point(6, 42);
            this.TriggerPinComboBox.Name = "TriggerPinComboBox";
            this.TriggerPinComboBox.Size = new System.Drawing.Size(837, 21);
            this.TriggerPinComboBox.TabIndex = 27;
            this.TriggerPinComboBox.SelectedIndexChanged += new System.EventHandler(this.TriggerPinComboBox_SelectedIndexChanged);
            // 
            // Trigger1IfValueIsBelowCheckbox
            // 
            this.Trigger1IfValueIsBelowCheckbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Trigger1IfValueIsBelowCheckbox.AutoSize = true;
            this.Trigger1IfValueIsBelowCheckbox.Location = new System.Drawing.Point(11, 133);
            this.Trigger1IfValueIsBelowCheckbox.Name = "Trigger1IfValueIsBelowCheckbox";
            this.Trigger1IfValueIsBelowCheckbox.Size = new System.Drawing.Size(89, 17);
            this.Trigger1IfValueIsBelowCheckbox.TabIndex = 26;
            this.Trigger1IfValueIsBelowCheckbox.Text = "Invert Trigger";
            this.Trigger1IfValueIsBelowCheckbox.UseVisualStyleBackColor = true;
            this.Trigger1IfValueIsBelowCheckbox.Click += new System.EventHandler(this.Trigger1IfValueIsBelowCheckbox_Click);
            // 
            // Trigger1Label
            // 
            this.Trigger1Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Trigger1Label.AutoSize = true;
            this.Trigger1Label.Location = new System.Drawing.Point(813, 66);
            this.Trigger1Label.Name = "Trigger1Label";
            this.Trigger1Label.Size = new System.Drawing.Size(13, 13);
            this.Trigger1Label.TabIndex = 14;
            this.Trigger1Label.Text = "0";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(813, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "1023";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "0";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Trigger Value:";
            this.label8.UseMnemonic = false;
            // 
            // Trigger1TrackBar
            // 
            this.Trigger1TrackBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Trigger1TrackBar.Location = new System.Drawing.Point(9, 82);
            this.Trigger1TrackBar.Maximum = 1023;
            this.Trigger1TrackBar.Name = "Trigger1TrackBar";
            this.Trigger1TrackBar.Size = new System.Drawing.Size(834, 45);
            this.Trigger1TrackBar.TabIndex = 10;
            this.Trigger1TrackBar.ValueChanged += new System.EventHandler(this.Trigger1TrackBar_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.DisconnectButton);
            this.groupBox1.Controls.Add(this.ConnectButton);
            this.groupBox1.Controls.Add(this.ComPortSelect);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BaudRateSelect);
            this.groupBox1.Location = new System.Drawing.Point(5, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 159);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setup Device";
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DisconnectButton.Location = new System.Drawing.Point(42, 127);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(121, 23);
            this.DisconnectButton.TabIndex = 9;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConnectButton.Location = new System.Drawing.Point(42, 96);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(121, 25);
            this.ConnectButton.TabIndex = 6;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ComPortSelect
            // 
            this.ComPortSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComPortSelect.FormattingEnabled = true;
            this.ComPortSelect.Location = new System.Drawing.Point(42, 32);
            this.ComPortSelect.Name = "ComPortSelect";
            this.ComPortSelect.Size = new System.Drawing.Size(121, 21);
            this.ComPortSelect.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select Baud Rate";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Com Port";
            // 
            // BaudRateSelect
            // 
            this.BaudRateSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BaudRateSelect.FormattingEnabled = true;
            this.BaudRateSelect.Items.AddRange(new object[] {
            "600",
            "1200",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "56000",
            "57600",
            "74880",
            "115200",
            "128000",
            "153600",
            "230400",
            "250000",
            "256000",
            "460800",
            "921600"});
            this.BaudRateSelect.Location = new System.Drawing.Point(42, 72);
            this.BaudRateSelect.Name = "BaudRateSelect";
            this.BaudRateSelect.Size = new System.Drawing.Size(121, 21);
            this.BaudRateSelect.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.Pin5TriggerState);
            this.groupBox4.Controls.Add(this.Pin4TriggerState);
            this.groupBox4.Controls.Add(this.Pin3TriggerState);
            this.groupBox4.Controls.Add(this.Pin2TriggerState);
            this.groupBox4.Controls.Add(this.Pin1TriggerState);
            this.groupBox4.Controls.Add(this.Pin0TriggerState);
            this.groupBox4.Location = new System.Drawing.Point(994, 23);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(65, 393);
            this.groupBox4.TabIndex = 38;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Triggers";
            // 
            // Pin5TriggerState
            // 
            this.Pin5TriggerState.BackColor = System.Drawing.Color.Red;
            this.Pin5TriggerState.Location = new System.Drawing.Point(6, 309);
            this.Pin5TriggerState.Name = "Pin5TriggerState";
            this.Pin5TriggerState.Size = new System.Drawing.Size(52, 53);
            this.Pin5TriggerState.TabIndex = 1;
            this.Pin5TriggerState.TabStop = false;
            this.Pin5TriggerState.Text = "Pin 5";
            // 
            // Pin4TriggerState
            // 
            this.Pin4TriggerState.BackColor = System.Drawing.Color.Red;
            this.Pin4TriggerState.Location = new System.Drawing.Point(6, 250);
            this.Pin4TriggerState.Name = "Pin4TriggerState";
            this.Pin4TriggerState.Size = new System.Drawing.Size(52, 53);
            this.Pin4TriggerState.TabIndex = 1;
            this.Pin4TriggerState.TabStop = false;
            this.Pin4TriggerState.Text = "Pin 4";
            // 
            // Pin3TriggerState
            // 
            this.Pin3TriggerState.BackColor = System.Drawing.Color.Red;
            this.Pin3TriggerState.Location = new System.Drawing.Point(6, 191);
            this.Pin3TriggerState.Name = "Pin3TriggerState";
            this.Pin3TriggerState.Size = new System.Drawing.Size(52, 53);
            this.Pin3TriggerState.TabIndex = 1;
            this.Pin3TriggerState.TabStop = false;
            this.Pin3TriggerState.Text = "Pin 3";
            // 
            // Pin2TriggerState
            // 
            this.Pin2TriggerState.BackColor = System.Drawing.Color.Red;
            this.Pin2TriggerState.Location = new System.Drawing.Point(6, 132);
            this.Pin2TriggerState.Name = "Pin2TriggerState";
            this.Pin2TriggerState.Size = new System.Drawing.Size(52, 53);
            this.Pin2TriggerState.TabIndex = 1;
            this.Pin2TriggerState.TabStop = false;
            this.Pin2TriggerState.Text = "Pin 2";
            // 
            // Pin1TriggerState
            // 
            this.Pin1TriggerState.BackColor = System.Drawing.Color.Red;
            this.Pin1TriggerState.Location = new System.Drawing.Point(7, 73);
            this.Pin1TriggerState.Name = "Pin1TriggerState";
            this.Pin1TriggerState.Size = new System.Drawing.Size(52, 53);
            this.Pin1TriggerState.TabIndex = 1;
            this.Pin1TriggerState.TabStop = false;
            this.Pin1TriggerState.Text = "Pin 1";
            // 
            // Pin0TriggerState
            // 
            this.Pin0TriggerState.BackColor = System.Drawing.Color.Red;
            this.Pin0TriggerState.Location = new System.Drawing.Point(6, 14);
            this.Pin0TriggerState.Name = "Pin0TriggerState";
            this.Pin0TriggerState.Size = new System.Drawing.Size(52, 53);
            this.Pin0TriggerState.TabIndex = 0;
            this.Pin0TriggerState.TabStop = false;
            this.Pin0TriggerState.Text = "Pin 0";
            // 
            // FlexibleChartWindow
            // 
            this.FlexibleChartWindow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FlexibleChartWindow.Location = new System.Drawing.Point(148, 364);
            this.FlexibleChartWindow.Name = "FlexibleChartWindow";
            this.FlexibleChartWindow.Size = new System.Drawing.Size(317, 23);
            this.FlexibleChartWindow.TabIndex = 31;
            this.FlexibleChartWindow.Text = "Open Flexible Chart Window";
            this.FlexibleChartWindow.UseVisualStyleBackColor = true;
            this.FlexibleChartWindow.Click += new System.EventHandler(this.FlexibleChartWindow_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 625);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DebugOutputTextBox);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainWindow";
            this.Text = "ADCGraphTool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LineChart)).EndInit();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClearGraphIntervalTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTrackBar)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Trigger1TrackBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart LineChart;
        private System.Windows.Forms.TextBox DebugOutputTextBox;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.CheckBox PIN5CheckBox;
        private System.Windows.Forms.CheckBox PIN4CheckBox;
        private System.Windows.Forms.CheckBox PIN3CheckBox;
        private System.Windows.Forms.CheckBox PIN2CheckBox;
        private System.Windows.Forms.CheckBox PIN1CheckBox;
        private System.Windows.Forms.CheckBox PIN0CheckBox;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Label ClearGraphIntervalLabel;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TrackBar ClearGraphIntervalTrackBar;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TrackBar SpeedTrackBar;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox readModeCheckbox;
        private System.Windows.Forms.Label AverageLabel;
        private System.Windows.Forms.Label AmmountOfDataPointsLabel;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.RichTextBox ComPortOutput;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ApplyTriggerButton;
        private System.Windows.Forms.ComboBox TriggerPinComboBox;
        private System.Windows.Forms.CheckBox Trigger1IfValueIsBelowCheckbox;
        private System.Windows.Forms.Label Trigger1Label;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar Trigger1TrackBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.ComboBox ComPortSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox BaudRateSelect;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox Pin5TriggerState;
        private System.Windows.Forms.GroupBox Pin4TriggerState;
        private System.Windows.Forms.GroupBox Pin3TriggerState;
        private System.Windows.Forms.GroupBox Pin2TriggerState;
        private System.Windows.Forms.GroupBox Pin1TriggerState;
        private System.Windows.Forms.GroupBox Pin0TriggerState;
        private System.Windows.Forms.Button ApplyTriggerValueToAllPins;
        private System.Windows.Forms.Button FlexibleChartWindow;
    }
}

