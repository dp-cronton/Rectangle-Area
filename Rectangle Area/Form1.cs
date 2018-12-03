using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rectangle_Area
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double w = double.Parse(textBox1.Text);
                double h = double.Parse(textBox2.Text);
                double a = w * h;
                textBox3.Text = a.ToString();
            }
            catch
            {
                MessageBox.Show("Error: Please enter two numbers.");
                textBox3.Text = "";
            }
        }
    }
}
