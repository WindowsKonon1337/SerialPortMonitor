using System;
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

        bool IsBlack = false;

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

        [Obsolete]
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            
            serialPort1.PortName = COMbox.Text.ToString();

            COMbox.Enabled = false;

            serialPort1.BaudRate = int.Parse(BaudRateBox.Text);

            BaudRateBox.Enabled = false;

            serialPort1.Parity = (Parity)int.Parse(ConfigurationSettings.AppSettings.Get(ParityBox.Text.ToString()));

            ParityBox.Enabled = false;

            serialPort1.DataBits = int.Parse(DataBitsBox.Text.ToString());

            DataBitsBox.Enabled = false;

            serialPort1.StopBits = (StopBits)int.Parse(ConfigurationSettings.AppSettings.Get(StopBitsBox.Text.ToString()));

            StopBitsBox.Enabled = false;

            SaveBtn.Enabled = false;

            EditBtn.Enabled = true;

            CloseBtn.Enabled = false;

            OpenBtn.Enabled = true;

            SendBtn.Enabled = false;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            StopBitsBox.Enabled = true;

            SaveBtn.Enabled = true;

            EditBtn.Enabled = false;

            CloseBtn.Enabled = false;

            OpenBtn.Enabled = false;

            SendBtn.Enabled = false;

            CommandString.Enabled = false;

            COMbox.Enabled = true;

            BaudRateBox.Enabled = true;

            ParityBox.Enabled = true;

            DataBitsBox.Enabled = true;
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Open();

                SendBtn.Enabled = true;

                CloseBtn.Enabled = true;

                OpenBtn.Enabled = false;

                EditBtn.Enabled = false;

                CommandString.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Что-то пошло не так :(");
            }
            finally
            {

            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();

            SendBtn.Enabled = false;

            CommandString.Enabled = false;

            CloseBtn.Enabled = false;

            OpenBtn.Enabled = true;

            EditBtn.Enabled = true;
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write(CommandString.Text.ToString());

                if (ShowSentCommCheckBox.Checked)
                    SerialOutput.Text += "[your command]: " + CommandString.Text.ToString() + "\n";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Что-то пошло не так :(");
            }
            finally
            {
                CommandString.Text = "";
            }
        }

        private void Day_Nignt_Btn_Click(object sender, EventArgs e)
        {
            if (!IsBlack)
            {
                BackColor = Color.FromArgb(255, 32, 32, 32);

                SerialOutput.BackColor = Color.FromArgb(255, 38, 33, 33);
                SerialOutput.ForeColor = Color.FromArgb(255, 204, 204, 204);

                CommandString.BackColor = Color.FromArgb(255, 109, 110, 166);
                CommandString.ForeColor = Color.FromArgb(255, 204, 204, 204);
                IsBlack = !IsBlack;
            }
            else
            {
                BackColor = Color.White;

                SerialOutput.BackColor = Color.White;
                SerialOutput.ForeColor = Color.Black;

                CommandString.BackColor = Color.White;
                CommandString.ForeColor = Color.Black;
                IsBlack = !IsBlack;
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
    }
}
