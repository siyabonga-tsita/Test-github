using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Derectives
using DAL;
using BLL;

namespace Property_Rental_App
{
    public partial class uc_Province : UserControl
    {
        public uc_Province()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            cProvince province = new cProvince(txt_ProvinceDesc.Text);
            int x = bll.InsertProvince(province);

            if (x>0)
            {
                MessageBox.Show(x + " row is successfully Added.","***EXECUTION WINDOW***", MessageBoxButtons.OK,MessageBoxIcon.Information);
                txt_ProvinceID.ResetText();
                txt_ProvinceDesc.ResetText();
            }
            else {
                MessageBox.Show("Failed to save data.", "***ERROR EXECUTION WINDOW***", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            dgv_DisplayProvince.DataSource = bll.SelectProvince();
        }

        private void uc_Province_Load(object sender, EventArgs e)
        {

        }
    }
}
