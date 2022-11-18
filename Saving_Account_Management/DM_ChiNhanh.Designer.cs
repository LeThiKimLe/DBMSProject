
namespace Saving_Account_Management
{
    partial class DM_ChiNhanh
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
            this.gb_DMChiNhanh = new System.Windows.Forms.GroupBox();
            this.label_ = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_ChiNhanh = new System.Windows.Forms.DataGridView();
            this.Col_MaCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_TenCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_DiaChiCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_SLNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_TenGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_DMChiNhanh.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ChiNhanh)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_DMChiNhanh
            // 
            this.gb_DMChiNhanh.Controls.Add(this.label_);
            this.gb_DMChiNhanh.Controls.Add(this.panel1);
            this.gb_DMChiNhanh.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gb_DMChiNhanh.Location = new System.Drawing.Point(10, 7);
            this.gb_DMChiNhanh.Margin = new System.Windows.Forms.Padding(2);
            this.gb_DMChiNhanh.Name = "gb_DMChiNhanh";
            this.gb_DMChiNhanh.Padding = new System.Windows.Forms.Padding(2);
            this.gb_DMChiNhanh.Size = new System.Drawing.Size(1044, 648);
            this.gb_DMChiNhanh.TabIndex = 2;
            this.gb_DMChiNhanh.TabStop = false;
            // 
            // label_
            // 
            this.label_.AutoSize = true;
            this.label_.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_.Location = new System.Drawing.Point(429, 0);
            this.label_.Name = "label_";
            this.label_.Size = new System.Drawing.Size(234, 25);
            this.label_.TabIndex = 2;
            this.label_.Text = "THÔNG TIN CHI NHÁNH";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dataGridView_ChiNhanh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 22);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 624);
            this.panel1.TabIndex = 3;
            // 
            // dataGridView_ChiNhanh
            // 
            this.dataGridView_ChiNhanh.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.dataGridView_ChiNhanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ChiNhanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_MaCN,
            this.Col_TenCN,
            this.Col_DiaChiCN,
            this.Col_SLNV,
            this.Col_TenGD});
            this.dataGridView_ChiNhanh.Location = new System.Drawing.Point(17, 34);
            this.dataGridView_ChiNhanh.Name = "dataGridView_ChiNhanh";
            this.dataGridView_ChiNhanh.RowHeadersVisible = false;
            this.dataGridView_ChiNhanh.Size = new System.Drawing.Size(940, 397);
            this.dataGridView_ChiNhanh.TabIndex = 1;
            this.dataGridView_ChiNhanh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ChiNhanh_CellClick_1);
            // 
            // Col_MaCN
            // 
            this.Col_MaCN.DataPropertyName = "MaChiNhanh";
            this.Col_MaCN.FillWeight = 50F;
            this.Col_MaCN.HeaderText = "Mã Chi Nhánh";
            this.Col_MaCN.Name = "Col_MaCN";
            this.Col_MaCN.Width = 145;
            // 
            // Col_TenCN
            // 
            this.Col_TenCN.DataPropertyName = "TenChiNhanh";
            this.Col_TenCN.HeaderText = "Tên Chi Nhánh";
            this.Col_TenCN.Name = "Col_TenCN";
            this.Col_TenCN.Width = 200;
            // 
            // Col_DiaChiCN
            // 
            this.Col_DiaChiCN.DataPropertyName = "DiaChi";
            this.Col_DiaChiCN.HeaderText = "Địa Chỉ ";
            this.Col_DiaChiCN.Name = "Col_DiaChiCN";
            this.Col_DiaChiCN.Width = 220;
            // 
            // Col_SLNV
            // 
            this.Col_SLNV.DataPropertyName = "SoLuong";
            this.Col_SLNV.HeaderText = "Số Lượng Nhân Viên";
            this.Col_SLNV.Name = "Col_SLNV";
            this.Col_SLNV.Width = 170;
            // 
            // Col_TenGD
            // 
            this.Col_TenGD.DataPropertyName = "TenGD";
            this.Col_TenGD.HeaderText = "Tên Giám Đốc";
            this.Col_TenGD.Name = "Col_TenGD";
            this.Col_TenGD.Width = 200;
            // 
            // DM_ChiNhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.gb_DMChiNhanh);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DM_ChiNhanh";
            this.Text = "DM_ChiNhanh";
            this.gb_DMChiNhanh.ResumeLayout(false);
            this.gb_DMChiNhanh.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ChiNhanh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.GroupBox gb_DMChiNhanh;
        private System.Windows.Forms.DataGridView dataGridView_ChiNhanh;
        private System.Windows.Forms.Label label_;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_MaCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_TenCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_DiaChiCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_SLNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_TenGD;
    }
}