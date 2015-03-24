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
        public static TreeNode collegenode;
        public static TreeNode schoolnode;

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

        private void userToolStripMenuItem_DropDownOpening(Object sender, EventArgs e) 
        {
            userToolStripMenuItem.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
        }

        private void profileToolStripMenuItem_MouseEnter(Object sender, EventArgs e) 
        {
            userToolStripMenuItem.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
        }

        private void userToolStripMenuItem_DropDownClosed(Object sender, EventArgs e)
        {
            userToolStripMenuItem.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
        }

        private void collegesToolStripMenuItem_DropDownOpening(Object sender, EventArgs e)
        {
            collegesToolStripMenuItem.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
        }

        private void studentsStripMenuItem_MouseEnter(Object sender, EventArgs e)
        {
            collegesToolStripMenuItem.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
        }

        private void collegesToolStripMenuItem_DropDownClosed(Object sender, EventArgs e)
        {
            collegesToolStripMenuItem.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
        }

        private void addToolStripMenuItem_DropDownOpening(Object sender, EventArgs e)
        {
            addToolStripMenuItem.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
        }

        private void studentsStripMenuItem1_MouseEnter(Object sender, EventArgs e)
        {
            addToolStripMenuItem.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
        }

        private void addToolStripMenuItem_DropDownClosed(Object sender, EventArgs e)
        {
            addToolStripMenuItem.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
        }

        private void importToolStripMenuItem_DropDownOpening(Object sender, EventArgs e)
        {
            importToolStripMenuItem.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
        }

        private void studentStripMenuItem2_MouseEnter(Object sender, EventArgs e)
        {
            importToolStripMenuItem.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
        }

        private void importToolStripMenuItem_DropDownClosed(Object sender, EventArgs e)
        {
            importToolStripMenuItem.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
        }

        private void settingsToolStripMenuItem_DropDownOpening(Object sender, EventArgs e)
        {
            settingsToolStripMenuItem.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
        }

        private void preferencesToolStripMenuItem_MouseEnter(Object sender, EventArgs e)
        {
            settingsToolStripMenuItem.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
        }

        private void settingsToolStripMenuItem_DropDownClosed(Object sender, EventArgs e)
        {
            settingsToolStripMenuItem.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
        }

        private void helpToolStripMenuItem_DropDownOpening(Object sender, EventArgs e)
        {
            helpToolStripMenuItem.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
        }

        private void aboutToolStripMenuItem_MouseEnter(Object sender, EventArgs e)
        {
            helpToolStripMenuItem.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
        }

        private void helpToolStripMenuItem_DropDownClosed(Object sender, EventArgs e)
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
            MySqlConnection MyConn2 = new MySqlConnection("datasource=10.10.10.10;Database=sample;username=sample;password=ilabsx");
            
            treeView1.Nodes.Clear();
            string Query = "select * from colleges ;";

            // MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            try
            {
                //MySqlDataReader dr = MyCommand2.ExecuteReader();
                MySqlDataAdapter da = new MySqlDataAdapter(MyCommand2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    collegenode = new TreeNode(dr["name"].ToString());

                    string schoolsQuery = "select * from schools WHERE college=" + dr["id"] + ";";
                    MySqlCommand MyCommand3 = new MySqlCommand(schoolsQuery, MyConn2);
                    try
                    {
                        //MySqlDataReader dr = MyCommand2.ExecuteReader();
                        MySqlDataAdapter schoolsda = new MySqlDataAdapter(MyCommand3);
                        DataTable schoolsdt = new DataTable();
                        schoolsda.Fill(schoolsdt);
                        foreach (DataRow schoolsdr in schoolsdt.Rows)
                        {
                            

                            schoolnode = collegenode.Nodes.Add(schoolsdr["name"].ToString());
                            string classQuery = "select * from classes WHERE school=" + schoolsdr["id"] + ";";
                            MySqlCommand MyCommand4 = new MySqlCommand(classQuery, MyConn2);
                            try
                            {
                                //MySqlDataReader dr = MyCommand2.ExecuteReader();
                                MySqlDataAdapter classda = new MySqlDataAdapter(MyCommand4);
                                DataTable classdt = new DataTable();
                                classda.Fill(classdt);
                                foreach (DataRow classdr in classdt.Rows)
                                {
                                    schoolnode.Nodes.Add(classdr["name"].ToString());
                                }
                            }
                            catch (MySqlException ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    //node.Nodes.Add(dr["dob"].ToString());
                    treeView1.Nodes.Add(collegenode);
                    treeView1.MouseClick += new MouseEventHandler(treeView1_MouseClick);
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
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

        private void studentsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AddExcellFiles addexcellfiles = new AddExcellFiles();

            addexcellfiles.Show();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
           // if (treeView1.SelectedNode == collegenode)
            //{
               // MessageBox.Show("yess");
           // }
        }

        private void treeView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (treeView1.SelectedNode == schoolnode)
            {
               /* Database doQuery = new Database();
                MySqlDataAdapter collegeAdapter = new MySqlDataAdapter();
                //doQuery.connect();
                collegeAdapter = doQuery.get_colleges();

                DataSet collegeTable = new DataSet();
                collegeAdapter.Fill(collegeTable);
                dataTable.DataSource = collegeTable.Tables[0];*/
                MessageBox.Show("yess");
            }
           // TreeNode clickedNode = e.;
        }

        
    }
}
