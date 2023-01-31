using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASPM
{
    public partial class SerialChartForm : Form
    {

        private static double StartPosition = 0;

        public SerialChartForm(MainForm form)
        {
            InitializeComponent();

            FillIntervalCombobox();

            UpdateTimer.Tick += TimerTick;

            comboBox1.SelectedIndex = comboBox1.Items.Count - 1;

        }

        private void FillIntervalCombobox()
        {
            for (int i = 50; i <= 1000; i += 50)
                comboBox1.Items.Add(i);
        }

        private void SerialChartForm_Load(object sender, EventArgs e)
        {
            label1.Text += MainForm._mainForm.serialPort.PortName;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            if (MainForm._mainForm._recievedData.Count() <= 0)
                return;

            var values = new List<double>();

            if (!MainForm._mainForm.serialPort.IsOpen)
            {
                ControlButton_Click(sender, e);

                label2.Text = "Port Status: Closed";

                return;
            }

            label2.Text = "Port Status: Open";

            values = ParseData(MainForm._mainForm._recievedData);

            if (values == null)
                return;

            AddPoints(values);

            if (SerialChart.Series[0].Points.Count > 30)
                SerialChart.ChartAreas[0].AxisX.Minimum += Math.Round((double)UpdateTimer.Interval / 1000, 4);

            SerialChart.ChartAreas[0].AxisX.Maximum = Math.Round(StartPosition, 4);

            SerialChart.ChartAreas[0].AxisY.Minimum = Convert.ToDouble(numericMinimum.Value);

            SerialChart.ChartAreas[0].AxisY.Maximum = Convert.ToDouble(numericMaximum.Value);

            StartPosition += Math.Round((double)UpdateTimer.Interval / 1000, 4);

        }

        private void AddPoints(List<double> values)
        {
            try
            {
                for (int i = 0; i < values.Count; i++)
                {
                    SerialChart.Series[i].Points.AddXY(StartPosition, values[i]);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error\n Probably the number of lines does not correspond to the number of data in the line ! ... !");
            }
        }

        private List<double> ParseData(string RecievedData)
        {
            try
            {
                if (RecievedData[0] != '!' && RecievedData[RecievedData.Length - 1] != '!')
                    return null;

                RecievedData = RecievedData.Remove(0, 1);

                RecievedData = RecievedData.Remove(RecievedData.Length - 1, 1);

                var argumentList = RecievedData.Split(' ').ToList();

                return argumentList.ConvertAll(x => Convert.ToDouble(x));
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void SerialChartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void ControlButton_Click(object sender, EventArgs e)
        {
            if (UpdateTimer.Enabled)
            {
                UpdateTimer.Stop();

                ControlButton.Text = "Start";
            }
            else
            {
                ControlButton.Text = "stop";
                UpdateTimer.Start();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTimer.Stop();

            UpdateTimer.Interval = (int)comboBox1.Items[comboBox1.SelectedIndex];

            UpdateTimer.Start();

        }
    }
}
