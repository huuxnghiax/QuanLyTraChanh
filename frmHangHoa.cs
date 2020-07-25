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
using System.IO;

namespace QuanLyTraChanh
{
    public partial class frmHangHoa : Form
    {
        //Khai báo các biến toàn cục
        SqlConnection conn;//Khai báo đối tượng thực hiện kết nối đến cơ sở dữ liệu
        SqlCommand cmd;//Khai báo đối tượng thực hiện các câu lệnh truy vấn
        SqlDataAdapter dap;//Khai báo đối tượng gắn kết DataSource với DataSet
        DataSet ds;//Đối tượng chứa dữ liệu tại local

        //Tạo biến toàn cục lấy đường dẫn hình ảnh
        string duongDanHinhAnh = "";
        public frmHangHoa()
        {
            InitializeComponent();
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {

            //Set kích thước hình ảnh trong picture box là phóng to
            ptrHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;

            //Tạo đối tượng connection
            conn = new SqlConnection();
            //Tạo kết nối mới đến cơ sở dữ liệu SQL Server
            conn.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLTC;Integrated Security=True; MultipleActiveResultSets=True;";

            //Gọi phương thức load dữ liệu
            LoadDuLieu("SELECT * FROM HANGHOA");
            //Khi Form mới Load lên thì ẩn các bút Sửa và Xóa
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            //Ẩn group box chi tiết
            HienChiTiet(false);

            //Lấy dữ liệu cho combo box loại hàng hóa
            String sqlGetLoaiHang = "SELECT * FROM LOAIHANGHOA";
            DataTable dtLH = new DataTable();
            SqlDataAdapter dapLH = new SqlDataAdapter(sqlGetLoaiHang, conn);
            dapLH.Fill(dtLH);
            cboMaLH.DataSource = dtLH;
            cboMaLH.DisplayMember = "MaLH";
            cboMaLH.ValueMember = "MaLH";
            //Lấy dữ liệu cho combobox tên loại hàng hóa
            cboTenLH.DataSource = dtLH;
            cboTenLH.DisplayMember = "TenLH";
            cboTenLH.ValueMember = "MaLH";

            //Lấy dữ liệu cho combobox nhà cung cấp
            String sqlGetNCC = "SELECT * FROM NHACUNGCAP";
            DataTable dtNCC = new DataTable();
            SqlDataAdapter dapNCC = new SqlDataAdapter(sqlGetNCC, conn);
            dapNCC.Fill(dtNCC);
            cboMaNCC.DataSource = dtNCC;
            cboMaNCC.DisplayMember = "MaNCC";
            cboMaNCC.ValueMember = "MaNCC";
            //Lấy dữ liệu cho combobox tên nhà cung cấp
            cboTenNCC.DataSource = dtNCC;
            cboTenNCC.DisplayMember = "TenNCC";
            cboTenNCC.ValueMember = "MaNCC";
        }
        //Sự kiện thay đổi combo box
        private void cboMaLH_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Thay đổi tên loại hàng theo mã loại hàng
            cboTenLH.Text = cboMaLH.Text;
        }

        private void cboMaNCC_TextChanged(object sender, EventArgs e)
        {
            cboTenNCC.Text = cboMaNCC.Text;
        }
        //Sự kiện ấn nút chọn ảnh
        private void btnLayHinhAnh_Click(object sender, EventArgs e)
        {
            //Tạo đối tượng mở file
            OpenFileDialog openFile = new OpenFileDialog();
            //Lọc file ảnh
            openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            //Khi mở file thì thư mục lúc mở sẽ được đặt là thư mục được làm việc
            //Vì thế nên set RestoreDirectory = true để khi đóng FileDialog thư mục làm việc gốc sẽ được khôi phục lại
            openFile.RestoreDirectory = true;

            if(openFile.ShowDialog() == DialogResult.OK)
            {
                //Lấy đường dẫn hình ảnh
                duongDanHinhAnh = openFile.FileName;

                //Set hình ảnh trong picture box thành ảnh đó
                ptrHinhAnh.ImageLocation = openFile.FileName;
            }    
        }

        //============================================================================================
        //============================================================================================
        //Hàm chuyển đổi hình ảnh sang byte[]
        //Lấy hình ảnh từ biến duongDanHinhAnh
        private byte[] ConvertImgToByte()
        {
            FileStream fs;
            //File mode là chế độ xử lý file, có 6 chế độ và open là chế độ 3
            //FileMode.Open mở file đã có sẵn
            //FileAccess.Read để cấp quyền đọc file
            fs = new FileStream(duongDanHinhAnh, FileMode.Open, FileAccess.Read);

            byte[] picbyte = new byte[fs.Length];

            //public override int Read (byte[] array, int offset, int count);
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            
            //Đóng FileStream
            fs.Close();

            return picbyte;
        }

