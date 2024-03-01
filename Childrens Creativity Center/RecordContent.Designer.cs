namespace Childrens_Creativity_Center
{
    partial class RecordContent
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
            this.checkBox_Visit = new System.Windows.Forms.CheckBox();
            this.dateTimePicker_DateTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Circle = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Theme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBox_Visit);
            this.tabPage1.Controls.Add(this.dateTimePicker_DateTime);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.comboBox_Circle);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBox_Theme);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox_Number);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button_Close);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1101, 594);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Запись занятия";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // checkBox_Visit
            // 
            this.checkBox_Visit.AutoSize = true;
            this.checkBox_Visit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.checkBox_Visit.Location = new System.Drawing.Point(867, 101);
            this.checkBox_Visit.Name = "checkBox_Visit";
            this.checkBox_Visit.Size = new System.Drawing.Size(212, 24);
            this.checkBox_Visit.TabIndex = 53;
            this.checkBox_Visit.Text = "Посещение учащимся";
            this.checkBox_Visit.UseVisualStyleBackColor = true;
            this.checkBox_Visit.CheckedChanged += new System.EventHandler(this.checkBox_Visit_CheckedChanged);
            // 
            // dateTimePicker_DateTime
            // 
            this.dateTimePicker_DateTime.CustomFormat = "MM.dd.yyyy HH:mm";
            this.dateTimePicker_DateTime.Enabled = false;
            this.dateTimePicker_DateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.dateTimePicker_DateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_DateTime.Location = new System.Drawing.Point(609, 49);
            this.dateTimePicker_DateTime.Name = "dateTimePicker_DateTime";
            this.dateTimePicker_DateTime.Size = new System.Drawing.Size(236, 26);
            this.dateTimePicker_DateTime.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(477, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 40);
            this.label3.TabIndex = 51;
            this.label3.Text = "Дата и время\r\nпроведения:";
            // 
            // comboBox_Circle
            // 
            this.comboBox_Circle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Circle.Enabled = false;
            this.comboBox_Circle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.comboBox_Circle.FormattingEnabled = true;
            this.comboBox_Circle.Location = new System.Drawing.Point(86, 51);
            this.comboBox_Circle.Name = "comboBox_Circle";
            this.comboBox_Circle.Size = new System.Drawing.Size(372, 28);
            this.comboBox_Circle.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "Кружок:";
            // 
            // textBox_Theme
            // 
            this.textBox_Theme.Enabled = false;
            this.textBox_Theme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBox_Theme.Location = new System.Drawing.Point(293, 14);
            this.textBox_Theme.Name = "textBox_Theme";
            this.textBox_Theme.ReadOnly = true;
            this.textBox_Theme.Size = new System.Drawing.Size(552, 26);
            this.textBox_Theme.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(218, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Тема:";
            // 
            // textBox_Number
            // 
            this.textBox_Number.Enabled = false;
            this.textBox_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBox_Number.Location = new System.Drawing.Point(81, 14);
            this.textBox_Number.Name = "textBox_Number";
            this.textBox_Number.ReadOnly = true;
            this.textBox_Number.Size = new System.Drawing.Size(118, 26);
            this.textBox_Number.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Номер:";
            // 
            // button_Close
            // 
            this.button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button_Close.Location = new System.Drawing.Point(851, 12);
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
            this.dataGridView1.Location = new System.Drawing.Point(10, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(835, 487);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            this.dataGridView1.BindingContextChanged += new System.EventHandler(this.dataGridView1_BindingContextChanged);
            // 
            // RecordContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 625);
            this.Controls.Add(this.tabControl1);
            this.Name = "RecordContent";
            this.Text = "Центр детского творчества - Преподаватель";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_Number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Theme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Circle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DateTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_Visit;
    }
}