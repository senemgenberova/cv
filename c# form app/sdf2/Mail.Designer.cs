namespace sdf2
{
    partial class Mail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mail));
            this.subject = new System.Windows.Forms.TextBox();
            this.mailTo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.RichTextBox();
            this.sendMail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subject
            // 
            this.subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.subject.Location = new System.Drawing.Point(120, 79);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(222, 23);
            this.subject.TabIndex = 35;
            // 
            // mailTo
            // 
            this.mailTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.mailTo.Location = new System.Drawing.Point(120, 37);
            this.mailTo.Name = "mailTo";
            this.mailTo.Size = new System.Drawing.Size(222, 23);
            this.mailTo.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "Message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "Subject";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Mail To";
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(120, 122);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(222, 109);
            this.message.TabIndex = 37;
            this.message.Text = "";
            // 
            // sendMail
            // 
            this.sendMail.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.sendMail.FlatAppearance.BorderSize = 0;
            this.sendMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.sendMail.ForeColor = System.Drawing.Color.White;
            this.sendMail.Location = new System.Drawing.Point(120, 254);
            this.sendMail.Name = "sendMail";
            this.sendMail.Size = new System.Drawing.Size(222, 42);
            this.sendMail.TabIndex = 38;
            this.sendMail.Text = "Send mail";
            this.sendMail.UseVisualStyleBackColor = false;
            this.sendMail.Click += new System.EventHandler(this.sendMail_Click);
            // 
            // Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(461, 355);
            this.Controls.Add(this.sendMail);
            this.Controls.Add(this.message);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.mailTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Mail";
            this.Text = "Mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox subject;
        private System.Windows.Forms.TextBox mailTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox message;
        private System.Windows.Forms.Button sendMail;
    }
}