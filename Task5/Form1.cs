using System;
using System.Windows.Forms;

namespace Task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Maximum = int.MaxValue;
            numericUpDown1.Value = 123;
            numericUpDown2.Maximum = int.MaxValue;
            numericUpDown2.Value = 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int number = Convert.ToInt32(numericUpDown1.Value);
                int accuracy = Convert.ToInt32(numericUpDown2.Value);

                textBox1.Text = SoloveyShtrassen.IsPrime(number, accuracy)
                    ? $"{number } is prime."
                    : $"{number } is not prime.";
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Please check your input data and try again. Exception was thrown : {ex.Message}");
            }
        }
    }
}
