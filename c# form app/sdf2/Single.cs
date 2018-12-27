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
    public partial class Single : Form
    {
        private DB dB = new DB();
        Image img;

        private Product product ;
        string tableName = "product", fileName, directory = @"C:\Users\User\source\repos\sdf2\sdf2\Upload";
        private string[] types = { "Electronic", "Makeup", "Food", "Vehicle", "Clothes" };

        public Single(Product product)
        {
            this.product = product;

            InitializeComponent();

            foreach (string type in types)
            {
                prType.Items.Add(type);
            }

            if (product != null)
            {
                prID.Text = product.id.ToString();
                prName.Text = product.pr_name;
                prType.Text = product.pr_type;
                prCount.Value = product.pr_number;
                prPrice.Value = product.pr_price;
                pictureBox1.Image = Image.FromFile(Path.Combine(directory, product.pr_picture));

            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();
        }

        OpenFileDialog dialog = new OpenFileDialog();

        private void selectImg_Click(object sender, EventArgs e)
        {
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png; ";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                img = Image.FromFile(dialog.FileName);
                pictureBox1.Image = img;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(prName.Text))
            {

                if (Directory.Exists(directory))
                {
                    if (!String.IsNullOrWhiteSpace(dialog.FileName))
                    {
                        fileName = DateTime.Now.ToString("yyyy-mm-dd") + '_' + Path.GetFileName(dialog.FileName);

                        img.Save(Path.Combine(directory, fileName));
                    }
                    else
                    {
                        fileName = product.pr_picture;
                    }
                }

                string[] columns = { "product_name", "product_type", "product_number", "product_price", "product_picture" };
                object[] values = { prName.Text, prType.SelectedItem.ToString(), prCount.Value, prPrice.Value, fileName };

                bool result = dB.update(tableName, columns, values, new string[] { "id" }, new object[] { product.id });

                if (result)
                {
                    MessageBox.Show("Product is successfully updated!");

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(prID.Text))
            {
                bool result = dB.delete(tableName, new string[] { "id" }, new string[] { prID.Text });

                if (result)
                {
                    MessageBox.Show("Product deleted!");

                }
                else
                {
                    MessageBox.Show("Some error occured");
                }
            }
        }

        private void prType_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(prType.Text))
            {
                prType.Text = product.pr_type;
            }
        }
    }
}
