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

namespace ASPM
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public static List<string> _ports = new List<string>();

        public static List<string> _baudRate = new List<string> { "4800", "9600", "14400", "19200", "115200"};

        public static List<string> _parity = new List<string> { "None", "Odd", "Even"};

        public static List<string> _dataBits = new List<string> { "8", "7"};

        public static List<string> _stopBits = new List<string> { "None", "1", "1.5", "2"};

        public Thread SerialReadThread = null;

        public Form1()
        {
            InitializeComponent();

            _ports = GetAvaliablePorts();

            comboBox1.Items.AddRange(_ports.ToArray());

            comboBox1.SelectedIndex = 0;

            comboBox2.Items.AddRange(_baudRate.ToArray());

            comboBox2.SelectedIndex = 1;

            comboBox3.Items.AddRange(_parity.ToArray());

            comboBox3.SelectedIndex = 0;

            comboBox4.Items.AddRange(_dataBits.ToArray());

            comboBox4.SelectedIndex = 0;

            comboBox5.Items.AddRange(_stopBits.ToArray());

            comboBox5.SelectedIndex = 1;


        }

        private List<string> GetAvaliablePorts() =>
            SerialPort.GetPortNames().ToList();
     

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            richTextBox1.Text += serialPort1.ReadExisting().ToString() + "\n";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.Text.ToString();

            comboBox1.Enabled = false;

            serialPort1.BaudRate = int.Parse(comboBox2.Text);

            comboBox2.Enabled = false;

            serialPort1.Parity = (Parity)Utils.TransformParity(comboBox3.Text.ToString());

            comboBox3.Enabled = false;

            serialPort1.DataBits = int.Parse(comboBox4.Text.ToString());

            comboBox4.Enabled = false;

            serialPort1.StopBits = (StopBits)Utils.TransformStopBits(comboBox5.Text.ToString());

            comboBox5.Enabled = false;

            button5.Enabled = false;

            button4.Enabled = true;

            button3.Enabled = true;

            button2.Enabled = true;

            button1.Enabled = false;

            textBox1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox5.Enabled = true;

            button5.Enabled = true;

            button4.Enabled = false;

            button3.Enabled = false;

            button2.Enabled = false;

            button1.Enabled = false;

            textBox1.Enabled = false;

            comboBox1.Enabled = true;

            comboBox2.Enabled = true;

            comboBox3.Enabled = true;

            comboBox4.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Что-то пошло не так :(");
            }

            button1.Enabled = true;

            button2.Enabled = false;

            button4.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();

            button1.Enabled = false;

            button2.Enabled = true;

            button4.Enabled = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write(textBox1.Text.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Что-то пошло не так :(");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
