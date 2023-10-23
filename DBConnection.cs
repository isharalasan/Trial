using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp11
{
    internal class DBConnection
    {
        SqlConnection con;
        SqlCommand cmd;

        public DBConnection() //Defualt constractor
        { 
            con= new SqlConnection("Data Source=DESKTOP-SVG83P9\\ISHARA;Initial Catalog=bank;Integrated Security=True");// view+server Explorer
        }
        public int Save_Update_Delete(String q) 
        {
            con.Open();
            cmd = new SqlCommand(q,con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public DataTable Display(String q)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(q,con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
