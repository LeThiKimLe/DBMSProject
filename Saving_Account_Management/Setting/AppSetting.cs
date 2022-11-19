using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Saving_Account_Management.DB_Layer;

namespace Saving_Account_Management.Setting
{
    public class AppSetting
    {
        public string CurrentTenDangNhap { get; set; }
        public string CurrentMaNhanVien { get; set; }
        public string CurrentTenhanVien { get; set; }
        public string CurrentQuyen { get; set; }

        public DB_Connect SQLConnection { get; set; }

        //public string CurrentDate { get; set; }

        //
    }

    public class AppSettingSingleton
    {
        private static readonly AppSetting instance = new AppSetting();
        
        public static AppSetting getSetting()
        {
            return instance;
        }
    }
}
