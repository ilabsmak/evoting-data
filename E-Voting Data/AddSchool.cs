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
    public partial class AddSchool : Form
    {
        public AddSchool()
        {
            InitializeComponent();

            Database doQuery = new Database();  
            MySqlDataAdapter collegeAdapter = new MySqlDataAdapter();
            //doQuery.connect();
            collegeAdapter = doQuery.get_colleges();

            DataTable collegeTable = new DataTable();
            collegeAdapter.Fill(collegeTable);

            foreach (DataRow row in collegeTable.Rows)
            {
                cbxcollege.Items.Add(new ComboboxValue(Int32.Parse(row[0].ToString()),row[1].ToString()));

            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                 

                //This is my connection string i have assigned the database file address path

                string MyConnection2 = "datasource=10.10.10.10; port=3306; username=sample; password=ilabsx";

                //This is my insert query in which i am taking input from the user through windows forms

                string Query = "insert into sample.schools(name,college) values('" + this.txtname.Text + "','" + (cbxcollege.SelectedIndex+1) + "');";

                //This is  MySqlConnection here i have created the object and pass my connection string.

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                //This is command class which will handle the query and connection object.

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                MySqlDataReader MyReader2;

                MyConn2.Open();

                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.

                MessageBox.Show("Save Data");

                while (MyReader2.Read())
                {

                }

                MyConn2.Close();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void cbxcollege_SelectedIndexChanged(object sender, EventArgs e)
        {
            
          
        }

    }
        }
    

