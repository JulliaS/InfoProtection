using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxP.Text = "2147483647";
            textBoxG.Text = NumbersOperations.Random(2, BigInteger.Parse(textBoxP.Text) - 1).ToString();
            textBoxK_B.Text = NumbersOperations.Random(2, BigInteger.Parse(textBoxP.Text) - 1).ToString();
        }

        private void button1_Click(object sender, EventArgs args)
        {
            try
            {
                var p = BigInteger.Parse(textBoxP.Text);
                var g = BigInteger.Parse(textBoxG.Text);
                var key_B = BigInteger.Parse(textBoxK_B.Text);
                var message_A = BigInteger.Parse(inputMessage.Text);

                ElGemal.Encode(p, g, key_B, message_A, out BigInteger r, out BigInteger e);

                decodedMessage.Text = r.ToString() + " " + e.ToString();
            }
            catch
            {
                MessageBox.Show("Wrong input data");
            }
        }

        private void button2_Click(object sender, EventArgs args)
        {
            try
            {
                var p = BigInteger.Parse(textBoxP.Text);
                var key_B = BigInteger.Parse(textBoxK_B.Text);

                string[] R_E = decodedMessage.Text.Split(' ');
                var r = BigInteger.Parse(R_E[0]);
                var e = BigInteger.Parse(R_E[1]);

                inputMessage.Text = ElGemal.Decode(r, e, p, key_B).ToString();
            }
            catch
            {
                MessageBox.Show("Wrong input data");
            }
        }
    }
}
