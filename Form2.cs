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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }

        private void buttonDataGrid_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

        private void buttonBinding_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            this.Hide();
        }

        private void Menu_Click(object sender, EventArgs e)
        {

        }
    }
}
