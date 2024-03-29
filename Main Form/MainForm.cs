﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;
using System.Configuration;
using System.IO;
using System.Collections.Concurrent;
using ASPM.Additional;

namespace ASPM
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        #region SerialPortDescriptionLists
        private static List<string> _ports = new List<string>();

        private static List<string> _baudRate = new List<string> { "4800", "9600", "14400", "19200", "115200"};

        private static List<string> _parity = new List<string> { "None", "Odd", "Even"};

        private static List<string> _dataBits = new List<string> { "8", "7"};

        private static List<string> _stopBits = new List<string> { "None", "1", "1.5", "2"};

        #endregion

        private AppState _state;

        private static System.Timers.Timer LoopTimer = new System.Timers.Timer();

        internal static MainForm _mainForm;

        internal string _recievedData = "";

        [Obsolete]
        private void SaveParameters()
        {
            serialPort.PortName = COMbox.Text.ToString();

            COMbox.Enabled = false;

            serialPort.BaudRate = int.Parse(BaudRateBox.Text);

            serialPort.Parity = (Parity)int.Parse(ConfigurationSettings.AppSettings.Get(ParityBox.Text.ToString()));

            serialPort.DataBits = int.Parse(DataBitsBox.Text.ToString());

            serialPort.StopBits = (StopBits)int.Parse(ConfigurationSettings.AppSettings.Get(StopBitsBox.Text.ToString()));
        }

        [Obsolete]
        private void UpdateParameters()
        {

            serialPort.BaudRate = int.Parse(BaudRateBox.Text);

            serialPort.Parity = (Parity)int.Parse(ConfigurationSettings.AppSettings.Get(ParityBox.Text.ToString()));

            serialPort.DataBits = int.Parse(DataBitsBox.Text.ToString());

            serialPort.StopBits = (StopBits)int.Parse(ConfigurationSettings.AppSettings.Get(StopBitsBox.Text.ToString()));
        }

        private List<string> GetAvaliablePorts() => 
            SerialPort.GetPortNames().ToList();

        public MainForm()
        {
            InitializeComponent();

            _mainForm = this;

            _ports = GetAvaliablePorts();

            COMbox.Items.AddRange(_ports.ToArray());

            COMbox.SelectedIndex = 0;

            BaudRateBox.Items.AddRange(_baudRate.ToArray());

            BaudRateBox.SelectedIndex = 1;

            ParityBox.Items.AddRange(_parity.ToArray());

            ParityBox.SelectedIndex = 0;

            DataBitsBox.Items.AddRange(_dataBits.ToArray());

            DataBitsBox.SelectedIndex = 0;

            StopBitsBox.Items.AddRange(_stopBits.ToArray());

            StopBitsBox.SelectedIndex = 1;

            this.MaximizeBox = false;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            _state.PortOpened = false;

            _state.IsBlack = false;

            _state.HexLength = 0;

            _state.LoopStarted = false;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort.IsOpen)
                serialPort.Close();
        }

        internal void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            _recievedData = serialPort.ReadExisting();

            ProccesRecievedData(_recievedData);

        }

        private void ProccesRecievedData(string data) // TODO: create logic for HEX-values
        {
            try
            {
                SerialOutput.Text += MainForm._mainForm._recievedData + "\n";
            }
            catch (Exception ex)
            {

            }
        }

        private void clearOutputWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SerialOutput.Text = "";
        }

        #region Buttons


        private void OpenBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_state.PortOpened)
                {
                    SaveParameters();

                    serialPort.Open();

                    SendBtn.Enabled = true;

                    CommandString.Enabled = true;

                    showGraphToolStripMenuItem.Enabled = true;

                    _state.PortOpened = true;

                    OpenBtn.Text = "Close port";
                }
                else
                {

                    if (_state.LoopStarted)
                        LoopButton_Click(sender, e);

                    if (serialPort.IsOpen)
                        serialPort.Close();

                    SendBtn.Enabled = false;

                    CommandString.Enabled = false;

                    showGraphToolStripMenuItem.Enabled = false;

                    _state.PortOpened = false;

                    COMbox.Enabled = true;

                    OpenBtn.Text = "Open port";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Something`s not right :(");
            }
            finally
            {
                COMbox.Enabled = true;
            }
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateParameters();

                if (CommandString.Text.Length == 0)
                    return;

                if (StringRadioButton.Checked)
                {
                    serialPort.Write(CommandString.Text.ToString());
                }
                
                if (HexRadioButton.Checked)
                {

                    var hexString = CommandString.Text.Remove(CommandString.Text.Length - 1);

                    var hexStringArray = hexString.Split(' ');

                    byte[] buffer = new byte[hexStringArray.Length];

                    for (int i = 0; i < hexStringArray.Length; i++)
                    {
                        buffer[i] = Convert.ToByte(hexStringArray[i], 16);
                    }

                    serialPort.Write(buffer, 0, buffer.Length);

                    _state.HexLength = 0;
                }

                if (ShowSentCommCheckBox.Checked)
                    SerialOutput.Text += "[your command]: " + CommandString.Text.ToString() + "\n";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Something`s not right :(");

            }
            finally
            {
                SerialOutput.SelectionStart = SerialOutput.Text.Length;

                SerialOutput.ScrollToCaret();

                if (!_state.LoopStarted)
                    CommandString.Text = "";
            }
        }

        private void LoopButton_Click(object sender, EventArgs e)
        {
            if (!_state.LoopStarted)
            {
                _state.LoopStarted = true;

                LoopTimer.Interval = (int)LoopNumeric.Value;

                LoopTimer.Elapsed += SendBtn_Click;

                LoopTimer.Start();

                LoopButton.Text = "Stop loop";
            }
            else
            {
                _state.LoopStarted = false;

                LoopTimer.Stop();

                LoopTimer.Elapsed -= SendBtn_Click;

                LoopButton.Text = "Start loop";
            }

        }

        #endregion

        #region Color

        private void ChangeColor(Color color)
        {
            SerialOutput.ForeColor = color;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.Red);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.Blue);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.Black);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.Green);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.Yellow);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.Red);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.Blue);
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.Black);
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.Green);
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.Yellow);
        }
        #endregion

        #region CommandStringEvents
        private void CommandString_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == '\r')
                SendBtn_Click(sender, e);
        }

        private void CommandString_KeyUp(object sender, KeyEventArgs e)
        {
            if (HexRadioButton.Checked)
            {
                _state.HexLength += 1;

                CommandString.Text = CommandString.Text.ToUpper();

                if (_state.HexLength % 2 == 0)
                {
                    CommandString.Text += " ";
                }

                CommandString.SelectionStart = CommandString.Text.Length;
            }
        }
        #endregion

        #region Session
        private void saveSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Session file (*.session)|*.session";

            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                using (BinaryWriter bw = new BinaryWriter(File.Open(saveFileDialog.FileName, FileMode.Create)))
                {
                    bw.Write(SerialOutput.Text);
                };
        }

        private void loadSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Session file (*.session)|*.session";

            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
                using (BinaryReader br = new BinaryReader(File.Open(openFileDialog.FileName, FileMode.Open)))
                {
                    SerialOutput.Text = br.ReadString();
                }
        }
        #endregion

        #region OutputFont
        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FontForm = new FontForm(this);

            FontForm.ShowDialog();
        }

        public void ChangeOutputFontSize(int FontSize)
        {
            SerialOutput.Font = new Font(SerialOutput.SelectionFont.FontFamily, FontSize, SerialOutput.SelectionFont.Style);
        }
        #endregion

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you like to go to the project repository?",
                "Yeah, star it)",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Asterisk
               ) == DialogResult.Yes)
                System.Diagnostics.Process.Start("https://github.com/WindowsKonon1337/SerialPortMonitor");
        }

        private void showGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new SerialChartForm(this);

            form.Show();
        }

        private void graphicsWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Parse data syntax: it must be an array of chars\n !first_value etc last_value!\n Plot window supports up to 10 splines");
        }
    }
}
