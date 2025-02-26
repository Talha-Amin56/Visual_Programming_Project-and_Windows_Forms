using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double resultvalue = 0;
        string operationperformed = "";
        bool isoperationperformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0"||(isoperationperformed))
                    textBox1.Clear();
            isoperationperformed = false;
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void button_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationperformed = button.Text;
            resultvalue = double.Parse(textBox1.Text);
            label1.Text = resultvalue + " " + operationperformed;
            isoperationperformed = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            switch(operationperformed)
            {
                case"+":
                    textBox1.Text = (resultvalue + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (resultvalue - double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (resultvalue * double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (resultvalue / double.Parse(textBox1.Text)).ToString();
                    break;

            }
        }
    }
}
