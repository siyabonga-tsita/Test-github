
namespace Property_Rental_App
{
    partial class frm_About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_About));
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.pnl_TopRight_Btn = new System.Windows.Forms.Panel();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.btn_Maximize = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.ucAbout1 = new Property_Rental_App.ucAbout();
            this.btn_Back_About = new System.Windows.Forms.Button();
            this.pnl_Header.SuspendLayout();
            this.pnl_TopRight_Btn.SuspendLayout();
            this.pnl_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.CadetBlue;
            this.pnl_Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Header.Controls.Add(this.btn_Back_About);
            this.pnl_Header.Controls.Add(this.pnl_TopRight_Btn);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(802, 58);
            this.pnl_Header.TabIndex = 12;
            // 
            // pnl_TopRight_Btn
            // 
            this.pnl_TopRight_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_TopRight_Btn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_TopRight_Btn.Controls.Add(this.btn_Minimize);
            this.pnl_TopRight_Btn.Controls.Add(this.btn_Maximize);
            this.pnl_TopRight_Btn.Controls.Add(this.button5);
            this.pnl_TopRight_Btn.Location = new System.Drawing.Point(634, 1);
            this.pnl_TopRight_Btn.Name = "pnl_TopRight_Btn";
            this.pnl_TopRight_Btn.Size = new System.Drawing.Size(163, 50);
            this.pnl_TopRight_Btn.TabIndex = 0;
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Minimize.ForeColor = System.Drawing.Color.White;
            this.btn_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("btn_Minimize.Image")));
            this.btn_Minimize.Location = new System.Drawing.Point(8, -1);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(46, 46);
            this.btn_Minimize.TabIndex = 9;
            this.btn_Minimize.UseVisualStyleBackColor = false;
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_Maximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Maximize.ForeColor = System.Drawing.Color.White;
            this.btn_Maximize.Image = ((System.Drawing.Image)(resources.GetObject("btn_Maximize.Image")));
            this.btn_Maximize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Maximize.Location = new System.Drawing.Point(60, -2);
            this.btn_Maximize.Name = "btn_Maximize";
            this.btn_Maximize.Size = new System.Drawing.Size(46, 46);
            this.btn_Maximize.TabIndex = 8;
            this.btn_Maximize.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.CadetBlue;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(112, -1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(46, 46);
            this.button5.TabIndex = 7;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pnl_Main
            // 
            this.pnl_Main.Controls.Add(this.ucAbout1);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 58);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(802, 642);
            this.pnl_Main.TabIndex = 13;
            // 
            // ucAbout1
            // 
            this.ucAbout1.Location = new System.Drawing.Point(9, 10);
            this.ucAbout1.Name = "ucAbout1";
            this.ucAbout1.Size = new System.Drawing.Size(790, 629);
            this.ucAbout1.TabIndex = 0;
            // 
            // btn_Back_About
            // 
            this.btn_Back_About.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_Back_About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back_About.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back_About.ForeColor = System.Drawing.Color.White;
            this.btn_Back_About.Image = ((System.Drawing.Image)(resources.GetObject("btn_Back_About.Image")));
            this.btn_Back_About.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Back_About.Location = new System.Drawing.Point(3, 1);
            this.btn_Back_About.Name = "btn_Back_About";
            this.btn_Back_About.Size = new System.Drawing.Size(274, 52);
            this.btn_Back_About.TabIndex = 10;
            this.btn_Back_About.Text = "Previous Page";
            this.btn_Back_About.UseVisualStyleBackColor = false;
            this.btn_Back_About.Click += new System.EventHandler(this.btn_Back_About_Click);
            // 
            // frm_About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 700);
            this.Controls.Add(this.pnl_Main);
            this.Controls.Add(this.pnl_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_About";
            this.pnl_Header.ResumeLayout(false);
            this.pnl_TopRight_Btn.ResumeLayout(false);
            this.pnl_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Panel pnl_TopRight_Btn;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.Button btn_Maximize;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel pnl_Main;
        private ucAbout ucAbout1;
        private System.Windows.Forms.Button btn_Back_About;
    }
}