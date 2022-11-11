﻿using Saving_Account_Management.BS_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saving_Account_Management
{
    public partial class DM_LaiTietKiem : Form
    {
        private BS_DMLoaiTietKiem action = new BS_DMLoaiTietKiem();

        public DM_LaiTietKiem()
        {
            InitializeComponent();
            Load_Data();
        }
        private void Show_Data()
        {

        }
        private void Load_Data()
        {
            dataGridView_LoaiTK.DataSource = action.LayDanhSachLoaiTietKiem().Tables[0];

        }

    }
}
