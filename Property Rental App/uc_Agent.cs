using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using directive
using DAL;
using BLL;

namespace Property_Rental_App
{
    public partial class uc_Agent : UserControl
    {
        public uc_Agent()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            cAgent agent = new cAgent(txt_Name.Text,txt_Surname.Text, txt_Email.Text,txt_Password.Text,txt_Phone.Text,cmb_Status.SelectedItem.ToString(),Convert.ToInt32(cmb_AgencyID.SelectedValue.ToString()));
            int x = bll.InsertAgent(agent);

            if (x > 0)
            {
                MessageBox.Show(x + " row is successfully Added.", "***CITY EXECUTION WINDOW***", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_AgentID.ResetText();
                txt_Name.ResetText();
                txt_Email.ResetText();
                txt_Surname.ResetText();
                txt_Password.ResetText();
                cmb_Status.ResetText();
                cmb_AgencyID.ResetText();
                txt_Phone.ResetText();
            }
            else
            {
                MessageBox.Show("Failed to save data.", "***CITY ERROR EXECUTION WINDOW***", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            dgv_DisplayAgent.DataSource = bll.SelectAgent();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            cAgent agent = new cAgent(Convert.ToInt32(txt_AgentID.Text),txt_Email.Text,txt_Phone.Text, cmb_Status.SelectedItem.ToString());
            int x = bll.UpdateAgent(agent);

            if (x > 0)
            {
                MessageBox.Show(x + " row is successfully Updated.", "***CITY EXECUTION WINDOW***", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_AgentID.ResetText();
                txt_Name.ResetText();
                txt_Email.ResetText();
                txt_Surname.ResetText();
                txt_Password.ResetText();
                cmb_Status.ResetText();
                cmb_AgencyID.ResetText();
                txt_Phone.ResetText();

                dgv_DisplayAgent.DataSource = bll.SelectAgent();
            }
            else
            {
                MessageBox.Show("Failed to Update data.", "***CITY ERROR EXECUTION WINDOW***", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btn_SoftDel_Click(object sender, EventArgs e)
        {
            cAgent agent = new cAgent(Convert.ToInt32(txt_AgentID.Text), "In-Active");
            int x = bll.DeleteSoft_Agent(agent);

            if (x > 0)
            {
                MessageBox.Show(x + " row is successfully De-Activated.", "***CITY EXECUTION WINDOW***", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_AgentID.ResetText();
                txt_Name.ResetText();
                txt_Email.ResetText();
                txt_Surname.ResetText();
                txt_Password.ResetText();
                cmb_Status.ResetText();
                cmb_AgencyID.ResetText();
                txt_Phone.ResetText();

                dgv_DisplayAgent.DataSource = bll.SelectAgent();
            }
            else
            {
                MessageBox.Show("Failed to De-active data.", "***CITY ERROR EXECUTION WINDOW***", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btn_HardDel_Click(object sender, EventArgs e)
        {
            cAgent agent = new cAgent(Convert.ToInt32(txt_AgentID.Text));
            int x = bll.DeleteHard_Agent(agent);

            if (x > 0)
            {
                MessageBox.Show(x + " row is successfully Removed.", "***CITY EXECUTION WINDOW***", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_AgentID.ResetText();
                txt_Name.ResetText();
                txt_Email.ResetText();
                txt_Surname.ResetText();
                txt_Password.ResetText();
                cmb_Status.ResetText();
                cmb_AgencyID.ResetText();
                txt_Phone.ResetText();

                dgv_DisplayAgent.DataSource = bll.SelectAgent();
            }
            else
            {
                MessageBox.Show("Failed to Remove data.", "***CITY ERROR EXECUTION WINDOW***", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void uc_Agent_Load(object sender, EventArgs e)
        {
            cmb_Status.Items.Add("Active");
            cmb_Status.Items.Add("In-Active");

            cmb_AgencyID.DataSource = bll.SelectAgency();
            cmb_AgencyID.DisplayMember = "AgencyName";
            cmb_AgencyID.ValueMember = "AgencyID";

            cmb_AgencyID.ResetText();
        }

        private void dgv_DisplayAgent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmb_AgencyID.ResetText();

            if (dgv_DisplayAgent.SelectedRows.Count>0)
            {
                
                txt_Name.Text = dgv_DisplayAgent.SelectedRows[0].Cells["Name"].Value.ToString();
                txt_Surname.Text = dgv_DisplayAgent.SelectedRows[0].Cells["Surname"].Value.ToString();
                txt_Email.Text = dgv_DisplayAgent.SelectedRows[0].Cells["Email"].Value.ToString();
                txt_Password.Text = dgv_DisplayAgent.SelectedRows[0].Cells["Password"].Value.ToString();
                txt_AgentID.Text = dgv_DisplayAgent.SelectedRows[0].Cells["AgentID"].Value.ToString();
                txt_Phone.Text = dgv_DisplayAgent.SelectedRows[0].Cells["Phone"].Value.ToString();
                cmb_AgencyID.Text = dgv_DisplayAgent.CurrentRow.Cells[7].Value.ToString();
                cmb_Status.Text = dgv_DisplayAgent.SelectedRows[0].Cells["Status"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Failed to display data to form the form controls.", "***AGENT ERROR EXECUTION WINDOW***", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            
        }

        private void btn_DisplayAll_Click(object sender, EventArgs e)
        {
            dgv_DisplayAgent.DataSource = bll.DisplayAll_Agent();
        }
    }
}
