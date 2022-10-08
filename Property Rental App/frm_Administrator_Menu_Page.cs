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
//using System.Data;
using DAL;
using BLL;

namespace Property_Rental_App
{
    public partial class frm_Admin_Menu_Page : Form
    {
        public frm_Admin_Menu_Page()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Home form = new frm_Home();
            form.Show();
            this.Hide();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        private void frm_Admin_Menu_Page_Load(object sender, EventArgs e)
        {
            frm_Administrator_Sign frm = new frm_Administrator_Sign();
            lbl_LoggedInAs.Text =
               "";

            //uc_PropertyType1.BringToFront();

        }

        private void propertyTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //uc_PropertyType1.BringToFront();
        }

        private void propertyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //uc_Property1.BringToFront();
        }

        private void uc_Property1_Load(object sender, EventArgs e)
        {

        }

        private void provinceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //uc_Province1.BringToFront();
        }

        private void cityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //uc_City1.BringToFront();
        }

        private void propertyAgentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //uc_Agent1.BringToFront();
        }

        private void surbubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //uc_Suburb1.BringToFront();
        }

        private void agencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //uc_Agency1.BringToFront();
        }

        private void propertyAgentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //uc_PropertyAgent1.BringToFront();
        }

        private void pnl_MainR_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
