namespace ADCGraphTool
{
    partial class SaveChart
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
            this.SaveCurrentGraphCheckbox = new System.Windows.Forms.CheckBox();
            this.SaveFullGraphCheckbox = new System.Windows.Forms.CheckBox();
            this.SaveImageButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.LineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ResXTextBox = new System.Windows.Forms.TextBox();
            this.ResYTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lab1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SaveCSVButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SaveDebugTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.LineChart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveCurrentGraphCheckbox
            // 
            this.SaveCurrentGraphCheckbox.AutoSize = true;
            this.SaveCurrentGraphCheckbox.Location = new System.Drawing.Point(14, 28);
            this.SaveCurrentGraphCheckbox.Name = "SaveCurrentGraphCheckbox";
            this.SaveCurrentGraphCheckbox.Size = new System.Drawing.Size(142, 17);
            this.SaveCurrentGraphCheckbox.TabIndex = 0;
            this.SaveCurrentGraphCheckbox.Text = "Datapoints Visible Graph";
            this.SaveCurrentGraphCheckbox.UseVisualStyleBackColor = true;
            this.SaveCurrentGraphCheckbox.CheckedChanged += new System.EventHandler(this.SaveCurrentGraphCheckbox_CheckedChanged);
            // 
            // SaveFullGraphCheckbox
            // 
            this.SaveFullGraphCheckbox.AutoSize = true;
            this.SaveFullGraphCheckbox.Location = new System.Drawing.Point(14, 51);
            this.SaveFullGraphCheckbox.Name = "SaveFullGraphCheckbox";
            this.SaveFullGraphCheckbox.Size = new System.Drawing.Size(141, 17);
            this.SaveFullGraphCheckbox.TabIndex = 1;
            this.SaveFullGraphCheckbox.Text = "All Recorded Datapoints";
            this.SaveFullGraphCheckbox.UseVisualStyleBackColor = true;
            this.SaveFullGraphCheckbox.CheckedChanged += new System.EventHandler(this.SaveFullGraphCheckbox_CheckedChanged);
            // 
            // SaveImageButton
            // 
            this.SaveImageButton.Location = new System.Drawing.Point(9, 58);
            this.SaveImageButton.Name = "SaveImageButton";
            this.SaveImageButton.Size = new System.Drawing.Size(228, 23);
            this.SaveImageButton.TabIndex = 5;
            this.SaveImageButton.Text = "Save";
            this.SaveImageButton.UseVisualStyleBackColor = true;
            this.SaveImageButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(21, 258);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(228, 23);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // LineChart
            // 
            chartArea1.Name = "ChartArea1";
            this.LineChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.LineChart.Legends.Add(legend1);
            this.LineChart.Location = new System.Drawing.Point(320, 12);
            this.LineChart.Name = "LineChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Silver;
            series1.Legend = "Legend1";
            series1.Name = "PIN0";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "PIN1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series3.Legend = "Legend1";
            series3.Name = "PIN2";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Yellow;
            series4.Legend = "Legend1";
            series4.Name = "PIN3";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Lime;
            series5.Legend = "Legend1";
            series5.Name = "PIN4";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.Aqua;
            series6.Legend = "Legend1";
            series6.Name = "PIN5";
            this.LineChart.Series.Add(series1);
            this.LineChart.Series.Add(series2);
            this.LineChart.Series.Add(series3);
            this.LineChart.Series.Add(series4);
            this.LineChart.Series.Add(series5);
            this.LineChart.Series.Add(series6);
            this.LineChart.Size = new System.Drawing.Size(521, 371);
            this.LineChart.TabIndex = 7;
            this.LineChart.Text = "LineChart";
            // 
            // ResXTextBox
            // 
            this.ResXTextBox.Location = new System.Drawing.Point(31, 32);
            this.ResXTextBox.Name = "ResXTextBox";
            this.ResXTextBox.ShortcutsEnabled = false;
            this.ResXTextBox.Size = new System.Drawing.Size(85, 20);
            this.ResXTextBox.TabIndex = 8;
            this.ResXTextBox.Text = "1920";
            // 
            // ResYTextBox
            // 
            this.ResYTextBox.Location = new System.Drawing.Point(153, 32);
            this.ResYTextBox.Name = "ResYTextBox";
            this.ResYTextBox.Size = new System.Drawing.Size(84, 20);
            this.ResYTextBox.TabIndex = 9;
            this.ResYTextBox.Text = "1080";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Resolution:";
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(11, 35);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(14, 13);
            this.lab1.TabIndex = 11;
            this.lab1.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Y";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "png";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SaveImageButton);
            this.groupBox1.Controls.Add(this.lab1);
            this.groupBox1.Controls.Add(this.ResXTextBox);
            this.groupBox1.Controls.Add(this.ResYTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 96);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate Image";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SaveCurrentGraphCheckbox);
            this.groupBox2.Controls.Add(this.SaveFullGraphCheckbox);
            this.groupBox2.Location = new System.Drawing.Point(12, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 81);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Which Data";
            // 
            // SaveCSVButton
            // 
            this.SaveCSVButton.Location = new System.Drawing.Point(9, 19);
            this.SaveCSVButton.Name = "SaveCSVButton";
            this.SaveCSVButton.Size = new System.Drawing.Size(228, 23);
            this.SaveCSVButton.TabIndex = 5;
            this.SaveCSVButton.Text = "Save";
            this.SaveCSVButton.UseVisualStyleBackColor = true;
            this.SaveCSVButton.Click += new System.EventHandler(this.SaveCSVButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SaveCSVButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 197);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 55);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Generate CSV";
            // 
            // SaveDebugTextBox
            // 
            this.SaveDebugTextBox.Location = new System.Drawing.Point(21, 295);
            this.SaveDebugTextBox.Name = "SaveDebugTextBox";
            this.SaveDebugTextBox.Size = new System.Drawing.Size(228, 20);
            this.SaveDebugTextBox.TabIndex = 15;
            // 
            // SaveChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 327);
            this.Controls.Add(this.SaveDebugTextBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LineChart);
            this.Controls.Add(this.CancelButton);
            this.Name = "SaveChart";
            this.Text = "SaveChart";
            this.Load += new System.EventHandler(this.SaveChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LineChart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox SaveCurrentGraphCheckbox;
        private System.Windows.Forms.CheckBox SaveFullGraphCheckbox;
        private System.Windows.Forms.Button SaveImageButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart LineChart;
        private System.Windows.Forms.TextBox ResXTextBox;
        private System.Windows.Forms.TextBox ResYTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SaveCSVButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox SaveDebugTextBox;
    }
}