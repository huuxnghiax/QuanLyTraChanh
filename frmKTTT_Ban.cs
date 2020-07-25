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
using System.Collections;

namespace QuanLyTraChanh
{
    public partial class frmKTTT_Ban : Form
    {
        //Khai báo các biến toàn cục
        SqlConnection conn;//Khai báo đối tượng thực hiện kết nối đến cơ sở dữ liệu
        SqlCommand cmd;//Khai báo đối tượng thực hiện các câu lệnh truy vấn
        SqlDataAdapter dap;//Khai báo đối tượng gắn kết DataSource với DataSet
        DataSet ds;//Đối tượng chứa dữ liệu tại local
        
        public frmKTTT_Ban()
        {
            InitializeComponent();
        }

        private void frmKTTT_Ban_Load(object sender, EventArgs e)
        {
            //Tạo đối tượng connection
            conn = new SqlConnection();
            //Tạo kết nối mới đến cơ sở dữ liệu SQL Server
            conn.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLTC;Integrated Security=True; MultipleActiveResultSets=True;";


            //Lấy dữ liệu cho comnbox chọn khu vực
            String sqlGetKV = "SELECT * FROM BAN";
            //Tạo đối tượng datatable
            DataTable dtGetKV = new DataTable();
            //tạo đối tượng DataSet
            DataSet dsGetKV = new DataSet();
            //Khởi tạo đối tượng DataAdapter và cung cấp vào câu lệnh SQL và đối tượng Connection
            SqlDataAdapter dapBan = new SqlDataAdapter(sqlGetKV, conn);
            //Dùng phương thức Fill của DataAdapter để đổ dữ liệu từ DataSource tới DataSet
            dapBan.Fill(dsGetKV);

            //Gán đối tượng dtGetKV là bảng đã bỏ đi các dòng bị trùng
            dtGetKV = RemoveDuplicateRows(dsGetKV.Tables[0], "KhuVuc");

            cboChonKhuVuc.DataSource = dtGetKV;
            cboChonKhuVuc.DisplayMember = "KhuVuc";

            CreateDataGridView("SELECT * FROM BAN");

            //Khởi tạo giá trị ban đầu cho combo box trạng thái
            String[] trangThai = { "Chưa có người ngồi", "Đã có người ngồi"};
            cboTrangThai.DataSource = trangThai;

        }
        private void CreateDataGridView(String sql)
        {
            //tạo đối tượng DataSet
            ds = new DataSet();
            //Khởi tạo đối tượng DataAdapter và cung cấp vào câu lệnh SQL và đối tượng Connection
            dap = new SqlDataAdapter(sql, conn);
            //Dùng phương thức Fill của DataAdapter để đổ dữ liệu từ DataSource tới DataSet
            dap.Fill(ds);

            dgvKetQua.DataSource = ds.Tables[0];
            dgvKetQua.Columns["MaBan"].HeaderText = "Mã bàn";
            dgvKetQua.Columns["TenBan"].HeaderText = "Tên bàn";
            dgvKetQua.Columns["TrangThai"].HeaderText = "Trạng thái";
            dgvKetQua.Columns["KhuVuc"].HeaderText = "Khu vực";

            //Ẩn nút sửa và hủy lúc load form
            btnSua.Enabled = false;
            btnHuy.Enabled = false;

            //Ẩn cbo trạng thái
            cboTrangThai.Enabled = false;
        }

         //Loại bỏ dòng bị trùng khỏi 1 cột trong datatable
         public DataTable RemoveDuplicateRows(DataTable dTable, string colName)
        {
            Hashtable hTable = new Hashtable();
            ArrayList duplicateList = new ArrayList();

            //Add list of all the unique item value to hashtable, which stores combination of key, value pair.
            //And add duplicate item value in arraylist.
            foreach (DataRow drow in dTable.Rows)
            {
                if (hTable.Contains(drow[colName]))
                    duplicateList.Add(drow);
                else
                    hTable.Add(drow[colName], string.Empty);
            }

            //Removing a list of duplicate items from datatable.
            foreach (DataRow dRow in duplicateList)
                dTable.Rows.Remove(dRow);

            //Datatable which contains unique records will be return as output.
            return dTable;
        }

        //Bắt sự kiện thay đổi khu vực
        private void cboChonKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = cboChonKhuVuc.Text;

            this.CreateDataGridView("SELECT * FROM BAN WHERE KhuVuc=N'"+ a +"'");
        }

        private void XoaTrangChiTiet()
        {
            tbMaBan.Clear();
            tbTenBan.Clear();
            cboTrangThai.ResetText();
            tbKhuVuc.Clear();
        }

        //Bắt sự kiện click dữ liệu trên data grid view
        private void dgvKetQua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Hiện nút sửa và hủy
            btnSua.Enabled = true;
            btnHuy.Enabled = true;
            //Hiện combobox trạng thái
            cboTrangThai.Enabled = true;

            try
            {
                string trangThaiBan = "";
                if (dgvKetQua["TrangThai", e.RowIndex].Value.ToString() == "False")
                {
                    trangThaiBan = "Chưa có người ngồi";
                }
                else trangThaiBan = "Đã có người ngồi";

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

        //Bắt dữ liệu click nút sửa (nút sửa sẽ ghi vào db luôn)
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                //Mở kết nối
                conn.Open();

                bool trangThaiMoi;
                if (cboTrangThai.Text == "Chưa có người ngồi") trangThaiMoi = false;
                else trangThaiMoi = true;

                //Tạo câu lệnh truy vấn
                String sqlUpdateTrangThai = "UPDATE BAN SET TrangThai = '"+ trangThaiMoi +"' WHERE MaBan = '"+ tbMaBan.Text +"'";

                //Thực thi câu lệnh sử dụng đối tượng command
                cmd = new SqlCommand(sqlUpdateTrangThai, conn);
                cmd.ExecuteNonQuery();

                //Đóng kết nối
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
                //Đóng kết nối để kết nối lại
                conn.Close();
            }

            //Làm mới data grid view
            CreateDataGridView("SELECT * FROM BAN");
        }

        //Bắt sự kiện click nút hủy
        private void btnHuy_Click(object sender, EventArgs e)
        {
            XoaTrangChiTiet();
        }
    }
}
