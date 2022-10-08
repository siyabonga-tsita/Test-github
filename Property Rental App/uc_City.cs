using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// using directive
using DAL;
using BLL;

namespace Property_Rental_App
{
    public partial class uc_City : UserControl
    {
        public uc_City()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();

        private void uc_City_Load(object sender, EventArgs e)
        {
            cmb_ProvinceDesc.DataSource = bll.SelectProvince();
            cmb_ProvinceDesc.DisplayMember = "Description";
            cmb_ProvinceDesc.ValueMember = "ProvinceID";

            txt_CityID.Enabled = false;
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            cCity city = new cCity(txt_CityDesc.Text, Convert.ToInt32(cmb_ProvinceDesc.SelectedValue.ToString()));
            int x = bll.InsertCity(city);

            if (x > 0)
            {
                MessageBox.Show(x + " row is successfully Added.", "***CITY EXECUTION WINDOW***", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_CityDesc.ResetText();
                txt_CityID.ResetText();
                cmb_ProvinceDesc.ResetText();
            }
            else
            {
                MessageBox.Show("Failed to save data.", "***CITY ERROR EXECUTION WINDOW***", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            dgv_DisplayCity.DataSource = bll.SelectCity();
        }
    }
}
