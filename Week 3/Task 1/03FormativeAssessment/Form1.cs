using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03FormativeAssessment
{
    public partial class Form1 : Form
    {
        int total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        //SumButton
        private void button1_Click(object sender, EventArgs e)
        {
            

            if (int.TryParse(textBox1.Text, out int num1))
            {
                total = total + num1;
            }
            if (int.TryParse(textBox2.Text, out int num2))
            {
                total = total + num2;
            }
            if (int.TryParse(textBox3.Text, out int num3))
            {
                total = total + num3;
            }
            if (int.TryParse(textBox4.Text, out int num4))
            {
                total = total + num4;
            }
            if (int.TryParse(textBox5.Text, out int num5))
            {
                total = total + num5;
            }

            textBox6.Text = total.ToString();

            
        }

        //AverageButton
        private void button2_Click(object sender, EventArgs e)
        {
            int average = total / 5;
            textBox7.Text = average.ToString();
        }

        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
