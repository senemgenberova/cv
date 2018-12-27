using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sdf2
{
    public partial class Form4 : Form
    {
        Image pr_image;
        string fileName = "";
        private DB db = new DB();
        private string[] types = { "Electronic", "Makeup", "Food", "Vehicle", "Clothes" };

        public Form4()
        {
            InitializeComponent();

            foreach (string type in types)
            {
                pr_type.Items.Add(type);
            }

            pr_type.SelectedItem = types[0];
        }

        OpenFileDialog dialog = new OpenFileDialog();
        private void selectImage_Click(object sender, EventArgs e)
        {
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png; ";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pr_image = Image.FromFile(dialog.FileName);
                pictureBox1.Image = pr_image;
            }
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(pr_name.Text) && !String.IsNullOrWhiteSpace(dialog.FileName))
            {
                string directory = @"C:\Users\User\source\repos\sdf2\sdf2\Upload";

                if (Directory.Exists(directory))
                {
                    if (!String.IsNullOrWhiteSpace(dialog.FileName))
                    {
                        fileName = DateTime.Now.ToString("yyyy-mm-dd") + '_' + Path.GetFileName(dialog.FileName);

                        pr_image.Save(Path.Combine(directory, fileName));
                    }
                }

                string[] columns = { "product_name", "product_type", "product_number", "product_price", "product_picture" };
                object[] values = { pr_name.Text, pr_type.SelectedItem.ToString(), pr_count.Value, pr_price.Value, fileName };

                bool result = db.insert("product", columns, values);

                if (result)
                {
                    MessageBox.Show("New product is successfully added!");
                    clearFields();

                }
                else
                {
                    MessageBox.Show("Some error occured!");

                }
            }
            else
            {
                MessageBox.Show("Empty fields not allowed!");
            }
        }

        private void pr_type_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(pr_type.Text))
            {
                pr_type.Text = types[0];
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void clearFields() {
            pr_name.Clear();
            pr_type.Text = types[0];
            pr_price.Value = 1;
            pr_count.Value = 1;
            dialog.FileName = "";
            pictureBox1.Image = null;
        }

    }
}
