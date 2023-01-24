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
using System.Timers;
using ASPM.Additional;

namespace ASPM
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        #region SerialPortDescriptionLists
        public static List<string> _ports = new List<string>();

        public static List<string> _baudRate = new List<string> { "4800", "9600", "14400", "19200", "115200"};

        public static List<string> _parity = new List<string> { "None", "Odd", "Even"};

        public static List<string> _dataBits = new List<string> { "8", "7"};

        public static List<string> _stopBits = new List<string> { "None", "1", "1.5", "2"};

        #endregion

        private AppState _state;

        private static System.Timers.Timer LoopTimer = new System.Timers.Timer();

        [Obsolete]
        private void SaveParameters()
        {
            serialPort1.PortName = COMbox.Text.ToString();

            COMbox.Enabled = false;

            serialPort1.BaudRate = int.Parse(BaudRateBox.Text);

            serialPort1.Parity = (Parity)int.Parse(ConfigurationSettings.AppSettings.Get(ParityBox.Text.ToString()));

            serialPort1.DataBits = int.Parse(DataBitsBox.Text.ToString());

            serialPort1.StopBits = (StopBits)int.Parse(ConfigurationSettings.AppSettings.Get(StopBitsBox.Text.ToString()));
        }

        [Obsolete]
        private void UpdateParameters()
        {

            serialPort1.BaudRate = int.Parse(BaudRateBox.Text);

            serialPort1.Parity = (Parity)int.Parse(ConfigurationSettings.AppSettings.Get(ParityBox.Text.ToString()));

            serialPort1.DataBits = int.Parse(DataBitsBox.Text.ToString());

            serialPort1.StopBits = (StopBits)int.Parse(ConfigurationSettings.AppSettings.Get(StopBitsBox.Text.ToString()));
        }

        private List<string> GetAvaliablePorts() => 
            SerialPort.GetPortNames().ToList();

        public Form1()
        {
            InitializeComponent();

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
            if (serialPort1.IsOpen)
                serialPort1.Close();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialOutput.Text += serialPort1.ReadExisting().ToString() + "\n";
        }

        #region Buttons


        private void OpenBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_state.PortOpened)
                {
                    SaveParameters();

                    serialPort1.Open();

                    SendBtn.Enabled = true;

                    CommandString.Enabled = true;

                    _state.PortOpened = true;

                    OpenBtn.Text = "Close port";
                }
                else
                {
                    if (serialPort1.IsOpen)
                        serialPort1.Close();

                    SendBtn.Enabled = false;

                    CommandString.Enabled = false;

                    _state.PortOpened = false;

                    COMbox.Enabled = true;

                    OpenBtn.Text = "Open port";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Что-то пошло не так :(");
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
                    serialPort1.Write(CommandString.Text.ToString());
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

                    serialPort1.Write(buffer, 0, buffer.Length);

                    _state.HexLength = 0;
                }

                if (ShowSentCommCheckBox.Checked)
                    SerialOutput.Text += "[your command]: " + CommandString.Text.ToString() + "\n";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Что-то пошло не так :(");
            }
            finally
            {
                if (!_state.LoopStarted)
                    CommandString.Text = "";
            }
        }

        private void Day_Nignt_Btn_Click(object sender, EventArgs e)
        {
            if (!_state.IsBlack)
            {
                BackColor = Color.FromArgb(255, 32, 32, 32);

                SerialOutput.BackColor = Color.FromArgb(255, 38, 33, 33);
                SerialOutput.ForeColor = Color.FromArgb(255, 204, 204, 204);

                CommandString.BackColor = Color.FromArgb(255, 109, 110, 166);
                CommandString.ForeColor = Color.FromArgb(255, 204, 204, 204);
                _state.IsBlack = !_state.IsBlack;
            }
            else
            {
                BackColor = Color.White;

                SerialOutput.BackColor = Color.White;
                SerialOutput.ForeColor = Color.Black;

                CommandString.BackColor = Color.White;
                CommandString.ForeColor = Color.Black;
                _state.IsBlack = !_state.IsBlack;
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

                LoopButton.Text = "Stop";
            }
            else
            {
                _state.LoopStarted = false;

                LoopTimer.Stop();

                LoopTimer.Elapsed -= SendBtn_Click;

                LoopButton.Text = "Start";
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

        #region SaveFilesSettings
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            saveFileDialog1.Filter = "Text file (*.txt)|*.txt|Word File (*.doc)|*.doc|Word File (*.docx)|*.docx";
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                File.WriteAllText(saveFileDialog1.FileName, SerialOutput.Text);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.Filter = "All files (*.*)|*.*";


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                File.WriteAllText(saveFileDialog1.FileName, SerialOutput.Text);
        }
        #endregion

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

        private void clearOutputWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SerialOutput.Text = "";
        }
    }
}
