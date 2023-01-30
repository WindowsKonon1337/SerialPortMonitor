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

        private int _startSec = DateTime.Now.Millisecond;
        public SerialChartForm(MainForm form)
        {
            InitializeComponent();

            UpdateTimer.Interval = 100;

            UpdateTimer.Tick += TimerTick;

            UpdateTimer.Start();
            
        }

        private void SerialChartForm_Load(object sender, EventArgs e)
        {
            
        }
        public void UpdateGraphsData(string ValString)
        {

        }

        private void TimerTick(object sender, EventArgs e)
        {
            decimal value = 0;

            if (MainForm._mainForm._recievedData.Count() > 0)
                value = Convert.ToDecimal(MainForm._mainForm._recievedData);

            SerialChart.Series[0].Points.AddXY((DateTime.Now.Millisecond - _startSec) / 1000, value);
        }

        private void SerialChartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //serialPort1.Close();
        }
    }
}
