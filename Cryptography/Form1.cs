using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Cryptography
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var task1Form = new Task1.Form1();
            task1Form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var task2Form = new Task2.Form1();
            task2Form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var task3Form = new Task3.Form1();
            task3Form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var task4Form = new Task4.Form1();
            task4Form.Show();
        }

        private void NotImplemented(object sender, EventArgs e)
        {
            MessageBox.Show("Task is not implemented yet!");   
        }
    }
}
