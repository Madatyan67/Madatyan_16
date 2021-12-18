using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keshishyan16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int t = Convert.ToInt32(textBox1.Text);
            if (radioButton1.Checked)
            { int oplata = t * 1000; textBox2.Text = Convert.ToString(oplata); }
            else if (radioButton2.Checked)
            { int oplata = t * 600; textBox2.Text = Convert.ToString(oplata); }
            else if (radioButton3.Checked)
            { int oplata = t * 300; textBox2.Text = Convert.ToString(oplata); }
        }
    }
}
