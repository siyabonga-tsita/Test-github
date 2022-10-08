
namespace Property_Rental_App
{
    partial class uc_Property
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
            this.cmb_Status = new System.Windows.Forms.ComboBox();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pic_PropertyImage = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_PropPrice = new System.Windows.Forms.TextBox();
            this.txt_PropDesc = new System.Windows.Forms.TextBox();
            this.cmb_TypeDesc = new System.Windows.Forms.ComboBox();
            this.cmb_SuburbDesc = new System.Windows.Forms.ComboBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_SelectALL = new System.Windows.Forms.Button();
            this.btn_Hard_Del = new System.Windows.Forms.Button();
            this.btn_Soft_Del = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Select = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_DisplayProperty = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Events = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PropertyImage)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DisplayProperty)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.cmb_Status);
            this.groupBox1.Controls.Add(this.btn_Upload);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_PropPrice);
            this.groupBox1.Controls.Add(this.txt_PropDesc);
            this.groupBox1.Controls.Add(this.cmb_TypeDesc);
            this.groupBox1.Controls.Add(this.cmb_SuburbDesc);
            this.groupBox1.Controls.Add(this.txt_ID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(851, 277);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Property Infomation";
            // 
            // cmb_Status
            // 
            this.cmb_Status.FormattingEnabled = true;
            this.cmb_Status.Location = new System.Drawing.Point(174, 200);
            this.cmb_Status.Name = "cmb_Status";
            this.cmb_Status.Size = new System.Drawing.Size(273, 29);
            this.cmb_Status.TabIndex = 20;
            // 
            // btn_Upload
            // 
            this.btn_Upload.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Upload.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Upload.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Upload.Location = new System.Drawing.Point(532, 201);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(214, 32);
            this.btn_Upload.TabIndex = 19;
            this.btn_Upload.Text = "Upload Property Image";
            this.btn_Upload.UseVisualStyleBackColor = false;
            this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pic_PropertyImage);
            this.panel3.Location = new System.Drawing.Point(532, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 100);
            this.panel3.TabIndex = 18;
            // 
            // pic_PropertyImage
            // 
            this.pic_PropertyImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_PropertyImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_PropertyImage.Location = new System.Drawing.Point(0, 0);
            this.pic_PropertyImage.Name = "pic_PropertyImage";
            this.pic_PropertyImage.Size = new System.Drawing.Size(212, 98);
            this.pic_PropertyImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_PropertyImage.TabIndex = 5;
            this.pic_PropertyImage.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Suburb Description:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Property Type Desc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Property Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Property Description: ";
            // 
            // txt_PropPrice
            // 
            this.txt_PropPrice.Location = new System.Drawing.Point(174, 65);
            this.txt_PropPrice.Name = "txt_PropPrice";
            this.txt_PropPrice.Size = new System.Drawing.Size(178, 27);
            this.txt_PropPrice.TabIndex = 10;
            // 
            // txt_PropDesc
            // 
            this.txt_PropDesc.Location = new System.Drawing.Point(532, 46);
            this.txt_PropDesc.Multiline = true;
            this.txt_PropDesc.Name = "txt_PropDesc";
            this.txt_PropDesc.Size = new System.Drawing.Size(283, 46);
            this.txt_PropDesc.TabIndex = 9;
            // 
            // cmb_TypeDesc
            // 
            this.cmb_TypeDesc.FormattingEnabled = true;
            this.cmb_TypeDesc.Location = new System.Drawing.Point(174, 157);
            this.cmb_TypeDesc.Name = "cmb_TypeDesc";
            this.cmb_TypeDesc.Size = new System.Drawing.Size(273, 29);
            this.cmb_TypeDesc.TabIndex = 8;
            // 
            // cmb_SuburbDesc
            // 
            this.cmb_SuburbDesc.FormattingEnabled = true;
            this.cmb_SuburbDesc.Location = new System.Drawing.Point(174, 110);
            this.cmb_SuburbDesc.Name = "cmb_SuburbDesc";
            this.cmb_SuburbDesc.Size = new System.Drawing.Size(273, 29);
            this.cmb_SuburbDesc.TabIndex = 7;
            // 
            // txt_ID
            // 
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(174, 29);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(116, 27);
            this.txt_ID.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Property ID:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_SelectALL);
            this.panel2.Controls.Add(this.btn_Hard_Del);
            this.panel2.Controls.Add(this.btn_Soft_Del);
            this.panel2.Controls.Add(this.btn_Update);
            this.panel2.Controls.Add(this.btn_Select);
            this.panel2.Controls.Add(this.btn_Insert);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(3, 238);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(845, 36);
            this.panel2.TabIndex = 3;
            // 
            // btn_SelectALL
            // 
            this.btn_SelectALL.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_SelectALL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SelectALL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelectALL.Location = new System.Drawing.Point(734, 0);
            this.btn_SelectALL.Name = "btn_SelectALL";
            this.btn_SelectALL.Size = new System.Drawing.Size(109, 34);
            this.btn_SelectALL.TabIndex = 7;
            this.btn_SelectALL.Text = "View All ";
            this.btn_SelectALL.UseVisualStyleBackColor = true;
            this.btn_SelectALL.Click += new System.EventHandler(this.btn_SelectALL_Click);
            // 
            // btn_Hard_Del
            // 
            this.btn_Hard_Del.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Hard_Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Hard_Del.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Hard_Del.Location = new System.Drawing.Point(466, 0);
            this.btn_Hard_Del.Name = "btn_Hard_Del";
            this.btn_Hard_Del.Size = new System.Drawing.Size(190, 34);
            this.btn_Hard_Del.TabIndex = 6;
            this.btn_Hard_Del.Text = "Permanent Delete";
            this.btn_Hard_Del.UseVisualStyleBackColor = true;
            this.btn_Hard_Del.Click += new System.EventHandler(this.btn_Hard_Del_Click);
            // 
            // btn_Soft_Del
            // 
            this.btn_Soft_Del.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Soft_Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Soft_Del.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Soft_Del.Location = new System.Drawing.Point(327, 0);
            this.btn_Soft_Del.Name = "btn_Soft_Del";
            this.btn_Soft_Del.Size = new System.Drawing.Size(139, 34);
            this.btn_Soft_Del.TabIndex = 3;
            this.btn_Soft_Del.Text = "Soft Delete";
            this.btn_Soft_Del.UseVisualStyleBackColor = true;
            this.btn_Soft_Del.Click += new System.EventHandler(this.btn_Soft_Del_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(218, 0);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(109, 34);
            this.btn_Update.TabIndex = 2;
            this.btn_Update.Text = "Edit";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
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
            this.groupBox2.Controls.Add(this.dgv_DisplayProperty);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 339);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(851, 190);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Display Property Information";
            // 
            // dgv_DisplayProperty
            // 
            this.dgv_DisplayProperty.AllowUserToAddRows = false;
            this.dgv_DisplayProperty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DisplayProperty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DisplayProperty.Location = new System.Drawing.Point(15, 26);
            this.dgv_DisplayProperty.Name = "dgv_DisplayProperty";
            this.dgv_DisplayProperty.Size = new System.Drawing.Size(825, 158);
            this.dgv_DisplayProperty.TabIndex = 0;
            this.dgv_DisplayProperty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DisplayProperty_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_Events);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(4, 291);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 24);
            this.panel1.TabIndex = 2;
            // 
            // lbl_Events
            // 
            this.lbl_Events.AutoSize = true;
            this.lbl_Events.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_Events.Location = new System.Drawing.Point(0, 0);
            this.lbl_Events.Name = "lbl_Events";
            this.lbl_Events.Size = new System.Drawing.Size(58, 20);
            this.lbl_Events.TabIndex = 17;
            this.lbl_Events.Text = "Events";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // uc_Property
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "uc_Property";
            this.Size = new System.Drawing.Size(874, 532);
            this.Load += new System.EventHandler(this.uc_Property_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_PropertyImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DisplayProperty)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pic_PropertyImage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_PropPrice;
        private System.Windows.Forms.TextBox txt_PropDesc;
        private System.Windows.Forms.ComboBox cmb_TypeDesc;
        private System.Windows.Forms.ComboBox cmb_SuburbDesc;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Hard_Del;
        private System.Windows.Forms.Button btn_Soft_Del;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_DisplayProperty;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Events;
        private System.Windows.Forms.Button btn_Upload;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_SelectALL;
        private System.Windows.Forms.ComboBox cmb_Status;
    }
}
