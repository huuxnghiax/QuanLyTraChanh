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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        //Tạo kết nối mới đến cơ sở dữ liệu SQL Server
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLTC;Integrated Security=True; MultipleActiveResultSets=True;");

        //Tạo đối tượng mã hoá MD5
        MD5 md = MD5.Create();
        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                //Mở kết nối
                conn.Open();
                string taiKhoan = tbTaiKhoan.Text;
                string matKhau = tbMatKhau.Text;

                //Mã hoá MD5 mật khẩu nhập vào
                byte[] encryptPass = System.Text.Encoding.ASCII.GetBytes(matKhau);
                byte[] hash = md.ComputeHash(encryptPass);
                StringBuilder sb = new StringBuilder();

                for(int i=0; i<hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X"));
                }
                string encryptedPass = sb.ToString();

                //Lấy Mã NV và mật khẩu được mã hoá từ db để kiểm tra
                string sqlNhanVien = "SELECT * FROM NHANVIEN WHERE MaNV = '"+taiKhoan+"' and MatKhau = '"+encryptedPass+ "' and PhanQuyen = 'False'";
                string sqlAdmin = "SELECT * FROM NHANVIEN WHERE MaNV = '" + taiKhoan + "' and MatKhau = '" + encryptedPass + "' and PhanQuyen = 'True'";

                SqlCommand cmdNhanVien = new SqlCommand(sqlNhanVien, conn);
                SqlCommand cmdAdmin = new SqlCommand(sqlAdmin, conn);
                
                //Tạo đối tượng đọc dữ liệu
                SqlDataReader dataNhanVien = cmdNhanVien.ExecuteReader();
                SqlDataReader dataAdmin = cmdAdmin.ExecuteReader();


                //Nếu đọc được đúng dư liệu
                if (dataNhanVien.Read() == true)
                {
                    MessageBox.Show("Bạn đã đăng nhập với quyền nhân viên!");

                    //Mở trang quản lý và truyền vào tham số
                    var frmTrangQuanLy = new frmTrangQuanLy("nhanVien");
                    frmTrangQuanLy.Show();
                   
                    //Ẩn trang đăng nhập
                    this.Hide();
                }    
                else if(dataAdmin.Read() == true)
                {
                    MessageBox.Show("Bạn đã đăng nhập với quyền quản trị!");

                    //Mở trang quản lý và truyền vào tham số
                    var frmTrangQuanLy = new frmTrangQuanLy("Admin");
                    frmTrangQuanLy.Show();

                    //Ẩn trang đăng nhập
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!");
                    //Đóng kết nối để đăng nhập lại
                    conn.Close();
                }    
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        //Gửi tài khoản đi form khác

        private void btnThoat_Click(object sender, EventArgs e)
        {
            conn.Close();
            Application.Exit();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            //Tạo đối tượng form đổi mật khẩu
            var frmDoiMatKhau = new frmDoiMatKhau();

            //Ẩn đi trang đăng nhập
            this.Hide();
            //Hiện trang đổi mật khẩu
            frmDoiMatKhau.Show();
        }

        private void frmDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
