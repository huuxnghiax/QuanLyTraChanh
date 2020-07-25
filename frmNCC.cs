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
    public partial class frmNCC : Form
    {
        //Khai báo các biến toàn cục
        SqlConnection conn;//Khai báo đối tượng thực hiện kết nối đến cơ sở dữ liệu
        SqlCommand cmd;//Khai báo đối tượng thực hiện các câu lệnh truy vấn
        SqlDataAdapter dap;//Khai báo đối tượng gắn kết DataSource với DataSet
        DataSet ds;//Đối tượng chứa dữ liệu tại local

        public frmNCC()
        {
            InitializeComponent();
        }

        private void frmNCC_Load(object sender, EventArgs e)
        {
            //Tạo đối tượng connection
            conn = new SqlConnection();
            //Tạo kết nối mới đến cơ sở dữ liệu SQL Server
            conn.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLTC;Integrated Security=True; MultipleActiveResultSets=True;";

            //Gọi phương thức load dữ liệu
            LoadDuLieu("SELECT * FROM NHACUNGCAP");

            //Khi Form mới Load lên thì ẩn các bút Sửa và Xóa
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            //Ẩn group box chi tiết
            HienChiTiet(false);
        }

        //Phương thức LoadDuLieu
        private void LoadDuLieu(String sql)
        {
            //tạo đối tượng DataSet
            ds = new DataSet();
            //Khởi tạo đối tượng DataAdapter và cung cấp vào câu lệnh SQL và đối tượng Connection
            dap = new SqlDataAdapter(sql, conn);
            //Dùng phương thức Fill của DataAdapter để đổ dữ liệu từ DataSource tới DataSet
            dap.Fill(ds);

            //Gắn dữ liệu từ DataSet lên DataGridView
            dgvKetQuaNCC.DataSource = ds.Tables[0];
        }

        //Phương thức ẩn hiện các control ở groupbox chi tiết
        private void HienChiTiet(Boolean hien)
        {
            tbMaNCC.Enabled = hien;
            tbTenNCC.Enabled = hien;
            tbDiaChi.Enabled = hien;
            tbSDT.Enabled = hien;

            //Ẩn hiện 3 nút lưu và huỷ và thêm mới
            btnHuy.Enabled = hien;
            btnLuu.Enabled = hien;
            btnThemMoiNCC.Enabled = hien;
        }

        //Xoá trắng groupbox chi tiết nhân viên
        private void XoaTrangChiTiet()
        {
            tbMaNCC.Clear();
            tbTenNCC.Clear();
            tbDiaChi.Clear();
            tbSDT.Clear();
        }

        //Sự kiện ấn nút thêm
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            lblTieuDe.Text = "Thêm nhà cung cấp";

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
        private void dgvKetQuaNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Hien thi nut sửa và xoá
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;

            //Bắt lỗi khii người sử dụng kích linh tinh lên datagrid
            try
            {
                //Tham số thứ nhất của dgv có thể là số cột hoặc là tên cột
                tbMaNCC.Text = dgvKetQuaNCC["MaNCC", e.RowIndex].Value.ToString();
                tbTenNCC.Text = dgvKetQuaNCC["TenNCC", e.RowIndex].Value.ToString();
                tbDiaChi.Text = dgvKetQuaNCC["DiaChi", e.RowIndex].Value.ToString();
                tbSDT.Text = "0"+dgvKetQuaNCC["SDT", e.RowIndex].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
                conn.Close();
            }
        }

        //Sự kiện ấn nút thêm mới
        private void btnThemMoiNCC_Click(object sender, EventArgs e)
        {
            //Hiện MessageBox cảnh báo
            if (MessageBox.Show("Bạn có chắc chắn thêm nhà cung cấp mã " + tbMaNCC.Text + " không?", "Thêm nhà cung cấp", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
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

                    //Tạo câu lệnh truy vấn
                    String sqlInsert = "INSERT INTO NHACUNGCAP(MaNCC,TenNCC,DiaChi,SDT) VALUES(";
                    sqlInsert += "'" + tbMaNCC.Text + "',N'" + tbTenNCC.Text + "',N'" + tbDiaChi.Text + "','" + Convert.ToInt32(tbSDT.Text) + "')";
                    //Thực thi câu lệnh sử dụng đối tượng command
                    cmd = new SqlCommand(sqlInsert, conn);
                    cmd.ExecuteNonQuery();

                    //Hiện thông báo
                    MessageBox.Show("Thêm thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message);
                    //Đóng kết nối để kết nối lại
                    conn.Close();
                }

                //Làm mới lại bảng data grid view
                LoadDuLieu("SELECT * FROM NHACUNGCAP");
            }
        }
        
        //Sự kiện ấn nút sửa
        private void btnSua_Click_1(object sender, EventArgs e)
        {
            //Hiện thông tin chi tiết
            HienChiTiet(true);
        }

        //Sự kiện ấn nút xóa
        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            lblTieuDe.Text = "Xoá nhà cung cấp";
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            //Hiện gropbox chi tiết
            HienChiTiet(true);

            //Hiện MessageBox cảnh báo
            if (MessageBox.Show("Bạn có chắc chắn xóa NCC mã " + tbMaNCC.Text + " không?", "Xoá nhà cung cấp", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Mở kết nối db
                conn.Open();

                //Tạo câu lệnh truy vấn DELETE
                String sqlDelete = "DELETE FROM NHACUNGCAP WHERE MaNCC = '" + tbMaNCC.Text + "'";
                //Thực thi câu lệnh sử dụng đối tượng command
                cmd = new SqlCommand(sqlDelete, conn);
                cmd.ExecuteNonQuery();

                //Hiện thông báo
                MessageBox.Show("Xóa thành công!");


                //Làm mới lại bảng data grid view
                LoadDuLieu("SELECT * FROM NHACUNGCAP");
            }
        }

        //Sự kiện ấn nút thoát
        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        //Sự kiện ấn nút làm mới
        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            //Làm mới lại bảng data grid view
            LoadDuLieu("SELECT * FROM NHACUNGCAP");
        }

        //Sự kiện ấn nút lưu
        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn cập nhật NCC mã " + tbMaNCC.Text + " không?", "Lưu nhà cung cấp", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
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

                    //Tạo câu lệnh truy vấn
                    String sqlUpdate = "UPDATE NHACUNGCAP SET " +
                        "TenNCC = N'" + tbTenNCC.Text + "'," +
                        "DiaChi = N'" + tbDiaChi.Text + "'," +
                        "SDT = '" + Convert.ToInt32(tbSDT.Text) + "'" +
                        "WHERE MaNCC = '" + tbMaNCC.Text + "'";

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
                LoadDuLieu("SELECT * FROM NHACUNGCAP");
            }
        }


        //Sự kiện ấn nút hủy
        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            XoaTrangChiTiet();
        }
    }
}
