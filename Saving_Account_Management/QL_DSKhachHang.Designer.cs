
namespace Saving_Account_Management
{
    partial class QL_DSKhachHang
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
            this.gb_DSKhachHang = new System.Windows.Forms.GroupBox();
            this.dgv_KhachHang = new System.Windows.Forms.DataGridView();
            this.MaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDinhDanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbDangSD = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ChuKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ptbChuky = new System.Windows.Forms.PictureBox();
            this.cb_TinhTrangSD = new System.Windows.Forms.CheckBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_NoiCap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_NgayCap = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_MaDinhDanh = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Sdt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NgaySinh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.rdb_TimKiemDinhDanh = new System.Windows.Forms.RadioButton();
            this.rdb_TimKiemTen = new System.Windows.Forms.RadioButton();
            this.rdb_TimKiemMa = new System.Windows.Forms.RadioButton();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.gb_DSKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbChuky)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_DSKhachHang
            // 
            this.gb_DSKhachHang.Controls.Add(this.dgv_KhachHang);
            this.gb_DSKhachHang.Controls.Add(this.panel1);
            this.gb_DSKhachHang.Controls.Add(this.panel2);
            this.gb_DSKhachHang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_DSKhachHang.Location = new System.Drawing.Point(14, 9);
            this.gb_DSKhachHang.Name = "gb_DSKhachHang";
            this.gb_DSKhachHang.Size = new System.Drawing.Size(1880, 797);
            this.gb_DSKhachHang.TabIndex = 2;
            this.gb_DSKhachHang.TabStop = false;
            this.gb_DSKhachHang.Text = "Danh sách Khách hàng";
            // 
            // dgv_KhachHang
            // 
            this.dgv_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhachHang,
            this.HoTen,
            this.NgaySinh,
            this.SDT,
            this.MaDinhDanh,
            this.NgayCap,
            this.NoiCap,
            this.DiaChi,
            this.cbDangSD,
            this.ChuKy});
            this.dgv_KhachHang.Location = new System.Drawing.Point(34, 397);
            this.dgv_KhachHang.Name = "dgv_KhachHang";
            this.dgv_KhachHang.RowHeadersVisible = false;
            this.dgv_KhachHang.RowHeadersWidth = 51;
            this.dgv_KhachHang.RowTemplate.Height = 24;
            this.dgv_KhachHang.Size = new System.Drawing.Size(1706, 387);
            this.dgv_KhachHang.TabIndex = 20;
            this.dgv_KhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_KhachHang_CellClick);
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.DataPropertyName = "MaKhachHang";
            this.MaKhachHang.HeaderText = "Mã khách hàng";
            this.MaKhachHang.MinimumWidth = 6;
            this.MaKhachHang.Name = "MaKhachHang";
            this.MaKhachHang.Width = 160;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 150;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Width = 125;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 145;
            // 
            // MaDinhDanh
            // 
            this.MaDinhDanh.DataPropertyName = "MaDinhDanh";
            this.MaDinhDanh.HeaderText = "Mã định danh";
            this.MaDinhDanh.MinimumWidth = 6;
            this.MaDinhDanh.Name = "MaDinhDanh";
            this.MaDinhDanh.Width = 145;
            // 
            // NgayCap
            // 
            this.NgayCap.DataPropertyName = "NgayCap";
            this.NgayCap.HeaderText = "Ngày cấp";
            this.NgayCap.MinimumWidth = 6;
            this.NgayCap.Name = "NgayCap";
            this.NgayCap.Width = 125;
            // 
            // NoiCap
            // 
            this.NoiCap.DataPropertyName = "NoiCap";
            this.NoiCap.HeaderText = "Nơi cấp";
            this.NoiCap.MinimumWidth = 6;
            this.NoiCap.Name = "NoiCap";
            this.NoiCap.Width = 150;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 125;
            // 
            // cbDangSD
            // 
            this.cbDangSD.DataPropertyName = "DangSuDung";
            this.cbDangSD.HeaderText = "Đang sử dụng";
            this.cbDangSD.MinimumWidth = 6;
            this.cbDangSD.Name = "cbDangSD";
            this.cbDangSD.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbDangSD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cbDangSD.Width = 150;
            // 
            // ChuKy
            // 
            this.ChuKy.DataPropertyName = "ChuKy";
            this.ChuKy.HeaderText = "Chữ ký";
            this.ChuKy.MinimumWidth = 6;
            this.ChuKy.Name = "ChuKy";
            this.ChuKy.Visible = false;
            this.ChuKy.Width = 125;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.ptbChuky);
            this.panel1.Controls.Add(this.cb_TinhTrangSD);
            this.panel1.Controls.Add(this.txt_DiaChi);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txt_NoiCap);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_NgayCap);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_MaDinhDanh);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_Sdt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_NgaySinh);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_HoTen);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_MaKH);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(34, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 354);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(505, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Chữ ký:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Lavender;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.IndianRed;
            this.label10.Location = new System.Drawing.Point(288, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(370, 40);
            this.label10.TabIndex = 18;
            this.label10.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // ptbChuky
            // 
            this.ptbChuky.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbChuky.Location = new System.Drawing.Point(676, 229);
            this.ptbChuky.Name = "ptbChuky";
            this.ptbChuky.Size = new System.Drawing.Size(246, 107);
            this.ptbChuky.TabIndex = 19;
            this.ptbChuky.TabStop = false;
            // 
            // cb_TinhTrangSD
            // 
            this.cb_TinhTrangSD.AutoSize = true;
            this.cb_TinhTrangSD.Location = new System.Drawing.Point(509, 282);
            this.cb_TinhTrangSD.Name = "cb_TinhTrangSD";
            this.cb_TinhTrangSD.Size = new System.Drawing.Size(140, 27);
            this.cb_TinhTrangSD.TabIndex = 18;
            this.cb_TinhTrangSD.Text = "Đang sử dụng";
            this.cb_TinhTrangSD.UseVisualStyleBackColor = true;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(196, 279);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(280, 30);
            this.txt_DiaChi.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 23);
            this.label9.TabIndex = 16;
            this.label9.Text = "Địa chỉ:";
            // 
            // txt_NoiCap
            // 
            this.txt_NoiCap.Location = new System.Drawing.Point(676, 178);
            this.txt_NoiCap.Name = "txt_NoiCap";
            this.txt_NoiCap.Size = new System.Drawing.Size(246, 30);
            this.txt_NoiCap.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(505, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nơi cấp:";
            // 
            // txt_NgayCap
            // 
            this.txt_NgayCap.Location = new System.Drawing.Point(676, 128);
            this.txt_NgayCap.Name = "txt_NgayCap";
            this.txt_NgayCap.Size = new System.Drawing.Size(246, 30);
            this.txt_NgayCap.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(505, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ngày cấp: ";
            // 
            // txt_MaDinhDanh
            // 
            this.txt_MaDinhDanh.Location = new System.Drawing.Point(676, 78);
            this.txt_MaDinhDanh.Name = "txt_MaDinhDanh";
            this.txt_MaDinhDanh.Size = new System.Drawing.Size(246, 30);
            this.txt_MaDinhDanh.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(505, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "Mã định danh:";
            // 
            // txt_Sdt
            // 
            this.txt_Sdt.Location = new System.Drawing.Point(196, 227);
            this.txt_Sdt.Name = "txt_Sdt";
            this.txt_Sdt.Size = new System.Drawing.Size(280, 30);
            this.txt_Sdt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "SĐT:";
            // 
            // txt_NgaySinh
            // 
            this.txt_NgaySinh.Location = new System.Drawing.Point(196, 178);
            this.txt_NgaySinh.Name = "txt_NgaySinh";
            this.txt_NgaySinh.Size = new System.Drawing.Size(280, 30);
            this.txt_NgaySinh.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày sinh:";
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(196, 128);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(280, 30);
            this.txt_HoTen.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên:";
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.Location = new System.Drawing.Point(196, 78);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Size = new System.Drawing.Size(280, 30);
            this.txt_MaKH.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.rdb_TimKiemDinhDanh);
            this.panel2.Controls.Add(this.rdb_TimKiemTen);
            this.panel2.Controls.Add(this.rdb_TimKiemMa);
            this.panel2.Controls.Add(this.txt_TimKiem);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(1036, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(704, 354);
            this.panel2.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Lavender;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.IndianRed;
            this.label11.Location = new System.Drawing.Point(188, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(344, 40);
            this.label11.TabIndex = 19;
            this.label11.Text = "TÌM KIẾM KHÁCH HÀNG";
            // 
            // rdb_TimKiemDinhDanh
            // 
            this.rdb_TimKiemDinhDanh.AutoSize = true;
            this.rdb_TimKiemDinhDanh.Location = new System.Drawing.Point(79, 259);
            this.rdb_TimKiemDinhDanh.Name = "rdb_TimKiemDinhDanh";
            this.rdb_TimKiemDinhDanh.Size = new System.Drawing.Size(252, 27);
            this.rdb_TimKiemDinhDanh.TabIndex = 14;
            this.rdb_TimKiemDinhDanh.TabStop = true;
            this.rdb_TimKiemDinhDanh.Text = "Tìm kiếm theo mã định danh";
            this.rdb_TimKiemDinhDanh.UseVisualStyleBackColor = true;
            // 
            // rdb_TimKiemTen
            // 
            this.rdb_TimKiemTen.AutoSize = true;
            this.rdb_TimKiemTen.Location = new System.Drawing.Point(79, 210);
            this.rdb_TimKiemTen.Name = "rdb_TimKiemTen";
            this.rdb_TimKiemTen.Size = new System.Drawing.Size(264, 27);
            this.rdb_TimKiemTen.TabIndex = 13;
            this.rdb_TimKiemTen.TabStop = true;
            this.rdb_TimKiemTen.Text = "Tìm kiếm theo tên khách hàng";
            this.rdb_TimKiemTen.UseVisualStyleBackColor = true;
            // 
            // rdb_TimKiemMa
            // 
            this.rdb_TimKiemMa.AutoSize = true;
            this.rdb_TimKiemMa.Location = new System.Drawing.Point(79, 162);
            this.rdb_TimKiemMa.Name = "rdb_TimKiemMa";
            this.rdb_TimKiemMa.Size = new System.Drawing.Size(263, 27);
            this.rdb_TimKiemMa.TabIndex = 12;
            this.rdb_TimKiemMa.TabStop = true;
            this.rdb_TimKiemMa.Text = "Tìm kiếm theo mã khách hàng";
            this.rdb_TimKiemMa.UseVisualStyleBackColor = true;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(377, 96);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(246, 30);
            this.txt_TimKiem.TabIndex = 11;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.MistyRose;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(79, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(247, 30);
            this.label12.TabIndex = 10;
            this.label12.Text = "Nhập thông tin cần tìm: ";
            // 
            // QL_DSKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1909, 805);
            this.Controls.Add(this.gb_DSKhachHang);
            this.Name = "QL_DSKhachHang";
            this.Text = "QL_DSKhachHang";
            this.gb_DSKhachHang.ResumeLayout(false);
            this.gb_DSKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbChuky)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.GroupBox gb_DSKhachHang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_Sdt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_NgaySinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_NoiCap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_NgayCap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_MaDinhDanh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rdb_TimKiemDinhDanh;
        private System.Windows.Forms.RadioButton rdb_TimKiemTen;
        private System.Windows.Forms.RadioButton rdb_TimKiemMa;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgv_KhachHang;
        private System.Windows.Forms.CheckBox cb_TinhTrangSD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox ptbChuky;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDinhDanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cbDangSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChuKy;
    }
}