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
    public partial class AddExcellFiles : Form
    {

        MySqlCommand sCommand;
        MySqlDataAdapter sAdapter;
        MySqlCommandBuilder sBuilder;
        DataSet sDs;
        DataTable sTable;

        public AddExcellFiles()
        {
            InitializeComponent();
        }


       
        private void AddExcellFiles_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            string connectionString = "datasource=10.10.10.10;database=sample;port=3306; username=sample;password=ilabsx";
            string sql = "SELECT * FROM students";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            sCommand = new MySqlCommand(sql, connection);
            sAdapter = new MySqlDataAdapter(sCommand);
            sBuilder = new MySqlCommandBuilder(sAdapter);
            sDs = new DataSet();
            sAdapter.Fill(sDs, "details");
            sTable = sDs.Tables["details"];
            connection.Close();
            dataGridView1.DataSource = sDs.Tables["details"];
            dataGridView1.ReadOnly = true;
            save_btn.Enabled = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
            save_btn.Enabled = true;
            button2.Enabled = false;
            delete_btn.Enabled = false;
        }

        private void delete_btn_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to delete this row ?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                sAdapter.Update(sTable);
            }
        }

        private void save_btn_Click_1(object sender, EventArgs e)
        {
            sAdapter.Update(sTable);
            dataGridView1.ReadOnly = true;
            save_btn.Enabled = false;
            button2.Enabled = true;
            delete_btn.Enabled = true;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF Files(*.pdf)|*.pdf|WORD Files(*.doc;*.docx)|*.doc;*.docx|EXCEL Files(*.xlsx;*.xlsm;*.xlsb;*.xltx;*.xltm;*.xls;*.xlt)|*.xlsx;*.xlsm;*.xlsb;*.xltx;*.xltm;*.xls;*.xlt|Image Files(*.jpg;*.gif;*.bmp;*.png;*.jpeg)|*.jpg;*.gif;*.bmp;*.png;*.jpeg|All Files|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName.ToString();
                //System.IO.FileInfo fInfo = new System.IO.FileInfo(ofd.FileName);

                // string strFileName = fInfo.Name;

                // string path = fInfo.DirectoryName;
                textBox1.Text = path;
            }
        
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                System.Data.OleDb.OleDbConnection MyConnection;
                System.Data.DataSet DtSet;
                System.Data.OleDb.OleDbDataAdapter MyCommand;
                MyConnection = new System.Data.OleDb.OleDbConnection(@"provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + textBox1.Text + ";Extended Properties=Excel 8.0;");
                MyCommand = new System.Data.OleDb.OleDbDataAdapter("select * from [Sheet1$]", MyConnection);



                MyCommand.TableMappings.Add("Table", "TestTable");
                DtSet = new System.Data.DataSet();
                MyCommand.Fill(DtSet);
                dataGridView1.DataSource = DtSet.Tables[0];
                MyConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            /* String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + textBox1 + ";Extended Properties='Excel 12.0 XML;HDR=YES;';";

           


            */
        }
    }
}
