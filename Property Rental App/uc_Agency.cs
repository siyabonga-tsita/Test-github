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
using DAL;
using BLL;

namespace Property_Rental_App
{
    public partial class uc_Agency : UserControl
    {
        public uc_Agency()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();

        private void uc_Agency_Load(object sender, EventArgs e)
        {
            cmb_SuburbDesc.DataSource = bll.SelectSuburb();
            cmb_SuburbDesc.DisplayMember = "SuburbDescription";
            cmb_SuburbDesc.ValueMember = "SuburbID";
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            cAgency agency = new cAgency(txt_AgencyDesc.Text,Convert.ToInt32(cmb_SuburbDesc.SelectedValue.ToString()));
            int x = bll.InsertAgency(agency);

            if (x > 0)
            {
                MessageBox.Show(x + " row is successfully Added.", "***AGENCY EXECUTION WINDOW***", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                txt_AgencyDesc.ResetText();
                cmb_SuburbDesc.ResetText();
                txt_AgencyID.ResetText();
          
            }
            else
            {
                MessageBox.Show("Failed to save data.", "***AGENCY ERROR EXECUTION WINDOW***", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            dgv_DisplayAgency.DataSource = bll.SelectAgency();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            cAgency agency = new cAgency(Convert.ToInt32(txt_AgencyID.Text));
            int x = bll.DeleteAgency(agency);

            if (x > 0)
            {
                MessageBox.Show(x + " row is successfully Removed.", "***AGENCY EXECUTION WINDOW***", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                txt_AgencyDesc.ResetText();
                cmb_SuburbDesc.ResetText();
                txt_AgencyID.ResetText();

                dgv_DisplayAgency.DataSource = bll.SelectAgency();

            }
            else
            {
                MessageBox.Show("Failed to remove data.", "***AGENCY ERROR EXECUTION WINDOW***", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void dgv_DisplayAgency_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_DisplayAgency.SelectedRows.Count > 0)
            {
                txt_AgencyID.Text = dgv_DisplayAgency.SelectedRows[0].Cells["AgencyID"].Value.ToString();
                txt_AgencyDesc.Text = dgv_DisplayAgency.SelectedRows[0].Cells["AgencyName"].Value.ToString();
                cmb_SuburbDesc.Text = dgv_DisplayAgency.SelectedRows[0].Cells["SuburbDescription"].Value.ToString();
            }
            else 
            {
                MessageBox.Show("Failed to display data to form the form controls.", "***AGENCY ERROR EXECUTION WINDOW***", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void dgv_DisplayAgency_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
