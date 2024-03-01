namespace Childrens_Creativity_Center
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.объектыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.занятияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кружкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.учащиесяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходныеДокументыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.журналУчащихсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1109, 620);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.menuStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1101, 594);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Работа с базой данных";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(847, 6);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(247, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Здравствуйте, Администратор";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.Location = new System.Drawing.Point(925, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 31);
            this.button1.TabIndex = 18;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.объектыToolStripMenuItem,
            this.выходныеДокументыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1095, 27);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // объектыToolStripMenuItem
            // 
            this.объектыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.занятияToolStripMenuItem,
            this.кружкиToolStripMenuItem,
            this.учащиесяToolStripMenuItem});
            this.объектыToolStripMenuItem.Name = "объектыToolStripMenuItem";
            this.объектыToolStripMenuItem.Size = new System.Drawing.Size(78, 23);
            this.объектыToolStripMenuItem.Text = "Объекты";
            // 
            // занятияToolStripMenuItem
            // 
            this.занятияToolStripMenuItem.Name = "занятияToolStripMenuItem";
            this.занятияToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.занятияToolStripMenuItem.Text = "Занятия";
            this.занятияToolStripMenuItem.Click += new System.EventHandler(this.занятияToolStripMenuItem_Click);
            // 
            // кружкиToolStripMenuItem
            // 
            this.кружкиToolStripMenuItem.Name = "кружкиToolStripMenuItem";
            this.кружкиToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.кружкиToolStripMenuItem.Text = "Кружки";
            this.кружкиToolStripMenuItem.Click += new System.EventHandler(this.кружкиToolStripMenuItem_Click);
            // 
            // учащиесяToolStripMenuItem
            // 
            this.учащиесяToolStripMenuItem.Name = "учащиесяToolStripMenuItem";
            this.учащиесяToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.учащиесяToolStripMenuItem.Text = "Учащиеся";
            this.учащиесяToolStripMenuItem.Click += new System.EventHandler(this.учащиесяToolStripMenuItem_Click);
            // 
            // выходныеДокументыToolStripMenuItem
            // 
            this.выходныеДокументыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.журналУчащихсяToolStripMenuItem});
            this.выходныеДокументыToolStripMenuItem.Name = "выходныеДокументыToolStripMenuItem";
            this.выходныеДокументыToolStripMenuItem.Size = new System.Drawing.Size(161, 23);
            this.выходныеДокументыToolStripMenuItem.Text = "Выходные документы";
            // 
            // журналУчащихсяToolStripMenuItem
            // 
            this.журналУчащихсяToolStripMenuItem.Name = "журналУчащихсяToolStripMenuItem";
            this.журналУчащихсяToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.журналУчащихсяToolStripMenuItem.Text = "Журнал учащихся";
            this.журналУчащихсяToolStripMenuItem.Click += new System.EventHandler(this.журналУчащихсяToolStripMenuItem_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 625);
            this.Controls.Add(this.tabControl1);
            this.Name = "menu";
            this.Text = "Центр детского творчества - Преподаватель";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem объектыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem занятияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кружкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem учащиесяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходныеДокументыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem журналУчащихсяToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TabControl tabControl1;
    }
}