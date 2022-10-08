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
using System.Data.SqlClient;
using System.IO;

using DAL;
using BLL;

namespace Property_Rental_App
{
    public partial class uc_Property : UserControl
    {
        public uc_Property()
        {
            InitializeComponent();
        }

        //Class instantiation

        static string sConn = "Data Source = localhost; Initial Catalog = Project-Prototype; Integrated Security = true;";

        SqlConnection dbConn = new SqlConnection(sConn);
        SqlCommand dbComm;
        SqlDataAdapter dbAdapter;
        DataTable dt;

        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void uc_Property_Load(object sender, EventArgs e)
        {
            Load_CMB();
        }

        public void Load_CMB() 
        {
            cmb_Status.Items.Add("Active");
            cmb_Status.Items.Add("In-Active");

            cmb_SuburbDesc.DataSource = bll.SelectSuburb();
            cmb_SuburbDesc.ValueMember = "SuburbID";
            cmb_SuburbDesc.DisplayMember = "SuburbDescription";

            cmb_TypeDesc.DataSource = bll.SelectPropType();
            cmb_TypeDesc.ValueMember = "PropertyTypeID";
            cmb_TypeDesc.DisplayMember = "PropertyTypeDescription";
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {

            try
            {
                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }
            }
            catch { }

            string sql = "sp_InsertProperty";

            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Description", txt_PropDesc.Text);
            dbComm.Parameters.AddWithValue("@Price", Convert.ToDouble(txt_PropPrice.Text));

            MemoryStream memoryStream = new MemoryStream();
            pic_PropertyImage.Image.Save(memoryStream, pic_PropertyImage.Image.RawFormat);

            dbComm.Parameters.AddWithValue("@Image", memoryStream.ToArray());
            dbComm.Parameters.AddWithValue("@PropertyTypeID", Convert.ToInt32(cmb_TypeDesc.SelectedValue.ToString()));
            dbComm.Parameters.AddWithValue("@Status", cmb_Status.SelectedItem.ToString());
            dbComm.Parameters.AddWithValue("@SuburbID", Convert.ToInt32(cmb_SuburbDesc.SelectedValue.ToString()));

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();

            if (x > 0)
            {
                MessageBox.Show(x + " row successfully Saved","***PROPERTY EXECUTION WINDOW***", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                pic_PropertyImage.ResetText();
                txt_ID.ResetText();
                txt_PropDesc.ResetText();
                txt_PropPrice.ResetText();
                cmb_TypeDesc.ResetText();
                cmb_SuburbDesc.ResetText();
                cmb_Status.ResetText();
            }
            else
            {
                MessageBox.Show("Something went wrong!!! \n\nFailed to Save", "***PROPERTY ERROR EXECUTION WINDOW***", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }


        }
        

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Select image(*.png)|*.jfif|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                pic_PropertyImage.Image = Image.FromFile(openFileDialog1.FileName);
            }
            pic_PropertyImage.ResetText();

            //string imgLocation = " ";
            //OpenFileDialog dialog = new OpenFileDialog();
            //dialog.Filter = "png files(*.png)|*.jfif|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";

            //if (dialog.ShowDialog() == DialogResult.OK)
            //{
            //    imgLocation = dialog.FileName.ToString();
            //    pic_PropertyImage.ImageLocation = imgLocation;
            //}
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            Load_Data();
        }
        private void Load_Data() 
        {
            try
            {
                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }
            }
            catch { }

            string sql = "sp_SelectProperty";

            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            //dt.Clear();
            dbAdapter.Fill(dt);         

            dgv_DisplayProperty.RowTemplate.Height = 60;
            DataGridViewImageColumn pic1 = new DataGridViewImageColumn();
            pic1 = (DataGridViewImageColumn)dgv_DisplayProperty.Columns["Image"];
            pic1.ImageLayout = DataGridViewImageCellLayout.Stretch; 
            
            dbConn.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

        }

        private void btn_Soft_Del_Click(object sender, EventArgs e)
        {

        }

        private void btn_Hard_Del_Click(object sender, EventArgs e)
        {

        }

        private void btn_SelectALL_Click(object sender, EventArgs e)
        {

        }

        private void dgv_DisplayProperty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_DisplayProperty.SelectedRows.Count > 0)
            {
                txt_ID.Text = dgv_DisplayProperty.SelectedRows[0].Cells["PropertyID"].Value.ToString();
                txt_PropDesc.Text = dgv_DisplayProperty.SelectedRows[0].Cells["Description"].Value.ToString();
                txt_PropPrice.Text = dgv_DisplayProperty.SelectedRows[0].Cells["Price"].Value.ToString();
                cmb_Status.SelectedItem = dgv_DisplayProperty.SelectedRows[0].Cells["Status"].Value.ToString();
                cmb_SuburbDesc.Text = dgv_DisplayProperty.SelectedRows[0].Cells["SuburbID"].Value.ToString();
                cmb_TypeDesc.Text = dgv_DisplayProperty.SelectedRows[0].Cells["PropertyTypeID"].Value.ToString();

                MemoryStream memoryStr = new MemoryStream((byte[])dgv_DisplayProperty.SelectedRows[0].Cells["Image"].Value);
                pic_PropertyImage.Image = Image.FromStream(memoryStr);
            }
            else 
            {
                MessageBox.Show("Something went wrong!!! \n\nFailed to Display data to form controls.", "***PROPERTY ERROR EXECUTION WINDOW***", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
        }
    }
}
