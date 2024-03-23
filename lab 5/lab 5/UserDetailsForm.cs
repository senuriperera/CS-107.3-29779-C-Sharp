using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace lab_5
{
    public partial class UserDetailsForm : Form
    {
        public UserDetailsForm(string firstName, string lastName, string username, string email)
        {
            InitializeComponent();

            label2.Text = $"Name:{firstName} {lastName}";
            label3.Text = $"Username: {username}";
            label4.Text = $"Email Address: {email}";

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
