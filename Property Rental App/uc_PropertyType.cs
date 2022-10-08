using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// using Directive
using DAL;
using BLL;

namespace Property_Rental_App
{
    public partial class uc_PropertyType : UserControl
    {
        public uc_PropertyType()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();

        private void btn_Save_Click(object sender, EventArgs e)
        {
            cPropertyType type = new cPropertyType(txt_Desc.Text);
            int x = bll.InsertPropType(type);


            if (x>0)
            {
                MessageBox.Show(x + " Added", "***EXECUTION WINDOW***",MessageBoxButtons.OK,MessageBoxIcon.Information);

                txt_Desc.ResetText();
                txt_ID.ResetText();
            }
            else 
            {
                MessageBox.Show("Failed to Save data", "***EXECUTION WINDOW***", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            dgv_PropertyType.DataSource = bll.SelectPropType();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
         
        }

        private void uc_PropertyType_Load(object sender, EventArgs e)
        {
            
        }
    }
}
