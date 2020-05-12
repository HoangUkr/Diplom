namespace App_v2
{
    partial class Exchange
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
            this.проАвтораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exchange_program = new System.Windows.Forms.DataGridView();
            this.category = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exchange_program)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проАвтораToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(731, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // проАвтораToolStripMenuItem
            // 
            this.проАвтораToolStripMenuItem.Name = "проАвтораToolStripMenuItem";
            this.проАвтораToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.проАвтораToolStripMenuItem.Text = "Про автора";
            this.проАвтораToolStripMenuItem.Click += new System.EventHandler(this.проАвтораToolStripMenuItem_Click);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // exchange_program
            // 
            this.exchange_program.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exchange_program.Location = new System.Drawing.Point(12, 31);
            this.exchange_program.Name = "exchange_program";
            this.exchange_program.RowTemplate.Height = 24;
            this.exchange_program.Size = new System.Drawing.Size(534, 398);
            this.exchange_program.TabIndex = 1;
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Location = new System.Drawing.Point(573, 31);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(123, 21);
            this.category.TabIndex = 2;
            this.category.Text = "Для студентів";
            this.category.UseVisualStyleBackColor = true;
            this.category.CheckedChanged += new System.EventHandler(this.category_CheckedChanged);
            // 
            // Exchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 450);
            this.Controls.Add(this.category);
            this.Controls.Add(this.exchange_program);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Exchange";
            this.Text = "Exchange";
            this.Load += new System.EventHandler(this.Exchange_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exchange_program)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem проАвтораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.DataGridView exchange_program;
        private System.Windows.Forms.CheckBox category;
    }
}