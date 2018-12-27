using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sdf2
{
    public partial class Form1 : Form
    {
        //public static Admin admin;
        DB database = new DB();
        public static String username;

        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtUserName.Text) && !String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                List<Admin> list_admins = new List<Admin>();

                string[] selection = { "username", "password" };

                SqlDataReader reader = database.select("admin", selection, new string[] { }, new string[] { });

                while (reader.Read())
                {
                    string username = reader.GetString(0).ToString();
                    string password = reader.GetString(1).ToString();


                    list_admins.Add(new Admin(username, password));
                }

                if (list_admins.Exists(a => a.username == txtUserName.Text) && list_admins.Exists(a => a.password == txtPassword.Text))
                {
                    username = txtUserName.Text;

                    Form3 form3 = new Form3();
                    //admin = new Admin(txtUserName.Text, txtPassword.Text);

                    form3.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong parameters!");
                }

                database.closeConnection();
            }
            else
            {
                MessageBox.Show("Please enter username and password");
            }

        }
    }
}
