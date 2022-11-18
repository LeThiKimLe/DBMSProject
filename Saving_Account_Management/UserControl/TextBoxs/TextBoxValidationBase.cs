using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saving_Account_Management.UserControl.TextBoxs
{
    public class TextBoxValidationBase : TextBox
    {
        public TextBoxValidationBase()
            : base()
        {

        }

        protected virtual bool RunValidateData(ref string errorMessage)
        {
            throw new NotImplementedException();
        }

        public bool Validate(bool throwException = true)
        {
            string errorMessage = null;
            if (!this.RunValidateData(ref errorMessage))
            {
                if (throwException)
                {
                    throw new Exception(errorMessage);
                }
                return false;
            }
            return true;
        }
    }
}
