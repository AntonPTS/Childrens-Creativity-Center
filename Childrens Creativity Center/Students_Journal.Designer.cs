namespace Childrens_Creativity_Center
{
    partial class Students_Journal
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Print = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1109, 620);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_Clear);
            this.tabPage1.Controls.Add(this.button_Delete);
            this.tabPage1.Controls.Add(this.button_Print);
            this.tabPage1.Controls.Add(this.button_Close);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1101, 594);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Журнал учащихся";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // button_Clear
            // 
            this.button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button_Clear.Location = new System.Drawing.Point(851, 117);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(243, 31);
            this.button_Clear.TabIndex = 17;
            this.button_Clear.Text = "Очистить";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button_Delete.Location = new System.Drawing.Point(851, 80);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(243, 31);
            this.button_Delete.TabIndex = 16;
            this.button_Delete.Text = "Удалить";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Print
            // 
            this.button_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button_Print.Location = new System.Drawing.Point(851, 43);
            this.button_Print.Name = "button_Print";
            this.button_Print.Size = new System.Drawing.Size(243, 31);
            this.button_Print.TabIndex = 15;
            this.button_Print.Text = "Распечатать";
            this.button_Print.UseVisualStyleBackColor = true;
            this.button_Print.Click += new System.EventHandler(this.button_Print_Click);
            // 
            // button_Close
            // 
            this.button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button_Close.Location = new System.Drawing.Point(851, 6);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(243, 31);
            this.button_Close.TabIndex = 14;
            this.button_Close.Text = "Закрыть";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(839, 582);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.BindingContextChanged += new System.EventHandler(this.dataGridView1_BindingContextChanged);
            // 
            // Students_Journal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 625);
            this.Controls.Add(this.tabControl1);
            this.Name = "Students_Journal";
            this.Text = "Центр детского творчества - Преподаватель";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Print;
        private System.Windows.Forms.Button button_Close;
        public System.Windows.Forms.TabControl tabControl1;
    }
}