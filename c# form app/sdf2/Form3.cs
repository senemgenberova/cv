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
using System.IO;

namespace sdf2
{
    public partial class Form3 : Form
    {

        string tableName = "product";

        private DB dB = new DB();
        Product product;

        public Form3()
        {
            InitializeComponent();

            greeting.Text = "Welcome, " + Form1.username;

        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            this.Hide();
            form.Show();
        }

        private void sendMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mail mail = new Mail();
            this.Hide();
            mail.Show();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            SqlDataReader reader = dB.select(tableName, new string[] { "*" }, new string[] { "id" }, new object[] { dataGridView1.CurrentRow.Cells[0].Value });

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                string type = reader.GetString(2);
                int count = reader.GetInt32(3);
                int price = reader.GetInt32(4);
                string img = reader.GetString(5);

                if (id != -1)
                {
                    product = new Product(id, name, type, img, count, price);
                }
            }

            dB.closeConnection();
        }

        private void showProduct_Click(object sender, EventArgs e)
        {
            Single single = new Single(product);
            this.Hide();
            single.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.productTableAdapter.Fill(this.marketDataSet1.Product);
        }
    }
}
