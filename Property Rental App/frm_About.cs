using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Property_Rental_App
{
    public partial class frm_About : Form
    {
        public frm_About()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Back_About_Click(object sender, EventArgs e)
        {
            frm_Home home = new frm_Home();
            home.Show();
            this.Hide();
        }
    }
}
