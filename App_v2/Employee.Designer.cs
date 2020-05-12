namespace App_v2
{
    partial class Employee
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.аккаунтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.програмОбмінуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.учасникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рейтингToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.документиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проАвтораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.login = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.upload_image = new System.Windows.Forms.Button();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.аккаунтToolStripMenuItem,
            this.програмОбмінуToolStripMenuItem,
            this.учасникиToolStripMenuItem,
            this.документиToolStripMenuItem,
            this.проАвтораToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(546, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // аккаунтToolStripMenuItem
            // 
            this.аккаунтToolStripMenuItem.Name = "аккаунтToolStripMenuItem";
            this.аккаунтToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.аккаунтToolStripMenuItem.Text = "Аккаунт";
            // 
            // програмОбмінуToolStripMenuItem
            // 
            this.програмОбмінуToolStripMenuItem.Name = "програмОбмінуToolStripMenuItem";
            this.програмОбмінуToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.програмОбмінуToolStripMenuItem.Text = "Програм обміну";
            this.програмОбмінуToolStripMenuItem.Click += new System.EventHandler(this.програмОбмінуToolStripMenuItem_Click);
            // 
            // учасникиToolStripMenuItem
            // 
            this.учасникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рейтингToolStripMenuItem});
            this.учасникиToolStripMenuItem.Name = "учасникиToolStripMenuItem";
            this.учасникиToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.учасникиToolStripMenuItem.Text = "Учасники";
            // 
            // рейтингToolStripMenuItem
            // 
            this.рейтингToolStripMenuItem.Name = "рейтингToolStripMenuItem";
            this.рейтингToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.рейтингToolStripMenuItem.Text = "Рейтинг";
            // 
            // документиToolStripMenuItem
            // 
            this.документиToolStripMenuItem.Name = "документиToolStripMenuItem";
            this.документиToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.документиToolStripMenuItem.Text = "Документи";
            // 
            // проАвтораToolStripMenuItem
            // 
            this.проАвтораToolStripMenuItem.Name = "проАвтораToolStripMenuItem";
            this.проАвтораToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.проАвтораToolStripMenuItem.Text = "Про автора";
            this.проАвтораToolStripMenuItem.Click += new System.EventHandler(this.проАвтораToolStripMenuItem_Click);
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(354, 85);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(16, 21);
            this.login.TabIndex = 16;
            this.login.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(254, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Логін:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(354, 40);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(16, 21);
            this.name.TabIndex = 13;
            this.name.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "ПІБ:";
            // 
            // upload_image
            // 
            this.upload_image.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.upload_image.Location = new System.Drawing.Point(41, 274);
            this.upload_image.Name = "upload_image";
            this.upload_image.Size = new System.Drawing.Size(122, 40);
            this.upload_image.TabIndex = 10;
            this.upload_image.Text = "Змінити аватар";
            this.upload_image.UseVisualStyleBackColor = true;
            this.upload_image.Click += new System.EventHandler(this.upload_image_Click);
            // 
            // avatar
            // 
            this.avatar.Location = new System.Drawing.Point(12, 40);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(194, 219);
            this.avatar.TabIndex = 9;
            this.avatar.TabStop = false;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 332);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.upload_image);
            this.Controls.Add(this.avatar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Employee";
            this.Text = "Employee";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Employee_FormClosed);
            this.Load += new System.EventHandler(this.Employee_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem аккаунтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem програмОбмінуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem учасникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рейтингToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem документиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проАвтораToolStripMenuItem;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button upload_image;
        private System.Windows.Forms.PictureBox avatar;
    }
}