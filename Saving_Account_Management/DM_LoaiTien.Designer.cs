﻿
namespace Saving_Account_Management
{
    partial class DM_LoaiTien
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
            this.gb_DMLoaiTien = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Col_MaLoaiTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_LoaiTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_TiGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label__LoaiTien = new System.Windows.Forms.Label();
            this.gb_DMLoaiTien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_DMLoaiTien
            // 
            this.gb_DMLoaiTien.Controls.Add(this.label__LoaiTien);
            this.gb_DMLoaiTien.Controls.Add(this.dataGridView1);
            this.gb_DMLoaiTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gb_DMLoaiTien.Location = new System.Drawing.Point(10, 7);
            this.gb_DMLoaiTien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_DMLoaiTien.Name = "gb_DMLoaiTien";
            this.gb_DMLoaiTien.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_DMLoaiTien.Size = new System.Drawing.Size(1410, 619);
            this.gb_DMLoaiTien.TabIndex = 2;
            this.gb_DMLoaiTien.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_MaLoaiTien,
            this.Col_LoaiTien,
            this.Col_TiGia});
            this.dataGridView1.Location = new System.Drawing.Point(207, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Col_MaLoaiTien
            // 
            this.Col_MaLoaiTien.HeaderText = "Mã Loại Tiền";
            this.Col_MaLoaiTien.Name = "Col_MaLoaiTien";
            this.Col_MaLoaiTien.Width = 200;
            // 
            // Col_LoaiTien
            // 
            this.Col_LoaiTien.HeaderText = "Loại Tiền";
            this.Col_LoaiTien.Name = "Col_LoaiTien";
            this.Col_LoaiTien.Width = 200;
            // 
            // Col_TiGia
            // 
            this.Col_TiGia.HeaderText = "Tỉ Giá VND";
            this.Col_TiGia.Name = "Col_TiGia";
            this.Col_TiGia.Width = 200;
            // 
            // label__LoaiTien
            // 
            this.label__LoaiTien.AutoSize = true;
            this.label__LoaiTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label__LoaiTien.Location = new System.Drawing.Point(395, 36);
            this.label__LoaiTien.Name = "label__LoaiTien";
            this.label__LoaiTien.Size = new System.Drawing.Size(228, 24);
            this.label__LoaiTien.TabIndex = 1;
            this.label__LoaiTien.Text = "THÔNG TIN LOẠI TIỀN";
            // 
            // DM_LoaiTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.gb_DMLoaiTien);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DM_LoaiTien";
            this.Text = "DM_LoaiTien";
            this.gb_DMLoaiTien.ResumeLayout(false);
            this.gb_DMLoaiTien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.GroupBox gb_DMLoaiTien;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label__LoaiTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_MaLoaiTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_LoaiTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_TiGia;
    }
}