using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = textBox6.Text;
            string lastName = textBox5.Text;
            string email = textBox4.Text;
            string username = textBox3.Text;
            string dob = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            
            if(string.IsNullOrEmpty(textBox1.Text) || 
                string.IsNullOrEmpty(textBox2.Text)||
                string.IsNullOrEmpty(textBox3.Text)||
                string.IsNullOrEmpty(textBox4.Text)||
                string.IsNullOrEmpty(textBox5.Text)||
                string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            if(textBox1.Text != textBox2.Text)
            {
                MessageBox.Show("Password and Confirm Password do not match");
                return;
            }

            if(!AreAllFieldsStrings())
            {
                MessageBox.Show("All fields should contain strings");
                return;
            }
            var userDetailsForm = new UserDetailsForm(firstName, lastName, username, email);
            userDetailsForm.Show();
            this.Hide();
        }

        private bool AreAllFieldsStrings()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    if (!string.IsNullOrEmpty(control.Text) && !IsString(control.Text))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool IsString(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    return false;
                }
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
                else if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).Value = DateTime.Now;
                }
            }
        }
    }
}
