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
    public partial class frmTrangQuanLy : Form
    {
        //Tạo biến nhận giá trị từ form Đăng nhập
        string strNhan;

        public frmTrangQuanLy()
        {
            InitializeComponent();
        }

        //Tạo kết nối mới đến cơ sở dữ liệu SQL Server
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLTC;Integrated Security=True; MultipleActiveResultSets=True;");

        //Ta cho hàm tạo của frmTrangQuanLy kế thừa this()
        //Và để nó nhận tham số là 1 kiểu string
        public frmTrangQuanLy(string giaTriNhan): this()
        {
            strNhan = giaTriNhan;
        }
        //=========================================================
        private void frmTrangQuanLy_Load(object sender, EventArgs e)
        {
            if(strNhan == "Admin")
            {
                tsmiNhapDuLieu.Enabled = true;
            }

            foreach (Control control in this.Controls)
            {
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    client.BackColor = Color.LightYellow;
                    break;
                }
            }
        }

        private void tsmiNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.MdiParent = this;
            frm.Show();
            
            //Đặt trạng thái toàn màn hình
            frm.WindowState = FormWindowState.Maximized; 
        }

        private void tsmiDangXuat_Click(object sender, EventArgs e)
        {
            //Đóng form hiện tại
            this.Close();

            //Mở form đăng nhập
            var frmDangNhap = new frmDangNhap();
            frmDangNhap.Show();
        }

        private void tsmiKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            frm.MdiParent = this;
            frm.Show();

            //Đặt trạng thái toàn màn hình
            frm.WindowState = FormWindowState.Maximized;
        }

        private void tsmiNhaCungCap_Click(object sender, EventArgs e)
        {
            frmNCC frm = new frmNCC();
            frm.MdiParent = this;
            frm.Show();

            //Đặt trạng thái toàn màn hình
            frm.WindowState = FormWindowState.Maximized;
        }

        private void tsmiLoaiHangHoa_Click(object sender, EventArgs e)
        {
            frmLoaiHangHoa frm = new frmLoaiHangHoa();
            frm.MdiParent = this;
            frm.Show();

            //Đặt trạng thái toàn màn hình
            frm.WindowState = FormWindowState.Maximized;
        }

        private void tsmiHangHoa_Click(object sender, EventArgs e)
        {
            frmHangHoa frm = new frmHangHoa();
            frm.MdiParent = this;
            frm.Show();

            //Đặt trạng thái toàn màn hình
            frm.WindowState = FormWindowState.Maximized;
        }

        private void bànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBan frm = new frmBan();
            frm.MdiParent = this;
            frm.Show();

            //Đặt trạng thái toàn màn hình
            frm.WindowState = FormWindowState.Maximized;
        }

        private void tsmiBan_Click(object sender, EventArgs e)
        {
            frmKTTT_Ban frm = new frmKTTT_Ban();
            frm.MdiParent = this;
            frm.Show();

            //Đặt trạng thái toàn màn hình
            frm.WindowState = FormWindowState.Maximized;
        }

    }
}
