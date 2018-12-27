namespace sdf2
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.pr_price = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.selectImage = new System.Windows.Forms.Button();
            this.pr_count = new System.Windows.Forms.NumericUpDown();
            this.pr_type = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addProduct = new System.Windows.Forms.Button();
            this.pr_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pr_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pr_count)).BeginInit();
            this.SuspendLayout();
            // 
            // pr_price
            // 
            this.pr_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.pr_price.Location = new System.Drawing.Point(108, 197);
            this.pr_price.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.pr_price.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pr_price.Name = "pr_price";
            this.pr_price.Size = new System.Drawing.Size(187, 23);
            this.pr_price.TabIndex = 14;
            this.pr_price.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(226, 239);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // selectImage
            // 
            this.selectImage.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.selectImage.FlatAppearance.BorderSize = 0;
            this.selectImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.selectImage.ForeColor = System.Drawing.Color.Snow;
            this.selectImage.Location = new System.Drawing.Point(108, 239);
            this.selectImage.Name = "selectImage";
            this.selectImage.Size = new System.Drawing.Size(112, 42);
            this.selectImage.TabIndex = 12;
            this.selectImage.Text = "Select image";
            this.selectImage.UseVisualStyleBackColor = false;
            this.selectImage.Click += new System.EventHandler(this.selectImage_Click);
            // 
            // pr_count
            // 
            this.pr_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.pr_count.Location = new System.Drawing.Point(108, 156);
            this.pr_count.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.pr_count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pr_count.Name = "pr_count";
            this.pr_count.Size = new System.Drawing.Size(187, 23);
            this.pr_count.TabIndex = 10;
            this.pr_count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pr_type
            // 
            this.pr_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.pr_type.FormattingEnabled = true;
            this.pr_type.Location = new System.Drawing.Point(108, 118);
            this.pr_type.Name = "pr_type";
            this.pr_type.Size = new System.Drawing.Size(187, 25);
            this.pr_type.TabIndex = 9;
            this.pr_type.TextChanged += new System.EventHandler(this.pr_type_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(32, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Picture";
            // 
            // addProduct
            // 
            this.addProduct.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.addProduct.FlatAppearance.BorderSize = 0;
            this.addProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.addProduct.ForeColor = System.Drawing.Color.Snow;
            this.addProduct.Location = new System.Drawing.Point(108, 345);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(160, 37);
            this.addProduct.TabIndex = 7;
            this.addProduct.Text = "Add product";
            this.addProduct.UseVisualStyleBackColor = false;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // pr_name
            // 
            this.pr_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.pr_name.Location = new System.Drawing.Point(108, 75);
            this.pr_name.Name = "pr_name";
            this.pr_name.Size = new System.Drawing.Size(187, 23);
            this.pr_name.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(32, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(32, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(32, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(32, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(82, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD PRODUCT";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(7, 364);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(72, 18);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Go back";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(375, 407);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pr_price);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pr_count);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pr_type);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.pr_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form4";
            this.Text = "Add product";
            ((System.ComponentModel.ISupportInitialize)(this.pr_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pr_count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown pr_price;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button selectImage;
        private System.Windows.Forms.NumericUpDown pr_count;
        private System.Windows.Forms.ComboBox pr_type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.TextBox pr_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}