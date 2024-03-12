using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A4_Net
{
    internal class Modify
    {
        public Modify() { }

        SqlDataAdapter dataAdapter;
        SqlCommand sqlCommand;

        public DataTable Table(string truyvan)
        {
            DataTable datatable = new DataTable();

            using (SqlConnection sqlConnection = connection.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(truyvan, sqlConnection);
                dataAdapter.Fill(datatable);
                sqlConnection.Close();
            }

            return datatable;
        }



        public void command(string truyvan)
        {
            using (SqlConnection sqlConnection = connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(truyvan, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        public string checkHD(string truyvan)
        {
            using (SqlConnection sqlConnection = connection.GetSqlConnection())
            {
                sqlConnection.Open();
                try
                {
                    using (SqlCommand sqlCommand = new SqlCommand(truyvan, sqlConnection))
                    {
                        object result = sqlCommand.ExecuteScalar();

                        // Kiểm tra kết quả null (không có hàng hoặc nhiều hàng)
                        if (result == null)
                        {
                            return "NULL"; // Cho biết không tìm thấy giá trị cuối cùng
                        }

                        return result.ToString(); // Chuyển đổi sang chuỗi nếu cần thiết
                    }
                }
                catch (SqlException ex)
                {
                    // Xử lý lỗi SQL tiềm ẩn một cách lịch sự (ví dụ: ghi nhật ký)
                    Console.WriteLine($"Lỗi khi thực thi truy vấn: {ex.Message}");
                    return null; // Cho biết lỗi
                }
                finally
                {
                    sqlConnection.Close(); // Đảm bảo kết nối được đóng
                }
            }
        }
        public string getHoaDonCuoi(string truyvan) // Đặt tên hàm mô tả hơn
        {
            using (SqlConnection sqlConnection = connection.GetSqlConnection())
            {
                sqlConnection.Open();

                // Thực thi truy vấn với xử lý lỗi phù hợp
                try
                {
                    using (SqlCommand sqlCommand = new SqlCommand(truyvan, sqlConnection))
                    {
                        object result = sqlCommand.ExecuteScalar();

                        // Kiểm tra kết quả null (không có hàng hoặc nhiều hàng)
                        if (result == null)
                        {
                            return null; // Cho biết không tìm thấy giá trị cuối cùng
                        }

                        return result.ToString(); // Chuyển đổi sang chuỗi nếu cần thiết
                    }
                }
                catch (SqlException ex)
                {
                    // Xử lý lỗi SQL tiềm ẩn một cách lịch sự (ví dụ: ghi nhật ký)
                    Console.WriteLine($"Lỗi khi thực thi truy vấn: {ex.Message}");
                    return null; // Cho biết lỗi
                }
                finally
                {
                    sqlConnection.Close(); // Đảm bảo kết nối được đóng
                }
            }
        }
    }
}
