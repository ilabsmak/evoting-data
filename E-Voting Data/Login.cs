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
    public partial class Login : Form
    {
        public static int status = 0;
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=10.10.10.10; port=3306; username=sample; password=ilabsx";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand SelectCommand = new MySqlCommand("select*from sample.users where username= '"+ this.usernameText.Text+"'and password='"+this.passwordText.Text+"';",myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                int count = 0;
                while (myReader.Read()){
                    count = count + 1;
                }
                if (count == 1)
                {
                   //MessageBox.Show("your in");
                   status = 1;
                   Main maininstance = new Main();
                   this.Hide();
                   maininstance.Show();
            
                }
                else if (count < 1)
                {
                    MessageBox.Show(" dup username or password, access denied");

                }
           
                else MessageBox.Show("inxorrect usename and password");
                 myConn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
