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
        private BS_FromDangNhap act = new BS_FromDangNhap();
        public string UserLogin = "";
        public FormDangNhap()
        {
            InitializeComponent();
        /*   tbUserName.Text = "LTKLe";
            tbPassWord.Text = "SEp9Y4";*/
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
            if(tbUserName.Text == null || tbUserName.Text == ""|| tbPassWord.Text == null|| tbPassWord.Text == ""  )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            else
            {
                if (act.KiemTraDangNhap(tbUserName.Text,tbPassWord.Text) == true)
                {

                    //MessageBox.Show("Đăng nhập thành công ");
                    this.Hide();
                    AppSettingSingleton.getSetting().CurrentLoginedUsername = tbUserName.Text;
                    Form1 frm = new Form1();
                    frm.ShowDialog();
                }
                
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai !! ");
                }
                //tbUserName.DataSource = act.KiemTraDangNhap(tbUserName.Text);
                
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
