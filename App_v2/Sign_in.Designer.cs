namespace App_v2
{
    partial class Sign_in
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign_in));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.createAccount = new System.Windows.Forms.LinkLabel();
            this.entry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(195, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вхід";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логін";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(31, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.username.Location = new System.Drawing.Point(146, 60);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(195, 28);
            this.username.TabIndex = 3;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(146, 129);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(195, 28);
            this.password.TabIndex = 4;
            // 
            // createAccount
            // 
            this.createAccount.AutoSize = true;
            this.createAccount.Location = new System.Drawing.Point(143, 170);
            this.createAccount.Name = "createAccount";
            this.createAccount.Size = new System.Drawing.Size(138, 17);
            this.createAccount.TabIndex = 6;
            this.createAccount.TabStop = true;
            this.createAccount.Text = "Don\'t have account?";
            this.createAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createAccount_LinkClicked);
            // 
            // entry
            // 
            this.entry.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.entry.Location = new System.Drawing.Point(35, 205);
            this.entry.Name = "entry";
            this.entry.Size = new System.Drawing.Size(128, 45);
            this.entry.TabIndex = 7;
            this.entry.Text = "Увійти";
            this.entry.UseVisualStyleBackColor = true;
            this.entry.Click += new System.EventHandler(this.entry_Click);
            // 
            // Sign_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 273);
            this.Controls.Add(this.entry);
            this.Controls.Add(this.createAccount);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sign_in";
            this.Text = "Вхід";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Sign_in_FormClosed);
            this.Load += new System.EventHandler(this.Sign_in_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.LinkLabel createAccount;
        private System.Windows.Forms.Button entry;
    }
}

