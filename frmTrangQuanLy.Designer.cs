namespace QuanLyTraChanh
{
    partial class frmTrangQuanLy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrangQuanLy));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiNhapDuLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNhaCungCap = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoaiHangHoa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHangHoa = new System.Windows.Forms.ToolStripMenuItem();
            this.bànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHoaDonNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHoaDonBan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.lươngNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTimHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTimHangHoa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTimNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTimKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTimNhaCungCap = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKiemTraTrangThai = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tSSLCredit = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNhapDuLieu,
            this.tsmiHoaDon,
            this.tsmiThongKe,
            this.tsmiTimKiem,
            this.tsmiKiemTraTrangThai,
            this.tsmiDangXuat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1185, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiNhapDuLieu
            // 
            this.tsmiNhapDuLieu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNhanVien,
            this.tsmiKhachHang,
            this.tsmiNhaCungCap,
            this.tsmiLoaiHangHoa,
            this.tsmiHangHoa,
            this.bànToolStripMenuItem});
            this.tsmiNhapDuLieu.Enabled = false;
            this.tsmiNhapDuLieu.Image = ((System.Drawing.Image)(resources.GetObject("tsmiNhapDuLieu.Image")));
            this.tsmiNhapDuLieu.Name = "tsmiNhapDuLieu";
            this.tsmiNhapDuLieu.Size = new System.Drawing.Size(103, 20);
            this.tsmiNhapDuLieu.Text = "&Nhập dữ liệu";
            // 
            // tsmiNhanVien
            // 
            this.tsmiNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("tsmiNhanVien.Image")));
            this.tsmiNhanVien.Name = "tsmiNhanVien";
            this.tsmiNhanVien.Size = new System.Drawing.Size(149, 22);
            this.tsmiNhanVien.Text = "Nhân viên";
            this.tsmiNhanVien.Click += new System.EventHandler(this.tsmiNhanVien_Click);
            // 
            // tsmiKhachHang
            // 
            this.tsmiKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("tsmiKhachHang.Image")));
            this.tsmiKhachHang.Name = "tsmiKhachHang";
            this.tsmiKhachHang.Size = new System.Drawing.Size(149, 22);
            this.tsmiKhachHang.Text = "Khách hàng";
            this.tsmiKhachHang.Click += new System.EventHandler(this.tsmiKhachHang_Click);
            // 
            // tsmiNhaCungCap
            // 
            this.tsmiNhaCungCap.Image = ((System.Drawing.Image)(resources.GetObject("tsmiNhaCungCap.Image")));
            this.tsmiNhaCungCap.Name = "tsmiNhaCungCap";
            this.tsmiNhaCungCap.Size = new System.Drawing.Size(149, 22);
            this.tsmiNhaCungCap.Text = "Nhà cung cấp";
            this.tsmiNhaCungCap.Click += new System.EventHandler(this.tsmiNhaCungCap_Click);
            // 
            // tsmiLoaiHangHoa
            // 
            this.tsmiLoaiHangHoa.Image = ((System.Drawing.Image)(resources.GetObject("tsmiLoaiHangHoa.Image")));
            this.tsmiLoaiHangHoa.Name = "tsmiLoaiHangHoa";
            this.tsmiLoaiHangHoa.Size = new System.Drawing.Size(149, 22);
            this.tsmiLoaiHangHoa.Text = "Loại hàng hóa";
            this.tsmiLoaiHangHoa.Click += new System.EventHandler(this.tsmiLoaiHangHoa_Click);
            // 
            // tsmiHangHoa
            // 
            this.tsmiHangHoa.Image = ((System.Drawing.Image)(resources.GetObject("tsmiHangHoa.Image")));
            this.tsmiHangHoa.Name = "tsmiHangHoa";
            this.tsmiHangHoa.Size = new System.Drawing.Size(149, 22);
            this.tsmiHangHoa.Text = "Hàng hoá";
            this.tsmiHangHoa.Click += new System.EventHandler(this.tsmiHangHoa_Click);
            // 
            // bànToolStripMenuItem
            // 
            this.bànToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bànToolStripMenuItem.Image")));
            this.bànToolStripMenuItem.Name = "bànToolStripMenuItem";
            this.bànToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.bànToolStripMenuItem.Text = "Bàn";
            this.bànToolStripMenuItem.Click += new System.EventHandler(this.bànToolStripMenuItem_Click);
            // 
            // tsmiHoaDon
            // 
            this.tsmiHoaDon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHoaDonNhap,
            this.tsmiHoaDonBan});
            this.tsmiHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("tsmiHoaDon.Image")));
            this.tsmiHoaDon.Name = "tsmiHoaDon";
            this.tsmiHoaDon.Size = new System.Drawing.Size(81, 20);
            this.tsmiHoaDon.Text = "&Hoá đơn";
            // 
            // tsmiHoaDonNhap
            // 
            this.tsmiHoaDonNhap.Image = ((System.Drawing.Image)(resources.GetObject("tsmiHoaDonNhap.Image")));
            this.tsmiHoaDonNhap.Name = "tsmiHoaDonNhap";
            this.tsmiHoaDonNhap.Size = new System.Drawing.Size(150, 22);
            this.tsmiHoaDonNhap.Text = "Hoá đơn nhập";
            // 
            // tsmiHoaDonBan
            // 
            this.tsmiHoaDonBan.Image = ((System.Drawing.Image)(resources.GetObject("tsmiHoaDonBan.Image")));
            this.tsmiHoaDonBan.Name = "tsmiHoaDonBan";
            this.tsmiHoaDonBan.Size = new System.Drawing.Size(150, 22);
            this.tsmiHoaDonBan.Text = "Hoá đơn bán";
            // 
            // tsmiThongKe
            // 
            this.tsmiThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lươngNhânViênToolStripMenuItem,
            this.doanhThuToolStripMenuItem});
            this.tsmiThongKe.Image = ((System.Drawing.Image)(resources.GetObject("tsmiThongKe.Image")));
            this.tsmiThongKe.Name = "tsmiThongKe";
            this.tsmiThongKe.Size = new System.Drawing.Size(84, 20);
            this.tsmiThongKe.Text = "&Thống kê";
            // 
            // lươngNhânViênToolStripMenuItem
            // 
            this.lươngNhânViênToolStripMenuItem.Name = "lươngNhânViênToolStripMenuItem";
            this.lươngNhânViênToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.lươngNhânViênToolStripMenuItem.Text = "Lương nhân viên";
            // 
            // doanhThuToolStripMenuItem
            // 
            this.doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            this.doanhThuToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.doanhThuToolStripMenuItem.Text = "Doanh thu";
            // 
            // tsmiTimKiem
            // 
            this.tsmiTimKiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTimHoaDon,
            this.tsmiTimHangHoa,
            this.tsmiTimNhanVien,
            this.tsmiTimKhachHang,
            this.tsmiTimNhaCungCap});
            this.tsmiTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("tsmiTimKiem.Image")));
            this.tsmiTimKiem.Name = "tsmiTimKiem";
            this.tsmiTimKiem.Size = new System.Drawing.Size(84, 20);
            this.tsmiTimKiem.Text = "Tìm kiếm";
            // 
            // tsmiTimHoaDon
            // 
            this.tsmiTimHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("tsmiTimHoaDon.Image")));
            this.tsmiTimHoaDon.Name = "tsmiTimHoaDon";
            this.tsmiTimHoaDon.Size = new System.Drawing.Size(148, 22);
            this.tsmiTimHoaDon.Text = "Hoá đơn";
            // 
            // tsmiTimHangHoa
            // 
            this.tsmiTimHangHoa.Image = ((System.Drawing.Image)(resources.GetObject("tsmiTimHangHoa.Image")));
            this.tsmiTimHangHoa.Name = "tsmiTimHangHoa";
            this.tsmiTimHangHoa.Size = new System.Drawing.Size(148, 22);
            this.tsmiTimHangHoa.Text = "Hàng hoá";
            // 
            // tsmiTimNhanVien
            // 
            this.tsmiTimNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("tsmiTimNhanVien.Image")));
            this.tsmiTimNhanVien.Name = "tsmiTimNhanVien";
            this.tsmiTimNhanVien.Size = new System.Drawing.Size(148, 22);
            this.tsmiTimNhanVien.Text = "Nhân viên";
            // 
            // tsmiTimKhachHang
            // 
            this.tsmiTimKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("tsmiTimKhachHang.Image")));
            this.tsmiTimKhachHang.Name = "tsmiTimKhachHang";
            this.tsmiTimKhachHang.Size = new System.Drawing.Size(148, 22);
            this.tsmiTimKhachHang.Text = "Khách hàng";
            // 
            // tsmiTimNhaCungCap
            // 
            this.tsmiTimNhaCungCap.Image = ((System.Drawing.Image)(resources.GetObject("tsmiTimNhaCungCap.Image")));
            this.tsmiTimNhaCungCap.Name = "tsmiTimNhaCungCap";
            this.tsmiTimNhaCungCap.Size = new System.Drawing.Size(148, 22);
            this.tsmiTimNhaCungCap.Text = "Nhà cung cấp";
            // 
            // tsmiKiemTraTrangThai
            // 
            this.tsmiKiemTraTrangThai.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBan});
            this.tsmiKiemTraTrangThai.Image = ((System.Drawing.Image)(resources.GetObject("tsmiKiemTraTrangThai.Image")));
            this.tsmiKiemTraTrangThai.Name = "tsmiKiemTraTrangThai";
            this.tsmiKiemTraTrangThai.Size = new System.Drawing.Size(133, 20);
            this.tsmiKiemTraTrangThai.Text = "&Kiểm tra trạng thái";
            // 
            // tsmiBan
            // 
            this.tsmiBan.Image = ((System.Drawing.Image)(resources.GetObject("tsmiBan.Image")));
            this.tsmiBan.Name = "tsmiBan";
            this.tsmiBan.Size = new System.Drawing.Size(94, 22);
            this.tsmiBan.Text = "Bàn";
            this.tsmiBan.Click += new System.EventHandler(this.tsmiBan_Click);
            // 
            // tsmiDangXuat
            // 
            this.tsmiDangXuat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmiDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDangXuat.Image")));
            this.tsmiDangXuat.Name = "tsmiDangXuat";
            this.tsmiDangXuat.Size = new System.Drawing.Size(89, 20);
            this.tsmiDangXuat.Text = "Đăng xuất";
            this.tsmiDangXuat.Click += new System.EventHandler(this.tsmiDangXuat_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(13, 733);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(1172, 24);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(13, 733);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSSLCredit});
            this.statusStrip1.Location = new System.Drawing.Point(13, 735);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1159, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tSSLCredit
            // 
            this.tSSLCredit.Name = "tSSLCredit";
            this.tSSLCredit.Size = new System.Drawing.Size(280, 17);
            this.tSSLCredit.Text = "Code by Huu Nghia, Manh Linh, Trung Hieu 2020 ©";
            // 
            // frmTrangQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1185, 757);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTrangQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý quán trà chanh";
            this.Load += new System.EventHandler(this.frmTrangQuanLy_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiNhapDuLieu;
        private System.Windows.Forms.ToolStripMenuItem tsmiNhanVien;
        private System.Windows.Forms.ToolStripMenuItem tsmiKhachHang;
        private System.Windows.Forms.ToolStripMenuItem tsmiNhaCungCap;
        private System.Windows.Forms.ToolStripMenuItem tsmiHangHoa;
        private System.Windows.Forms.ToolStripMenuItem tsmiHoaDon;
        private System.Windows.Forms.ToolStripMenuItem tsmiHoaDonNhap;
        private System.Windows.Forms.ToolStripMenuItem tsmiHoaDonBan;
        private System.Windows.Forms.ToolStripMenuItem tsmiThongKe;
        private System.Windows.Forms.ToolStripMenuItem tsmiTimKiem;
        private System.Windows.Forms.ToolStripMenuItem tsmiTimHoaDon;
        private System.Windows.Forms.ToolStripMenuItem tsmiTimHangHoa;
        private System.Windows.Forms.ToolStripMenuItem tsmiTimNhanVien;
        private System.Windows.Forms.ToolStripMenuItem tsmiTimKhachHang;
        private System.Windows.Forms.ToolStripMenuItem tsmiTimNhaCungCap;
        private System.Windows.Forms.ToolStripMenuItem tsmiKiemTraTrangThai;
        private System.Windows.Forms.ToolStripMenuItem tsmiBan;
        private System.Windows.Forms.ToolStripMenuItem tsmiDangXuat;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoaiHangHoa;
        private System.Windows.Forms.ToolStripMenuItem lươngNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bànToolStripMenuItem;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tSSLCredit;
    }
}