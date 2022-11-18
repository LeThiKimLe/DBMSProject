using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saving_Account_Management.UserControl.TextBoxs
{
    public class TextBoxDiaChi : TextBoxValidationBase
    {
        protected override bool RunValidateData(ref string errorMessage)
        {
            this.Text = this.Text.Trim();
            if (this.Text.Length == 0)
            {
                errorMessage = "Địa chỉ không được trống";
                return false;
            }
            return true;
        }
    }

    public class TextBoxHoTen : TextBoxValidationBase
    {
        protected override bool RunValidateData(ref string errorMessage)
        {
            this.Text = this.Text.Trim();
            if (this.Text.Length == 0)
            {
                errorMessage = "Họ và tên không được trống";
                return false;
            }
            return true;
        }
    }

    public class TextBoxMaKhachHang : TextBoxValidationBase
    {
        protected override bool RunValidateData(ref string errorMessage)
        {
            this.Text = this.Text.Trim();
            if (this.Text.Length == 0)
            {
                errorMessage = "Mã khách hàng không được trống";
                return false;
            }

            return true;
        }
    }

    public class TextBoxNoiCap : TextBoxValidationBase
    {
        protected override bool RunValidateData(ref string errorMessage)
        {
            this.Text = this.Text.Trim();
            if (this.Text.Length == 0)
            {
                errorMessage = "Nơi cấp không được trống";
                return false;
            }

            return true;
        }
    }

    public class TextBoxMaDinhDanh : TextBoxValidationBase
    {
        protected override bool RunValidateData(ref string errorMessage)
        {
            this.Text = this.Text.Trim();
            if (this.Text.Length == 0)
            {
                errorMessage = "Mã dịnh danh không được trống";
                return false;
            }

            return true;
        }
    }

    public class TextBoxSoDienThoai : TextBoxValidationBase
    {
        protected override bool RunValidateData(ref string errorMessage)
        {
            this.Text = this.Text.Trim();
            if (!this.Text.All(u => "1234567890".Contains(u)))
            {
                errorMessage = "Số điện thoại chỉ được chứa các ký tự số";
                return false;
            }
            if (this.Text.Length != 10)
            {
                errorMessage = "Số điện thoại phải có 10 ký tự (thử nghiệm)";
                return false;
            }
            return true;
        }
    }
}
