using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sdf2
{
    public partial class Form2 : Form
    {
        DB database = new DB();
        List<string> adminList = new List<string>();

        public Form2()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(firstName.Text)
                && !String.IsNullOrWhiteSpace(lastName.Text)
                && !String.IsNullOrWhiteSpace(userName.Text)
                && !String.IsNullOrWhiteSpace(password.Text)
                && !String.IsNullOrWhiteSpace(passConfirm.Text)
                && !String.IsNullOrWhiteSpace(address.Text))
            {
                if (password.Text.Equals(passConfirm.Text))
                {
                    string[] columns = { "first_name", "last_name", "username", "password", "birthdate", "address" };
                    object[] vals = { firstName.Text, lastName.Text, userName.Text, password.Text, birthday.Value.Date, address.Text };

                    SqlDataReader reader = database.select("admin",new string[] { "username"},new string[] { },new object[] { });

                    while (reader.Read()) {
                        string userName = reader.GetString(0);

                        adminList.Add(userName);
                    }

                    database.closeConnection();

                    if (adminList.Exists(a => a == userName.Text))
                    {
                        MessageBox.Show("Username is taken!");
                    }
                    else {

                        bool insert = database.insert("admin", columns, vals);

                        if (insert)
                        {
                            MessageBox.Show("New user is successfully added!");
                            clearFields();
                        }
                        else
                        {
                            MessageBox.Show("Some error occured!");
                        }
                    }


                }
                else {
                    MessageBox.Show("Passwords dont match!");
                }
            }
            else {
                MessageBox.Show("Empty fields not allowed!");
            }
        }

        private void clearFields() {
            firstName.Clear();
            lastName.Clear();
            userName.Clear();
            password.Clear();
            passConfirm.Clear();
            address.Clear();
            birthday.Value = DateTime.Now.Date; 
        }
    }
}
