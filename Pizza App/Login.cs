using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_App
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTxt.Text== "admin" && passwordTxt.Text == "admin")
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("WRONG USERNAME OR PASSWORD","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                usernameTxt.Clear();
                passwordTxt.Clear();
            }
        }
    }
}
