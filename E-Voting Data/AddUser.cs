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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try{
             //This is my connection string i have assigned the database file address path

                string MyConnection2 = "datasource=10.10.10.10; port=3306; username=sample; password=ilabsx";

                //This is my insert query in which i am taking input from the user through windows forms

                string Query = "insert into sample.schools(fullname,username,password) values('" + this.txtfullname.Text + "','" + this.txtusername.Text + "', '" + this.txtpassword.Text + "');";

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
    }
}
