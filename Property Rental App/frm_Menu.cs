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
    public partial class frm_Home : Form
    {
        public frm_Home()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Administrator_Sign admin = new frm_Administrator_Sign();
            admin.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //frm_Agent agent = new frm_Agent();
            //agent.Show();
            //this.Hide();
        }
        private void btn_Exit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="FormLoad"></param>
        /// <param name="e"></param>
        private void frm_Home_Load(object sender, EventArgs e)
        {
            //pnl_TopRight_Btn.Location = L


        }


        /// <summary>
        /// name = " IMAGE SLIDER"
        /// </summary>
        private int ImageNumber = 1;
        private void Slider()
        {
            if (ImageNumber == 10) 
            {
                ImageNumber = 1;
            }
            pic_slideShow_H.ImageLocation = string.Format(@"Images\{0}.jpg", ImageNumber);
            ImageNumber++;
        }
       
        private void tmr_SlideShow_H_Tick(object sender, EventArgs e)
        {
            Slider();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="THREE TOP BUTTON"></param>
        /// <param ></param>
        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pnl_Main.Dock = DockStyle.Fill;
            pnl_Header.Dock = DockStyle.Top;
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal; 
        }

        //btn_Close_Home
        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <param name="btn_Close_Home"></param>
        /// <param name="e"></param>
        private void button5_Click_1(object sender, EventArgs e)
        {        
            //btn_Close_Home.DialogResult = DialogResult.Yes;

            if (MessageBox.Show("Click 'Yes' if you want to close the app.", "HOME PAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            else 
            {
                this.Show();              
            }
        }

        private void btn_Maximize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pnl_Header.Dock = DockStyle.Top;
            pnl_Main.Dock = DockStyle.Fill;
        }

        private void btn_Minimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            frm_About about = new frm_About();
            about.Show();
            this.Hide();
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            btn_Close_Home.BackColor = Color.Red;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            btn_Close_Home.BackColor = Color.CadetBlue;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pnl_Left.Width == 242)
            {
                pnl_Left.Width = 70;
            }
            else 
            {
                pnl_Left.Width = 242;
            }
        }
    }
}
