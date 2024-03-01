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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Admin")
            {
                if (textBox2.Text == "Admin")
                {
                    Main_Menu.Table_Fill("Учащиеся", "SELECT student_id AS \"Номер\", username AS \"Логин\", password AS \"Пароль\", surname AS \"Фамилия\", name AS \"Имя\", " +
                        "patronymic AS \"Отчество\", birthdate AS \"Дата рождения\", address AS \"Адрес\", phone_number AS \"Номер телефона\" FROM student ORDER BY student_id");
                    Main_Menu.ds.Tables["Учащиеся"].DefaultView.Sort = "Фамилия";

                    Main_Menu.Table_Fill("Кружки", "SELECT circle_id AS \"Номер\", circle_name AS \"Название\" FROM circle ORDER BY circle_id");
                    Main_Menu.ds.Tables["Кружки"].DefaultView.Sort = "Название";

                    menu menu = new menu();
                    Main_Menu.tabControl.TabPages.RemoveAt(0);
                    Main_Menu.tabControl.Controls.Add(menu.tabControl1.TabPages[0]);
                }
                else
                {
                    MessageBox.Show("Неправильный пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void tabPage1_Paint()
        {
            string sql = "SELECT lesson_id AS \"Номер\", lesson_theme AS \"Тема\", circle_name AS \"Кружок\", lesson_datetime AS \"Дата и время\" FROM " +
                "lesson LEFT JOIN circle ON lesson.circle_id = circle.circle_id ORDER BY lesson_id";
            Main_Menu.Table_Fill("Занятия", sql);
            Main_Menu.ds.Tables["Занятия"].DefaultView.Sort = "Номер";

            dataGridView1.DataSource = Main_Menu.ds.Tables["Занятия"].DefaultView;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Enabled = true;
            dataGridView1.AutoResizeColumns();
            dataGridView1.CurrentCell = null;

            textBox2.UseSystemPasswordChar = true;
            textBox1.Select();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBox2.UseSystemPasswordChar = false;
            else
                textBox2.UseSystemPasswordChar = true;
        }
    }
}
