using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Policy;

namespace Bliblioteca.Classes.Database
{
    public class SQLServerC
    {
        public string stringConn;
        public SqlConnection connDB;

        public SQLServerC()
        {
            stringConn = "Data Source=MATHEUS;Initial Catalog=Be3;Persist Security Info=True;User ID=sa;Password=1707";
            connDB = new SqlConnection(stringConn);
            connDB.Open();
        }


        public string SQLCommand(string SQL) 
        {
            var myCommand = new SqlCommand(SQL, connDB);
            myCommand.CommandTimeout = 0;
            var myReader = myCommand.ExecuteReader();
            return "";
        }


        public DataTable SQLQuery(string SQL)
        {
            DataTable dt = new DataTable(); 
            
            var myCommand = new SqlCommand(SQL, connDB);
            myCommand.CommandTimeout = 0;
            var myReader = myCommand.ExecuteReader();
            dt.Load(myReader);
            return dt;  
       
        }
        public void Close()
        {
            connDB.Close();
            connDB.Close();
        }
    }

        

    
}
