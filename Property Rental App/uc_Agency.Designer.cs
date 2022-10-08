
namespace Property_Rental_App
{
    partial class uc_Agency
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Event = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_DisplayAgency = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_SuburbDesc = new System.Windows.Forms.ComboBox();
            this.txt_AgencyDesc = new System.Windows.Forms.TextBox();
            this.txt_AgencyID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Select = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DisplayAgency)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_Event);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 246);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 23);
            this.panel1.TabIndex = 5;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_DisplayAgency);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(895, 205);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Display Agency Information";
            // 
            // dgv_DisplayAgency
            // 
            this.dgv_DisplayAgency.AllowUserToAddRows = false;
            this.dgv_DisplayAgency.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DisplayAgency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DisplayAgency.Location = new System.Drawing.Point(11, 29);
            this.dgv_DisplayAgency.Name = "dgv_DisplayAgency";
            this.dgv_DisplayAgency.Size = new System.Drawing.Size(878, 158);
            this.dgv_DisplayAgency.TabIndex = 0;
            this.dgv_DisplayAgency.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DisplayAgency_CellClick);
            this.dgv_DisplayAgency.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DisplayAgency_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.cmb_SuburbDesc);
            this.groupBox1.Controls.Add(this.txt_AgencyDesc);
            this.groupBox1.Controls.Add(this.txt_AgencyID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(901, 246);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agency Information";
            // 
            // cmb_SuburbDesc
            // 
            this.cmb_SuburbDesc.FormattingEnabled = true;
            this.cmb_SuburbDesc.Location = new System.Drawing.Point(222, 124);
            this.cmb_SuburbDesc.Name = "cmb_SuburbDesc";
            this.cmb_SuburbDesc.Size = new System.Drawing.Size(362, 29);
            this.cmb_SuburbDesc.TabIndex = 10;
            // 
            // txt_AgencyDesc
            // 
            this.txt_AgencyDesc.Location = new System.Drawing.Point(222, 81);
            this.txt_AgencyDesc.Name = "txt_AgencyDesc";
            this.txt_AgencyDesc.Size = new System.Drawing.Size(364, 27);
            this.txt_AgencyDesc.TabIndex = 9;
            // 
            // txt_AgencyID
            // 
            this.txt_AgencyID.Enabled = false;
            this.txt_AgencyID.Location = new System.Drawing.Point(222, 36);
            this.txt_AgencyID.Name = "txt_AgencyID";
            this.txt_AgencyID.Size = new System.Drawing.Size(129, 27);
            this.txt_AgencyID.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Suburb Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Agency Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Agency ID:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_Delete);
            this.panel2.Controls.Add(this.btn_Select);
            this.panel2.Controls.Add(this.btn_Insert);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(3, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(895, 36);
            this.panel2.TabIndex = 4;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(218, 0);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(109, 34);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CadetBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 482);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(901, 45);
            this.panel3.TabIndex = 7;
            // 
            // uc_Agency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "uc_Agency";
            this.Size = new System.Drawing.Size(901, 527);
            this.Load += new System.EventHandler(this.uc_Agency_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DisplayAgency)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Event;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_DisplayAgency;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_SuburbDesc;
        private System.Windows.Forms.TextBox txt_AgencyDesc;
        private System.Windows.Forms.TextBox txt_AgencyID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Panel panel3;
    }
}
