using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Childrens_Creativity_Center
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        public static NpgsqlConnection connection =
            new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=153215; Database=childrens_creativity_center;");

        public static DataSet ds = new DataSet();

        public static TabControl tabControl = new TabControl();

        public static void Table_Fill(string name, string sql)
        {
            if (ds.Tables[name] != null)
                ds.Tables[name].Clear();
            NpgsqlDataAdapter dat;
            dat = new NpgsqlDataAdapter(sql, connection);
            dat.Fill(ds, name);
            connection.Close();
        }

        public static bool Modification_Execute(string sql)
        {
            NpgsqlCommand com;
            com = new NpgsqlCommand(sql, connection);
            connection.Open();
            try
            {   
                com.ExecuteNonQuery();
            }
            catch (NpgsqlException)
            {
                MessageBox.Show("Обновление базы данных не было выполнено либо из-за некорректно указанных" +
                    " обновляемых данных либо отсутствующих, но при этом обязательных!!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                return false;
            }
            connection.Close();
            return true;
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {
            tabControl.Size = new Size(1109, 620);
            tabControl.Location = new Point(3, 3);
            this.Controls.Add(tabControl);

            Login login = new Login();
            tabControl.Controls.Add(login.tabControl1.TabPages[0]);
            login.tabPage1_Paint();
        }
    }
}
