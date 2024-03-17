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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1=Convert.ToInt32(textBox1.Text);
            int num2=Convert.ToInt32(textBox2.Text);

            int add = num1 + num2;

            label3.Text = "Addition:" + add.ToString();

            int sub = num1 - num2;

            label5.Text = "Substraction:" + sub.ToString();

            int div = num1 / num2;

            label4.Text = "Division:" + div.ToString();

            int multiply = num1 * num2;

            label6.Text = "Multiplication:" + multiply.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
