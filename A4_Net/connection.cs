using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace A4_Net
{
    internal class connection
    {
        public static string chuoiketnoi = @"Data Source=DESKTOP-PAD99D1\SQLEXPRESS;Initial Catalog=QuanLyPhongGym;Integrated Security=True";
        public static SqlConnection GetSqlConnection() {
            return new SqlConnection(chuoiketnoi);
        }
    }
}
//Data Source=DESKTOP-PAD99D1\SQLEXPRESS;Initial Catalog=QuanLyPhongGym;Integrated Security=True  // kieuanh
//Data Source=DESKTOP-8IR3320\SQLEXPRESS;Initial Catalog=QuanLyPhongGym;Integrated Security=True //hoanganh