using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer
{
    public class Connection
    {
        public OleDbConnection GetConnection()
        {
            string pathcon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/sdalvi/Desktop/data1.xls;Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(pathcon);
            return conn;
        }
    }
}
