using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace E_Voting_Data
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Database doQuery = new Database();
            MySqlDataAdapter collegeAdapter = new MySqlDataAdapter();
            //doQuery.connect();
            collegeAdapter = doQuery.get_colleges();

            DataSet collegeData = new DataSet();
            collegeAdapter.Fill(collegeData);
            dataTable.DataSource = collegeData.Tables[0];

            DataTable collegeTable = new DataTable();
            collegeAdapter.Fill(collegeTable);

            foreach (DataRow row in collegeTable.Rows)
            {
                collegeFilter.Items.Add(new ComboboxValue(Int32.Parse(row[0].ToString()), row[1].ToString()));

            }

            mainMenu.Renderer = new MyRenderer();
            mainMenu.BackColor = System.Drawing.ColorTranslator.FromHtml("#266050");
            
        }

        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }

        private class MyColors : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return System.Drawing.ColorTranslator.FromHtml("#10bd8f"); }
            }

            public override Color MenuItemSelectedGradientBegin
            {
                get { return System.Drawing.ColorTranslator.FromHtml("#10bd8f"); }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return System.Drawing.ColorTranslator.FromHtml("#10bd8f"); }
            }
        }

        private void userToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            userToolStripMenuItem.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
        }

        private void collegesToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            collegesToolStripMenuItem.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
        }

        private void addToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            addToolStripMenuItem.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
        }

        private void importToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            importToolStripMenuItem.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
        }

        private void settingsToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            settingsToolStripMenuItem.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
        }

        private void helpToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            helpToolStripMenuItem.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
        }

        private void userToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            userToolStripMenuItem.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
        }
        
        private void collegesToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            collegesToolStripMenuItem.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
        }

        private void addToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            addToolStripMenuItem.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
        }

        private void importToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            importToolStripMenuItem.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
        }

        private void settingsToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            settingsToolStripMenuItem.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
        }

        private void helpToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            helpToolStripMenuItem.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
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

        private void collegesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Database doQuery = new Database();
            MySqlDataAdapter collegeAdapter = new MySqlDataAdapter();
            //doQuery.connect();
            collegeAdapter = doQuery.get_colleges();

            DataSet collegeTable = new DataSet();
            collegeAdapter.Fill(collegeTable);
            dataTable.DataSource = collegeTable.Tables[0];
        }

        private void schoolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Database doQuery = new Database();
            MySqlDataAdapter schoolAdapter = new MySqlDataAdapter();
            //doQuery.connect();
            schoolAdapter = doQuery.get_schools();

            DataSet collegeTable = new DataSet();
            schoolAdapter.Fill(collegeTable);
            dataTable.DataSource = collegeTable.Tables[0];
        }

        private void classesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Database doQuery = new Database();
            MySqlDataAdapter collegeAdapter = new MySqlDataAdapter();
            //doQuery.connect();
            collegeAdapter = doQuery.get_classes();

            DataSet collegeTable = new DataSet();
            collegeAdapter.Fill(collegeTable);
            dataTable.DataSource = collegeTable.Tables[0];
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Database doQuery = new Database();
            MySqlDataAdapter studentAdapter = new MySqlDataAdapter();
            //doQuery.connect();
            studentAdapter = doQuery.get_students();

            DataSet collegeTable = new DataSet();
            studentAdapter.Fill(collegeTable);
            dataTable.DataSource = collegeTable.Tables[0];
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Database doQuery = new Database();
            MySqlDataAdapter usersAdapter = new MySqlDataAdapter();
            //doQuery.connect();
            usersAdapter = doQuery.get_users();

            DataSet collegeTable = new DataSet();
            usersAdapter.Fill(collegeTable);
            dataTable.DataSource = collegeTable.Tables[0];
        }

        private void collegeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            int college = (collegeFilter.SelectedIndex + 1);
            Database doQuery = new Database();
            MySqlDataAdapter schoolAdapter = new MySqlDataAdapter();
            //doQuery.connect();
            schoolAdapter = doQuery.get_schools(college);

            DataSet schoolData = new DataSet();
            schoolAdapter.Fill(schoolData);
            dataTable.DataSource = schoolData.Tables[0];

            DataTable schoolTable = new DataTable();
            schoolAdapter.Fill(schoolTable);

            schoolFilter.Items.Clear();

            foreach (DataRow row in schoolTable.Rows)
            {
                schoolFilter.Items.Add(new ComboboxValue(Int32.Parse(row[0].ToString()), row[1].ToString()));
            }
        }

        private void schoolFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            int school = (schoolFilter.SelectedIndex + 1);
            Database doQuery = new Database();
            MySqlDataAdapter classAdapter = new MySqlDataAdapter();
            //doQuery.connect();
            classAdapter = doQuery.get_classes(school);

            DataSet classData = new DataSet();
            classAdapter.Fill(classData);
            dataTable.DataSource = classData.Tables[0];

            DataTable classTable = new DataTable();
            classAdapter.Fill(classTable);

            classFilter.Items.Clear();

            foreach (DataRow row in classTable.Rows)
            {
                classFilter.Items.Add(new ComboboxValue(Int32.Parse(row[0].ToString()), row[1].ToString()));
            }
        }

        private void mainMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
