using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.textBox1.Text = "Hola Mundo";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = this.textBox1.Text;
            this.BackColor = Color.Blue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sale con DISPOSE");
            this.Dispose();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
                _ = this.BackColor == Color.LightBlue;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
