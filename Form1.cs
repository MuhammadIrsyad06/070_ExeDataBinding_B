using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercisePABD_B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBoxUsername.Text=="Irsyad" && textBoxPass.Text=="icad123" && checkBox1.Checked)
            {
                new Form2().Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Username/Password Salah, jangan lupa kotaknya diceklis :)");
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {
            if(textBoxPass.PasswordChar=='\0')
            {
                textBoxPass.PasswordChar = '^';
            }
        }
    }
}
