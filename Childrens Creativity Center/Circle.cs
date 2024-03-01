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
    public partial class Circle : Form
    {
        public Circle()
        {
            InitializeComponent();
        }

        public static int n = 0;

        private void FieldsForm_Fill()
        {
            textBox_Number.Text = Main_Menu.ds.Tables["Кружки"].Rows[n]["Номер"].ToString();
            textBox_Name.Text = Main_Menu.ds.Tables["Кружки"].Rows[n]["Название"].ToString();

            textBox_Number.Enabled = false;
        }

        private void FieldsForm_Clear()
        {
            textBox_Number.Text = "0";
            textBox_Name.Text = "";

            textBox_Number.Enabled = true; textBox_Number.Focus();
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            if (Main_Menu.ds.Tables["Кружки"].Rows.Count > n)
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
            if (n < Main_Menu.ds.Tables["Кружки"].Rows.Count) n++;
            if (Main_Menu.ds.Tables["Кружки"].Rows.Count > n)
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
            n = Main_Menu.ds.Tables["Кружки"].Rows.Count;
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
            if (Main_Menu.ds.Tables["Кружки"].Rows.Count > 0)
            {
                n = 0; FieldsForm_Fill();
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            string sql;
            if (n < Main_Menu.ds.Tables["Кружки"].Rows.Count)
            {
                sql = "UPDATE circle SET circle_name='" + textBox_Name.Text + "' WHERE circle_id=" + textBox_Number.Text;
                if (!Main_Menu.Modification_Execute(sql))
                    return;

                Main_Menu.ds.Tables["Кружки"].Rows[n].ItemArray = new object[] { textBox_Number.Text, textBox_Name.Text };
            }
            else
            {
                sql = "INSERT INTO circle VALUES(" + textBox_Number.Text + ", '" + textBox_Name.Text + "')";
                if (!Main_Menu.Modification_Execute(sql))
                    return;
                textBox_Number.Enabled = false;

                Main_Menu.ds.Tables["Кружки"].Rows.Add(new object[] { textBox_Number.Text, textBox_Name.Text });
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            string message = "Вы точно хотите удалить из справочника кружок с номером " + textBox_Number.Text + "?";
            string caption = "Удаление кружка";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult dialogResult = MessageBox.Show(message, caption, buttons, icon);

            if (dialogResult == DialogResult.No) { return; }
            string sql = "SELECT lesson_id AS \"Номер\", lesson_theme AS \"Тема\", circle_name AS \"Кружок\", lesson_datetime AS \"Дата и время\" FROM " +
                "lesson LEFT JOIN circle ON lesson.circle_id = circle.circle_id ORDER BY lesson_id";
            Main_Menu.Table_Fill("Журнал учащихся", sql);
            
            for (int i = 0; i < Main_Menu.ds.Tables["Занятия"].DefaultView.Count; i++)
            {
                if (Main_Menu.ds.Tables["Занятия"].DefaultView[i]["circle_id"].ToString() == textBox_Number.Text)
                {
                    MessageBox.Show("Кружок \"" + textBox_Name.Text + "\" входит в состав записей справочника Занятия!", "Ошибка удаления");
                    return;
                }
            }

            sql = "DELETE FROM circle WHERE circle_id=" + textBox_Number.Text;
            Main_Menu.Modification_Execute(sql);

            Main_Menu.ds.Tables["Кружки"].Rows.RemoveAt(n);

            if (Main_Menu.ds.Tables["Кружки"].Rows.Count > n)
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
