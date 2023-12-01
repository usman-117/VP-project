using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usman_Login_page_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private const string Username = "UsmanAli";
        private const string Password = "Usman";

        private void button1_Click(object sender, EventArgs e)
        {
            string Username = textBox1.Text;
            string Password = textBox2.Text;

            if(Username == "UsmanAli" && Password == "Usman")
            {
                MessageBox.Show("Login Sucessfully");
            }
            else
            {
                MessageBox.Show("Invalid! Please Try Again");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
