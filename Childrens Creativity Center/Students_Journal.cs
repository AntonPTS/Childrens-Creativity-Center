using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Childrens_Creativity_Center
{
    public partial class Students_Journal : Form
    {
        public Students_Journal()
        {
            InitializeComponent();
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            string sql = "SELECT student_journal.lesson_id AS \"Номер\", lesson.lesson_theme AS \"Тема\", lesson.lesson_datetime\"Дата и время\", " +
                "circle.circle_name\"Кружок\", COUNT(student_journal.student_id) AS \"Кол-во учащихся\", COUNT(CASE WHEN student_journal.visit = TRUE THEN 1 END) " +
                "AS \"Кол-во присутствовавших\" FROM student_journal JOIN lesson ON student_journal.lesson_id = lesson.lesson_id JOIN circle ON lesson.circle_id = " +
                "circle.circle_id GROUP BY student_journal.lesson_id, lesson.lesson_theme, lesson.lesson_datetime, circle.circle_name ORDER BY student_journal.lesson_id";
            Main_Menu.Table_Fill("Журнал учащихся", sql);

            dataGridView1.DataSource = Main_Menu.ds.Tables["Журнал учащихся"];
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoResizeColumns();
            dataGridView1.CurrentCell = null;
        }

        private void dataGridView1_BindingContextChanged(object sender, EventArgs e)
        {
            dataGridView1.AutoResizeColumns();
            dataGridView1.CurrentCell = null;
        }

        private void button_Print_Click(object sender, EventArgs e)
        {
            Excel.Application Excel_ = new Excel.Application();
            Excel_.Visible = true;
            Excel.Workbook WorkBook_ = Excel_.Workbooks.Add();
            Excel.Worksheet Sheet_ = (Excel.Worksheet)WorkBook_.Sheets[1];
            Sheet_.Columns.AutoFit();

            Sheet_.Cells[1, 1].Value = "Журнал учащихся";
            Sheet_.Range[Sheet_.Cells[1, 1], Sheet_.Cells[1, 6]].Merge();
            Sheet_.Cells[1, 1].HorizontalAlignment = 3;

            Sheet_.Cells[2, 1].Value = dataGridView1.Columns["Номер"].HeaderText;
            Sheet_.Cells[2, 2].Value = dataGridView1.Columns["Тема"].HeaderText;
            Sheet_.Cells[2, 3].Value = dataGridView1.Columns["Дата и время"].HeaderText;
            Sheet_.Cells[2, 4].Value = dataGridView1.Columns["Кружок"].HeaderText;
            Sheet_.Cells[2, 5].Value = dataGridView1.Columns["Кол-во учащихся"].HeaderText;
            Sheet_.Cells[2, 6].Value = dataGridView1.Columns["Кол-во присутствовавших"].HeaderText;

            Sheet_.Range[Sheet_.Cells[2, 1], Sheet_.Cells[2, 6]].HorizontalAlignment = 3;

            int n = 3;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                Sheet_.Cells[n, 1].Value = dataGridView1.Rows[i].Cells["Номер"].Value;
                Sheet_.Cells[n, 2].Value = dataGridView1.Rows[i].Cells["Тема"].Value;
                Sheet_.Cells[n, 3].Value = dataGridView1.Rows[i].Cells["Дата и время"].Value;
                Sheet_.Cells[n, 4].Value = dataGridView1.Rows[i].Cells["Кружок"].Value;
                Sheet_.Cells[n, 5].Value = dataGridView1.Rows[i].Cells["Кол-во учащихся"].Value;
                Sheet_.Cells[n, 6].Value = dataGridView1.Rows[i].Cells["Кол-во присутствовавших"].Value;
                n++;
            }
            Sheet_.Range[Sheet_.Cells[3, 5], Sheet_.Cells[3 + dataGridView1.RowCount, 6]].HorizontalAlignment = 3;

            Sheet_.Range[Sheet_.Cells[2, 1], Sheet_.Cells[2 + dataGridView1.RowCount, 6]].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

            Sheet_.Rows.AutoFit();
            Sheet_.Columns.AutoFit();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            string num;
            try
            {
                num = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Номер"].Value.ToString();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Не указан удаляемый экземпляр!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            string message = "Вы точно хотите удалить занятие № " + num + "?";
            string caption = "Удаление записи";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult dialogResult = MessageBox.Show(message, caption, buttons, icon);
            if (dialogResult == DialogResult.No) { return; }

            string sql = "DELETE FROM student_journal WHERE lesson_id=" + num;
            Main_Menu.Modification_Execute(sql);
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            string message = "Вы точно хотите очистить журнал учащихся?";
            string caption = "Очистка журнала";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult dialogResult = MessageBox.Show(message, caption, buttons, icon);
            if (dialogResult == DialogResult.No) { return; }

            string sql = "DELETE FROM student_journal";
            Main_Menu.Modification_Execute(sql);
            Main_Menu.ds.Tables["Журнал учащихся"].Clear();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RecordContent.n = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Номер"].Value.ToString();
            RecordContent recordContent = new RecordContent();

            if (Main_Menu.tabControl.TabCount > 2)
                Main_Menu.tabControl.TabPages.RemoveAt(Main_Menu.tabControl.TabCount - 1);
            Main_Menu.tabControl.Controls.Add(recordContent.tabControl1.TabPages[0]);
            Main_Menu.tabControl.SelectedIndex = Main_Menu.tabControl.TabCount - 1;
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Main_Menu.tabControl.Controls.Remove(Main_Menu.tabControl.SelectedTab);
        }
    }
}
