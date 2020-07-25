namespace QuanLyTraChanh
{
    partial class frmDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiMatKhau));
            this.lblNhapMaNV = new System.Windows.Forms.Label();
            this.llblNhapMatKhauCu = new System.Windows.Forms.Label();
            this.lblNhapLaiMatKhauMoi = new System.Windows.Forms.Label();
            this.tbNhapMaNV = new System.Windows.Forms.TextBox();
            this.tbNhapMKCu = new System.Windows.Forms.TextBox();
            this.tbNhapLaiMKMoi = new System.Windows.Forms.TextBox();
            this.lblNhapMatKhauMoi = new System.Windows.Forms.Label();
            this.tbNhapMKMoi = new System.Windows.Forms.TextBox();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNhapMaNV
            // 
            this.lblNhapMaNV.AutoSize = true;
            this.lblNhapMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapMaNV.Location = new System.Drawing.Point(38, 36);
            this.lblNhapMaNV.Name = "lblNhapMaNV";
            this.lblNhapMaNV.Size = new System.Drawing.Size(109, 20);
            this.lblNhapMaNV.TabIndex = 0;
            this.lblNhapMaNV.Text = "Nhập Mã NV";
            // 
            // llblNhapMatKhauCu
            // 
            this.llblNhapMatKhauCu.AutoSize = true;
            this.llblNhapMatKhauCu.Location = new System.Drawing.Point(39, 93);
            this.llblNhapMatKhauCu.Name = "llblNhapMatKhauCu";
            this.llblNhapMatKhauCu.Size = new System.Drawing.Size(95, 13);
            this.llblNhapMatKhauCu.TabIndex = 1;
            this.llblNhapMatKhauCu.Text = "Nhập mật khẩu cũ";
            // 
            // lblNhapLaiMatKhauMoi
            // 
            this.lblNhapLaiMatKhauMoi.AutoSize = true;
            this.lblNhapLaiMatKhauMoi.Location = new System.Drawing.Point(39, 170);
            this.lblNhapLaiMatKhauMoi.Name = "lblNhapLaiMatKhauMoi";
            this.lblNhapLaiMatKhauMoi.Size = new System.Drawing.Size(112, 13);
            this.lblNhapLaiMatKhauMoi.TabIndex = 2;
            this.lblNhapLaiMatKhauMoi.Text = "Nhập lại mật khẩu mới";
            // 
            // tbNhapMaNV
            // 
            this.tbNhapMaNV.Location = new System.Drawing.Point(204, 34);
            this.tbNhapMaNV.Name = "tbNhapMaNV";
            this.tbNhapMaNV.Size = new System.Drawing.Size(100, 20);
            this.tbNhapMaNV.TabIndex = 0;
            // 
            // tbNhapMKCu
            // 
            this.tbNhapMKCu.Location = new System.Drawing.Point(204, 87);
            this.tbNhapMKCu.Name = "tbNhapMKCu";
            this.tbNhapMKCu.Size = new System.Drawing.Size(163, 20);
            this.tbNhapMKCu.TabIndex = 1;
            this.tbNhapMKCu.UseSystemPasswordChar = true;
            // 
            // tbNhapLaiMKMoi
            // 
            this.tbNhapLaiMKMoi.Location = new System.Drawing.Point(204, 167);
            this.tbNhapLaiMKMoi.Name = "tbNhapLaiMKMoi";
            this.tbNhapLaiMKMoi.Size = new System.Drawing.Size(163, 20);
            this.tbNhapLaiMKMoi.TabIndex = 3;
            this.tbNhapLaiMKMoi.UseSystemPasswordChar = true;
            // 
            // lblNhapMatKhauMoi
            // 
            this.lblNhapMatKhauMoi.AutoSize = true;
            this.lblNhapMatKhauMoi.Location = new System.Drawing.Point(39, 144);
            this.lblNhapMatKhauMoi.Name = "lblNhapMatKhauMoi";
            this.lblNhapMatKhauMoi.Size = new System.Drawing.Size(99, 13);
            this.lblNhapMatKhauMoi.TabIndex = 6;
            this.lblNhapMatKhauMoi.Text = "Nhập mật khẩu mới";
            // 
            // tbNhapMKMoi
            // 
            this.tbNhapMKMoi.Location = new System.Drawing.Point(204, 141);
            this.tbNhapMKMoi.Name = "tbNhapMKMoi";
            this.tbNhapMKMoi.Size = new System.Drawing.Size(163, 20);
            this.tbNhapMKMoi.TabIndex = 2;
            this.tbNhapMKMoi.UseSystemPasswordChar = true;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Location = new System.Drawing.Point(157, 231);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(122, 23);
            this.btnDoiMatKhau.TabIndex = 4;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = true;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // frmDoiMatKhau
            // 
            this.AcceptButton = this.btnDoiMatKhau;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 298);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Controls.Add(this.tbNhapMKMoi);
            this.Controls.Add(this.lblNhapMatKhauMoi);
            this.Controls.Add(this.tbNhapLaiMKMoi);
            this.Controls.Add(this.tbNhapMKCu);
            this.Controls.Add(this.tbNhapMaNV);
            this.Controls.Add(this.lblNhapLaiMatKhauMoi);
            this.Controls.Add(this.llblNhapMatKhauCu);
            this.Controls.Add(this.lblNhapMaNV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDoiMatKhau_FormClosing);
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhapMaNV;
        private System.Windows.Forms.Label llblNhapMatKhauCu;
        private System.Windows.Forms.Label lblNhapLaiMatKhauMoi;
        private System.Windows.Forms.TextBox tbNhapMaNV;
        private System.Windows.Forms.TextBox tbNhapMKCu;
        private System.Windows.Forms.TextBox tbNhapLaiMKMoi;
        private System.Windows.Forms.Label lblNhapMatKhauMoi;
        private System.Windows.Forms.TextBox tbNhapMKMoi;
        private System.Windows.Forms.Button btnDoiMatKhau;
    }
}