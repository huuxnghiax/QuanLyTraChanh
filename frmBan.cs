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

namespace QuanLyTraChanh
{
    public partial class frmBan : Form
    {
        //Khai báo các biến toàn cục
        SqlConnection conn;//Khai báo đối tượng thực hiện kết nối đến cơ sở dữ liệu
        SqlCommand cmd;//Khai báo đối tượng thực hiện các câu lệnh truy vấn
        SqlDataAdapter dap;//Khai báo đối tượng gắn kết DataSource với DataSet
        DataSet ds;//Đối tượng chứa dữ liệu tại local

        public frmBan()
        {
            InitializeComponent();
        }

        private void frmBan_Load(object sender, EventArgs e)
        {
            //Tạo đối tượng connection
            conn = new SqlConnection();
            //Tạo kết nối mới đến cơ sở dữ liệu SQL Server
            conn.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLTC;Integrated Security=True; MultipleActiveResultSets=True;";
            //Gọi phương thức load dữ liệu
            LoadDuLieu("SELECT * FROM BAN");
            //Khi Form mới Load lên thì ẩn các bút Sửa và Xóa
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            //Ẩn group box chi tiết
            HienChiTiet(false);

            //Cung cấp datasource cho combobox trạng thái
            String[] trangThai = new String[]{"Chưa có người ngồi", "Đã có người ngồi"};
            cboTrangThai.DataSource = trangThai;

        }
        //Phương thức Load dữ liệu từ database
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
            dgvKetQua.Columns["MaBan"].HeaderText = "Mã bàn";
            dgvKetQua.Columns["TenBan"].HeaderText = "Tên bàn";
            dgvKetQua.Columns["TrangThai"].HeaderText = "Trạng thái";
            dgvKetQua.Columns["KhuVuc"].HeaderText = "Khu vực";
        }

        //Phương thức ẩn hiện các control ở groupbox chi tiết
        private void HienChiTiet(Boolean hien)
        {
            tbMaBan.Enabled = hien;
            tbTenBan.Enabled = hien;
            cboTrangThai.Enabled = hien;
            tbKhuVuc.Enabled = hien;

            //Ẩn hiện 3 nút lưu và huỷ và thêm mới
            btnHuy.Enabled = hien;
            btnLuu.Enabled = hien;
            btnThemMoi.Enabled = hien;
        }
        //Xoá trắng groupbox chi tiết nhân viên
        private void XoaTrangChiTiet()
        {
            tbMaBan.Clear();
            tbTenBan.Clear();
            cboTrangThai.ResetText();
            tbKhuVuc.Clear();
        }

        //Sự kiện ấn nút thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "Thêm bàn";

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

        //Sự kiện ấn nút sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            //Hiện thông tin chi tiết
            HienChiTiet(true);
        }
        //Sự kiện ấn nút xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "Xoá bàn";
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            //Hiện gropbox chi tiết
            HienChiTiet(true);

            //Hiện MessageBox cảnh báo
            if (MessageBox.Show("Bạn có chắc chắn xóa bàn mã " + tbMaBan.Text + " không?", "Xoá bàn", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Mở kết nối db
                conn.Open();

                //Tạo câu lệnh truy vấn DELETE
                String sqlDelete = "DELETE FROM BAN WHERE MaBan = '" + tbMaBan.Text + "'";
                //Thực thi câu lệnh sử dụng đối tượng command
                cmd = new SqlCommand(sqlDelete, conn);
                cmd.ExecuteNonQuery();

                //Hiện thông báo
                MessageBox.Show("Xóa thành công!");

                //Làm mới lại bảng data grid view
                LoadDuLieu("SELECT * FROM BAN");

                conn.Close();
            }

        }
        //Sự kiện ấn nút thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            //Làm mới lại bảng data grid view
            LoadDuLieu("SELECT * FROM BAN");
        }

        //Sự kiện ấn nút thêm mới
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            //Hiện MessageBox cảnh báo
            if (MessageBox.Show("Bạn có chắc chắn thêm bàn mã " + tbMaBan.Text + " không?", "Thêm bàn", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    //Mở kết nối
                    conn.Open();

                    bool trangThaiMoi;
                    if (cboTrangThai.Text == "Chưa có người ngồi") trangThaiMoi = false;
                    else trangThaiMoi = true;

                    //Tạo câu lệnh truy vấn
                    String sqlInsert = "INSERT INTO BAN(MaBan,TenBan,TrangThai,KhuVuc) VALUES(";
                    sqlInsert += "'" + tbMaBan.Text + "',N'" + tbTenBan.Text + "',N'" + trangThaiMoi + "',N'" + tbKhuVuc.Text + "')";
                    //Thực thi câu lệnh sử dụng đối tượng command
                    cmd = new SqlCommand(sqlInsert, conn);
                    cmd.ExecuteNonQuery();

                    //Hiện thông báo
                    MessageBox.Show("Thêm thành công!");

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message);
                    //Đóng kết nối để kết nối lại
                    conn.Close();
                }

                //Làm mới lại bảng data grid view
                LoadDuLieu("SELECT * FROM BAN");
            }
        }
        //Sự kiện ấn nút lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn cập nhật bàn mã " + tbMaBan.Text + " không?", "Lưu bàn", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    //Mở kết nối
                    conn.Open();

                    bool trangThaiMoi;
                    if (cboTrangThai.Text == "Chưa có người ngồi") trangThaiMoi = false;
                    else trangThaiMoi = true;

                    //Tạo câu lệnh truy vấn
                    String sqlUpdate = "UPDATE BAN SET " +
                        "TenBan = N'" + tbTenBan.Text + "'," +
                        "TrangThai = '" + trangThaiMoi + "'," +
                        "KhuVuc = N'" + tbKhuVuc.Text + "'" +
                        "WHERE MaBan = '" + tbMaBan.Text + "'";

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
                LoadDuLieu("SELECT * FROM BAN");
            }
        }
        //Sự kiện ấn nút hủy
        private void btnHuy_Click(object sender, EventArgs e)
        {
            XoaTrangChiTiet();
        }

        //Khi người dùng click vào data grid view
        private void dgvKetQua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Hien thi nut sửa và xoá
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;

            //Bắt lỗi khii người sử dụng kích linh tinh lên datagrid
            try
            {
                string trangThaiBan = "";
                if (dgvKetQua["TrangThai", e.RowIndex].Value.ToString() == "False")
                {
                    trangThaiBan = "Chưa có người ngồi";
                }
                else trangThaiBan = "Đã có người ngồi";
                //Tham số thứ nhất của dgv có thể là số cột hoặc là tên cột
                tbMaBan.Text = dgvKetQua["MaBan", e.RowIndex].Value.ToString();
                tbTenBan.Text = dgvKetQua["TenBan", e.RowIndex].Value.ToString();
                cboTrangThai.Text = trangThaiBan;
                tbKhuVuc.Text = dgvKetQua["KhuVuc", e.RowIndex].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
                conn.Close();
            }
        }
    }
}
