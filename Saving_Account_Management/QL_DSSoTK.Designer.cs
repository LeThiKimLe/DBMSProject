
namespace Saving_Account_Management
{
    partial class QL_DSSoTK
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
            this.gb_DSSoTK = new System.Windows.Forms.GroupBox();
            this.dgv_SoTK = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_SoHuu = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_TKSoHuu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_TKLoaiSo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TKMaSo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.gb_DSSoTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SoTK)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SoHuu)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_DSSoTK
            // 
            this.gb_DSSoTK.Controls.Add(this.dgv_SoTK);
            this.gb_DSSoTK.Controls.Add(this.panel1);
            this.gb_DSSoTK.Controls.Add(this.panel2);
            this.gb_DSSoTK.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_DSSoTK.Location = new System.Drawing.Point(12, 12);
            this.gb_DSSoTK.Name = "gb_DSSoTK";
            this.gb_DSSoTK.Size = new System.Drawing.Size(1880, 797);
            this.gb_DSSoTK.TabIndex = 3;
            this.gb_DSSoTK.TabStop = false;
            this.gb_DSSoTK.Text = "Danh sách sổ tiết kiệm";
            // 
            // dgv_SoTK
            // 
            this.dgv_SoTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SoTK.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_SoTK.Location = new System.Drawing.Point(3, 373);
            this.dgv_SoTK.Name = "dgv_SoTK";
            this.dgv_SoTK.RowHeadersWidth = 51;
            this.dgv_SoTK.RowTemplate.Height = 24;
            this.dgv_SoTK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SoTK.Size = new System.Drawing.Size(1874, 421);
            this.dgv_SoTK.TabIndex = 3;
            this.dgv_SoTK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SoTK_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgv_SoHuu);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(47, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 317);
            this.panel1.TabIndex = 0;
            // 
            // dgv_SoHuu
            // 
            this.dgv_SoHuu.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgv_SoHuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SoHuu.Location = new System.Drawing.Point(115, 120);
            this.dgv_SoHuu.Name = "dgv_SoHuu";
            this.dgv_SoHuu.RowHeadersWidth = 51;
            this.dgv_SoHuu.RowTemplate.Height = 24;
            this.dgv_SoHuu.Size = new System.Drawing.Size(664, 150);
            this.dgv_SoHuu.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Purple;
            this.label10.Location = new System.Drawing.Point(261, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(355, 38);
            this.label10.TabIndex = 18;
            this.label10.Text = "THÔNG TIN CHỦ SỞ HỮU";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_TimKiem);
            this.panel2.Controls.Add(this.txt_TKSoHuu);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cb_TKLoaiSo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_TKMaSo);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(926, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(876, 317);
            this.panel2.TabIndex = 1;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_TimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_TimKiem.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_TimKiem.Image = global::Saving_Account_Management.Properties.Resources.Search;
            this.btn_TimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimKiem.Location = new System.Drawing.Point(665, 118);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(120, 36);
            this.btn_TimKiem.TabIndex = 24;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt_TKSoHuu
            // 
            this.txt_TKSoHuu.Location = new System.Drawing.Point(402, 227);
            this.txt_TKSoHuu.Name = "txt_TKSoHuu";
            this.txt_TKSoHuu.Size = new System.Drawing.Size(232, 30);
            this.txt_TKSoHuu.TabIndex = 3;
            this.txt_TKSoHuu.TextChanged += new System.EventHandler(this.txt_TKSoHuu_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 28);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tìm kiếm theo chủ sở hữu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 28);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tìm kiếm theo mã sổ:";
            // 
            // cb_TKLoaiSo
            // 
            this.cb_TKLoaiSo.FormattingEnabled = true;
            this.cb_TKLoaiSo.Location = new System.Drawing.Point(402, 120);
            this.cb_TKLoaiSo.Name = "cb_TKLoaiSo";
            this.cb_TKLoaiSo.Size = new System.Drawing.Size(232, 31);
            this.cb_TKLoaiSo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(337, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 38);
            this.label1.TabIndex = 20;
            this.label1.Text = "TÌM KIẾM SỔ";
            // 
            // txt_TKMaSo
            // 
            this.txt_TKMaSo.Location = new System.Drawing.Point(402, 176);
            this.txt_TKMaSo.Name = "txt_TKMaSo";
            this.txt_TKMaSo.Size = new System.Drawing.Size(232, 30);
            this.txt_TKMaSo.TabIndex = 2;
            this.txt_TKMaSo.TextChanged += new System.EventHandler(this.txt_TKMaSo_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(114, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(210, 28);
            this.label12.TabIndex = 10;
            this.label12.Text = "Tìm kiếm theo loại sổ:";
            // 
            // QL_DSSoTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1909, 780);
            this.Controls.Add(this.gb_DSSoTK);
            this.Name = "QL_DSSoTK";
            this.Text = "QL_DSSoTK";
            this.gb_DSSoTK.ResumeLayout(false);
            this.gb_DSSoTK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SoTK)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SoHuu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox gb_DSSoTK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_TKMaSo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgv_SoHuu;
        private System.Windows.Forms.ComboBox cb_TKLoaiSo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TKSoHuu;
        private System.Windows.Forms.DataGridView dgv_SoTK;
        private System.Windows.Forms.Button btn_TimKiem;
    }
}