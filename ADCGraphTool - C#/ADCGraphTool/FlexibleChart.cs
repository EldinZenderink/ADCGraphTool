using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ADCGraphTool
{
    public partial class FlexibleChart : Form
    {
        
        public static Thread ConstantChartUpdate = null;
        public int ammountOfIntegers = 0;

        public bool[] visiblePins = new bool[6];

        public FlexibleChart()
        {
            InitializeComponent();
            LineChart.ChartAreas[0].AxisY.ScaleView.Zoom(0, 1023);
            LineChart.ChartAreas[0].AxisX.Minimum = 0;
            LineChart.ChartAreas[0].AxisY.Minimum = 0;
            LineChart.ChartAreas[0].AxisX.Maximum = 30 * 20;
            LineChart.ChartAreas[0].CursorX.IsUserEnabled = true;
            LineChart.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            LineChart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            LineChart.ChartAreas[0].AxisY.ScaleView.Zoomable = true;

            StripLine stripline = new StripLine();
            stripline.Interval = 0;
            stripline.IntervalOffset = 0;
            stripline.StripWidth = 1;
            stripline.BackColor = Color.Black;
            LineChart.ChartAreas[0].AxisY.StripLines.Add(stripline);
            LineChart.ChartAreas[0].AxisY.StripLines.Add(stripline);


            for(int i = 0; i < visiblePins.Length; i++)
            {
                visiblePins[i] = true;
            }
            
            ConstantChartUpdate = new Thread(new ThreadStart(ConstantChartUpdateThread));
            if (ConstantChartUpdate.IsAlive)
            {
                ConstantChartUpdate.Abort();
                ClearChart();
            }
            ConstantChartUpdate.Start();
        }

        public void setVisiblePin(int pin)
        {
            visiblePins[pin] = true;
            try
            {

                for (int i = 0; i < visiblePins.Length; i++)
                {
                    if (visiblePins[i])
                    {
                        LineChart.Series[i].Enabled = true;
                    }
                    else
                    {
                        LineChart.Series[i].Enabled = false;
                    }
                }
            }
            catch
            {

            }
        }

        public void setHiddenPin(int pin)
        {
            visiblePins[pin] = false;

            try
            {

                for (int i = 0; i < visiblePins.Length; i++)
                {
                    if (visiblePins[i])
                    {
                        LineChart.Series[i].Enabled = true;
                    }
                    else
                    {
                        LineChart.Series[i].Enabled = false;
                    }
                }
            } catch
            {

            }
        }

        public void AddToChart(int series, double x, double y)
        {
            try
            {
                if (LineChart.InvokeRequired)
                {
                    LineChart.Invoke((MethodInvoker)delegate { AddToChart(series, x, y); });
                } else
                {
                    LineChart.Series[series].Points.AddXY(x, y);
                }
            }
            catch { }
        }
        

        public void AddStripeLine(int lineNumber,  double y, Color color)
        {
            if (LineChart.InvokeRequired)
            {
                try { LineChart.Invoke((MethodInvoker)delegate { AddStripeLine(lineNumber, y, color); }); } catch { }
            }
            else
            {
                StripLine stripline = new StripLine();
                stripline.Interval = 0;
                stripline.IntervalOffset = y;
                stripline.StripWidth = 1;
                stripline.BackColor = color;               
                LineChart.ChartAreas[0].AxisY.StripLines[lineNumber] = stripline;
            }
        }

        public void ClearChart()
        {
            if (LineChart.InvokeRequired)
            {
                    LineChart.Invoke((MethodInvoker)delegate { ClearChart(); }); 
            }
            else
            {
               
                LineChart.Series[0].Points.Clear();
                LineChart.Series[1].Points.Clear();
                LineChart.Series[2].Points.Clear();
                LineChart.Series[3].Points.Clear();
                LineChart.Series[4].Points.Clear();
                LineChart.Series[5].Points.Clear();
                LineChart.ChartAreas[0].AxisX.Maximum = MainWindow.clearInterval;
            }
        }

        public void UpdateChart()
        {
            if (LineChart.InvokeRequired)
            {
                try
                {
                    LineChart.Invoke((MethodInvoker)delegate { UpdateChart(); });
                }
                catch
                {

                }
            }
            else
            {

                if (MainWindow.dataPointsPIN0.Count > 0 && MainWindow.dataPointsPIN1.Count > 0 && MainWindow.dataPointsPIN2.Count > 0 && MainWindow.dataPointsPIN3.Count > 0 && MainWindow.dataPointsPIN4.Count > 0 && MainWindow.dataPointsPIN5.Count > 0 && ammountOfIntegers < MainWindow.clearInterval)
                {
                    
                    AddToChart(0, ammountOfIntegers, MainWindow.dataPointsPIN0[MainWindow.dataPointsPIN0.Count - 1]);
                    AddToChart(1, ammountOfIntegers, MainWindow.dataPointsPIN1[MainWindow.dataPointsPIN1.Count - 1]);
                    AddToChart(2, ammountOfIntegers, MainWindow.dataPointsPIN2[MainWindow.dataPointsPIN2.Count - 1]);
                    AddToChart(3, ammountOfIntegers, MainWindow.dataPointsPIN3[MainWindow.dataPointsPIN3.Count - 1]);
                    AddToChart(4, ammountOfIntegers, MainWindow.dataPointsPIN4[MainWindow.dataPointsPIN4.Count - 1]);
                    AddToChart(5, ammountOfIntegers, MainWindow.dataPointsPIN5[MainWindow.dataPointsPIN5.Count - 1]);


                    ammountOfIntegers++;
                    LineChart.Update();
                }
                else if (MainWindow.clearInterval >= ammountOfIntegers)
                {
                    ammountOfIntegers = 0;
                    ClearChart();
                }
            }
        }

        public void ConstantChartUpdateThread()
        {
            
            while (true)
            {
                if(MainWindow.ComPort != null)
                {
                    if (MainWindow.ComPort.IsOpen)
                    {
                        Thread.Sleep((1000 / MainWindow.speed));
                        if (!MainWindow.PauseChart)
                        {
                            //AppendDebugOutputTextBox("CurrentDatalength: " + CurrentData[0].Count().ToString() + ", AllData: " + MainWindow.dataPointsPIN4.Count().ToString());
                            UpdateChart();
                        }

                    } else
                    {
                        break;
                    }

                } else
                {
                    Thread.Sleep(100);
                }
            }
        }

        private void FlexibleChart_FormClosing(object sender, FormClosingEventArgs e)
        {
            try { ConstantChartUpdate.Abort(); } catch { }
        }
    }
}
