using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace QuanLyTraChanh
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        //Tạo kết nối mới đến cơ sở dữ liệu SQL Server
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLTC;Integrated Security=True;MultipleActiveResultSets=true");

        //Tạo đối tượng mã hoá MD5
        MD5 md = MD5.Create();

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void frmDoiMatKhau_FormClosing(object sender, FormClosingEventArgs e)
        {
            var frmDangNhap = new frmDangNhap();
            //Đóng kết nối db
            conn.Close();

            frmDangNhap.Show();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            try
            {
                //Mở kết nối
                conn.Open();

                string taiKhoan = tbNhapMaNV.Text;
                string matKhauCu = tbNhapMKCu.Text;
                string matKhauMoi = tbNhapMKMoi.Text;
                string matKhauMoi2 = tbNhapLaiMKMoi.Text;

                //Mã hoá MD5 mật khẩu cũ nhập vào
                byte[] encryptPass = System.Text.Encoding.ASCII.GetBytes(matKhauCu);
                byte[] hash = md.ComputeHash(encryptPass);
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X"));
                }
                string matKhauCuEncrypted = sb.ToString();

                //Mã hoá MD5 mật khẩu mới
                byte[] encryptNewPass = System.Text.Encoding.ASCII.GetBytes(matKhauMoi);
                byte[] hashNewPass = md.ComputeHash(encryptNewPass);
                StringBuilder sb1 = new StringBuilder();
                for (int i = 0; i < hashNewPass.Length; i++)
                {
                    sb1.Append(hashNewPass[i].ToString("X"));
                }
                string matKhauMoiEncrypted = sb1.ToString();

                //Lấy Mã NV và mật khẩu được mã hoá từ db để kiểm tra
                string sql = "SELECT * FROM NHANVIEN WHERE MaNV = '" + taiKhoan + "' and MatKhau = '" + matKhauCuEncrypted + "'";

                SqlCommand cmd = new SqlCommand(sql, conn);
                //Tạo đối tượng đọc dữ liệu
                SqlDataReader data = cmd.ExecuteReader();
                //Nếu đọc được đúng dư liệu
                if(data.Read() == true)
                {
                    //Nếu nhập lại mật khẩu mới giống mật khẩu mới
                    if(matKhauMoi2 == matKhauMoi)
                    {
                        //Đổi mật khẩu
                        string sqlUpdate = "UPDATE NHANVIEN SET MatKhau = '" + matKhauMoiEncrypted + "' WHERE MaNV = '" + taiKhoan + "'";

                        //Thực thi câu lệnh sử dụng đối tượng SQL Command
                        SqlCommand cmdUpdate = new SqlCommand(sqlUpdate,conn);
                        cmdUpdate.ExecuteNonQuery();

                        //Hiển thị thông báo
                        MessageBox.Show("Đổi mật khẩu thành công!");
                        //Ẩn trang đổi mật khẩu
                        this.Hide();
                        //Đóng kết nối db
                        conn.Close();
                        //Hiển thị trang đăng nhập
                        var frmDangNhap = new frmDangNhap();
                        frmDangNhap.Show();
                    }   
                    //Nếu khác
                    if(matKhauMoi2 != matKhauMoi)
                    {
                        MessageBox.Show("Vui lòng kiểm tra nhập lại mật khẩu mới!");
                        //Đóng kết nối database để kết nối lại
                        conn.Close();
                    }    
                }   
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại tài khoản hoặc mật khẩu cũ!");
                    //Đóng kết nối database để kết nối lại
                    conn.Close();
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
        }
    }
}
