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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (Main_Menu.tabControl.TabCount > 0)
                Main_Menu.tabControl.TabPages.RemoveAt(Main_Menu.tabControl.TabCount - 1);
            Login login = new Login();
            Main_Menu.tabControl.Controls.Add(login.tabControl1.TabPages[0]);
            login.tabPage1_Paint();
        }

        private void занятияToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            Lesson lesson = new Lesson();
            Main_Menu.tabControl.Controls.Add(lesson.tabControl1.TabPages[0]);
            Main_Menu.tabControl.SelectedIndex = Main_Menu.tabControl.TabCount - 1;
        }

        private void кружкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle();
            Main_Menu.tabControl.Controls.Add(circle.tabControl1.TabPages[0]);
            Main_Menu.tabControl.SelectedIndex = Main_Menu.tabControl.TabCount - 1;
        }

        private void учащиесяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            Main_Menu.tabControl.Controls.Add(student.tabControl1.TabPages[0]);
            Main_Menu.tabControl.SelectedIndex = Main_Menu.tabControl.TabCount - 1;
        }

        private void журналУчащихсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Students_Journal students_Journal = new Students_Journal();
            Main_Menu.tabControl.Controls.Add(students_Journal.tabControl1.TabPages[0]);
            Main_Menu.tabControl.SelectedIndex = Main_Menu.tabControl.TabCount - 1;
        }
    }
}
