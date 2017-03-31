using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ADCGraphTool
{
    public partial class SaveChart : Form
    {


        public bool CurrentGraph = false;
        public bool FullGraph = true;
        public List<List<int>> CurrentData = new List<List<int>>();
        public List<List<int>> AllData = new List<List<int>>();
        public bool[] VisibleLines = new bool[7];
        public SaveChart(List<List<int>> CurrentData, List<List<int>> AllData, bool[] VisibleLines)
        {
            InitializeComponent();
            SaveCurrentGraphCheckbox.Checked = CurrentGraph;
            SaveFullGraphCheckbox.Checked = FullGraph;
            this.CurrentData = CurrentData;
            this.AllData = AllData;
            this.VisibleLines = VisibleLines;
            SaveDebugTextBox.Text = "AllDataCount: " + AllData[0].Count().ToString() + ", CurrentDataCount: " + CurrentData[0].Count().ToString();
        }

        private void SaveCurrentGraphCheckbox_CheckedChanged(object sender, EventArgs e)
        {
          

            SaveFullGraphCheckbox.Checked = false;
        }

        private void SaveFullGraphCheckbox_CheckedChanged(object sender, EventArgs e)
        {

            SaveCurrentGraphCheckbox.Checked = false;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            GenerateGraph();
            //saveFileDialog1.ShowDialog();
            LineChart.SaveImage("test.png", ChartImageFormat.Png);
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            // Get file name.
            string name = saveFileDialog1.FileName;
            // Write to the file name selected.
            // ... You can write the text from a TextBox instead of a string literal.
            //LineChart.SaveImage(name, ChartImageFormat.Png);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenerateGraph()
        {

            List<List<int>> DataToBeUsed = new List<List<int>>();
            if (SaveCurrentGraphCheckbox.Checked)
            {
                DataToBeUsed = CurrentData;
            }
            else if (SaveFullGraphCheckbox.Checked)
            {
                DataToBeUsed = AllData;
            }
            //LineChart.Visible = false;
            LineChart.Width = int.Parse(ResXTextBox.Text);
            LineChart.Height = int.Parse(ResYTextBox.Text);

            for (int i = 0; i < DataToBeUsed.Count; i++)
            {
                List<int> yData = DataToBeUsed[i];
                for(int a = 0; a < yData.Count; a++)
                {
                    AddToChart(i, a, yData[a]);
                }
            }
            LineChart.Update();
        }

        private void AddToChart(int series, double x, double y)
        {
            try
            {
                if (LineChart.InvokeRequired)
                {
                    LineChart.Invoke((MethodInvoker)delegate { AddToChart(series, x, y); });
                }
                else
                {
                    LineChart.Series[series].Points.AddXY(x, y);
                }
            }
            catch { }
        }

        private void SaveChart_Load(object sender, EventArgs e)
        {

        }

        private void SaveCSVButton_Click(object sender, EventArgs e)
        {
            List<List<int>> DataToBeUsed = new List<List<int>>();
            if (SaveCurrentGraphCheckbox.Checked)
            {
                DataToBeUsed = CurrentData;
            } else if (SaveFullGraphCheckbox.Checked)
            {
                DataToBeUsed = AllData;
            }

            SaveDebugTextBox.Text = "AllDataCount: " + AllData.Count().ToString() + ", CurrentDataCount: " + CurrentData.Count().ToString() + ", DataToBeUsed: " + DataToBeUsed.Count(); 
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("sep=,");
            sb.AppendLine("PIN0,PIN1,PIN2,PIN3,PIN4,PIN5");


            int Columns = DataToBeUsed.Count - 1;
            int a = 0;
            int i = 0;
            string prefix = "";
            while (a < DataToBeUsed[0].Count)
            {
                try
                {
                    sb.Append(prefix);
                    prefix = ",";
                    sb.Append(DataToBeUsed[i][a]);
                }
                catch
                {
                    break;
                }
                if (i > (Columns - 1))
                {
                    sb.AppendLine();
                    prefix = "";
                    i = 0;
                    a++;
                } else
                {
                    i++;
                }
            }
            using (StreamWriter writer = new StreamWriter("test.csv"))
            {
                writer.Write(sb);
            }

        }
    }
}
