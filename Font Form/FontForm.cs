using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASPM
{
    public partial class FontForm : Form
    {

        public delegate void GetFontSizeDelegate(int size);

        public event GetFontSizeDelegate GetFontSize;

        public FontForm(MainForm form)
        {
            InitializeComponent();

            GetFontSize += form.ChangeOutputFontSize;

            MaximizeBox = false;

            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void FontForm_Load(object sender, EventArgs e)
        {
            for (int i = 5; i < 16; i++)
                listBox1.Items.Add(i);

            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetFontSize((int)listBox1.SelectedItem);
            Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
}
