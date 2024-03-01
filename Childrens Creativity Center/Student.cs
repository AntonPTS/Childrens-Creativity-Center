using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;

namespace Childrens_Creativity_Center
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        public static int n = 0;

        private void FieldsForm_Fill()
        {
            textBox_Number.Text = Main_Menu.ds.Tables["Учащиеся"].Rows[n]["Номер"].ToString();
            textBox_Login.Text = Main_Menu.ds.Tables["Учащиеся"].Rows[n]["Логин"].ToString();
            textBox_Password.Text = Main_Menu.ds.Tables["Учащиеся"].Rows[n]["Пароль"].ToString();
            textBox_Surname.Text = Main_Menu.ds.Tables["Учащиеся"].Rows[n]["Фамилия"].ToString();
            textBox_Name.Text = Main_Menu.ds.Tables["Учащиеся"].Rows[n]["Имя"].ToString();
            textBox_Patronymic.Text = Main_Menu.ds.Tables["Учащиеся"].Rows[n]["Отчество"].ToString();
            dateTimePicker_Birthdate.Value = Convert.ToDateTime(Main_Menu.ds.Tables["Учащиеся"].Rows[n]["Дата рождения"].ToString());
            textBox_Address.Text = Main_Menu.ds.Tables["Учащиеся"].Rows[n]["Адрес"].ToString();
            maskedTextBox_Phone.Text = Main_Menu.ds.Tables["Учащиеся"].Rows[n]["Номер телефона"].ToString();

            textBox_Number.Enabled = false;
        }

        private void FieldsForm_Clear()
        {
            textBox_Number.Text = "0";
            textBox_Login.Text = "";
            textBox_Password.Text = "";
            textBox_Surname.Text = "";
            textBox_Name.Text = "";
            textBox_Patronymic.Text = "";
            dateTimePicker_Birthdate.ResetText();
            textBox_Address.Text = "";
            maskedTextBox_Phone.ResetText();

            textBox_Number.Enabled = true;
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            textBox_Password.UseSystemPasswordChar = true;
            if (Main_Menu.ds.Tables["Учащиеся"].Rows.Count > n)
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
            if (n < Main_Menu.ds.Tables["Учащиеся"].Rows.Count) n++;
            if (Main_Menu.ds.Tables["Учащиеся"].Rows.Count > n)
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
            n = Main_Menu.ds.Tables["Учащиеся"].Rows.Count;
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
            if (Main_Menu.ds.Tables["Учащиеся"].Rows.Count > 0)
            {
                n = 0; FieldsForm_Fill();
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            maskedTextBox_Phone.Mask = "80000000000";

            string sql;
            if (n < Main_Menu.ds.Tables["Учащиеся"].Rows.Count)
            {
                sql = "UPDATE student SET username='" + textBox_Login.Text + "', password='" + textBox_Password.Text + "', surname='" + textBox_Surname.Text +
                    "', name='" + textBox_Name.Text + "', patronymic='" + textBox_Patronymic.Text + "', birthdate='" + dateTimePicker_Birthdate.Value +
                    "', address='" + textBox_Address.Text + "', phone_number='" + maskedTextBox_Phone.Text + "' WHERE student_id=" + textBox_Number.Text;
                if (!Main_Menu.Modification_Execute(sql))
                    return;

                Main_Menu.ds.Tables["Учащиеся"].Rows[n].ItemArray = new object[] { textBox_Number.Text, textBox_Login.Text, textBox_Password.Text, textBox_Surname.Text,
                    textBox_Name.Text, textBox_Patronymic.Text, dateTimePicker_Birthdate.Value, textBox_Address.Text, maskedTextBox_Phone.Text };

                maskedTextBox_Phone.Mask = "8 (999) 000-0000";
            }
            else
            {
                maskedTextBox_Phone.Mask = "80000000000";

                sql = "INSERT INTO student VALUES(" + textBox_Number.Text + ", '" + textBox_Login.Text + "', '" + textBox_Password.Text + "', '" + textBox_Surname.Text +
                    "', '" + textBox_Name.Text + "', '" + textBox_Patronymic.Text + "', '" + dateTimePicker_Birthdate.Value + "', '" + textBox_Address.Text + "', '" + 
                    maskedTextBox_Phone.Text + "')";
                if (!Main_Menu.Modification_Execute(sql))
                    return;
                textBox_Number.Enabled = false;

                Main_Menu.ds.Tables["Учащиеся"].Rows.Add(new object[] { textBox_Number.Text, textBox_Login.Text, textBox_Password.Text, textBox_Surname.Text, textBox_Name.Text,
                    textBox_Patronymic.Text, dateTimePicker_Birthdate.Value, textBox_Address.Text, maskedTextBox_Phone.Text });

                maskedTextBox_Phone.Mask = "8 (999) 000-0000";
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            string message = "Вы точно хотите удалить из справочника учащегося под номером " + textBox_Number.Text + "?";
            string caption = "Удаление учащегося";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult dialogResult =  MessageBox.Show(message, caption, buttons, icon);

            if (dialogResult == DialogResult.No) { return; }
            Main_Menu.Table_Fill("Журнал учащихся", "SELECT * FROM student_journal");

            for (int i = 0; i < Main_Menu.ds.Tables["Журнал учащихся"].DefaultView.Count; i++)
            {
                if (Main_Menu.ds.Tables["Журнал учащихся"].DefaultView[i]["student_id"].ToString() == textBox_Number.Text)
                {
                    MessageBox.Show("Студент " + textBox_Surname + " " + textBox_Name.Text + " " + textBox_Patronymic.Text + " входит в состав журнала учащихся!", "Ошибка удаления");
                    return;
                }
            }

            string sql = "DELETE FROM student WHERE student_id=" + textBox_Number.Text;
            Main_Menu.Modification_Execute(sql);

            Main_Menu.ds.Tables["Учащиеся"].Rows.RemoveAt(n);

            if (Main_Menu.ds.Tables["Учащиеся"].Rows.Count > n)
                FieldsForm_Fill();
            else
                FieldsForm_Clear();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Main_Menu.tabControl.Controls.Remove(Main_Menu.tabControl.SelectedTab);
        }

        private void checkBox_Pass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Pass.Checked)
                textBox_Password.UseSystemPasswordChar = false;
            else
                textBox_Password.UseSystemPasswordChar = true;
        }
    }
}
