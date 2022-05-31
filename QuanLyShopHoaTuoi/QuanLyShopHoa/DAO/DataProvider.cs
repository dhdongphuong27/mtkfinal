using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace QuanLyCuaHangTienLoi.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        String connString = @"server=sql6.freemysqlhosting.net;port=3306;database=sql6495204;uid=sql6495204;pwd=LbPVLAx5wm;Allow Zero Datetime=True";
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() {}

        public DataTable ExcuteQuery(string query)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);
            DataTable data = new DataTable();

            data.Load(cmd.ExecuteReader());
            conn.Close();
            return data;
        }

        public int ExcuteNonQuery(string query)
        {
            int data=0;
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);
            data = cmd.ExecuteNonQuery();
            conn.Close();
            return data;
        }

        public string ExcuteScalar(string query)
        {
            string data;

            

            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);
            data = cmd.ExecuteScalar().ToString();
            conn.Close();
            return data;
        }

    }
}
