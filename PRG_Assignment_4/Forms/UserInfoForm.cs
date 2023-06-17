using Seneca;
using System.Windows.Forms;

namespace PRG_Assignment_4.Forms
{
    public partial class UserInfoForm : Form
    {
        public UserInfoForm()
        {
            InitializeComponent();
            textBox1.Text = User.loggedInUser.firstName;
            textBox2.Text = User.loggedInUser.lastName;
            textBox3.Text = User.loggedInUser.email;
        }
    }
}
