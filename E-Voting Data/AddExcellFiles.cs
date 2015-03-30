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
        public static string connectionString = "datasource=10.10.10.10;database=sample;port=3306; username=sample;password=ilabsx";
         MySqlConnection connection = new MySqlConnection(connectionString);
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
           // FormBorderStyle = FormBorderStyle.None;
            //WindowState = FormWindowState.Maximized;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            //string connectionString = "datasource=10.10.10.10;database=sample;port=3306; username=sample;password=ilabsx";
            string sql = "SELECT * FROM students";
           
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

        

        private void button1_Click_1(object sender, EventArgs e)
        {
             OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF Files(*.pdf)|*.pdf|WORD Files(*.doc;*.docx)|*.doc;*.docx|EXCEL Files(*.xlsx;*.xlsm;*.xlsb;*.xltx;*.xltm;*.xls;*.xlt)|*.xlsx;*.xlsm;*.xlsb;*.xltx;*.xltm;*.xls;*.xlt|Image Files(*.jpg;*.gif;*.bmp;*.png;*.jpeg)|*.jpg;*.gif;*.bmp;*.png;*.jpeg|All Files|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName.ToString();
                try
                {

                    System.Data.OleDb.OleDbConnection MyConnection;
                    System.Data.DataSet DtSet;
                    System.Data.OleDb.OleDbDataAdapter MyCommand;
                    MyConnection = new System.Data.OleDb.OleDbConnection(@"provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=Excel 8.0;");
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

        private void button5_Click(object sender, EventArgs e)
        {
           
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand();
                

                MySqlCommand command2 = new MySqlCommand();
               
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = connection;
                    connection.Open();
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        Boolean Empty = true;
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {

                            Empty = false;
                            string StrQuery = @"INSERT  INTO students(Id,Name,Country) VALUES ('"
                                    + dataGridView1.Rows[i].Cells["Id"].Value + "','"
                                    + dataGridView1.Rows[i].Cells["Name"].Value + "','"
                                    + dataGridView1.Rows[i].Cells["Country"].Value + "')";
                            cmd.CommandText = StrQuery;
                            cmd.ExecuteNonQuery();

                        }
                        if (Empty)
                        {
                            dataGridView1.Rows.RemoveAt(i);
                            i--;
                        }
                    }
                }
                MessageBox.Show("Successfully Added!");
            }

        }
    }
}
