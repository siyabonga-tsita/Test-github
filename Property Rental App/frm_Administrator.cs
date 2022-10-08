using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//directives
using DAL;
using BLL;

namespace Property_Rental_App
{
    public partial class frm_Administrator_Sign : Form
    {
        public frm_Administrator_Sign()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();      

        private void lbl_Register_Click_1(object sender, EventArgs e)
        {
            pnl_Register_Admin.BringToFront();
            pnl_Login_Admin.SendToBack();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            pnl_Login_Admin.BringToFront();
            pnl_Register_Admin.SendToBack();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            cAdmin admin = new cAdmin(txt_Name.Text, txt_Surname.Text, txt_Email_Reg.Text, txt_Password_Reg.Text);
            int x = bll.InsertAdmin(admin);


            if (x > 0)
            {
                MessageBox.Show(x + " Added." +
                    "\nPlease continue to login.", "***EXECUTION WINDOW***", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_Email_Reg.ResetText();
                txt_Password_Reg.ResetText();
                txt_Name.ResetText();
                txt_Surname.ResetText();

                pnl_Login_Admin.BringToFront();
                pnl_Register_Admin.SendToBack();
            }
            else
            {
                MessageBox.Show("Something went wrong, \n\nfailed to save data", "***EXECUTION WINDOW***", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void pic_Encryption_Click(object sender, EventArgs e)
        {
            if (txt_Password_Login.UseSystemPasswordChar == false)
            {
                txt_Password_Login.UseSystemPasswordChar = true;
                pic_Decryption.BringToFront();
            }

        }

        private void pic_Decryption_Click(object sender, EventArgs e)
        {
            if (txt_Password_Login.UseSystemPasswordChar == true)
            {
                txt_Password_Login.UseSystemPasswordChar = false;
                pic_Encryption.BringToFront();
            }

        }

        private void frm_Administrator_Sign_Load(object sender, EventArgs e)
        {
            pnl_Register_Admin.BringToFront();
            txt_Password_Login.UseSystemPasswordChar = true;
            lbl_Error.Visible = false;


        }
        


        public void btn_Login_Click(object sender, EventArgs e)
        {
            cAdmin admin = new cAdmin(txt_Username_Login.Text, txt_Password_Login.Text);
            DataTable dt = bll.SelectAdmin(admin);

            if (dt.Rows.Count > 0)
            {
                //cAdmin admin = new cAdmin(txt_Username_Login.Text, txt_Password_Login.Text);
                DataTable dtLog = bll.SelectAdmin(admin);
                string fullName = dtLog.Rows[0]["FullName"].ToString();

                lbl_Show.Text = fullName;

                MessageBox.Show("Access granted. \n\nWelcome: " + fullName + " to Property Reantal.", "Accessed by: " + fullName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbl_Error.Visible = false;

                frm_Admin_Menu_Page form = new frm_Admin_Menu_Page();
                form.Show();
                this.Hide();

                txt_Username_Login.ResetText();
            }
            else if (dt.Rows.Count == 0)
            {
                lbl_Error.Visible = true;
            }
        }



    }
}













//public string LoggedAs() 
        //{
        //    cAdmin admin = new cAdmin(txt_Username_Login.Text, txt_Password_Login.Text);
        //    DataTable dtLog = bll.SelectAdmin(admin);
        //    string fullName = dtLog.Rows[0]["FullName"].ToString();

        //    return fullName;
        //}

    
    
        ///// <summary>
        ///// 
        ///// </summary>
        //public class cLoggedInAs
        //{
        //    public string FullName { get; }

        //    public cLoggedInAs(string name)
        //    {
        //        this.FullName = name;
        //    }
        //}

        //public string Log(cLoggedInAs log)
        //{
        //    cAdmin admin = new cAdmin(txt_Username_Login.Text, txt_Password_Login.Text);
        //    DataTable dtLog = bll.SelectAdmin(admin);
        //    string fullName = dtLog.Rows[0]["FullName"].ToString();

        //    cLoggedInAs logd = new cLoggedInAs(fullName);
        //    //lbl_Show.Text = logd.FullName;

        //    return logd.FullName;
        //}