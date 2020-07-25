namespace QuanLyTraChanh
{
    partial class frmKTTT_Ban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKTTT_Ban));
            this.lblChonKhuVuc = new System.Windows.Forms.Label();
            this.cboChonKhuVuc = new System.Windows.Forms.ComboBox();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.chkChecked = new System.Windows.Forms.CheckBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblMaBan = new System.Windows.Forms.Label();
            this.lblTenBan = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblKhuVuc = new System.Windows.Forms.Label();
            this.tbMaBan = new System.Windows.Forms.TextBox();
            this.tbTenBan = new System.Windows.Forms.TextBox();
            this.tbKhuVuc = new System.Windows.Forms.TextBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChonKhuVuc
            // 
            this.lblChonKhuVuc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblChonKhuVuc.AutoSize = true;
            this.lblChonKhuVuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonKhuVuc.Location = new System.Drawing.Point(230, 47);
            this.lblChonKhuVuc.Name = "lblChonKhuVuc";
            this.lblChonKhuVuc.Size = new System.Drawing.Size(117, 20);
            this.lblChonKhuVuc.TabIndex = 0;
            this.lblChonKhuVuc.Text = "Chọn khu vực";
            // 
            // cboChonKhuVuc
            // 
            this.cboChonKhuVuc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboChonKhuVuc.FormattingEnabled = true;
            this.cboChonKhuVuc.Location = new System.Drawing.Point(362, 47);
            this.cboChonKhuVuc.Name = "cboChonKhuVuc";
            this.cboChonKhuVuc.Size = new System.Drawing.Size(121, 21);
            this.cboChonKhuVuc.TabIndex = 0;
            this.cboChonKhuVuc.SelectedIndexChanged += new System.EventHandler(this.cboChonKhuVuc_SelectedIndexChanged);
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Location = new System.Drawing.Point(80, 146);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.Size = new System.Drawing.Size(590, 259);
            this.dgvKetQua.TabIndex = 2;
            this.dgvKetQua.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKetQua_CellContentClick);
            // 
            // chkChecked
            // 
            this.chkChecked.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkChecked.Checked = true;
            this.chkChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkChecked.Enabled = false;
            this.chkChecked.Location = new System.Drawing.Point(505, 47);
            this.chkChecked.Name = "chkChecked";
            this.chkChecked.Size = new System.Drawing.Size(104, 24);
            this.chkChecked.TabIndex = 3;
            this.chkChecked.Text = "Là đã có người ngồi";
            this.chkChecked.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.Location = new System.Drawing.Point(461, 103);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(96, 23);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa trạng thái";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuy.Location = new System.Drawing.Point(563, 102);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lblMaBan
            // 
            this.lblMaBan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMaBan.AutoSize = true;
            this.lblMaBan.Location = new System.Drawing.Point(94, 89);
            this.lblMaBan.Name = "lblMaBan";
            this.lblMaBan.Size = new System.Drawing.Size(43, 13);
            this.lblMaBan.TabIndex = 6;
            this.lblMaBan.Text = "Mã bàn";
            // 
            // lblTenBan
            // 
            this.lblTenBan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTenBan.AutoSize = true;
            this.lblTenBan.Location = new System.Drawing.Point(176, 89);
            this.lblTenBan.Name = "lblTenBan";
            this.lblTenBan.Size = new System.Drawing.Size(47, 13);
            this.lblTenBan.TabIndex = 7;
            this.lblTenBan.Text = "Tên bàn";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(271, 89);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(55, 13);
            this.lblTrangThai.TabIndex = 8;
            this.lblTrangThai.Text = "Trạng thái";
            // 
            // lblKhuVuc
            // 
            this.lblKhuVuc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblKhuVuc.AutoSize = true;
            this.lblKhuVuc.Location = new System.Drawing.Point(388, 89);
            this.lblKhuVuc.Name = "lblKhuVuc";
            this.lblKhuVuc.Size = new System.Drawing.Size(47, 13);
            this.lblKhuVuc.TabIndex = 9;
            this.lblKhuVuc.Text = "Khu vực";
            // 
            // tbMaBan
            // 
            this.tbMaBan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbMaBan.Enabled = false;
            this.tbMaBan.Location = new System.Drawing.Point(80, 105);
            this.tbMaBan.Name = "tbMaBan";
            this.tbMaBan.Size = new System.Drawing.Size(75, 20);
            this.tbMaBan.TabIndex = 10;
            // 
            // tbTenBan
            // 
            this.tbTenBan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbTenBan.Enabled = false;
            this.tbTenBan.Location = new System.Drawing.Point(161, 105);
            this.tbTenBan.Name = "tbTenBan";
            this.tbTenBan.Size = new System.Drawing.Size(75, 20);
            this.tbTenBan.TabIndex = 11;
            // 
            // tbKhuVuc
            // 
            this.tbKhuVuc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbKhuVuc.Enabled = false;
            this.tbKhuVuc.Location = new System.Drawing.Point(367, 105);
            this.tbKhuVuc.Name = "tbKhuVuc";
            this.tbKhuVuc.Size = new System.Drawing.Size(88, 20);
            this.tbKhuVuc.TabIndex = 13;
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(240, 105);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(121, 21);
            this.cboTrangThai.TabIndex = 1;
            // 
            // frmKTTT_Ban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 459);
            this.Controls.Add(this.cboTrangThai);
            this.Controls.Add(this.tbKhuVuc);
            this.Controls.Add(this.tbTenBan);
            this.Controls.Add(this.tbMaBan);
            this.Controls.Add(this.lblKhuVuc);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.lblTenBan);
            this.Controls.Add(this.lblMaBan);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.chkChecked);
            this.Controls.Add(this.dgvKetQua);
            this.Controls.Add(this.cboChonKhuVuc);
            this.Controls.Add(this.lblChonKhuVuc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKTTT_Ban";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiểm tra trạng thái bàn";
            this.Load += new System.EventHandler(this.frmKTTT_Ban_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChonKhuVuc;
        private System.Windows.Forms.ComboBox cboChonKhuVuc;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.CheckBox chkChecked;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lblMaBan;
        private System.Windows.Forms.Label lblTenBan;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblKhuVuc;
        private System.Windows.Forms.TextBox tbMaBan;
        private System.Windows.Forms.TextBox tbTenBan;
        private System.Windows.Forms.TextBox tbKhuVuc;
        private System.Windows.Forms.ComboBox cboTrangThai;
    }
}