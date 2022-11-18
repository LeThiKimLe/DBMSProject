
namespace Saving_Account_Management
{
    partial class DM_LaiTietKiem
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
            this.gb_DMLaiTietKiem = new System.Windows.Forms.GroupBox();
            this.label_LoaiTK = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_LoaiTK = new System.Windows.Forms.DataGridView();
            this.Col_MaLoaiTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_TenHinhThucGui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_TenHTTLai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_KyHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_LaiSuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_DMLaiTietKiem.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LoaiTK)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_DMLaiTietKiem
            // 
            this.gb_DMLaiTietKiem.Controls.Add(this.label_LoaiTK);
            this.gb_DMLaiTietKiem.Controls.Add(this.panel1);
            this.gb_DMLaiTietKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gb_DMLaiTietKiem.Location = new System.Drawing.Point(10, 7);
            this.gb_DMLaiTietKiem.Margin = new System.Windows.Forms.Padding(2);
            this.gb_DMLaiTietKiem.Name = "gb_DMLaiTietKiem";
            this.gb_DMLaiTietKiem.Padding = new System.Windows.Forms.Padding(2);
            this.gb_DMLaiTietKiem.Size = new System.Drawing.Size(1410, 619);
            this.gb_DMLaiTietKiem.TabIndex = 2;
            this.gb_DMLaiTietKiem.TabStop = false;
            // 
            // label_LoaiTK
            // 
            this.label_LoaiTK.AutoSize = true;
            this.label_LoaiTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_LoaiTK.Location = new System.Drawing.Point(357, 40);
            this.label_LoaiTK.Name = "label_LoaiTK";
            this.label_LoaiTK.Size = new System.Drawing.Size(281, 24);
            this.label_LoaiTK.TabIndex = 1;
            this.label_LoaiTK.Text = "THÔNG TIN LOẠI TIẾT KIỆM";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBox_Search);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView_LoaiTK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel1.Location = new System.Drawing.Point(2, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1406, 596);
            this.panel1.TabIndex = 3;
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(291, 77);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(387, 27);
            this.textBox_Search.TabIndex = 4;
            this.textBox_Search.TextChanged += new System.EventHandler(this.textBox_Search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(142, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tìm Kiếm";
            // 
            // dataGridView_LoaiTK
            // 
            this.dataGridView_LoaiTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_LoaiTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_MaLoaiTK,
            this.Col_TenHinhThucGui,
            this.Col_TenHTTLai,
            this.Col_KyHan,
            this.Col_LaiSuat});
            this.dataGridView_LoaiTK.Location = new System.Drawing.Point(56, 168);
            this.dataGridView_LoaiTK.Name = "dataGridView_LoaiTK";
            this.dataGridView_LoaiTK.Size = new System.Drawing.Size(857, 399);
            this.dataGridView_LoaiTK.TabIndex = 0;
            // 
            // Col_MaLoaiTK
            // 
            this.Col_MaLoaiTK.DataPropertyName = "MaLoaiTietKiem";
            this.Col_MaLoaiTK.HeaderText = "Mã Loại Tiết Kiệm";
            this.Col_MaLoaiTK.Name = "Col_MaLoaiTK";
            this.Col_MaLoaiTK.Width = 155;
            // 
            // Col_TenHinhThucGui
            // 
            this.Col_TenHinhThucGui.DataPropertyName = "TenHinhThucGui";
            this.Col_TenHinhThucGui.HeaderText = "Tên Hình Thức Gửi";
            this.Col_TenHinhThucGui.Name = "Col_TenHinhThucGui";
            this.Col_TenHinhThucGui.Width = 170;
            // 
            // Col_TenHTTLai
            // 
            this.Col_TenHTTLai.DataPropertyName = "TenHinhThucTraLai";
            this.Col_TenHTTLai.HeaderText = "Tên Hình Thức Trả Lãi";
            this.Col_TenHTTLai.Name = "Col_TenHTTLai";
            this.Col_TenHTTLai.Width = 190;
            // 
            // Col_KyHan
            // 
            this.Col_KyHan.DataPropertyName = "KyHan";
            this.Col_KyHan.HeaderText = "Kỳ Hạn";
            this.Col_KyHan.Name = "Col_KyHan";
            this.Col_KyHan.Width = 150;
            // 
            // Col_LaiSuat
            // 
            this.Col_LaiSuat.DataPropertyName = "LaiSuat";
            this.Col_LaiSuat.HeaderText = "Lãi Suất";
            this.Col_LaiSuat.Name = "Col_LaiSuat";
            this.Col_LaiSuat.Width = 150;
            // 
            // DM_LaiTietKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.gb_DMLaiTietKiem);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DM_LaiTietKiem";
            this.Text = "DM_LaiTietKiem";
            this.gb_DMLaiTietKiem.ResumeLayout(false);
            this.gb_DMLaiTietKiem.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LoaiTK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.GroupBox gb_DMLaiTietKiem;
        private System.Windows.Forms.Label label_LoaiTK;
        private System.Windows.Forms.DataGridView dataGridView_LoaiTK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_MaLoaiTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_TenHinhThucGui;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_TenHTTLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_KyHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_LaiSuat;
    }
}