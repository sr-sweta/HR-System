using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BusinessLogic;

namespace WindowLogin
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            User user = UserLogic.ValidateUser(username.Text.Trim(), password.Text.Trim());
            if (user == null)
            {
                MessageBox.Show("Login Failed");
            }
            else
            {
                MessageBox.Show("Welcome " + user.FirstName + " " + user.LastName);
            }
        }
    }
}
