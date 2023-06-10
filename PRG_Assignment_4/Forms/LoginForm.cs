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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PRG_Assignment_4.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            User initialUser = new User()
            {
                firstName = "Preeti",
                lastName = "Gurung",
                email = "Mr.Handsome",
                passWord = "12345678"
            };
            initialUser.CreateUser("Preeti", "Gurung", "Mr.Handsome", "12345678");
        }

        private void login_Click(object sender, EventArgs e)
        {
            foreach (User user in User.Credentials.Values)
            {
                if (user.email == textBox1.Text && user.passWord == textBox2.Text)
                {
                    User.loggedInStatus = true;
                    MessageBox.Show("Successfully Logged In!!!");

                    User.loggedInUser = user;

                    UserInfoForm userInfoForm = new UserInfoForm();
                    userInfoForm.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed!!!");
                    User.loggedInStatus = false;
                }
            }
        }
    }
}
