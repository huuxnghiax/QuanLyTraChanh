namespace QuanLyTraChanh
{
    partial class frmHangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHangHoa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboTenNCC = new System.Windows.Forms.ComboBox();
            this.cboMaNCC = new System.Windows.Forms.ComboBox();
            this.cboTenLH = new System.Windows.Forms.ComboBox();
            this.cboMaLH = new System.Windows.Forms.ComboBox();
            this.lblTenLH = new System.Windows.Forms.Label();
            this.lbMaNCC = new System.Windows.Forms.Label();
            this.btnLayHinhAnh = new System.Windows.Forms.Button();
            this.tbDonGiaBan = new System.Windows.Forms.TextBox();
            this.lbDonGiaBan = new System.Windows.Forms.Label();
            this.ptrHinhAnh = new System.Windows.Forms.PictureBox();
            this.tbDonGiaNhap = new System.Windows.Forms.TextBox();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lblMaHH = new System.Windows.Forms.Label();
            this.lblTenHH = new System.Windows.Forms.Label();
            this.tbSLTrongKho = new System.Windows.Forms.TextBox();
            this.lblMaLH = new System.Windows.Forms.Label();
            this.lblHinhAnh = new System.Windows.Forms.Label();
            this.lblDonGiaNhap = new System.Windows.Forms.Label();
            this.lblSLTrongKho = new System.Windows.Forms.Label();
            this.tbTenHH = new System.Windows.Forms.TextBox();
            this.tbMaHH = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrHinhAnh)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.lblTieuDe);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 71);
            this.panel1.TabIndex = 20;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTieuDe.Location = new System.Drawing.Point(331, 18);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(413, 39);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "DANH MỤC HÀNG HÓA";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLamMoi);
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 619);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1116, 50);
            this.panel2.TabIndex = 21;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoi.Location = new System.Drawing.Point(1029, 15);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThoat.Location = new System.Drawing.Point(400, 15);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.Location = new System.Drawing.Point(260, 15);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSua.Location = new System.Drawing.Point(151, 15);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.Location = new System.Drawing.Point(39, 15);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboTenNCC);
            this.groupBox1.Controls.Add(this.cboMaNCC);
            this.groupBox1.Controls.Add(this.cboTenLH);
            this.groupBox1.Controls.Add(this.cboMaLH);
            this.groupBox1.Controls.Add(this.lblTenLH);
            this.groupBox1.Controls.Add(this.lbMaNCC);
            this.groupBox1.Controls.Add(this.btnLayHinhAnh);
            this.groupBox1.Controls.Add(this.tbDonGiaBan);
            this.groupBox1.Controls.Add(this.lbDonGiaBan);
            this.groupBox1.Controls.Add(this.ptrHinhAnh);
            this.groupBox1.Controls.Add(this.tbDonGiaNhap);
            this.groupBox1.Controls.Add(this.btnThemMoi);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.lblMaHH);
            this.groupBox1.Controls.Add(this.lblTenHH);
            this.groupBox1.Controls.Add(this.tbSLTrongKho);
            this.groupBox1.Controls.Add(this.lblMaLH);
            this.groupBox1.Controls.Add(this.lblHinhAnh);
            this.groupBox1.Controls.Add(this.lblDonGiaNhap);
            this.groupBox1.Controls.Add(this.lblSLTrongKho);
            this.groupBox1.Controls.Add(this.tbTenHH);
            this.groupBox1.Controls.Add(this.tbMaHH);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(723, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 548);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết";
            // 
            // cboTenNCC
            // 
            this.cboTenNCC.Enabled = false;
            this.cboTenNCC.FormattingEnabled = true;
            this.cboTenNCC.Location = new System.Drawing.Point(201, 93);
            this.cboTenNCC.Name = "cboTenNCC";
            this.cboTenNCC.Size = new System.Drawing.Size(166, 21);
            this.cboTenNCC.TabIndex = 44;
            // 
            // cboMaNCC
            // 
            this.cboMaNCC.FormattingEnabled = true;
            this.cboMaNCC.Location = new System.Drawing.Point(115, 93);
            this.cboMaNCC.Name = "cboMaNCC";
            this.cboMaNCC.Size = new System.Drawing.Size(79, 21);
            this.cboMaNCC.TabIndex = 43;
            this.cboMaNCC.TextChanged += new System.EventHandler(this.cboMaNCC_TextChanged);
            // 
            // cboTenLH
            // 
            this.cboTenLH.Enabled = false;
            this.cboTenLH.FormattingEnabled = true;
            this.cboTenLH.Location = new System.Drawing.Point(246, 66);
            this.cboTenLH.Name = "cboTenLH";
            this.cboTenLH.Size = new System.Drawing.Size(121, 21);
            this.cboTenLH.TabIndex = 42;
            // 
            // cboMaLH
            // 
            this.cboMaLH.FormattingEnabled = true;
            this.cboMaLH.Location = new System.Drawing.Point(115, 67);
            this.cboMaLH.Name = "cboMaLH";
            this.cboMaLH.Size = new System.Drawing.Size(79, 21);
            this.cboMaLH.TabIndex = 41;
            this.cboMaLH.SelectedIndexChanged += new System.EventHandler(this.cboMaLH_SelectedIndexChanged);
            // 
            // lblTenLH
            // 
            this.lblTenLH.AutoSize = true;
            this.lblTenLH.Location = new System.Drawing.Point(200, 70);
            this.lblTenLH.Name = "lblTenLH";
            this.lblTenLH.Size = new System.Drawing.Size(52, 13);
            this.lblTenLH.TabIndex = 40;
            this.lblTenLH.Text = "- TenLH: ";
            // 
            // lbMaNCC
            // 
            this.lbMaNCC.AutoSize = true;
            this.lbMaNCC.Location = new System.Drawing.Point(9, 96);
            this.lbMaNCC.Name = "lbMaNCC";
            this.lbMaNCC.Size = new System.Drawing.Size(91, 13);
            this.lbMaNCC.TabIndex = 38;
            this.lbMaNCC.Text = "Mã nhà cung cấp";
            // 
            // btnLayHinhAnh
            // 
            this.btnLayHinhAnh.Location = new System.Drawing.Point(9, 214);
            this.btnLayHinhAnh.Name = "btnLayHinhAnh";
            this.btnLayHinhAnh.Size = new System.Drawing.Size(75, 23);
            this.btnLayHinhAnh.TabIndex = 4;
            this.btnLayHinhAnh.Text = "Chọn ảnh";
            this.btnLayHinhAnh.UseVisualStyleBackColor = true;
            this.btnLayHinhAnh.Click += new System.EventHandler(this.btnLayHinhAnh_Click);
            // 
            // tbDonGiaBan
            // 
            this.tbDonGiaBan.Location = new System.Drawing.Point(115, 414);
            this.tbDonGiaBan.Name = "tbDonGiaBan";
            this.tbDonGiaBan.Size = new System.Drawing.Size(210, 20);
            this.tbDonGiaBan.TabIndex = 6;
            // 
            // lbDonGiaBan
            // 
            this.lbDonGiaBan.AutoSize = true;
            this.lbDonGiaBan.Location = new System.Drawing.Point(6, 417);
            this.lbDonGiaBan.Name = "lbDonGiaBan";
            this.lbDonGiaBan.Size = new System.Drawing.Size(65, 13);
            this.lbDonGiaBan.TabIndex = 33;
            this.lbDonGiaBan.Text = "Đơn giá bán";
            // 
            // ptrHinhAnh
            // 
            this.ptrHinhAnh.Location = new System.Drawing.Point(115, 178);
            this.ptrHinhAnh.Name = "ptrHinhAnh";
            this.ptrHinhAnh.Size = new System.Drawing.Size(189, 189);
            this.ptrHinhAnh.TabIndex = 32;
            this.ptrHinhAnh.TabStop = false;
            // 
            // tbDonGiaNhap
            // 
            this.tbDonGiaNhap.Location = new System.Drawing.Point(115, 373);
            this.tbDonGiaNhap.Name = "tbDonGiaNhap";
            this.tbDonGiaNhap.Size = new System.Drawing.Size(210, 20);
            this.tbDonGiaNhap.TabIndex = 5;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThemMoi.Location = new System.Drawing.Point(47, 503);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemMoi.TabIndex = 8;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.Location = new System.Drawing.Point(283, 503);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLuu.Location = new System.Drawing.Point(168, 503);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lblMaHH
            // 
            this.lblMaHH.AutoSize = true;
            this.lblMaHH.Location = new System.Drawing.Point(6, 19);
            this.lblMaHH.Name = "lblMaHH";
            this.lblMaHH.Size = new System.Drawing.Size(41, 13);
            this.lblMaHH.TabIndex = 5;
            this.lblMaHH.Text = "Mã HH";
            // 
            // lblTenHH
            // 
            this.lblTenHH.AutoSize = true;
            this.lblTenHH.Location = new System.Drawing.Point(6, 43);
            this.lblTenHH.Name = "lblTenHH";
            this.lblTenHH.Size = new System.Drawing.Size(45, 13);
            this.lblTenHH.TabIndex = 6;
            this.lblTenHH.Text = "Tên HH";
            // 
            // tbSLTrongKho
            // 
            this.tbSLTrongKho.Location = new System.Drawing.Point(115, 455);
            this.tbSLTrongKho.Name = "tbSLTrongKho";
            this.tbSLTrongKho.Size = new System.Drawing.Size(210, 20);
            this.tbSLTrongKho.TabIndex = 7;
            // 
            // lblMaLH
            // 
            this.lblMaLH.AutoSize = true;
            this.lblMaLH.Location = new System.Drawing.Point(9, 70);
            this.lblMaLH.Name = "lblMaLH";
            this.lblMaLH.Size = new System.Drawing.Size(68, 13);
            this.lblMaLH.TabIndex = 7;
            this.lblMaLH.Text = "Mã loại hàng";
            // 
            // lblHinhAnh
            // 
            this.lblHinhAnh.AutoSize = true;
            this.lblHinhAnh.Location = new System.Drawing.Point(10, 187);
            this.lblHinhAnh.Name = "lblHinhAnh";
            this.lblHinhAnh.Size = new System.Drawing.Size(50, 13);
            this.lblHinhAnh.TabIndex = 8;
            this.lblHinhAnh.Text = "Hình ảnh";
            // 
            // lblDonGiaNhap
            // 
            this.lblDonGiaNhap.AutoSize = true;
            this.lblDonGiaNhap.Location = new System.Drawing.Point(6, 376);
            this.lblDonGiaNhap.Name = "lblDonGiaNhap";
            this.lblDonGiaNhap.Size = new System.Drawing.Size(71, 13);
            this.lblDonGiaNhap.TabIndex = 9;
            this.lblDonGiaNhap.Text = "Đơn giá nhập";
            // 
            // lblSLTrongKho
            // 
            this.lblSLTrongKho.AutoSize = true;
            this.lblSLTrongKho.Location = new System.Drawing.Point(6, 458);
            this.lblSLTrongKho.Name = "lblSLTrongKho";
            this.lblSLTrongKho.Size = new System.Drawing.Size(68, 13);
            this.lblSLTrongKho.TabIndex = 10;
            this.lblSLTrongKho.Text = "SL trong kho";
            // 
            // tbTenHH
            // 
            this.tbTenHH.Location = new System.Drawing.Point(115, 40);
            this.tbTenHH.Name = "tbTenHH";
            this.tbTenHH.Size = new System.Drawing.Size(210, 20);
            this.tbTenHH.TabIndex = 1;
            // 
            // tbMaHH
            // 
            this.tbMaHH.Location = new System.Drawing.Point(115, 16);
            this.tbMaHH.Name = "tbMaHH";
            this.tbMaHH.Size = new System.Drawing.Size(210, 20);
            this.tbMaHH.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvKetQua);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(723, 548);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKetQua.Location = new System.Drawing.Point(3, 16);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.RowTemplate.Height = 24;
            this.dgvKetQua.Size = new System.Drawing.Size(717, 529);
            this.dgvKetQua.TabIndex = 0;
            this.dgvKetQua.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKetQua_CellContentClick);
            // 
            // frmHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 669);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHangHoa";
            this.Text = "Hàng hóa";
            this.Load += new System.EventHandler(this.frmHangHoa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrHinhAnh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox ptrHinhAnh;
        private System.Windows.Forms.TextBox tbDonGiaNhap;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lblMaHH;
        private System.Windows.Forms.Label lblTenHH;
        private System.Windows.Forms.TextBox tbSLTrongKho;
        private System.Windows.Forms.Label lblMaLH;
        private System.Windows.Forms.Label lblHinhAnh;
        private System.Windows.Forms.Label lblDonGiaNhap;
        private System.Windows.Forms.Label lblSLTrongKho;
        private System.Windows.Forms.TextBox tbTenHH;
        private System.Windows.Forms.TextBox tbMaHH;
        private System.Windows.Forms.TextBox tbDonGiaBan;
        private System.Windows.Forms.Label lbDonGiaBan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.Button btnLayHinhAnh;
        private System.Windows.Forms.Label lbMaNCC;
        private System.Windows.Forms.Label lblTenLH;
        private System.Windows.Forms.ComboBox cboMaLH;
        private System.Windows.Forms.ComboBox cboTenLH;
        private System.Windows.Forms.ComboBox cboMaNCC;
        private System.Windows.Forms.ComboBox cboTenNCC;
    }
}