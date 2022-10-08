using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using Directives
using DAL;
using BLL;

namespace Property_Rental_App
{
    public partial class uc_PropertyAgent : UserControl
    {
        public uc_PropertyAgent()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            cPropertyAgent pAgent = new cPropertyAgent(Convert.ToInt32(cmb_PropID.SelectedValue.ToString()), Convert.ToInt32(cmb_AgentName.SelectedValue.ToString()), dtp_Date.Value.ToString());

            int x = bll.Insert_PropAgent(pAgent);

            if (x > 0)
            {
                MessageBox.Show(x + " row is successfully Added.", "***Propert Agent EXECUTION WINDOW***", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_PropAgentID.ResetText();
                cmb_AgentName.ResetText();
                cmb_PropID.ResetText();
                dtp_Date.ResetText();
            
            }
            else
            {
                MessageBox.Show("Failed to save data.", "***Propert Agent ERROR EXECUTION WINDOW***", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            dgv_DisplayPropAgent.DataSource = bll.Select_PropAgent();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            cPropertyAgent pAgent = new cPropertyAgent(Convert.ToInt32(txt_PropAgentID.Text),Convert.ToInt32(cmb_PropID.SelectedValue.ToString()), Convert.ToInt32(cmb_AgentName.SelectedValue.ToString()), dtp_Date.Value.ToString());

            int x = bll.Insert_PropAgent(pAgent);

            if (x > 0)
            {
                MessageBox.Show(x + " row is successfully Updated.", "***Propert Agent EXECUTION WINDOW***", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                txt_PropAgentID.ResetText();
                cmb_AgentName.ResetText();
                cmb_PropID.ResetText();
                dtp_Date.ResetText();

                dgv_DisplayPropAgent.DataSource = bll.Select_PropAgent();

            }
            else
            {
                MessageBox.Show("Failed to Update data.", "***Propert Agent ERROR EXECUTION WINDOW***", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void uc_PropertyAgent_Load(object sender, EventArgs e)
        {
            cmb_AgentName.DataSource = bll.SelectAgent();
            cmb_AgentName.DisplayMember = "Name";
            cmb_AgentName.ValueMember = "AgentID";

            cmb_PropID.DataSource = bll.SelectProperty();
            cmb_PropID.DisplayMember = "Description";
            cmb_PropID.ValueMember = "PropertyID";
            
        }

        private void cmb_AgentName_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(cmb_AgentName.Text)) 
            {
                cmb_AgentName.DataSource = bll.SelectAgent();
                cmb_AgentName.DisplayMember = "Name";
                cmb_AgentName.ValueMember = "AgentID";
            }

        }
    }
}
