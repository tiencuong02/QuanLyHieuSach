using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyHieuSach
{
    public class DataProvider
    {
        string strCon = @"Data Source=Admin-PC\\SQLEXPRESS;Initial Catalog=QuanLyHieuSach;Integrated Security=True;Trust Server Certificate=True";

        //Doi tuong ket noi
        SqlConnection sqlCon = null;

        public DataTable ExecQuery(string query)
        {
            DataTable data = new DataTable();

            using ( sqlCon = new SqlConnection(strCon))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataAdapter adapter = new SqlDataAdapter(Cmd);

                adapter.Fill(data);

                con.Close();
            }    
            return data;    
        }

        public int execNonQuery(string query)
        {
            int data = 0;
            using (sqlCon = new sqlConnection(connectString)) ;
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);

                data = cmd.ExecuteNonQuery();

                con.Close();
            }
            return data;
        }

        public object execScaler(string query)
        {
            object data = 0;
            using ( sqlCon = new SqlConnection(connectString))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);

                data = cmd.ExecuteScalar();

                con.Close();
            }    
            return data;
        }
    }
}
