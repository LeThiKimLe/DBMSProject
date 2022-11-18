
namespace Saving_Account_Management
{
    partial class DM_LoaiGiaoDich
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
            this.gb_DMLoaiGiaoDich = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_LoaiGD = new System.Windows.Forms.Label();
            this.dataGridView_LoaiGD = new System.Windows.Forms.DataGridView();
            this.Col_MaLoaiGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_TenGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_DMLoaiGiaoDich.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LoaiGD)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_DMLoaiGiaoDich
            // 
            this.gb_DMLoaiGiaoDich.Controls.Add(this.panel1);
            this.gb_DMLoaiGiaoDich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gb_DMLoaiGiaoDich.Location = new System.Drawing.Point(10, 7);
            this.gb_DMLoaiGiaoDich.Margin = new System.Windows.Forms.Padding(2);
            this.gb_DMLoaiGiaoDich.Name = "gb_DMLoaiGiaoDich";
            this.gb_DMLoaiGiaoDich.Padding = new System.Windows.Forms.Padding(2);
            this.gb_DMLoaiGiaoDich.Size = new System.Drawing.Size(1410, 619);
            this.gb_DMLoaiGiaoDich.TabIndex = 2;
            this.gb_DMLoaiGiaoDich.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label_LoaiGD);
            this.panel1.Controls.Add(this.dataGridView_LoaiGD);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.panel1.Location = new System.Drawing.Point(2, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1406, 596);
            this.panel1.TabIndex = 2;
            // 
            // label_LoaiGD
            // 
            this.label_LoaiGD.AutoSize = true;
            this.label_LoaiGD.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_LoaiGD.Location = new System.Drawing.Point(197, 27);
            this.label_LoaiGD.Name = "label_LoaiGD";
            this.label_LoaiGD.Size = new System.Drawing.Size(312, 25);
            this.label_LoaiGD.TabIndex = 0;
            this.label_LoaiGD.Text = "THÔNG TIN CÁC LOẠI GIAO DỊCH";
            // 
            // dataGridView_LoaiGD
            // 
            this.dataGridView_LoaiGD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_LoaiGD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_MaLoaiGD,
            this.Col_TenGD});
            this.dataGridView_LoaiGD.Location = new System.Drawing.Point(59, 54);
            this.dataGridView_LoaiGD.Name = "dataGridView_LoaiGD";
            this.dataGridView_LoaiGD.Size = new System.Drawing.Size(643, 179);
            this.dataGridView_LoaiGD.TabIndex = 1;
            // 
            // Col_MaLoaiGD
            // 
            this.Col_MaLoaiGD.DataPropertyName = "MaLoaiGiaoDich";
            this.Col_MaLoaiGD.HeaderText = "Mã Loại Giao Dịch";
            this.Col_MaLoaiGD.Name = "Col_MaLoaiGD";
            this.Col_MaLoaiGD.Width = 200;
            // 
            // Col_TenGD
            // 
            this.Col_TenGD.DataPropertyName = "TenLoaiGiaoDich";
            this.Col_TenGD.HeaderText = "Tên Loại Giao Dịch";
            this.Col_TenGD.Name = "Col_TenGD";
            this.Col_TenGD.Width = 400;
            // 
            // DM_LoaiGiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.gb_DMLoaiGiaoDich);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DM_LoaiGiaoDich";
            this.Text = "DM_LoaiGiaoDich";
            this.Load += new System.EventHandler(this.DM_LoaiGiaoDich_Load);
            this.gb_DMLoaiGiaoDich.ResumeLayout(false);
            this.gb_DMLoaiGiaoDich.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LoaiGD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.GroupBox gb_DMLoaiGiaoDich;
        private System.Windows.Forms.DataGridView dataGridView_LoaiGD;
        private System.Windows.Forms.Label label_LoaiGD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_MaLoaiGD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_TenGD;
    }
}