using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace E_Voting_Data
{
    class Database
    {
        public static string myConnection = "datasource=10.10.10.10; port=3306; username=sample; password=ilabsx";
        public static MySqlConnection myConn = new MySqlConnection(myConnection);

        public void connect()
        {
            string myConnection = "datasource=10.10.10.10; port=3306; username=sample; password=ilabsx";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();
        }

        public MySqlDataAdapter get_users() 
        {
            MySqlCommand SelectCommand = new MySqlCommand("select * from sample.users ;", myConn);
            MySqlDataAdapter userAdapter = new MySqlDataAdapter(SelectCommand);
            return userAdapter;
        }

        public MySqlDataAdapter get_colleges()
        {
            MySqlCommand SelectCommand = new MySqlCommand("select * from sample.colleges ;", myConn);
            MySqlDataAdapter collegeAdapter = new MySqlDataAdapter(SelectCommand);
            return collegeAdapter;
            
        }

        public MySqlDataAdapter get_schools(int college=0)
        {
            if (college == 0)
            {
                MySqlCommand SelectCommand = new MySqlCommand("select * from sample.schools ;", myConn);
                MySqlDataAdapter schoolAdapter = new MySqlDataAdapter(SelectCommand);
                return schoolAdapter;
            }
            else
            {
                MySqlCommand SelectCommand = new MySqlCommand("select * from sample.schools where college="+college+";", myConn);
                MySqlDataAdapter schoolAdapter = new MySqlDataAdapter(SelectCommand);
                return schoolAdapter;
            }
            
        }

        public MySqlDataAdapter get_classes(int school=0)
        {
            if (school == 0)
            {
                MySqlCommand SelectCommand = new MySqlCommand("select * from sample.classes ;", myConn);
                MySqlDataAdapter classAdapter = new MySqlDataAdapter(SelectCommand);
                return classAdapter;
            }
            else 
            {
                MySqlCommand SelectCommand = new MySqlCommand("select * from sample.classes where school="+school+" ;", myConn);
                MySqlDataAdapter classAdapter = new MySqlDataAdapter(SelectCommand);
                return classAdapter;
            }
            
        }

        public MySqlDataAdapter get_students()
        {
            MySqlCommand SelectCommand = new MySqlCommand("select * from sample.students ;", myConn);
            MySqlDataAdapter studentAdapter = new MySqlDataAdapter(SelectCommand);
            return studentAdapter;
        }

        public void add_users()
        {
            string myConnection = "datasource=10.10.10.10; port=3306; username=sample; password=ilabsx";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand("select*from sample.users WHERE Name='" + myConn + "';");
            // MySqlDataReader myReader;
        }

        public void add_colleges()
        {
            string myConnection = "datasource=10.10.10.10; port=3306; username=sample; password=ilabsx";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand("select*from sample.users WHERE Name='" + myConn + "';");
            // MySqlDataReader myReader;
        }

        public void add_schools()
        {
            string myConnection = "datasource=10.10.10.10; port=3306; username=sample; password=ilabsx";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand("select*from sample.users WHERE Name='" + myConn + "';");
            // MySqlDataReader myReader;
        }

        public void add_class()
        {
            string myConnection = "datasource=10.10.10.10; port=3306; username=sample; password=ilabsx";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand("select*from sample.users WHERE Name='" + myConn + "';");
            // MySqlDataReader myReader;
        }

        public void add_students()
        {
            string myConnection = "datasource=10.10.10.10; port=3306; username=sample; password=ilabsx";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand("select*from sample.users WHERE Name='" + myConn + "';");
            // MySqlDataReader myReader;
        }
       

    }
}
