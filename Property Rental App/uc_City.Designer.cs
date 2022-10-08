
namespace Property_Rental_App
{
    partial class uc_City
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_ProvinceDesc = new System.Windows.Forms.ComboBox();
            this.txt_CityDesc = new System.Windows.Forms.TextBox();
            this.txt_CityID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Select = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_DisplayCity = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Event = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DisplayCity)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.cmb_ProvinceDesc);
            this.groupBox1.Controls.Add(this.txt_CityDesc);
            this.groupBox1.Controls.Add(this.txt_CityID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(855, 246);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "City Information";
            // 
            // cmb_ProvinceDesc
            // 
            this.cmb_ProvinceDesc.FormattingEnabled = true;
            this.cmb_ProvinceDesc.Location = new System.Drawing.Point(222, 124);
            this.cmb_ProvinceDesc.Name = "cmb_ProvinceDesc";
            this.cmb_ProvinceDesc.Size = new System.Drawing.Size(362, 29);
            this.cmb_ProvinceDesc.TabIndex = 10;
            // 
            // txt_CityDesc
            // 
            this.txt_CityDesc.Location = new System.Drawing.Point(222, 81);
            this.txt_CityDesc.Name = "txt_CityDesc";
            this.txt_CityDesc.Size = new System.Drawing.Size(364, 27);
            this.txt_CityDesc.TabIndex = 9;
            // 
            // txt_CityID
            // 
            this.txt_CityID.Enabled = false;
            this.txt_CityID.Location = new System.Drawing.Point(222, 36);
            this.txt_CityID.Name = "txt_CityID";
            this.txt_CityID.Size = new System.Drawing.Size(129, 27);
            this.txt_CityID.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Province Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "City Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "City ID:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_Select);
            this.panel2.Controls.Add(this.btn_Insert);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(3, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(849, 36);
            this.panel2.TabIndex = 4;
            // 
            // btn_Select
            // 
            this.btn_Select.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Select.Location = new System.Drawing.Point(109, 0);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(109, 34);
            this.btn_Select.TabIndex = 1;
            this.btn_Select.Text = "View";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insert.Location = new System.Drawing.Point(0, 0);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(109, 34);
            this.btn_Insert.TabIndex = 0;
            this.btn_Insert.Text = "Save";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_DisplayCity);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(855, 188);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Display City Information";
            // 
            // dgv_DisplayCity
            // 
            this.dgv_DisplayCity.AllowUserToAddRows = false;
            this.dgv_DisplayCity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DisplayCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DisplayCity.Location = new System.Drawing.Point(11, 29);
            this.dgv_DisplayCity.Name = "dgv_DisplayCity";
            this.dgv_DisplayCity.Size = new System.Drawing.Size(829, 158);
            this.dgv_DisplayCity.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_Event);
            this.panel1.Location = new System.Drawing.Point(10, 267);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 23);
            this.panel1.TabIndex = 2;
            // 
            // lbl_Event
            // 
            this.lbl_Event.AutoSize = true;
            this.lbl_Event.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Event.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_Event.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Event.Location = new System.Drawing.Point(0, 0);
            this.lbl_Event.Name = "lbl_Event";
            this.lbl_Event.Size = new System.Drawing.Size(58, 23);
            this.lbl_Event.TabIndex = 6;
            this.lbl_Event.Text = "Event";
            // 
            // uc_City
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "uc_City";
            this.Size = new System.Drawing.Size(895, 511);
            this.Load += new System.EventHandler(this.uc_City_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DisplayCity)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_DisplayCity;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_ProvinceDesc;
        private System.Windows.Forms.TextBox txt_CityDesc;
        private System.Windows.Forms.TextBox txt_CityID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Label lbl_Event;
    }
}
