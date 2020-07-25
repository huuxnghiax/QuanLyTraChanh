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
    public partial class frmNhanVien : Form
    {
        //Khai báo các biến toàn cục
        SqlConnection conn;//Khai báo đối tượng thực hiện kết nối đến cơ sở dữ liệu
        SqlCommand cmd;//Khai báo đối tượng thực hiện các câu lệnh truy vấn
        SqlDataAdapter dap;//Khai báo đối tượng gắn kết DataSource với DataSet
        DataSet ds;//Đối tượng chứa dữ liệu tại local

        string getPass = "";

        //Tạo đối tượng mã hoá MD5
        MD5 md = MD5.Create();

        public frmNhanVien()
        {
            InitializeComponent();
        }
        
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            //Tạo đối tượng connection
            conn = new SqlConnection();
            //Tạo kết nối mới đến cơ sở dữ liệu SQL Server
            conn.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLTC;Integrated Security=True; MultipleActiveResultSets=True;";

            //Gọi phương thức load dữ liệu
            LoadDuLieu("SELECT * FROM NHANVIEN");
            //Khi Form mới Load lên thì ẩn các bút Sửa và Xóa
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            //Ẩn group box chi tiết
            HienChiTiet(false);

        }

        private void LoadDuLieu(String sql)
        {
            //tạo đối tượng DataSet
            ds = new DataSet();
            //Khởi tạo đối tượng DataAdapter và cung cấp vào câu lệnh SQL và đối tượng Connection
            dap = new SqlDataAdapter(sql, conn);
            //Dùng phương thức Fill của DataAdapter để đổ dữ liệu từ DataSource tới DataSet
            dap.Fill(ds);

            //Gắn dữ liệu từ DataSet lên DataGridView
            dgvKetQua.DataSource = ds.Tables[0];

            //Gắn dữ liệu ngày vào làm tối đa là ngày hôm nay
            dtpNgayVaoLam.MaxDate = DateTime.Today;
        }

        //Phương thức ẩn hiện các control ở groupbox chi tiết
        private void HienChiTiet(Boolean hien)
        {
            tbMaNV.Enabled = hien;
            tbTenNV.Enabled = hien;
            tbGioiTinh.Enabled = hien;
            tbChucVu.Enabled = hien;
            dtpNgayVaoLam.Enabled = hien;
            tbDiaChi.Enabled = hien;
            tbSDT.Enabled = hien;
            chkAdmin.Enabled = hien;
            tbMatKhau.Enabled = hien;

            //Ẩn hiện 3 nút lưu và huỷ và thêm mới
            btnHuy.Enabled = hien;
            btnLuu.Enabled = hien;
            btnThemMoiNV.Enabled = hien;
            
        }
        //Xoá trắng groupbox chi tiết nhân viên
        private void XoaTrangChiTiet()
        {
            tbMaNV.Clear();
            tbTenNV.Clear();
            tbGioiTinh.Clear();
            tbChucVu.Clear();
            dtpNgayVaoLam.Value = DateTime.Today ;
            tbDiaChi.Clear();
            tbSDT.Clear();
            chkAdmin.Checked = false;
            tbMatKhau.Clear();
        }

        //Sự kiện ấn nút thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "Thêm nhân viên";

            //Xoá trắng groupbox chi tiết nhân viên
            XoaTrangChiTiet();
            //Cấm nút sửa xoá
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            //Hiện groupbox chi tiết
            HienChiTiet(true);

            //Hiện nút Lưu và huỷ
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
        }

        //Sư kiện khi người dùng chọn một hàng trên DataGridView
        private void dgvKetQua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Hien thi nut sửa và xoá
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;

            //Bắt lỗi khi người sử dụng kích linh tinh lên datagrid
            try
            {
                //Tham số thứ nhất của dgv có thể là số cột hoặc là tên cột
                tbMaNV.Text = dgvKetQua["MaNV", e.RowIndex].Value.ToString();
                tbTenNV.Text = dgvKetQua["TenNV", e.RowIndex].Value.ToString();
                if ((Boolean)dgvKetQua["GioiTinh", e.RowIndex].Value == false) tbGioiTinh.Text = "Nam";
                else tbGioiTinh.Text = "Nữ";
                tbChucVu.Text = dgvKetQua["ChucVu", e.RowIndex].Value.ToString();
                dtpNgayVaoLam.Value = (DateTime)dgvKetQua["NgayVaoLam", e.RowIndex].Value;
                tbDiaChi.Text = dgvKetQua["DiaChi", e.RowIndex].Value.ToString();
                tbSDT.Text = "0"+dgvKetQua["SDT", e.RowIndex].Value.ToString();
                if ((Boolean)dgvKetQua["PhanQuyen", e.RowIndex].Value == true) chkAdmin.Checked = true;
                else chkAdmin.Checked = false;
                tbMatKhau.Text = dgvKetQua["MatKhau", e.RowIndex].Value.ToString();

                //Lấy password để check khi lưu lại nhân viên không bị encrypt tiếp mật khẩu
                getPass = dgvKetQua["MatKhau", e.RowIndex].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);

                //Đóng kết nối
                conn.Close();
            }

        }
        //Sự kiện ấn nút sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            //Hiện thông tin chi tiết
            HienChiTiet(true);
        }
        //Sự kiện Click của nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "Xoá nhân viên";
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            //Hiện gropbox chi tiết
            HienChiTiet(true);

            //Hiện MessageBox cảnh báo
            if (MessageBox.Show("Bạn có chắc chắn xóa nhân viên mã " + tbMaNV.Text + " không?", "Xoá nhân viên", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    //Mở kết nối db
                    conn.Open();

                    //Tạo câu lệnh truy vấn DELETE
                    String sqlDelete = "DELETE FROM NHANVIEN WHERE MaNV = '" + tbMaNV.Text + "'";
                    //Thực thi câu lệnh sử dụng đối tượng command
                    cmd = new SqlCommand(sqlDelete, conn);
                    cmd.ExecuteNonQuery();

                    //Làm mới lại bảng data grid view
                    LoadDuLieu("SELECT * FROM NHANVIEN");

                    //Đóng kết nối
                    conn.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message);

                    conn.Close();
                }
            }    
        }

        //Sự kiện ấn nút huỷ
        private void btnHuy_Click(object sender, EventArgs e)
        {
            XoaTrangChiTiet();
        }

        //Sự kiện ấn nút lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn cập nhật nhân viên mã " + tbMaNV.Text + " không?", "Lưu nhân viên", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Chuyển đổi kiểu phân quyền
                bool checkPhanQuyen = false;
                if (chkAdmin.Checked == true)
                    checkPhanQuyen = true;
                //Chuyển đổi kiểu giới tính
                bool checkGioiTinh = false;
                if (tbGioiTinh.Text == "Nam") checkGioiTinh = false;
                else if (tbGioiTinh.Text == "Nữ") checkGioiTinh = true;
                else
                {
                    MessageBox.Show("Vui lòng nhập 'Nam' hoặc 'Nữ'");
                    tbGioiTinh.Clear();
                }
                //Chuyển đổi số điện thoại
                if (tbSDT.Text.Length > 10)
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại từ 10 số trở xuống và đầu số 0");
                    tbSDT.Clear();
                }

                try
                {
                    //Mở kết nối
                    conn.Open();

                    string encryptedPass = "";

                    //Đề phòng mật khẩu mới bị mã hoá
                    //Nếu mật khẩu trong textbox không bị trùng
                    if (tbMatKhau.Text != getPass)
                    {
                        //Lấy mật khẩu từ textbox mật khẩu
                        string matKhau = tbMatKhau.Text;
                        //Mã hoá MD5 mật khẩu nhập vào
                        byte[] encryptPass = System.Text.Encoding.ASCII.GetBytes(matKhau);
                        byte[] hash = md.ComputeHash(encryptPass);
                        StringBuilder sb = new StringBuilder();
                        for (int i = 0; i < hash.Length; i++)
                        {
                            sb.Append(hash[i].ToString("X"));
                        }
                        //Lấy mật khẩu đã được mã hoá
                        encryptedPass = sb.ToString();
                    }
                    //Nếu bị trùng thì lấy mật khẩu đã mã hoá
                    else
                    {
                        encryptedPass = tbMatKhau.Text;
                    }    

                    //Chuyển đổi ngày tháng
                    string strDate = dtpNgayVaoLam.Value.Date.ToString("yyyy-MM-dd");

                    //Tạo câu lệnh truy vấn
                    String sqlUpdate = "UPDATE NHANVIEN SET " +
                        "TenNV = N'" + tbTenNV.Text + "'," +
                        "GioiTinh = '" + checkGioiTinh + "'," +
                        "ChucVu = N'" + tbChucVu.Text + "'," +
                        "NgayVaoLam = '" + strDate + "'," +
                        "DiaChi = N'" + tbDiaChi.Text + "'," +
                        "SDT = '" + Convert.ToInt32(tbSDT.Text) + "'," +
                        "PhanQuyen = '" + checkPhanQuyen + "'," +
                        "MatKhau = '" + encryptedPass + "'" +
                        "WHERE MaNV = '" + tbMaNV.Text + "'";

                    //Thực thi câu lệnh sử dụng đối tượng command
                    cmd = new SqlCommand(sqlUpdate, conn);
                    cmd.ExecuteNonQuery();

                    //Hiện thông báo
                    MessageBox.Show("Sửa thành công!");

                    //Đóng kết nối
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message);
                    //Đóng kết nối để kết nối lại
                    conn.Close();
                }

                //Làm mới lại bảng data grid view
                LoadDuLieu("SELECT * FROM NHANVIEN");
            }    
        }
        //Sự kiện ấn nút thêm mới
        private void btnThemMoiNV_Click(object sender, EventArgs e)
        {
            //Hiện MessageBox cảnh báo
            if (MessageBox.Show("Bạn có chắc chắn thêm nhân viên mã " + tbMaNV.Text + " không?", "Thêm nhân viên", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Chuyển đổi kiểu phân quyền
                bool checkPhanQuyen = false;
                if (chkAdmin.Checked == true)
                    checkPhanQuyen = true;
                //Chuyển đổi kiểu giới tính
                bool checkGioiTinh = false;
                if (tbGioiTinh.Text == "Nam") checkGioiTinh = false;
                else if (tbGioiTinh.Text == "Nữ") checkGioiTinh = true;
                else
                {
                    MessageBox.Show("Vui lòng nhập 'Nam' hoặc 'Nữ'");
                    tbGioiTinh.Clear();
                }
                //Chuyển đổi số điện thoại
                if (tbSDT.Text.Length > 10)
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại từ 10 số trở xuống và đầu số 0");
                    tbSDT.Clear();
                }



                try
                {
                    //Mở kết nối
                    conn.Open();
                    //Lấy mật khẩu từ textbox mật khẩu
                    string matKhau = tbMatKhau.Text;
                    //Mã hoá MD5 mật khẩu nhập vào
                    byte[] encryptPass = System.Text.Encoding.ASCII.GetBytes(matKhau);
                    byte[] hash = md.ComputeHash(encryptPass);
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < hash.Length; i++)
                    {
                        sb.Append(hash[i].ToString("X"));
                    }
                    //Lấy mật khẩu đã được mã hoá
                    string encryptedPass = sb.ToString();
                    //Chuyển đổi ngày tháng
                    string strDate = dtpNgayVaoLam.Value.Date.ToString("yyyy-MM-dd");

                    //Tạo câu lệnh truy vấn
                    String sqlInsert = "INSERT INTO NHANVIEN(MaNV,TenNV,GioiTinh,ChucVu,NgayVaoLam,DiaChi,SDT,PhanQuyen,MatKhau) VALUES(";
                    sqlInsert += "'"+tbMaNV.Text+"',N'"+tbTenNV.Text+"','"+checkGioiTinh+"',N'"+tbChucVu.Text+"','"+ strDate + "',N'"+tbDiaChi.Text+"','"+Convert.ToInt32(tbSDT.Text)+"','"+checkPhanQuyen+"','"+encryptedPass+"')"; 
                    //Thực thi câu lệnh sử dụng đối tượng command
                    cmd = new SqlCommand(sqlInsert, conn);
                    cmd.ExecuteNonQuery();

                    //Hiện thông báo
                    MessageBox.Show("Thêm thành công!");

                    //Đóng kết nối
                    conn.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message);
                    //Đóng kết nối để kết nối lại
                    conn.Close();
                }

                //Làm mới lại bảng data grid view
                LoadDuLieu("SELECT * FROM NHANVIEN");
            }
        }

        //Sự kiện ấn nút làm mới
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDuLieu("SELECT * FROM NHANVIEN");
        }

        //Sự kiện tick ô hiện mật khẩu
        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienMatKhau.Checked == true)
                tbMatKhau.UseSystemPasswordChar = false;
            else
                tbMatKhau.UseSystemPasswordChar = true;
        }

        //Sự kiện ấn nút thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
