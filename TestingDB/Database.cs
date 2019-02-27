using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingDB
{
    class Database
    {
        private static string ProjectPath=Environment.CurrentDirectory.Substring(0,Environment.CurrentDirectory.LastIndexOf("bin\\Debug"));
        public static string conString="Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+ProjectPath+@"Database\Registration.mdb;Persist Security Info=True";
       
        public static void ExecuteNonQuery(string sql)
        {
            OleDbConnection con = new OleDbConnection(conString);
            con.Open();
            OleDbCommand command = new OleDbCommand(sql, con);
            command.ExecuteNonQuery();
            con.Close();
        }
        public static DataTable Retrieve(string sql)
        {
            DataTable dt = new DataTable();
            OleDbConnection con = new OleDbConnection(conString);
            con.Open();
            OleDbCommand command = new OleDbCommand(sql, con);
            OleDbDataAdapter dat = new OleDbDataAdapter(command);
            dat.Fill(dt);
            
            con.Close();
            return dt;
        }

        
    }
    
   
}
