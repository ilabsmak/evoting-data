using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Voting_Data
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (Login.status == 0)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void collegesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void collegesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AddCollege addcollege = new AddCollege();
            addcollege.Show();
        }

        private void schoolsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddSchool addschool = new AddSchool();
            addschool.Show();
        }

        private void usersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddUser adduser = new AddUser();
            adduser.Show();
        }

        private void classesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddClass addclass = new AddClass();
            addclass.Show();
        }

        private void studentsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddStudent addstudent = new AddStudent();
            addstudent.Show();
        }
    }
}
