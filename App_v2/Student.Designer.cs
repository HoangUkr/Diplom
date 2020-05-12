namespace App_v2
{
    partial class Student
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
            this.подачаДокументівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.документиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проАвторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.upload_image = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.faculty = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.подачаДокументівToolStripMenuItem,
            this.документиToolStripMenuItem,
            this.проАвторToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(658, 28);
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
            // подачаДокументівToolStripMenuItem
            // 
            this.подачаДокументівToolStripMenuItem.Name = "подачаДокументівToolStripMenuItem";
            this.подачаДокументівToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.подачаДокументівToolStripMenuItem.Text = "Подача документів";
            this.подачаДокументівToolStripMenuItem.Click += new System.EventHandler(this.подачаДокументівToolStripMenuItem_Click);
            // 
            // документиToolStripMenuItem
            // 
            this.документиToolStripMenuItem.Name = "документиToolStripMenuItem";
            this.документиToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.документиToolStripMenuItem.Text = "Документи";
            this.документиToolStripMenuItem.Click += new System.EventHandler(this.документиToolStripMenuItem_Click);
            // 
            // проАвторToolStripMenuItem
            // 
            this.проАвторToolStripMenuItem.Name = "проАвторToolStripMenuItem";
            this.проАвторToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.проАвторToolStripMenuItem.Text = "Про автор";
            this.проАвторToolStripMenuItem.Click += new System.EventHandler(this.проАвторToolStripMenuItem_Click);
            // 
            // avatar
            // 
            this.avatar.Location = new System.Drawing.Point(12, 40);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(194, 219);
            this.avatar.TabIndex = 1;
            this.avatar.TabStop = false;
            // 
            // upload_image
            // 
            this.upload_image.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.upload_image.Location = new System.Drawing.Point(41, 274);
            this.upload_image.Name = "upload_image";
            this.upload_image.Size = new System.Drawing.Size(122, 40);
            this.upload_image.TabIndex = 2;
            this.upload_image.Text = "Змінити аватар";
            this.upload_image.UseVisualStyleBackColor = true;
            this.upload_image.Click += new System.EventHandler(this.upload_image_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Студент:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(254, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Факультет:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(354, 40);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(16, 21);
            this.name.TabIndex = 5;
            this.name.Text = "-";
            // 
            // faculty
            // 
            this.faculty.AutoSize = true;
            this.faculty.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.faculty.Location = new System.Drawing.Point(354, 90);
            this.faculty.Name = "faculty";
            this.faculty.Size = new System.Drawing.Size(16, 21);
            this.faculty.TabIndex = 6;
            this.faculty.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(254, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Логін:";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(354, 139);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(16, 21);
            this.login.TabIndex = 8;
            this.login.Text = "-";
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.year.Location = new System.Drawing.Point(354, 184);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(16, 21);
            this.year.TabIndex = 10;
            this.year.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(254, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Курс:";
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 324);
            this.Controls.Add(this.year);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.faculty);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.upload_image);
            this.Controls.Add(this.avatar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Student";
            this.Text = "Student";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Student_FormClosed);
            this.Load += new System.EventHandler(this.Student_Load);
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
        private System.Windows.Forms.ToolStripMenuItem подачаДокументівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem документиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проАвторToolStripMenuItem;
        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.Button upload_image;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label faculty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Label label5;
    }
}