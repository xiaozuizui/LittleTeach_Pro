using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.SQLite.Linq;
using System.Data.SQLite.Generic;

namespace ServiceCore.Model
{
    public class SqlHelper
    {
        public static void CreatDB(string path)
        {
            string connectstr = "Data source=" + path;
            SQLiteConnection sQLiteConnection = new SQLiteConnection(connectstr);
            sQLiteConnection.Open();
            if (sQLiteConnection.State != System.Data.ConnectionState.Open)
            {
                sQLiteConnection.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = sQLiteConnection;
                cmd.CommandText = "CREATE TABLE t1(Id varchar(4),ClassName char(4),Section int , ClassInfo varchar(20),Teacher char(4) )";
                //cmd.CommandText = "CREATE TABLE IF NOT EXISTS t1(id varchar(4),score int)";
              
       
                cmd.ExecuteNonQuery();
            }
            sQLiteConnection.Close();
        }
    }
}
