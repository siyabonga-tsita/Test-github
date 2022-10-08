using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using directives
using BLL;
using DAL;


namespace Property_Rental_App
{
    public partial class uc_Suburb : UserControl
    {
        public uc_Suburb()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();

        private void uc_Suburb_Load(object sender, EventArgs e)
        {
            LoadCMB();
        }

        public void LoadCMB() 
        {
            cmb_CityDesc.DataSource = bll.SelectCity();
            cmb_CityDesc.ValueMember = "CityID";
            cmb_CityDesc.DisplayMember = "CityDescription";

            cmb_PostalCode.Items.Add("10001");
            cmb_PostalCode.Items.Add("20001");
            cmb_PostalCode.Items.Add("30001");
            cmb_PostalCode.Items.Add("40001");
            cmb_PostalCode.Items.Add("50001");
            cmb_PostalCode.Items.Add("60001");
            cmb_PostalCode.Items.Add("70001");
            cmb_PostalCode.Items.Add("80001");
            cmb_PostalCode.Items.Add("90001");

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            cSuburb s = new cSuburb(txt_SuburbDesc.Text, cmb_PostalCode.SelectedItem.ToString(), Convert.ToInt32(cmb_CityDesc.SelectedValue.ToString()));
            int x = bll.InsertSuburb(s);
           if (x > 0)
            {
                MessageBox.Show(x + " row is successfully Added.", "***SUBURB EXECUTION WINDOW***", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_SuburbID.ResetText();
                txt_SuburbDesc.ResetText();
                cmb_CityDesc.ResetText();
                cmb_PostalCode.ResetText();
            }
            else
            {
                MessageBox.Show("Failed to save data.", "***SUBURB ERROR EXECUTION WINDOW***", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            dgv_DisplaySuburb.DataSource = bll.SelectSuburb();
        }
    }
}
