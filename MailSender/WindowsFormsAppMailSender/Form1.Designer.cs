namespace WindowsFormsAppMailSender
{
    partial class MailSender
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
            this.lblRecipient = new System.Windows.Forms.Label();
            this.lblMessageTitle = new System.Windows.Forms.Label();
            this.lblMessageBody = new System.Windows.Forms.Label();
            this.inptRecipient = new System.Windows.Forms.TextBox();
            this.inptMessageTitle = new System.Windows.Forms.TextBox();
            this.inptMessageBody = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRecipient
            // 
            this.lblRecipient.AutoSize = true;
            this.lblRecipient.Location = new System.Drawing.Point(25, 30);
            this.lblRecipient.Name = "lblRecipient";
            this.lblRecipient.Size = new System.Drawing.Size(49, 13);
            this.lblRecipient.TabIndex = 0;
            this.lblRecipient.Text = "Primatelj:";
            // 
            // lblMessageTitle
            // 
            this.lblMessageTitle.AutoSize = true;
            this.lblMessageTitle.Location = new System.Drawing.Point(25, 55);
            this.lblMessageTitle.Name = "lblMessageTitle";
            this.lblMessageTitle.Size = new System.Drawing.Size(79, 13);
            this.lblMessageTitle.TabIndex = 1;
            this.lblMessageTitle.Text = "Naslov poruke:";
            // 
            // lblMessageBody
            // 
            this.lblMessageBody.AutoSize = true;
            this.lblMessageBody.Location = new System.Drawing.Point(25, 81);
            this.lblMessageBody.Name = "lblMessageBody";
            this.lblMessageBody.Size = new System.Drawing.Size(71, 13);
            this.lblMessageBody.TabIndex = 2;
            this.lblMessageBody.Text = "Tijelo poruke:";
            // 
            // inptRecipient
            // 
            this.inptRecipient.Location = new System.Drawing.Point(80, 27);
            this.inptRecipient.Name = "inptRecipient";
            this.inptRecipient.Size = new System.Drawing.Size(171, 20);
            this.inptRecipient.TabIndex = 3;
            this.inptRecipient.TextChanged += new System.EventHandler(this.inptRecipient_TextChanged);
            // 
            // inptMessageTitle
            // 
            this.inptMessageTitle.Location = new System.Drawing.Point(110, 48);
            this.inptMessageTitle.Name = "inptMessageTitle";
            this.inptMessageTitle.Size = new System.Drawing.Size(186, 20);
            this.inptMessageTitle.TabIndex = 4;
            this.inptMessageTitle.TextChanged += new System.EventHandler(this.inptMessageTitle_TextChanged);
            // 
            // inptMessageBody
            // 
            this.inptMessageBody.Location = new System.Drawing.Point(102, 74);
            this.inptMessageBody.Name = "inptMessageBody";
            this.inptMessageBody.Size = new System.Drawing.Size(280, 20);
            this.inptMessageBody.TabIndex = 5;
            this.inptMessageBody.TextChanged += new System.EventHandler(this.inptMessageBody_TextChanged);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(307, 130);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Pošalji";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // MailSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 192);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.inptMessageBody);
            this.Controls.Add(this.inptMessageTitle);
            this.Controls.Add(this.inptRecipient);
            this.Controls.Add(this.lblMessageBody);
            this.Controls.Add(this.lblMessageTitle);
            this.Controls.Add(this.lblRecipient);
            this.Name = "MailSender";
            this.Text = "Mail Sender v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecipient;
        private System.Windows.Forms.Label lblMessageTitle;
        private System.Windows.Forms.Label lblMessageBody;
        private System.Windows.Forms.TextBox inptRecipient;
        private System.Windows.Forms.TextBox inptMessageTitle;
        private System.Windows.Forms.TextBox inptMessageBody;
        private System.Windows.Forms.Button btnSend;
    }
}

