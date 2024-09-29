using QuanLySanPham.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanPham.DAL
{
    public class SanPhamDAL
    {
        private string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=CuaHang;Integrated Security=True;Encrypt=False";


        //Lay tat ca san pham
        public List<SanPham> GetAll()
        {
            List<SanPham> sanPhams = new List<SanPham>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM SanPham";
                SqlCommand cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        SanPham sp = new SanPham
                        {
                            MaSanPham = reader["MaSanPham"].ToString(),
                            TenSanPham = reader["TenSanPham"].ToString(),
                            SoLuong = Convert.ToInt32(reader["SoLuong"]),
                            DonGia = Convert.ToInt32(reader["DonGia"]),
                            XuatXu = reader["XuatXu"].ToString(),
                            NgayHetHan = reader["NgayHetHan"] as DateTime?
                        };
                        sanPhams.Add(sp);
                    }
                }
            }

            return sanPhams;
        }

        //Them san pham
        public void Add(SanPham sanPham)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO SanPham (MaSanPham, TenSanPham, SoLuong, DonGia, XuatXu, NgayHetHan) VALUES (@MaSanPham, @TenSanPham, @SoLuong, @DonGia, @XuatXu, @NgayHetHan)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@MaSanPham", sanPham.MaSanPham);
                cmd.Parameters.AddWithValue("@TenSanPham", sanPham.TenSanPham);
                cmd.Parameters.AddWithValue("@SoLuong", sanPham.SoLuong);
                cmd.Parameters.AddWithValue("@DonGia", sanPham.DonGia);
                cmd.Parameters.AddWithValue("@XuatXu", sanPham.XuatXu);
                cmd.Parameters.AddWithValue("@NgayHetHan", sanPham.NgayHetHan);

                cmd.ExecuteNonQuery();
            }
        }

        //Xoa san Pham
        public bool Delete(string MaSP)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM SanPham WHERE MaSanPham = @MaSanPham";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSanPham", MaSP);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public bool DeleteAll()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM SanPham";
                SqlCommand cmd = new SqlCommand(query, conn);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public bool DeleteExpired()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM SanPham WHERE NgayHetHan < @CurrentDate";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@CurrentDate", DateTime.Now);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
}
