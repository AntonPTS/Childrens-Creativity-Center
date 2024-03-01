using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Childrens_Creativity_Center
{
    public partial class RecordContent : Form
    {
        public RecordContent()
        {
            InitializeComponent();
        }

        public static string n = null;
        public int ind;

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            comboBox_Circle.DataSource = Main_Menu.ds.Tables["Кружки"].DefaultView;
            comboBox_Circle.DisplayMember = "Название";

            int i = 0;
            while (Main_Menu.ds.Tables["Журнал учащихся"].Rows[i]["Номер"].ToString() != n) i++;

            textBox_Number.Text = Main_Menu.ds.Tables["Журнал учащихся"].Rows[i]["Номер"].ToString();
            textBox_Theme.Text = Main_Menu.ds.Tables["Журнал учащихся"].Rows[i]["Тема"].ToString();
            comboBox_Circle.Text = Main_Menu.ds.Tables["Журнал учащихся"].Rows[i]["Кружок"].ToString();
            dateTimePicker_DateTime.Value = Convert.ToDateTime(Main_Menu.ds.Tables["Журнал учащихся"].Rows[i]["Дата и время"]);

            updateDataGridView();

            dataGridView1.DataSource = Main_Menu.ds.Tables["Студенты записи"].DefaultView;
            dataGridView1.Columns["Номер учащегося"].Visible = false;
            dataGridView1.Columns["Номер занятия"].Visible = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;

            this.AcceptButton = button_Close;
        }

        private void updateDataGridView()
        {
            string sql = "SELECT ROW_NUMBER() OVER (ORDER BY student_journal.student_id) AS \"Номер\", student_journal.student_id AS \"Номер учащегося\", " +
                "student_journal.lesson_id AS \"Номер занятия\", surname AS \"Фамилия\", name AS \"Имя\", patronymic AS \"Отчество\", phone_number AS \"Номер телефона\", " +
                "visit AS \"Посещение\" FROM student_journal LEFT JOIN student ON student_journal.student_id=student.student_id WHERE lesson_id=" + textBox_Number.Text;
            Main_Menu.Table_Fill("Студенты записи", sql);
        }

        private void dataGridView1_BindingContextChanged(object sender, EventArgs e)
        {
            dataGridView1.AutoResizeColumns();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Main_Menu.tabControl.Controls.Remove(Main_Menu.tabControl.SelectedTab);
            Main_Menu.tabControl.SelectedIndex = Main_Menu.tabControl.TabCount - 1;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                ind = dataGridView1.SelectedRows[0].Index;
                string student_surname = dataGridView1.Rows[ind].Cells[3].Value.ToString();
                string student_name = dataGridView1.Rows[ind].Cells[4].Value.ToString();
                string student_patronymic = dataGridView1.Rows[ind].Cells[5].Value.ToString();
                checkBox_Visit.Text = "Посещение учащимся\n" + student_surname + " " + student_name[0] + "." + student_patronymic[0] + ". занятия";
                if (dataGridView1.Rows[ind].Cells[7].Value.ToString() == "True")
                    checkBox_Visit.Checked = true;
                else
                    checkBox_Visit.Checked = false;
            }
        }

        private void checkBox_Visit_CheckedChanged(object sender, EventArgs e)
        {
            bool visit;
            if (checkBox_Visit.Checked == true)
                visit = true;
            else
                visit = false;

            string sql = "UPDATE student_journal SET visit=" + visit + " WHERE lesson_id=" + dataGridView1.Rows[ind].Cells[2].Value.ToString() + " AND student_id=" +
                dataGridView1.Rows[ind].Cells[1].Value.ToString();
            Main_Menu.Modification_Execute(sql);
            updateDataGridView();
        }
    }
}
