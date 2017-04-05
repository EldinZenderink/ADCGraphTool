using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ADCGraphTool
{
    public partial class MainWindow : Form
    {

        FlexibleChart flexChart = null;
        public static SerialPort ComPort = null;
        public Thread putDataInComPortOut = null;
        public Thread ClearGraphThread = null;
        public Thread ConstantChartUpdate = null;
        public Thread CheckComPorts = null;
        public static int speed = 30;
        public static int clearInterval = 1000;
        public int ammountOfIntegers = 0;
        
        public bool trigger1triggeronbelow = false;
        public bool trigger2triggeronbelow = false;
        public int trigger1counter = 0;
        public static List<int> dataPointsPIN0 = new List<int>();
        public static List<int> dataPointsPIN1 = new List<int>();
        public static List<int> dataPointsPIN2 = new List<int>();
        public static List<int> dataPointsPIN3 = new List<int>();
        public static List<int> dataPointsPIN4 = new List<int>();
        public static List<int> dataPointsPIN5 = new List<int>();

        public static List<List<int>> CurrentData = new List<List<int>>();
        public static List<List<int>> AllData = new List<List<int>>();

        public static List<int> TriggerValuesPerPin = new List<int>();
        public static List<bool> TriggerInvertedPerPin = new List<bool>();
        public int countReadoutPostition = 0;
        public int ammountOfLinesRead = 0;
        public bool ComPortOutputPause = false;
        public static bool PauseChart = false;
        public string ComPortOutputPauseBuffer = "";

        public bool DataReceived = false;

        public MainWindow()
        {
            InitializeComponent();


            flexChart = new FlexibleChart();
            List<int> dummy = new List<int>();
            dummy.Add(1);


            for(int i = 0; i < 6; i++)
            {
                CurrentData.Add(dummy);
                AllData.Add(dummy);
                TriggerValuesPerPin.Add(0);
                TriggerInvertedPerPin.Add(false);
            }

            LineChart.ChartAreas[0].AxisY.ScaleView.Zoom(0, 1023);
            LineChart.ChartAreas[0].AxisX.Minimum = 0;
            LineChart.ChartAreas[0].AxisY.Minimum = 0;
            LineChart.ChartAreas[0].AxisX.Maximum = 30*20;
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

            string[] ports = SerialPort.GetPortNames();
            foreach(string port in ports)
            {
                ComPortSelect.Items.Add(port);
            }

            SpeedTrackBar.Value = speed;
            SpeedLabel.Text = speed.ToString() + "/s";
            ClearGraphIntervalTrackBar.Value = clearInterval;
            ClearGraphIntervalLabel.Text = clearInterval.ToString();


            AppendDebugOutputTextBox("Hello, please select the comport and baudrate for your arduino!");
            if (MessageBox.Show("Hi, just before you start. Make sure you have compiled the arduino code that comes along with this application on your arduino! You can get it on the github page which will open when you press Yes. If you already have it and want to start using this application, press No.", "Before you start using ADCGraphTool.", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://github.com/EldinZenderink/ADCGraphTool");
            }

            BaudRateSelect.SelectedIndex = 11;
            CheckComPorts = new Thread(new ThreadStart(KeepOnCheckingComPorts));
            CheckComPorts.Start();
        }

        public void KeepOnCheckingComPorts()
        {
            while (true)
            {
                string[] ports = SerialPort.GetPortNames();
                UpdateComPortSelect(ports);                
                Thread.Sleep(2000);
            }
        }

        public void UpdateComPortSelect(string[] ports)
        {
            if (ComPortSelect.InvokeRequired)
            {
                ComPortSelect.Invoke((MethodInvoker)delegate { UpdateComPortSelect(ports); });

            } else
            {
                ComPortSelect.Items.Clear();
                ComPortSelect.Text = "";
                foreach (string port in ports)
                {
                    if (!ComPortSelect.Items.Contains(port))
                    {
                        ComPortSelect.Items.Add(port);
                    }
                }
                if (ComPortSelect.Items.Count > 0)
                {
                    ComPortSelect.SelectedIndex = 0;
                }
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
                ammountOfIntegers = 0;

                AllData[0].AddRange(new List<int>(dataPointsPIN0));
                AllData[1].AddRange(new List<int>(dataPointsPIN1));
                AllData[2].AddRange(new List<int>(dataPointsPIN2));
                AllData[3].AddRange(new List<int>(dataPointsPIN3));
                AllData[4].AddRange(new List<int>(dataPointsPIN4));
                AllData[5].AddRange(new List<int>(dataPointsPIN5));
                
                dataPointsPIN0.Clear();
                dataPointsPIN1.Clear();
                dataPointsPIN2.Clear();
                dataPointsPIN3.Clear();
                dataPointsPIN4.Clear();
                dataPointsPIN5.Clear(); 
                LineChart.ChartAreas[0].AxisX.Maximum = clearInterval;
            }
        }

        public void AppendToComPortOutput(string txt)
        {
            try
            {
                if (ComPortOutput.InvokeRequired)
                {
                    ComPortOutput.Invoke((MethodInvoker)delegate { AppendToComPortOutput(txt); });
                }
                else
                {
                    if (!ComPortOutputPause)
                    {
                        ComPortOutput.AppendText(txt + "\n");
                        ComPortOutput.SelectionStart = ComPortOutput.Text.Length;
                        ComPortOutput.ScrollToCaret();
                    } else
                    {
                        ComPortOutputPauseBuffer = ComPortOutputPause + txt + "\n";
                    }
                }
            }
            catch { }
        }

        public void AppendDebugOutputTextBox(string txt)
        {
            try
            {
                if (DebugOutputTextBox.InvokeRequired)
                {
                    DebugOutputTextBox.Invoke((MethodInvoker)delegate { AppendDebugOutputTextBox(txt); });
                }
                else
                {
                    DebugOutputTextBox.Text = txt;
                }
            }
            catch { }
        }

        public void UpdateAverageLabel(string txt)
        {
            if (AverageLabel.InvokeRequired)
            {
                try { AverageLabel.Invoke((MethodInvoker)delegate { UpdateAverageLabel(txt); }); } catch { }
            } else
            {
                AverageLabel.Text = txt;
            }
        }

        public void UpdateAmmountOfDataPointsLabel(string txt)
        {
            if (AmmountOfDataPointsLabel.InvokeRequired)
            {
                try { AmmountOfDataPointsLabel.Invoke((MethodInvoker)delegate { UpdateAmmountOfDataPointsLabel(txt); }); }catch { }
            }
            else
            {
                AmmountOfDataPointsLabel.Text = txt;
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
            } else
            {
                if(dataPointsPIN0.Count > 0 && dataPointsPIN1.Count > 0 && dataPointsPIN2.Count > 0 && dataPointsPIN3.Count > 0 && dataPointsPIN4.Count > 0 && dataPointsPIN5.Count > 0 && ammountOfIntegers < clearInterval)
                {
                    AddToChart(0, ammountOfIntegers, dataPointsPIN0[dataPointsPIN0.Count - 1]);
                    AddToChart(1, ammountOfIntegers, dataPointsPIN1[dataPointsPIN1.Count - 1]);
                    AddToChart(2, ammountOfIntegers, dataPointsPIN2[dataPointsPIN2.Count - 1]);
                    AddToChart(3, ammountOfIntegers, dataPointsPIN3[dataPointsPIN3.Count - 1]);
                    AddToChart(4, ammountOfIntegers, dataPointsPIN4[dataPointsPIN4.Count - 1]);
                    AddToChart(5, ammountOfIntegers, dataPointsPIN5[dataPointsPIN5.Count - 1]);
                    ammountOfIntegers++;
                    LineChart.Update();
                } else if(clearInterval >= ammountOfIntegers)
                {
                    ClearChart();
                }
            }
        }

        public void ConstantChartUpdateThread()
        {
            while (ComPort.IsOpen)
            {

                Thread.Sleep((1000 / speed));
                if (!PauseChart)
                {
                    //AppendDebugOutputTextBox("CurrentDatalength: " + CurrentData[0].Count().ToString() + ", AllData: " + dataPointsPIN4.Count().ToString());
                    UpdateChart();
                }
                
            }
        }

        public void CheckDataReceived()
        {
            while (true)
            {
                Thread.Sleep(1000);
                if (!DataReceived && ComPort.IsOpen && !PauseChart)
                {
                    if (putDataInComPortOut.IsAlive)
                    {
                        putDataInComPortOut.Abort();
                    }

                    try
                    {

                        putDataInComPortOut.Start();
                    } catch
                    {

                    }
                }
            }
        }
       

        private void ReadFromComPort()
        {
            string message = "";
            byte[] buffer = new byte[1024];

            Action kickoffRead = null;
            kickoffRead = delegate
            {
                ComPort.BaseStream.BeginRead(buffer, 0, buffer.Length, delegate (IAsyncResult ar)
                {
                    try
                    {
                        if (!PauseChart)
                        {
                            int actualLength = ComPort.BaseStream.EndRead(ar);
                            byte[] received = new byte[actualLength];
                            Buffer.BlockCopy(buffer, 0, received, 0, actualLength);
                            string receivedStr = Encoding.Default.GetString(received);

                            if (message.Contains("RECSTR:"))
                            {

                                AppendToComPortOutput(message);
                                message = "";
                            }
                            if (message.Length >= 64)
                            {
                                string[] parts = message.Split('D');
                                ParseIntegersAndPutThemInGraph(parts[parts.Length - 2]);
                                message = "";
                                DataReceived = true;
                            }


                            message = message + receivedStr;
                        }
                       
                    }
                    catch
                    {
                    }
                    if (ComPort.IsOpen)
                    {
                        if (!readModeCheckbox.Checked)
                        {
                            kickoffRead();
                        }
                        else
                        {
                            while (readModeCheckbox.Checked)
                            {

                                message = ComPort.ReadLine();
                                AppendToComPortOutput(message);
                                string[] parts = message.Split('D');
                                ParseIntegersAndPutThemInGraph(parts[parts.Length - 1]);
                                message = "";
                            }
                            kickoffRead();
                        }
                    }
                }, null);
            };

            if (!readModeCheckbox.Checked) {                
                kickoffRead();
            } else
            {
                while (readModeCheckbox.Checked)
                {

                    message = ComPort.ReadLine();
                    AppendToComPortOutput(message);
                    string[] parts = message.Split('D');
                    ParseIntegersAndPutThemInGraph(parts[parts.Length - 1]);
                    message = "";
                }
                kickoffRead();
            }
        }

        private void UpdateTriggerBoxes(int pin, int triggerValue, int value, bool inverted)
        {
            switch (pin)
            {
                case 0:
                    if (Pin0TriggerState.InvokeRequired)
                    {
                        try { Pin0TriggerState.Invoke((MethodInvoker)delegate { UpdateTriggerBoxes(pin, triggerValue, value, inverted); }); } catch { }
                    }
                    else
                    {
                        if (inverted)
                        {
                            if(value < triggerValue)
                            {
                                Pin0TriggerState.BackColor = Color.Green;
                            } else
                            {
                                Pin0TriggerState.BackColor = Color.Red;
                            }
                        } else
                        {
                            if (value > triggerValue)
                            {
                                Pin0TriggerState.BackColor = Color.Green;
                            }
                            else
                            {
                                Pin0TriggerState.BackColor = Color.Red;
                            }
                        }
                    }
                    break;
                case 1:
                    if (Pin0TriggerState.InvokeRequired)
                    {
                        try { Pin0TriggerState.Invoke((MethodInvoker)delegate { UpdateTriggerBoxes(pin, triggerValue, value, inverted); }); } catch { }
                    }
                    else
                    {
                        if (inverted)
                        {
                            if (value < triggerValue)
                            {
                                Pin1TriggerState.BackColor = Color.Green;
                            }
                            else
                            {
                                Pin1TriggerState.BackColor = Color.Red;
                            }
                        }
                        else
                        {
                            if (value > triggerValue)
                            {
                                Pin1TriggerState.BackColor = Color.Green;
                            }
                            else
                            {
                                Pin1TriggerState.BackColor = Color.Red;
                            }
                        }
                    }
                    break;
                case 2:
                    if (Pin0TriggerState.InvokeRequired)
                    {
                        try { Pin0TriggerState.Invoke((MethodInvoker)delegate { UpdateTriggerBoxes(pin, triggerValue, value, inverted); }); } catch { }
                    }
                    else
                    {
                        if (inverted)
                        {
                            if (value < triggerValue)
                            {
                                Pin2TriggerState.BackColor = Color.Green;
                            }
                            else
                            {
                                Pin2TriggerState.BackColor = Color.Red;
                            }
                        }
                        else
                        {
                            if (value > triggerValue)
                            {
                                Pin2TriggerState.BackColor = Color.Green;
                            }
                            else
                            {
                                Pin2TriggerState.BackColor = Color.Red;
                            }
                        }
                    }
                    break;
                case 3:
                    if (Pin0TriggerState.InvokeRequired)
                    {
                        try { Pin0TriggerState.Invoke((MethodInvoker)delegate { UpdateTriggerBoxes(pin, triggerValue, value, inverted); }); } catch { }
                    }
                    else
                    {
                        if (inverted)
                        {
                            if (value < triggerValue)
                            {
                                Pin3TriggerState.BackColor = Color.Green;
                            }
                            else
                            {
                                Pin3TriggerState.BackColor = Color.Red;
                            }
                        }
                        else
                        {
                            if (value > triggerValue)
                            {
                                Pin3TriggerState.BackColor = Color.Green;
                            }
                            else
                            {
                                Pin3TriggerState.BackColor = Color.Red;
                            }
                        }
                    }
                    break;
                case 4:
                    if (Pin0TriggerState.InvokeRequired)
                    {
                        try { Pin0TriggerState.Invoke((MethodInvoker)delegate { UpdateTriggerBoxes(pin, triggerValue, value, inverted); }); } catch { }
                    }
                    else
                    {
                        if (inverted)
                        {
                            if (value < triggerValue)
                            {
                                Pin4TriggerState.BackColor = Color.Green;
                            }
                            else
                            {
                                Pin4TriggerState.BackColor = Color.Red;
                            }
                        }
                        else
                        {
                            if (value > triggerValue)
                            {
                                Pin4TriggerState.BackColor = Color.Green;
                            }
                            else
                            {
                                Pin4TriggerState.BackColor = Color.Red;
                            }
                        }
                    }
                    break;
                case 5:
                    if (Pin0TriggerState.InvokeRequired)
                    {
                        try { Pin0TriggerState.Invoke((MethodInvoker)delegate { UpdateTriggerBoxes(pin, triggerValue, value, inverted); }); } catch { }
                    }
                    else
                    {
                        if (inverted)
                        {
                            if (value < triggerValue)
                            {
                                Pin5TriggerState.BackColor = Color.Green;
                            }
                            else
                            {
                                Pin5TriggerState.BackColor = Color.Red;
                            }
                        }
                        else
                        {
                            if (value > triggerValue)
                            {
                                Pin5TriggerState.BackColor = Color.Green;
                            }
                            else
                            {
                                Pin5TriggerState.BackColor = Color.Red;
                            }
                        }
                    }
                    break;
            }
            
        }
        private void ParseIntegersAndPutThemInGraph(string txt)
        {
            string onlyints =txt;
            
            int o = 0;
            int count = 0;
            try
            {
                if (!PauseChart)
                {
                    
                for (int i = 0; i < onlyints.Length; i++)
                {
                    if ((i % 5) == 0)
                    {
                        string currentIntStr = onlyints.Substring(i, 5);
                        bool parsed = int.TryParse(currentIntStr, out o);
                        if (parsed)
                        {
                            if (count == 0)
                            {
                                UpdateTriggerBoxes(count, TriggerValuesPerPin[count], o, TriggerInvertedPerPin[count]);
                                dataPointsPIN0.Add(o);
                            }
                            if (count == 1)
                            {
                                    UpdateTriggerBoxes(count, TriggerValuesPerPin[count], o, TriggerInvertedPerPin[count]);
                                    dataPointsPIN1.Add(o);
                            }
                            if (count == 2)
                            {
                                    UpdateTriggerBoxes(count, TriggerValuesPerPin[count], o, TriggerInvertedPerPin[count]);
                                    dataPointsPIN2.Add(o);
                            }
                            if (count == 3)
                            {
                                    UpdateTriggerBoxes(count, TriggerValuesPerPin[count], o, TriggerInvertedPerPin[count]);
                                    dataPointsPIN3.Add(o);
                            }
                            if (count == 4)
                            {
                                    UpdateTriggerBoxes(count, TriggerValuesPerPin[count], o, TriggerInvertedPerPin[count]);
                                    dataPointsPIN4.Add(o);
                            }
                            if (count == 5)
                            {
                                    UpdateTriggerBoxes(count, TriggerValuesPerPin[count], o, TriggerInvertedPerPin[count]);
                                    dataPointsPIN5.Add(o);
                            }
                        }
                        count++;
                    }
                }
                }

            } catch
            {

            }
            
        }



        private void ConnectButton_Click(object sender, EventArgs e)
        {
            AppendDebugOutputTextBox("You clicked on the connect button, waiting for connection!");
            if (ComPort == null || !ComPort.IsOpen)
            {
                if (ComPortSelect.SelectedItem != null && BaudRateSelect.SelectedItem != null)
                {
                    if (ComPortSelect.SelectedItem.ToString() != "" && BaudRateSelect.SelectedItem.ToString() != "")
                    {
                        ComPort = new SerialPort();
                        ComPort.PortName = ComPortSelect.SelectedItem.ToString();
                        ComPort.BaudRate = int.Parse(BaudRateSelect.SelectedItem.ToString());
                        ComPort.Open();

                        putDataInComPortOut = new Thread(new ThreadStart(ReadFromComPort));
                        putDataInComPortOut.Start();

                        ClearGraphThread = new Thread(new ThreadStart(CheckDataReceived));
                        ClearGraphThread.Start();

                        ConstantChartUpdate = new Thread(new ThreadStart(ConstantChartUpdateThread));
                        ConstantChartUpdate.Start();
                        AppendDebugOutputTextBox("Ready to go! Opened connection at: " + ComPort.PortName + ", speed: " + ComPort.BaudRate);
                    } else
                    {

                        AppendDebugOutputTextBox("You didn't select a baud rate or a com port :(");
                    }

                } else
                {
                    AppendDebugOutputTextBox("You didn't select a baud rate or a com port :(");
                }
               
            } else
            {
                AppendDebugOutputTextBox("Com port is already in use :(");
            }
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            if(ComPort != null && ComPort.IsOpen)
            {
                ComPort.Close();
                if (putDataInComPortOut.IsAlive)
                {
                    putDataInComPortOut.Abort();
                }

                if (ClearGraphThread.IsAlive)
                {
                    ClearGraphThread.Abort();
                }

                if (ConstantChartUpdate.IsAlive)
                {
                    ConstantChartUpdate.Abort();
                }
            }
        }

        private void SpeedTrackBar_ValueChanged(object sender, EventArgs e)
        {
            speed = SpeedTrackBar.Value;
            SpeedLabel.Text = speed.ToString() + "/s";
            
            ClearChart();
        }

        private void ClearGraphIntervalTrackBar_ValueChanged(object sender, EventArgs e)
        {
            clearInterval = ClearGraphIntervalTrackBar.Value;
            ClearGraphIntervalLabel.Text = clearInterval.ToString();

            ClearChart();
        }

        private void SpeedTrackBar_MouseLeave(object sender, EventArgs e)
        {

        }

        private void ClearGraphIntervalTrackBar_MouseLeave(object sender, EventArgs e)
        {

        }

        private void ComPortOutput_MouseHover(object sender, EventArgs e)
        {
            ComPortOutputPause = true;
        }

        private void ComPortOutput_MouseLeave(object sender, EventArgs e)
        {
            ComPortOutputPause = false;
            ComPortOutput.AppendText(ComPortOutputPauseBuffer);
            ComPortOutputPauseBuffer = "";
        }

        private void Trigger1TrackBar_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                TriggerValuesPerPin[TriggerPinComboBox.SelectedIndex] = Trigger1TrackBar.Value;

                Trigger1Label.Text = TriggerValuesPerPin[TriggerPinComboBox.SelectedIndex].ToString();
                AddStripeLine(0, TriggerValuesPerPin[TriggerPinComboBox.SelectedIndex], Color.Orange);

            }
            catch
            {

            }
        }

        private void Trigger1IfValueIsBelowCheckbox_Click(object sender, EventArgs e)
        {
            if (Trigger1IfValueIsBelowCheckbox.Checked)
            {
                trigger1triggeronbelow = true;
            } else
            {
                trigger1triggeronbelow = false;
            }

            TriggerInvertedPerPin[TriggerPinComboBox.SelectedIndex] = trigger1triggeronbelow;
        }

        private void PIN0CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PIN0CheckBox.Checked)
            {
                LineChart.Series[0].Enabled = true;
                flexChart.setVisiblePin(0);
            }
            else
            {
                LineChart.Series[0].Enabled = false;
                flexChart.setHiddenPin(0);
            }
        }

        private void PIN1CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PIN1CheckBox.Checked)
            {
                LineChart.Series[1].Enabled = true;
                flexChart.setVisiblePin(1);
            } else
            {
                LineChart.Series[1].Enabled = false;
                flexChart.setHiddenPin(1);
            }
        }

        private void PIN2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PIN2CheckBox.Checked)
            {
                LineChart.Series[2].Enabled = true;
                flexChart.setVisiblePin(2);
            }
            else
            {
                LineChart.Series[2].Enabled = false;
                flexChart.setHiddenPin(2);
            }
        }

        private void PIN3CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PIN3CheckBox.Checked)
            {
                LineChart.Series[3].Enabled = true;
                flexChart.setVisiblePin(3);
            }
            else
            {
                LineChart.Series[3].Enabled = false;
                flexChart.setHiddenPin(3);
            }
        }

        private void PIN4CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PIN4CheckBox.Checked)
            {
                LineChart.Series[4].Enabled = true;
                flexChart.setVisiblePin(4);
            }
            else
            {
                LineChart.Series[4].Enabled = false;
                flexChart.setHiddenPin(4);
            }
        }

        private void PIN5CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PIN5CheckBox.Checked)
            {
                LineChart.Series[5].Enabled = true;

                flexChart.setVisiblePin(5);
            }
            else
            {
                LineChart.Series[5].Enabled = false;

                flexChart.setHiddenPin(5);
            }
        }

        private void LineChart_DoubleClick(object sender, EventArgs e)
        {
            LineChart.ChartAreas[0].AxisX.ScaleView.ZoomReset(1);
            LineChart.ChartAreas[0].AxisY.ScaleView.ZoomReset(1);
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            if (!PauseChart)
            {
                PauseButton.Text = "PAUSED";
                PauseChart = true;
            } else
            {
                PauseButton.Text = "NOT PAUSED";
                PauseChart = false;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            bool[] VisibleLines = { PIN0CheckBox.Checked, PIN1CheckBox.Checked, PIN2CheckBox.Checked, PIN3CheckBox.Checked, PIN4CheckBox.Checked, PIN5CheckBox.Checked };
            CurrentData[0] = dataPointsPIN0;
            CurrentData[1] = dataPointsPIN1;
            CurrentData[2] = dataPointsPIN2;
            CurrentData[3] = dataPointsPIN3;
            CurrentData[4] = dataPointsPIN4;
            CurrentData[5] = dataPointsPIN5;
            SaveChart chart = new SaveChart(CurrentData, AllData, VisibleLines);
            PauseChart = true;
            PauseButton.Text = "PAUSED";
            chart.ShowDialog();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            try { putDataInComPortOut.Abort(); } catch { }
            try { ClearGraphThread.Abort(); } catch { }
            try { ConstantChartUpdate.Abort(); } catch { }
            try { FlexibleChart.ConstantChartUpdate.Abort(); } catch { }
            try { CheckComPorts.Abort(); } catch { }
        }

        private string convertIntToString(int input)
        {
            string defaultString = input.ToString();
            int ammountOfDigits = 0;
            if (input > 0)
            {

                ammountOfDigits = (int)Math.Floor(Math.Log10(input) + 1);
            } else
            {
                ammountOfDigits = 1;
            }

            int ammountOfZerosToBeAdded = 4 - ammountOfDigits;
            for(int i = 0; i < ammountOfZerosToBeAdded; i++)
            {
                defaultString = "0" + defaultString;
            }
            return defaultString;
        }

        private void ApplyTriggerButton_Click(object sender, EventArgs e)
        {
            if (ComPort.IsOpen)
            {
                string finalstring = "";
                for(int x = 0; x < 6; x++)
                {
                    string toSend = convertIntToString(TriggerValuesPerPin[x]);
                    if (TriggerInvertedPerPin[x])
                    {
                        toSend = toSend + "1";
                    } else
                    {
                        toSend = toSend + "0";
                    }

                    AppendToComPortOutput(toSend);
                    finalstring = finalstring + toSend;
                    
                }

                PauseChart = true;
                ComPort.Write(finalstring);
                ComPort.BaseStream.Flush();
                Thread.Sleep(2000);
                PauseChart = false;

                AppendDebugOutputTextBox(finalstring);
            }
        }

        private void TriggerPinComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = TriggerPinComboBox.SelectedIndex;
            bool checkbox = TriggerInvertedPerPin[index];
            Trigger1IfValueIsBelowCheckbox.Checked = checkbox;
            Trigger1TrackBar.Value = TriggerValuesPerPin[index];

            PIN0CheckBox.Checked = false;
            PIN1CheckBox.Checked = false;
            PIN2CheckBox.Checked = false;
            PIN3CheckBox.Checked = false;
            PIN4CheckBox.Checked = false;
            PIN5CheckBox.Checked = false;

            switch (index) {
                case 0:
                    PIN0CheckBox.Checked = true;
                    break;
                case 1:
                    PIN1CheckBox.Checked = true;
                    break;
                case 2:
                    PIN2CheckBox.Checked = true;
                    break;
                case 3:
                    PIN3CheckBox.Checked = true;
                    break;
                case 4:
                    PIN4CheckBox.Checked = true;
                    break;
                case 5:
                    PIN5CheckBox.Checked = true;
                    break;

            }

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void readModeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (readModeCheckbox.Checked)
            {
                MessageBox.Show("This mode allows for better readability within the Data Received/Status window, but it introduces an increasing delay on processing, please don't use this when you are logging data in the graph in real time!");
            }
        }

        private void ApplyTriggerValueToAllPins_Click(object sender, EventArgs e)
        {
            if (ComPort.IsOpen)
            {
                string finalstring = "";

                for(int a = 0; a < 6; a++)
                {
                    TriggerValuesPerPin[a] = TriggerValuesPerPin[TriggerPinComboBox.SelectedIndex];
                    TriggerInvertedPerPin[a] = TriggerInvertedPerPin[TriggerPinComboBox.SelectedIndex];
                }

                for (int x = 0; x < 6; x++)
                {
                    string toSend = convertIntToString(TriggerValuesPerPin[x]);
                    if (TriggerInvertedPerPin[x])
                    {
                        toSend = toSend + "1";
                    }
                    else
                    {
                        toSend = toSend + "0";
                    }

                    AppendToComPortOutput(toSend);
                    finalstring = finalstring + toSend;

                }

                PauseChart = true;
                ComPort.Write(finalstring);
                ComPort.BaseStream.Flush();
                Thread.Sleep(2000);
                PauseChart = false;

                AppendDebugOutputTextBox(finalstring);
            }
        }

        private void FlexibleChartWindow_Click(object sender, EventArgs e)
        {
            if(flexChart == null)
            {
                flexChart = new FlexibleChart();
            }
            if (Application.OpenForms.OfType<FlexibleChart>().Count() == 1)
            {

                Application.OpenForms.OfType<FlexibleChart>().First().Close();
            }
            try
            {
                flexChart.Show();
            }
            catch
            {
                
                flexChart = new FlexibleChart();
                flexChart.Show();

            }
        }
    }
}
