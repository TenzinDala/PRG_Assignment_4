using PRG_Assignment_4.Forms;
using Seneca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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
            registrationForm.ShowDialog(); //For Modal
            //registrationForm.MdiParent = this;
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
                userInfoForm.ShowDialog();
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

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Form is now closing");
            FileManager.WriteFile();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            List<string> strings = new List<string>();
            string path = Directory.GetCurrentDirectory();
            string filePath = System.IO.Path.Combine(path, "User_Informations.txt");
            if(File.Exists(filePath))
            {
                FileManager.ReadFile(filePath);
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm2 = new LoginForm();
            loginForm2.ShowDialog();
        }
    }
}
