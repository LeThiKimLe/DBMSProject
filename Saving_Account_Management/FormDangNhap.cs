using Saving_Account_Management.BS_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Saving_Account_Management.DB_Layer;
using Saving_Account_Management.Setting;

namespace Saving_Account_Management
{
    public partial class FormDangNhap : Form
    { 
        public string UserLogin = "";
        DB_Connect db = null;
        BS_FromDangNhap act1 = new BS_FromDangNhap();
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void but_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            DangNhap();
            //Application.Run(new Form1());


        }
         private void DangNhap()
        {
            string maNhanVien = null;
            if(tbUserName.Text == null || tbUserName.Text == ""|| tbPassWord.Text == null|| tbPassWord.Text == ""  )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            else
            {
                try
                {
                    db = new DB_Connect(tbUserName.Text, tbPassWord.Text);
                    AppSettingSingleton.getSetting().CurrentTenDangNhap = tbUserName.Text;
                    AppSettingSingleton.getSetting().SQLConnection = db;
                    BS_DanhMuc act2 = new BS_DanhMuc();
                    maNhanVien = act1.KiemTraDangNhap(tbUserName.Text, tbPassWord.Text);
                    AppSettingSingleton.getSetting().CurrentMaNhanVien = maNhanVien;
                    AppSettingSingleton.getSetting().CurrentQuyen=act2.LayChucVu(maNhanVien).Tables[0].Rows[0][1].ToString();
                    this.Hide();
                    Form1 frm = new Form1();

                    foreach (Control ctrl in frm.panelFunction.Controls)
                    {
                        if (ctrl.Tag != null)
                            if (String.Compare(ctrl.Tag.ToString(), AppSettingSingleton.getSetting().CurrentQuyen) > 0)
                            {
                                ctrl.Visible = false;
                            }
                    }

                    frm.ShowDialog();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message,"Lỗi");
                }
            }
        }

        
           

        private void tbUserName_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tbPassWord_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tbPassWord.PasswordChar = (char)0;
            }
            else
            {
                tbPassWord.PasswordChar = '*';

            }
        }
    }
}
