using PRG_Assignment_4.Forms;
using Seneca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG_Assignment_4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            loginForm.MdiParent = this;
            
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
            registrationForm.MdiParent = this;
        }

        private void userInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!User.loggedInStatus)
            {
                MessageBox.Show("You are not Logged in!!!");
            }
            else
            {
                UserInfoForm userInfoForm = new UserInfoForm();
                userInfoForm.Show();
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Default UserName: Mr.Handsome\n\nDefault Password: 12345678");
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!User.loggedInStatus)
            {
                userInfoToolStripMenuItem.BackColor = Color.Gray;
                logoutToolStripMenuItem.BackColor = Color.Gray;


            }
            else
            {
                userInfoToolStripMenuItem.BackColor = Color.White;
                logoutToolStripMenuItem.BackColor = Color.White;

            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!User.loggedInStatus)
            {
                MessageBox.Show("You are not Logged in!!!");
            }
            else
            {
                User.loggedInUser = null;
                User.loggedInStatus = false;
                MessageBox.Show("Successfully Logged out!!!");
            }
        }
    }
}
