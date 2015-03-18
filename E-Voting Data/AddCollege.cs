using MySql.Data.MySqlClient;
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
    public partial class AddCollege : Form
    {
        public AddCollege()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                //This is my connection string i have assigned the database file address path

                string MyConnection2 = "datasource=10.10.10.10; port=3306; username=sample; password=ilabsx";

                //This is my insert query in which i am taking input from the user through windows forms

                string Query = "insert into sample.colleges(name,code) values('" + this.txtname.Text + "','" + this.txtcode.Text + "');";

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

        private void AddCollege_Load(object sender, EventArgs e)
        {
            this.panel1.BackColor = System.Drawing.ColorTranslator.FromHtml("#266050");
            this.panel2.BackColor = System.Drawing.ColorTranslator.FromHtml("#266050");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtcode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
