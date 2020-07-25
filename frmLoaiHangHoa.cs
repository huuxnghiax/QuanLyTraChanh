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
    public partial class frmLoaiHangHoa : Form
    {
        //Khai báo các biến toàn cục
        SqlConnection conn;//Khai báo đối tượng thực hiện kết nối đến cơ sở dữ liệu
        SqlCommand cmd;//Khai báo đối tượng thực hiện các câu lệnh truy vấn
        SqlDataAdapter dap;//Khai báo đối tượng gắn kết DataSource với DataSet
        DataSet ds;//Đối tượng chứa dữ liệu tại local

        public frmLoaiHangHoa()
        {
            InitializeComponent();
        }

        private void frmLoaiHangHoa_Load(object sender, EventArgs e)
        {
            //Tạo đối tượng connection
            conn = new SqlConnection();
            //Tạo kết nối mới đến cơ sở dữ liệu SQL Server
            conn.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLTC;Integrated Security=True; MultipleActiveResultSets=True;";

            //Gọi phương thức load dữ liệu
            LoadDuLieu("SELECT * FROM LOAIHANGHOA");

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
            dgvKetQuaLH.DataSource = ds.Tables[0];
        }

        //Phương thức ẩn hiện các control ở groupbox chi tiết
        private void HienChiTiet(Boolean hien)
        {
            tbMaLH.Enabled = hien;
            tbTenLH.Enabled = hien;
            rtbMoTa.Enabled = hien;

            //Ẩn hiện 3 nút lưu và huỷ và thêm mới
            btnHuy.Enabled = hien;
            btnLuu.Enabled = hien;
            btnThemMoi.Enabled = hien;
        }

        //Xoá trắng groupbox chi tiết nhân viên
        private void XoaTrangChiTiet()
        {
            tbMaLH.Clear();
            tbTenLH.Clear();
            rtbMoTa.Clear();
        }

        //Sự kiện ấn nút thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "Thêm loại hàng";

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
        private void dgvKetQuaLH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Hien thi nut sửa và xoá
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;

            //Bắt lỗi khii người sử dụng kích linh tinh lên datagrid
            try
            {
                //Tham số thứ nhất của dgv có thể là số cột hoặc là tên cột
                tbMaLH.Text = dgvKetQuaLH["MaLH", e.RowIndex].Value.ToString();
                tbTenLH.Text = dgvKetQuaLH["TenLH", e.RowIndex].Value.ToString();
                rtbMoTa.Text = dgvKetQuaLH["MoTa", e.RowIndex].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
                conn.Close();
            }
        }

        //Sự kiện ấn nút thêm mới
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            //Hiện MessageBox cảnh báo
            if (MessageBox.Show("Bạn có chắc chắn thêm loại hàng mã " + tbMaLH.Text + " không?", "Thêm loại hàng", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    //Mở kết nối
                    conn.Open();

                    //Tạo câu lệnh truy vấn
                    String sqlInsert = "INSERT INTO LOAIHANGHOA(MaLH,TenLH,MoTa) VALUES(";
                    sqlInsert += "'" + tbMaLH.Text + "',N'" + tbTenLH.Text + "',N'" + rtbMoTa.Text + "')";
                    //Thực thi câu lệnh sử dụng đối tượng command
                    cmd = new SqlCommand(sqlInsert, conn);
                    cmd.ExecuteNonQuery();

                    //Hiện thông báo
                    MessageBox.Show("Thêm thành công!");

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
                LoadDuLieu("SELECT * FROM LOAIHANGHOA");
            }
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
            lblTieuDe.Text = "Xoá loại hàng hóa";
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            //Hiện gropbox chi tiết
            HienChiTiet(true);

            //Hiện MessageBox cảnh báo
            if (MessageBox.Show("Bạn có chắc chắn xóa loại hàng mã " + tbMaLH.Text + " không?", "Xoá loại hàng", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    //Mở kết nối db
                    conn.Open();

                    //Tạo câu lệnh truy vấn DELETE
                    String sqlDelete = "DELETE FROM LOAIHANGHOA WHERE MaLH = '" + tbMaLH.Text + "'";
                    //Thực thi câu lệnh sử dụng đối tượng command
                    cmd = new SqlCommand(sqlDelete, conn);
                    cmd.ExecuteNonQuery();

                    //Làm mới lại bảng data grid view
                    LoadDuLieu("SELECT * FROM LOAIHANGHOA");

                    //Đóng kết nối
                    conn.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message);
                    //Đóng kết nối
                    conn.Close();
                }
            }
        }

        //Sự kiện ấn nút thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Sự kiện ấn nút làm mới
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            //Làm mới lại bảng data grid view
            LoadDuLieu("SELECT * FROM LOAIHANGHOA");
        }

        //Sự kiện ấn nút lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn cập nhật loại hàng mã " + tbMaLH.Text + " không?", "Lưu loại hàng", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    //Mở kết nối
                    conn.Open();

                    //Tạo câu lệnh truy vấn
                    String sqlUpdate = "UPDATE LOAIHANGHOA SET " +
                        "TenLH = N'" + tbTenLH.Text + "'," +
                        "MoTa = N'" + rtbMoTa.Text + "'" +
                        "WHERE MaLH = '" + tbMaLH.Text + "'";

                    //Thực thi câu lệnh sử dụng đối tượng command
                    cmd = new SqlCommand(sqlUpdate, conn);
                    cmd.ExecuteNonQuery();

                    //Hiện thông báo
                    MessageBox.Show("Sửa thành công!");

                    //Đóng kết nối
                    conn.Close();

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
                LoadDuLieu("SELECT * FROM LOAIHANGHOA");
            }
        }

        //Sự kiện ấn nút hủy
        private void btnHuy_Click(object sender, EventArgs e)
        {
            XoaTrangChiTiet();
        }
    }
}
