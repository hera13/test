using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Email")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.LightGray;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "PassWord";
                textBox3.ForeColor = Color.DimGray;
                textBox3.UseSystemPasswordChar = false;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "PassWord")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.LightGray;
                textBox3.UseSystemPasswordChar = true;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Email";
                textBox1.ForeColor = Color.DimGray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
