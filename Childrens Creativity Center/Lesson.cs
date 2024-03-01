using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Childrens_Creativity_Center
{
    public partial class Lesson : Form
    {
        public Lesson()
        {
            InitializeComponent();
        }

        public static int n = 0;

        private void FieldsForm_Fill()
        {       
            textBox_Number.Text = Main_Menu.ds.Tables["Занятия"].Rows[n]["Номер"].ToString();
            textBox_Theme.Text = Main_Menu.ds.Tables["Занятия"].Rows[n]["Тема"].ToString();
            comboBox_Circle.Text = Main_Menu.ds.Tables["Занятия"].Rows[n]["Кружок"].ToString();
            dateTimePicker_DateTime.Value = Convert.ToDateTime(Main_Menu.ds.Tables["Занятия"].Rows[n]["Дата и время"].ToString());

            textBox_Number.Enabled = false;
        }

        private void FieldsForm_Clear()
        {
            textBox_Number.Text = "0";
            textBox_Theme.Text = "";
            comboBox_Circle.SelectedIndex = -1;
            dateTimePicker_DateTime.ResetText();

            textBox_Number.Enabled = true; textBox_Number.Focus();
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            comboBox_Circle.DataSource = Main_Menu.ds.Tables["Кружки"].DefaultView;
            comboBox_Circle.DisplayMember = "Название";

            if (Main_Menu.ds.Tables["Занятия"].Rows.Count > n)
            {
                FieldsForm_Fill();
            }
            else
            {
                textBox_Number.Text = "0";
            }
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            if (n < Main_Menu.ds.Tables["Занятия"].Rows.Count) n++;
            if (Main_Menu.ds.Tables["Занятия"].Rows.Count > n)
            {
                FieldsForm_Fill();
            }
            else
            {
                FieldsForm_Clear();
            }
        }

        private void button_ToEnd_Click(object sender, EventArgs e)
        {
            FieldsForm_Clear();
            n = Main_Menu.ds.Tables["Занятия"].Rows.Count;
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            if (n > 0)
            {
                n--; FieldsForm_Fill();
            }
        }

        private void button_ToBegin_Click(object sender, EventArgs e)
        {
            if (Main_Menu.ds.Tables["Занятия"].Rows.Count > 0)
            {
                n = 0; FieldsForm_Fill();
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            string circle_id = Main_Menu.ds.Tables["Кружки"].DefaultView[comboBox_Circle.SelectedIndex]["circle_id"].ToString();

            string sql;
            if (n < Main_Menu.ds.Tables["Занятия"].Rows.Count)
            {
                sql = "UPDATE lesson SET lesson_theme='" + textBox_Theme.Text + "', lesson_datetime='" + dateTimePicker_DateTime.Value +
                    "', circle_id=" + circle_id + " WHERE lesson_id=" + textBox_Number.Text;
                if (!Main_Menu.Modification_Execute(sql))
                    return;

                Main_Menu.ds.Tables["Занятия"].Rows[n].ItemArray = new object[] { textBox_Number.Text, textBox_Theme.Text, comboBox_Circle.Text,
                    dateTimePicker_DateTime.Value };
            }
            else
            {
                sql = "INSERT INTO lesson VALUES(" + textBox_Number.Text + ", '" + textBox_Theme.Text + "', '" +
                    dateTimePicker_DateTime.Value + "', " + circle_id + ")";
                if (!Main_Menu.Modification_Execute(sql))
                    return;
                textBox_Number.Enabled = false;

                Main_Menu.ds.Tables["Занятия"].Rows.Add(new object[] { textBox_Number.Text, textBox_Theme.Text, comboBox_Circle.Text,
                    dateTimePicker_DateTime.Value });
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            string message = "Вы точно хотите удалить из справочника занятие с номером " + textBox_Number.Text + "?";
            string caption = "Удаление занятия";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult dialogResult = MessageBox.Show(message, caption, buttons, icon);

            if (dialogResult == DialogResult.No) { return; }
            Main_Menu.Table_Fill("Журнал учащихся", "SELECT * FROM student_journal");

            for (int i = 0; i < Main_Menu.ds.Tables["Журнал учащихся"].DefaultView.Count; i++)
            {
                if (Main_Menu.ds.Tables["Журнал учащихся"].DefaultView[i]["lesson_id"].ToString() == textBox_Number.Text)
                {
                    MessageBox.Show("Занятие \"" + textBox_Theme.Text + "\" входит в состав журнала учащихся!", "Ошибка удаления");
                    return;
                }
            }

            string sql = "DELETE FROM lesson WHERE lesson_id=" + textBox_Number.Text;
            Main_Menu.Modification_Execute(sql);

            Main_Menu.ds.Tables["Занятия"].Rows.RemoveAt(n);

            if (Main_Menu.ds.Tables["Занятия"].Rows.Count > n)
                FieldsForm_Fill();
            else
                FieldsForm_Clear();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Main_Menu.tabControl.Controls.Remove(Main_Menu.tabControl.SelectedTab);
        }
    }
}
