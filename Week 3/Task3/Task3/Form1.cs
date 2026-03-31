using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total = 0;

            listBox1.Items.Clear();

            if (checkBox1.Checked)
            {
                total += 2;
                listBox1.Items.Add("Onion");
            }
            if (checkBox2.Checked)
            { 
            total += 2;
            listBox1.Items.Add("Tomato");
            }
            if (checkBox3.Checked)
            {
                total += 3.5;
                listBox1.Items.Add("Beef");
            }
            if (checkBox4.Checked)
            {
                total += 3;
                listBox1.Items.Add("Chicken");
            }
            if (checkBox5.Checked)
            {
                total += 2.5;
                listBox1.Items.Add("Capsicum");
            }
            if (radioButton1.Checked)
                total += 4;
            if (radioButton2.Checked)
                total += 5.5;
            if (radioButton3.Checked)
                total += 7;

            textBox1.Text = total.ToString();
        }
    }
}
