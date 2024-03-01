namespace Childrens_Creativity_Center
{
    partial class Lesson
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_ToEnd = new System.Windows.Forms.Button();
            this.button_Next = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            this.button_ToBegin = new System.Windows.Forms.Button();
            this.comboBox_Circle = new System.Windows.Forms.ComboBox();
            this.textBox_Theme = new System.Windows.Forms.TextBox();
            this.textBox_Number = new System.Windows.Forms.TextBox();
            this.dateTimePicker_DateTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Controls.Add(this.button_Close);
            this.tabPage1.Controls.Add(this.button_Delete);
            this.tabPage1.Controls.Add(this.button_Save);
            this.tabPage1.Controls.Add(this.button_ToEnd);
            this.tabPage1.Controls.Add(this.button_Next);
            this.tabPage1.Controls.Add(this.button_Back);
            this.tabPage1.Controls.Add(this.button_ToBegin);
            this.tabPage1.Controls.Add(this.comboBox_Circle);
            this.tabPage1.Controls.Add(this.textBox_Theme);
            this.tabPage1.Controls.Add(this.textBox_Number);
            this.tabPage1.Controls.Add(this.dateTimePicker_DateTime);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1101, 594);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Занятия";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // button_Close
            // 
            this.button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button_Close.Location = new System.Drawing.Point(924, 6);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(170, 31);
            this.button_Close.TabIndex = 53;
            this.button_Close.Text = "Закрыть";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button_Delete.Location = new System.Drawing.Point(262, 212);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(246, 30);
            this.button_Delete.TabIndex = 52;
            this.button_Delete.Text = "Удалить данные";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Save
            // 
            this.button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button_Save.Location = new System.Drawing.Point(10, 212);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(246, 30);
            this.button_Save.TabIndex = 51;
            this.button_Save.Text = "Сохранить данные";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_ToEnd
            // 
            this.button_ToEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button_ToEnd.Location = new System.Drawing.Point(388, 176);
            this.button_ToEnd.Name = "button_ToEnd";
            this.button_ToEnd.Size = new System.Drawing.Size(120, 30);
            this.button_ToEnd.TabIndex = 50;
            this.button_ToEnd.Text = "В конец";
            this.button_ToEnd.UseVisualStyleBackColor = true;
            this.button_ToEnd.Click += new System.EventHandler(this.button_ToEnd_Click);
            // 
            // button_Next
            // 
            this.button_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button_Next.Location = new System.Drawing.Point(262, 176);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(120, 30);
            this.button_Next.TabIndex = 49;
            this.button_Next.Text = "Вперед";
            this.button_Next.UseVisualStyleBackColor = true;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // button_Back
            // 
            this.button_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button_Back.Location = new System.Drawing.Point(136, 176);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(120, 30);
            this.button_Back.TabIndex = 48;
            this.button_Back.Text = "Назад";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // button_ToBegin
            // 
            this.button_ToBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button_ToBegin.Location = new System.Drawing.Point(10, 176);
            this.button_ToBegin.Name = "button_ToBegin";
            this.button_ToBegin.Size = new System.Drawing.Size(120, 30);
            this.button_ToBegin.TabIndex = 47;
            this.button_ToBegin.Text = "В начало";
            this.button_ToBegin.UseVisualStyleBackColor = true;
            this.button_ToBegin.Click += new System.EventHandler(this.button_ToBegin_Click);
            // 
            // comboBox_Circle
            // 
            this.comboBox_Circle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Circle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.comboBox_Circle.FormattingEnabled = true;
            this.comboBox_Circle.Location = new System.Drawing.Point(138, 81);
            this.comboBox_Circle.Name = "comboBox_Circle";
            this.comboBox_Circle.Size = new System.Drawing.Size(372, 28);
            this.comboBox_Circle.TabIndex = 46;
            this.toolTip1.SetToolTip(this.comboBox_Circle, "Выберите из списка");
            // 
            // textBox_Theme
            // 
            this.textBox_Theme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBox_Theme.Location = new System.Drawing.Point(138, 45);
            this.textBox_Theme.Name = "textBox_Theme";
            this.textBox_Theme.Size = new System.Drawing.Size(552, 26);
            this.textBox_Theme.TabIndex = 45;
            // 
            // textBox_Number
            // 
            this.textBox_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBox_Number.Location = new System.Drawing.Point(138, 9);
            this.textBox_Number.Name = "textBox_Number";
            this.textBox_Number.Size = new System.Drawing.Size(118, 26);
            this.textBox_Number.TabIndex = 44;
            // 
            // dateTimePicker_DateTime
            // 
            this.dateTimePicker_DateTime.CustomFormat = "MM.dd.yyyy HH:mm";
            this.dateTimePicker_DateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.dateTimePicker_DateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_DateTime.Location = new System.Drawing.Point(138, 119);
            this.dateTimePicker_DateTime.Name = "dateTimePicker_DateTime";
            this.dateTimePicker_DateTime.Size = new System.Drawing.Size(372, 26);
            this.dateTimePicker_DateTime.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(6, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Кружок:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(6, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 40);
            this.label3.TabIndex = 41;
            this.label3.Text = "Дата и время\r\nпроведения:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Тема:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Номер:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(3, 569);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1095, 22);
            this.statusStrip1.TabIndex = 54;
            this.statusStrip1.Text = "Оформление нового занятия начинайте с ввода кода";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(300, 17);
            this.toolStripStatusLabel1.Text = "Оформление нового занятия начинайте с ввода кода";
            // 
            // Lesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 625);
            this.Controls.Add(this.tabControl1);
            this.Name = "Lesson";
            this.Text = "Центр детского творчества - Преподаватель";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_ToEnd;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button button_ToBegin;
        private System.Windows.Forms.ComboBox comboBox_Circle;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox_Theme;
        private System.Windows.Forms.TextBox textBox_Number;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DateTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Close;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}