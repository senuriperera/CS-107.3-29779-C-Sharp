using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_4
{
    public partial class Calculator : Form
    {
        string operation = "";
        double result_Value = 0;
        bool is_operation_performed = false;
        public Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || is_operation_performed)
            {
                textBox1.Clear();
            }

            Button btn = (Button)sender;

            if (textBox1.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text = textBox1.Text + btn.Text;
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + btn.Text;
            }
           
            is_operation_performed = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
        }
        private void operation_Performed(object sender, EventArgs e)
        {
            if(result_Value != 0)
            {
                button18.PerformClick();
                Button btn = (Button)sender;
                operation = btn.Text;
                result_Value = double.Parse(textBox1.Text);
                label1.Text = result_Value + operation;
                is_operation_performed = true;
            }
            else
            {
                Button btn = (Button)sender;
                operation = btn.Text;
                result_Value = double.Parse(textBox1.Text);
                label1.Text = result_Value + operation;
                is_operation_performed = true;
            }
          

        }

        private void button18_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox1.Text = (result_Value + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result_Value - double.Parse(textBox1.Text)).ToString();
                    break;
                case "x":
                    textBox1.Text = (result_Value * double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (result_Value / double.Parse(textBox1.Text)).ToString();
                    break;
            }
        }
    }
}