        //Hàm chuyển đổi từ byte[] sang hình ảnh
        private Image ByteToImage (string byteString)
        {
            byte[] imgBytes = Convert.FromBase64String(byteString);
            MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
            ms.Write(imgBytes, 0, imgBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
        //Chuyển đổi hình ảnh sang byte nhưng chuyền vào hình ảnh
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
        //============================================================================================
        //============================================================================================
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
        }
        //Phương thức ẩn hiện các control ở groupbox chi tiết
        private void HienChiTiet(Boolean hien)
        {
            tbMaHH.Enabled = hien;
            tbTenHH.Enabled = hien;
            cboMaLH.Enabled = hien;
            cboMaNCC.Enabled = hien;
            tbDonGiaNhap.Enabled = hien;
            tbDonGiaBan.Enabled = hien;
            tbSLTrongKho.Enabled = hien;

            //Ẩn hiện 3 nút lưu và huỷ và thêm mới
            btnHuy.Enabled = hien;
            btnLuu.Enabled = hien;
            btnThemMoi.Enabled = hien;
            //Nút chọn ảnh
            btnLayHinhAnh.Enabled = hien;
        }
        //Xoá trắng groupbox chi tiết nhân viên
        private void XoaTrangChiTiet()
        {
            tbMaHH.Clear();
            tbTenHH.Clear();
            cboMaLH.ResetText();
            cboMaNCC.ResetText();
            tbDonGiaNhap.Clear();
            tbDonGiaBan.Clear();
            tbSLTrongKho.Clear();
        }

        //Sự kiện ấn nút thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "Thêm hàng hóa";

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
                tbMaHH.Text = dgvKetQua["MaHH", e.RowIndex].Value.ToString();
                tbTenHH.Text = dgvKetQua["TenHH", e.RowIndex].Value.ToString();
                cboMaLH.Text = dgvKetQua["MaLH", e.RowIndex].Value.ToString();
                cboMaNCC.Text = dgvKetQua["MaNCC", e.RowIndex].Value.ToString();

                //Lấy byte[] từ db rồi convert sang image
                byte[] imageFromDB = (byte [])dgvKetQua.CurrentRow.Cells["HinhAnh"].Value;
                //Convert.ToBase64String(imageFromDB)
                ptrHinhAnh.Image = ByteToImage(Convert.ToBase64String(imageFromDB));

                tbDonGiaNhap.Text = dgvKetQua["DonGiaNhap", e.RowIndex].Value.ToString();
                tbDonGiaBan.Text = dgvKetQua["DonGiaBan", e.RowIndex].Value.ToString();
                tbSLTrongKho.Text = dgvKetQua["SLTrongKho", e.RowIndex].Value.ToString();

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
            lblTieuDe.Text = "Xoá hàng hóa";
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            //Hiện gropbox chi tiết
            HienChiTiet(true);

            //Hiện MessageBox cảnh báo
            if (MessageBox.Show("Bạn có chắc chắn xóa hàng hóa mã " + tbMaHH.Text + " không?", "Xoá hàng hóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    //Mở kết nối db
                    conn.Open();

                    //Tạo câu lệnh truy vấn DELETE
                    String sqlDelete = "DELETE FROM HANGHOA WHERE MaHH = '" + tbMaHH.Text + "'";
                    //Thực thi câu lệnh sử dụng đối tượng command
                    cmd = new SqlCommand(sqlDelete, conn);
                    cmd.ExecuteNonQuery();

                    //Làm mới lại bảng data grid view
                    LoadDuLieu("SELECT * FROM HANGHOA");

                    //Đóng kết nối
                    conn.Close();
                }
                catch (Exception ex)
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
            if (MessageBox.Show("Bạn có muốn cập nhật hàng hóa mã " + tbMaHH.Text + " không?", "Lưu hàng hóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    //Tạo câu lệnh truy vấn
                    String sqlUpdate = "UPDATE HANGHOA SET " +
                        "TenHH = @TenHH, MaLH = @MaLH, MaNCC = @MaNCC, HinhAnh = @HinhAnh, DonGiaNhap = @DonGiaNhap, DonGiaBan = @DonGiaBan, SLTrongKho = @SLTrongKho " +
                        "WHERE MaHH = @MaHH";

                    //Thực thi câu lệnh sử dụng đối tượng command
                    SqlCommand sqlCommandUpdate = new SqlCommand(sqlUpdate, conn);
                    sqlCommandUpdate.Parameters.AddWithValue("@MaHH", tbMaHH.Text);
                    sqlCommandUpdate.Parameters.AddWithValue("@TenHH", tbTenHH.Text);
                    sqlCommandUpdate.Parameters.AddWithValue("@MaLH", cboMaLH.Text);
                    sqlCommandUpdate.Parameters.AddWithValue("@MaNCC", cboMaNCC.Text);
                    //Trong trường hợp không mở chọn file thì không lấy được duongDanHinhAnh
                    sqlCommandUpdate.Parameters.AddWithValue("@HinhAnh", ImageToByte(ptrHinhAnh.Image));

                    //Xử lý Convert rỗng
                    int donGiaNhap;
                    int donGiaBan;
                    int SLTrongKho;
                    if(Int32.TryParse(tbDonGiaNhap.Text, out donGiaNhap))
                    {
                        sqlCommandUpdate.Parameters.AddWithValue("@DonGiaNhap", donGiaNhap);
                    }
                    else
                    {
                        sqlCommandUpdate.Parameters.AddWithValue("@DonGiaNhap", DBNull.Value);
                    }
                    //===========
                    if (Int32.TryParse(tbDonGiaBan.Text, out donGiaBan))
                    {
                        sqlCommandUpdate.Parameters.AddWithValue("@DonGiaBan", donGiaBan);
                    }
                    else
                    {
                        sqlCommandUpdate.Parameters.AddWithValue("@DonGiaBan", DBNull.Value);
                    }
                    //===========
                    if (Int32.TryParse(tbSLTrongKho.Text, out SLTrongKho))
                    {
                        sqlCommandUpdate.Parameters.AddWithValue("@SLTrongKho", SLTrongKho);
                    }
                    else
                    {
                        sqlCommandUpdate.Parameters.AddWithValue("@SLTrongKho", DBNull.Value);
                    }

                    //Mở kết nối
                    conn.Open();

                    sqlCommandUpdate.ExecuteNonQuery();

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
                LoadDuLieu("SELECT * FROM HANGHOA");
            }
        }

        //Sự kiện ấn nút thêm mới
        private void btnThemMoi_Click(object sender, EventArgs e)
        {

            //Hiện MessageBox cảnh báo
            if (MessageBox.Show("Bạn có chắc chắn thêm hàng hóa mã " + tbMaHH.Text + " không?", "Thêm hàng hóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    //Tạo câu lệnh truy vấn
                    String sqlInsert = "INSERT INTO HANGHOA(MaHH,TenHH,MaLH,MaNCC,HinhAnh,DonGiaNhap,DonGiaBan,SLTrongKho) VALUES(@MaHH,@TenHH,@MaLH,@MaNCC,@HinhAnh,@DonGiaNhap,@DonGiaBan,@SLTrongKho)";

                    SqlCommand sqlCommandInsert = new SqlCommand(sqlInsert, conn);

                    sqlCommandInsert.Parameters.AddWithValue("@MaHH", tbMaHH.Text);
                    sqlCommandInsert.Parameters.AddWithValue("@TenHH", tbTenHH.Text);
                    sqlCommandInsert.Parameters.AddWithValue("@MaLH", cboMaLH.Text);
                    sqlCommandInsert.Parameters.AddWithValue("@MaNCC", cboMaNCC.Text);
                    sqlCommandInsert.Parameters.AddWithValue("@HinhAnh", ConvertImgToByte());
                    //Xử lý Convert rỗng
                    int donGiaNhap;
                    int donGiaBan;
                    int SLTrongKho;
                    if (Int32.TryParse(tbDonGiaNhap.Text, out donGiaNhap))
                    {
                        sqlCommandInsert.Parameters.AddWithValue("@DonGiaNhap", donGiaNhap);
                    }
                    else
                    {
                        sqlCommandInsert.Parameters.AddWithValue("@DonGiaNhap", DBNull.Value);
                    }
                    //===========
                    if (Int32.TryParse(tbDonGiaBan.Text, out donGiaBan))
                    {
                        sqlCommandInsert.Parameters.AddWithValue("@DonGiaBan", donGiaBan);
                    }
                    else
                    {
                        sqlCommandInsert.Parameters.AddWithValue("@DonGiaBan", DBNull.Value);
                    }
                    //===========
                    if (Int32.TryParse(tbSLTrongKho.Text, out SLTrongKho))
                    {
                        sqlCommandInsert.Parameters.AddWithValue("@SLTrongKho", SLTrongKho);
                    }
                    else
                    {
                        sqlCommandInsert.Parameters.AddWithValue("@SLTrongKho", DBNull.Value);
                    }

                    //Mở kết nối
                    conn.Open();

                    //Thực thi câu lệnh sử dụng đối tượng command
                    sqlCommandInsert.ExecuteNonQuery();

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
                LoadDuLieu("SELECT * FROM HANGHOA");
            }
        }

        //Sự kiện ấn nút làm mới
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            //Làm mới lại bảng data grid view
            LoadDuLieu("SELECT * FROM HANGHOA");
        }

        //Sự kiện ấn nút thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
