
namespace Property_Rental_App
{
    partial class frm_Admin_Menu_Page
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Admin_Menu_Page));
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agenciesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertyTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.provinceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.surbubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAgenciesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertyAgentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertyAgentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_LoggedInAs = new System.Windows.Forms.Label();
            this.lbl_Admin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_MainR = new System.Windows.Forms.Panel();
            this.pnl_Main.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnl_Top.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Main.Controls.Add(this.menuStrip1);
            this.pnl_Main.Location = new System.Drawing.Point(0, 99);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(992, 48);
            this.pnl_Main.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propertiesToolStripMenuItem,
            this.agenciesToolStripMenuItem,
            this.locationToolStripMenuItem,
            this.manageAgenciesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(990, 46);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(68, 42);
            this.propertiesToolStripMenuItem.Text = "Home";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // agenciesToolStripMenuItem
            // 
            this.agenciesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propertyTypeToolStripMenuItem,
            this.propertyToolStripMenuItem});
            this.agenciesToolStripMenuItem.Name = "agenciesToolStripMenuItem";
            this.agenciesToolStripMenuItem.Size = new System.Drawing.Size(166, 42);
            this.agenciesToolStripMenuItem.Text = "Manage Properties";
            // 
            // propertyTypeToolStripMenuItem
            // 
            this.propertyTypeToolStripMenuItem.Name = "propertyTypeToolStripMenuItem";
            this.propertyTypeToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.propertyTypeToolStripMenuItem.Text = "Property Type";
            this.propertyTypeToolStripMenuItem.Click += new System.EventHandler(this.propertyTypeToolStripMenuItem_Click);
            // 
            // propertyToolStripMenuItem
            // 
            this.propertyToolStripMenuItem.Name = "propertyToolStripMenuItem";
            this.propertyToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.propertyToolStripMenuItem.Text = "Property";
            this.propertyToolStripMenuItem.Click += new System.EventHandler(this.propertyToolStripMenuItem_Click);
            // 
            // locationToolStripMenuItem
            // 
            this.locationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.provinceToolStripMenuItem,
            this.cityToolStripMenuItem,
            this.surbubToolStripMenuItem});
            this.locationToolStripMenuItem.Name = "locationToolStripMenuItem";
            this.locationToolStripMenuItem.Size = new System.Drawing.Size(164, 42);
            this.locationToolStripMenuItem.Text = "Manage Locations";
            // 
            // provinceToolStripMenuItem
            // 
            this.provinceToolStripMenuItem.Name = "provinceToolStripMenuItem";
            this.provinceToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.provinceToolStripMenuItem.Text = "Province";
            this.provinceToolStripMenuItem.Click += new System.EventHandler(this.provinceToolStripMenuItem_Click);
            // 
            // cityToolStripMenuItem
            // 
            this.cityToolStripMenuItem.Name = "cityToolStripMenuItem";
            this.cityToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.cityToolStripMenuItem.Text = "City";
            this.cityToolStripMenuItem.Click += new System.EventHandler(this.cityToolStripMenuItem_Click);
            // 
            // surbubToolStripMenuItem
            // 
            this.surbubToolStripMenuItem.Name = "surbubToolStripMenuItem";
            this.surbubToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.surbubToolStripMenuItem.Text = "Surbub";
            this.surbubToolStripMenuItem.Click += new System.EventHandler(this.surbubToolStripMenuItem_Click);
            // 
            // manageAgenciesToolStripMenuItem
            // 
            this.manageAgenciesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propertyAgentToolStripMenuItem,
            this.agencyToolStripMenuItem,
            this.propertyAgentToolStripMenuItem1});
            this.manageAgenciesToolStripMenuItem.Name = "manageAgenciesToolStripMenuItem";
            this.manageAgenciesToolStripMenuItem.Size = new System.Drawing.Size(165, 42);
            this.manageAgenciesToolStripMenuItem.Text = "Manage Agencies";
            // 
            // propertyAgentToolStripMenuItem
            // 
            this.propertyAgentToolStripMenuItem.Name = "propertyAgentToolStripMenuItem";
            this.propertyAgentToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.propertyAgentToolStripMenuItem.Text = "Sign Up Agent ";
            this.propertyAgentToolStripMenuItem.Click += new System.EventHandler(this.propertyAgentToolStripMenuItem_Click);
            // 
            // agencyToolStripMenuItem
            // 
            this.agencyToolStripMenuItem.Name = "agencyToolStripMenuItem";
            this.agencyToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.agencyToolStripMenuItem.Text = "Agency";
            this.agencyToolStripMenuItem.Click += new System.EventHandler(this.agencyToolStripMenuItem_Click);
            // 
            // propertyAgentToolStripMenuItem1
            // 
            this.propertyAgentToolStripMenuItem1.Name = "propertyAgentToolStripMenuItem1";
            this.propertyAgentToolStripMenuItem1.Size = new System.Drawing.Size(192, 24);
            this.propertyAgentToolStripMenuItem1.Text = "Property Agent";
            this.propertyAgentToolStripMenuItem1.Click += new System.EventHandler(this.propertyAgentToolStripMenuItem1_Click);
            // 
            // pnl_Top
            // 
            this.pnl_Top.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnl_Top.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Top.Controls.Add(this.panel2);
            this.pnl_Top.Controls.Add(this.pictureBox1);
            this.pnl_Top.Controls.Add(this.label2);
            this.pnl_Top.Controls.Add(this.label1);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(913, 101);
            this.pnl_Top.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbl_LoggedInAs);
            this.panel2.Controls.Add(this.lbl_Admin);
            this.panel2.Location = new System.Drawing.Point(503, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 28);
            this.panel2.TabIndex = 4;
            // 
            // lbl_LoggedInAs
            // 
            this.lbl_LoggedInAs.AutoSize = true;
            this.lbl_LoggedInAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_LoggedInAs.Font = new System.Drawing.Font("Arial Nova Cond", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoggedInAs.Location = new System.Drawing.Point(140, 4);
            this.lbl_LoggedInAs.Name = "lbl_LoggedInAs";
            this.lbl_LoggedInAs.Size = new System.Drawing.Size(44, 20);
            this.lbl_LoggedInAs.TabIndex = 4;
            this.lbl_LoggedInAs.Text = "*****";
            // 
            // lbl_Admin
            // 
            this.lbl_Admin.AutoSize = true;
            this.lbl_Admin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Admin.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Admin.Location = new System.Drawing.Point(0, 0);
            this.lbl_Admin.Name = "lbl_Admin";
            this.lbl_Admin.Size = new System.Drawing.Size(150, 23);
            this.lbl_Admin.TabIndex = 3;
            this.lbl_Admin.Text = "Administrator -  ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Property Rental \r\n    Company";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnl_MainR);
            this.panel1.Location = new System.Drawing.Point(1, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 527);
            this.panel1.TabIndex = 4;
            // 
            // pnl_MainR
            // 
            this.pnl_MainR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_MainR.Location = new System.Drawing.Point(0, 0);
            this.pnl_MainR.Name = "pnl_MainR";
            this.pnl_MainR.Size = new System.Drawing.Size(901, 527);
            this.pnl_MainR.TabIndex = 0;
            this.pnl_MainR.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_MainR_Paint);
            // 
            // frm_Admin_Menu_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 674);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Top);
            this.Controls.Add(this.pnl_Main);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Admin_Menu_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Menu Page";
            this.Load += new System.EventHandler(this.frm_Admin_Menu_Page_Load);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_Top.ResumeLayout(false);
            this.pnl_Top.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agenciesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageAgenciesToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_MainR;
        private System.Windows.Forms.ToolStripMenuItem propertyTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem provinceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem surbubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertyAgentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agencyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertyAgentToolStripMenuItem1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Admin;
        private System.Windows.Forms.Label lbl_LoggedInAs;
        //private uc_PropertyType uc_PropertyType1;
        //private uc_Property uc_Property1;
        //private uc_Province uc_Province1;
        //private uc_City uc_City1;
        //private uc_Agent uc_Agent1;
        //private uc_Suburb uc_Suburb1;
        //private uc_Agency uc_Agency1;
        //private uc_PropertyAgent uc_PropertyAgent1;
    }
}