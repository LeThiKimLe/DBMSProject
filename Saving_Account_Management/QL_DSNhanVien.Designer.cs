
namespace Saving_Account_Management
{
    partial class QL_DSNhanVien
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
            this.gb_DSNhanVien = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_timkiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_NV = new System.Windows.Forms.DataGridView();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDinhDanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChiNhanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaChiNhanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_machinhanh = new System.Windows.Forms.ComboBox();
            this.label_machinhanh = new System.Windows.Forms.Label();
            this.maNV_tb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmndNV_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sdtNV_tb = new System.Windows.Forms.TextBox();
            this.tenNV_tb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox_timtheoCN = new System.Windows.Forms.ComboBox();
            this.fix_btn = new System.Windows.Forms.Button();
            this.AddNV_btn = new System.Windows.Forms.Button();
            this.DeleteNV_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.button_huy = new System.Windows.Forms.Button();
            this.gb_DSNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_DSNhanVien
            // 
            this.gb_DSNhanVien.Controls.Add(this.fix_btn);
            this.gb_DSNhanVien.Controls.Add(this.AddNV_btn);
            this.gb_DSNhanVien.Controls.Add(this.DeleteNV_btn);
            this.gb_DSNhanVien.Controls.Add(this.save_btn);
            this.gb_DSNhanVien.Controls.Add(this.button_huy);
            this.gb_DSNhanVien.Controls.Add(this.comboBox_timtheoCN);
            this.gb_DSNhanVien.Controls.Add(this.label2);
            this.gb_DSNhanVien.Controls.Add(this.button_timkiem);
            this.gb_DSNhanVien.Controls.Add(this.label1);
            this.gb_DSNhanVien.Controls.Add(this.dataGridView_NV);
            this.gb_DSNhanVien.Controls.Add(this.panel1);
            this.gb_DSNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_DSNhanVien.Location = new System.Drawing.Point(14, 9);
            this.gb_DSNhanVien.Name = "gb_DSNhanVien";
            this.gb_DSNhanVien.Size = new System.Drawing.Size(1883, 762);
            this.gb_DSNhanVien.TabIndex = 5;
            this.gb_DSNhanVien.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(749, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 63;
            this.label2.Text = "Chi Nhánh";
            // 
            // button_timkiem
            // 
            this.button_timkiem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_timkiem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_timkiem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.button_timkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_timkiem.Location = new System.Drawing.Point(1323, 78);
            this.button_timkiem.Name = "button_timkiem";
            this.button_timkiem.Size = new System.Drawing.Size(197, 42);
            this.button_timkiem.TabIndex = 62;
            this.button_timkiem.Text = "Tìm Kiếm";
            this.button_timkiem.UseVisualStyleBackColor = false;
            this.button_timkiem.Click += new System.EventHandler(this.button_timkiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(1094, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // dataGridView_NV
            // 
            this.dataGridView_NV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_NV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhanVien,
            this.HoTen,
            this.NgaySinh,
            this.MaDinhDanh,
            this.SDT,
            this.TenChiNhanh,
            this.TenNhom,
            this.MaChiNhanh});
            this.dataGridView_NV.Location = new System.Drawing.Point(586, 204);
            this.dataGridView_NV.Name = "dataGridView_NV";
            this.dataGridView_NV.RowHeadersWidth = 51;
            this.dataGridView_NV.RowTemplate.Height = 24;
            this.dataGridView_NV.Size = new System.Drawing.Size(1333, 523);
            this.dataGridView_NV.TabIndex = 1;
            this.dataGridView_NV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_NV_CellClick);
            this.dataGridView_NV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_NV_CellContentClick);
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Mã NV";
            this.MaNhanVien.MinimumWidth = 6;
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.Width = 70;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ Và Tên ";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 200;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Width = 150;
            // 
            // MaDinhDanh
            // 
            this.MaDinhDanh.DataPropertyName = "MaDinhDanh";
            this.MaDinhDanh.HeaderText = "Mã Định Danh";
            this.MaDinhDanh.MinimumWidth = 6;
            this.MaDinhDanh.Name = "MaDinhDanh";
            this.MaDinhDanh.Width = 150;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số Điện Thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 150;
            // 
            // TenChiNhanh
            // 
            this.TenChiNhanh.DataPropertyName = "TenChiNhanh";
            this.TenChiNhanh.HeaderText = "Chi Nhánh";
            this.TenChiNhanh.MinimumWidth = 6;
            this.TenChiNhanh.Name = "TenChiNhanh";
            this.TenChiNhanh.Width = 200;
            // 
            // TenNhom
            // 
            this.TenNhom.DataPropertyName = "TenNhom";
            this.TenNhom.HeaderText = "Chức Vụ";
            this.TenNhom.MinimumWidth = 6;
            this.TenNhom.Name = "TenNhom";
            this.TenNhom.Width = 200;
            // 
            // MaChiNhanh
            // 
            this.MaChiNhanh.DataPropertyName = "MaChiNhanh";
            this.MaChiNhanh.HeaderText = "MaCN";
            this.MaChiNhanh.MinimumWidth = 6;
            this.MaChiNhanh.Name = "MaChiNhanh";
            this.MaChiNhanh.Visible = false;
            this.MaChiNhanh.Width = 10;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dateTimePicker_ngaysinh);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comboBox_machinhanh);
            this.panel1.Controls.Add(this.label_machinhanh);
            this.panel1.Controls.Add(this.maNV_tb);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cmndNV_tb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.sdtNV_tb);
            this.panel1.Controls.Add(this.tenNV_tb);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(40, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 360);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePicker_ngaysinh
            // 
            this.dateTimePicker_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_ngaysinh.Location = new System.Drawing.Point(196, 255);
            this.dateTimePicker_ngaysinh.Name = "dateTimePicker_ngaysinh";
            this.dateTimePicker_ngaysinh.Size = new System.Drawing.Size(275, 30);
            this.dateTimePicker_ngaysinh.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 62;
            this.label6.Text = "Ngày Sinh";
            // 
            // comboBox_machinhanh
            // 
            this.comboBox_machinhanh.FormattingEnabled = true;
            this.comboBox_machinhanh.Location = new System.Drawing.Point(196, 303);
            this.comboBox_machinhanh.Name = "comboBox_machinhanh";
            this.comboBox_machinhanh.Size = new System.Drawing.Size(275, 33);
            this.comboBox_machinhanh.TabIndex = 61;
            // 
            // label_machinhanh
            // 
            this.label_machinhanh.AutoSize = true;
            this.label_machinhanh.Location = new System.Drawing.Point(18, 303);
            this.label_machinhanh.Name = "label_machinhanh";
            this.label_machinhanh.Size = new System.Drawing.Size(105, 25);
            this.label_machinhanh.TabIndex = 60;
            this.label_machinhanh.Text = "Chi Nhánh";
            // 
            // maNV_tb
            // 
            this.maNV_tb.Location = new System.Drawing.Point(196, 68);
            this.maNV_tb.Name = "maNV_tb";
            this.maNV_tb.Size = new System.Drawing.Size(275, 30);
            this.maNV_tb.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 25);
            this.label9.TabIndex = 54;
            this.label9.Text = "Mã Nhân viên";
            // 
            // cmndNV_tb
            // 
            this.cmndNV_tb.Location = new System.Drawing.Point(196, 209);
            this.cmndNV_tb.MaxLength = 12;
            this.cmndNV_tb.Name = "cmndNV_tb";
            this.cmndNV_tb.Size = new System.Drawing.Size(275, 30);
            this.cmndNV_tb.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 25);
            this.label5.TabIndex = 50;
            this.label5.Text = "Mã Định Danh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 25);
            this.label4.TabIndex = 49;
            this.label4.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // sdtNV_tb
            // 
            this.sdtNV_tb.Location = new System.Drawing.Point(196, 162);
            this.sdtNV_tb.MaxLength = 10;
            this.sdtNV_tb.Name = "sdtNV_tb";
            this.sdtNV_tb.Size = new System.Drawing.Size(275, 30);
            this.sdtNV_tb.TabIndex = 47;
            // 
            // tenNV_tb
            // 
            this.tenNV_tb.Location = new System.Drawing.Point(196, 110);
            this.tenNV_tb.Name = "tenNV_tb";
            this.tenNV_tb.Size = new System.Drawing.Size(275, 30);
            this.tenNV_tb.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 25);
            this.label11.TabIndex = 44;
            this.label11.Text = "Số điện thoại ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 25);
            this.label12.TabIndex = 43;
            this.label12.Text = "Tên Nhân viên";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // comboBox_timtheoCN
            // 
            this.comboBox_timtheoCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_timtheoCN.FormattingEnabled = true;
            this.comboBox_timtheoCN.Location = new System.Drawing.Point(879, 84);
            this.comboBox_timtheoCN.Name = "comboBox_timtheoCN";
            this.comboBox_timtheoCN.Size = new System.Drawing.Size(392, 33);
            this.comboBox_timtheoCN.TabIndex = 64;
            // 
            // fix_btn
            // 
            this.fix_btn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.fix_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fix_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.fix_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fix_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fix_btn.Location = new System.Drawing.Point(68, 685);
            this.fix_btn.Name = "fix_btn";
            this.fix_btn.Size = new System.Drawing.Size(197, 42);
            this.fix_btn.TabIndex = 65;
            this.fix_btn.Text = "Sửa thông tin";
            this.fix_btn.UseVisualStyleBackColor = false;
            // 
            // AddNV_btn
            // 
            this.AddNV_btn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.AddNV_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AddNV_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.AddNV_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNV_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddNV_btn.Location = new System.Drawing.Point(192, 553);
            this.AddNV_btn.Name = "AddNV_btn";
            this.AddNV_btn.Size = new System.Drawing.Size(200, 42);
            this.AddNV_btn.TabIndex = 68;
            this.AddNV_btn.Text = "Thêm nhân viên";
            this.AddNV_btn.UseVisualStyleBackColor = false;
            // 
            // DeleteNV_btn
            // 
            this.DeleteNV_btn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.DeleteNV_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DeleteNV_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.DeleteNV_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteNV_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteNV_btn.Location = new System.Drawing.Point(318, 685);
            this.DeleteNV_btn.Name = "DeleteNV_btn";
            this.DeleteNV_btn.Size = new System.Drawing.Size(197, 42);
            this.DeleteNV_btn.TabIndex = 69;
            this.DeleteNV_btn.Text = "Xóa nhân viên";
            this.DeleteNV_btn.UseVisualStyleBackColor = false;
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.save_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.save_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.save_btn.Location = new System.Drawing.Point(68, 619);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(200, 42);
            this.save_btn.TabIndex = 66;
            this.save_btn.Text = "Lưu Thông Tin";
            this.save_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.save_btn.UseVisualStyleBackColor = false;
            // 
            // button_huy
            // 
            this.button_huy.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_huy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_huy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.button_huy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_huy.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_huy.Location = new System.Drawing.Point(318, 619);
            this.button_huy.Name = "button_huy";
            this.button_huy.Size = new System.Drawing.Size(197, 42);
            this.button_huy.TabIndex = 67;
            this.button_huy.Text = "Hủy Thao Tác";
            this.button_huy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_huy.UseVisualStyleBackColor = false;
            // 
            // QL_DSNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1909, 780);
            this.Controls.Add(this.gb_DSNhanVien);
            this.Name = "QL_DSNhanVien";
            this.Text = "QL_DSNhanVien";
            this.gb_DSNhanVien.ResumeLayout(false);
            this.gb_DSNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox gb_DSNhanVien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_machinhanh;
        private System.Windows.Forms.TextBox maNV_tb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cmndNV_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sdtNV_tb;
        private System.Windows.Forms.TextBox tenNV_tb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_timkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_NV;
        private System.Windows.Forms.ComboBox comboBox_machinhanh;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ngaysinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDinhDanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChiNhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChiNhanh;
        private System.Windows.Forms.ComboBox comboBox_timtheoCN;
        private System.Windows.Forms.Button fix_btn;
        private System.Windows.Forms.Button AddNV_btn;
        private System.Windows.Forms.Button DeleteNV_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button button_huy;
    }
}