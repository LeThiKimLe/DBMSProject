using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saving_Account_Management.Setting
{
    public class AppSetting
    {
        public string CurrentLoginedUsername { get; set; }
        public string CurrentUserName { get; set; }

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
