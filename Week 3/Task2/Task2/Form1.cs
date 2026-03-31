using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {

        int num1, num2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // + Button
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out num1) && int.TryParse(textBox2.Text, out num2))
            {
                int answer = num1 + num2;
                textBox3.Text = answer.ToString();
            }
        }
        // - Button
        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out num1) && int.TryParse(textBox2.Text, out num2))
            {
                int answer = num1 - num2;
                textBox3.Text = answer.ToString();
            }
        }
        // * Button
        private void button3_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out num1) && int.TryParse(textBox2.Text, out num2))
            {
                int answer = num1 * num2;
                textBox3.Text = answer.ToString();
            }
        }
        // / Button
        private void button4_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out num1) && int.TryParse(textBox2.Text, out num2))
            {
                int answer = num1 / num2;
                textBox3.Text = answer.ToString();
            }
        }
        // % Button
        private void button5_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out num1) && int.TryParse(textBox2.Text, out num2))
            {
                int answer = num1 % num2;
                textBox3.Text = answer.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
