using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Pizza_App
{
    public partial class user_Form : Form
    {
        public List<User> userAccess = new List<User>();
        const string userFile = "userFile_json";
        public user_Form()
        {
            InitializeComponent();
            initializeUser();
        }
        
        public void initializeUser()
        {
            userAccess.Add(new User("admin", "admin", User.accessible.some));
        }

        private void user_Form_Load(object sender, EventArgs e)
        {
            userDataGridView.DataSource=new  BindingList<User>(userAccess);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var jsonSize = JsonConvert.SerializeObject(userAccess);
            System.IO.File.WriteAllText(userFile, jsonSize, Encoding.UTF8);
            MessageBox.Show("Successfully saved the Users.", "Success", MessageBoxButtons.OK);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(userFile))
            {
                var jsonString = System.IO.File.ReadAllText(userFile);
                userAccess = JsonConvert.DeserializeObject<List<User>>(jsonString);
            }
            else
            {
                userAccess.Clear();
            }
            userDataGridView.DataSource = new BindingList<User>(userAccess);
        }
        public void Loadusers()
        {
            if (System.IO.File.Exists(userFile))
            {
                var jsonString = System.IO.File.ReadAllText(userFile);
                userAccess = JsonConvert.DeserializeObject<List<User>>(jsonString);
            }
            else
            {
                userAccess.Clear();
                initializeUser();
            }

        }
    }
}
