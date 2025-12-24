namespace QLKS_Winform
{
    partial class Index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.plMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnEx = new System.Windows.Forms.Button();
            this.btnSting = new System.Windows.Forms.Button();
            this.btnAltic = new System.Windows.Forms.Button();
            this.btnChkout = new System.Windows.Forms.Button();
            this.btnChkin = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnRoomManage = new System.Windows.Forms.Button();
            this.plLogo = new System.Windows.Forms.Panel();
            this.ptrLogo = new System.Windows.Forms.PictureBox();
            this.plData = new System.Windows.Forms.Panel();
            this.uC_MyAccount1 = new QLKS_Winform.UC_MyAccount();
            this.uC_RoomManagement1 = new QLKS_Winform.UC_RoomManagement();
            this.uC_CheckOut1 = new QLKS_Winform.UC_CheckOut();
            this.uC_CheckIn1 = new QLKS_Winform.UC_CheckIn();
            this.uC_Employees1 = new QLKS_Winform.UC_Employees();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_FindClient1 = new QLKS_Winform.UC_FindClient();
            this.plMenu.SuspendLayout();
            this.plLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrLogo)).BeginInit();
            this.plData.SuspendLayout();
            this.SuspendLayout();
            // 
            // plMenu
            // 
            this.plMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.plMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(27)))), ((int)(((byte)(53)))));
            this.plMenu.Controls.Add(this.btnLogout);
            this.plMenu.Controls.Add(this.btnAccount);
            this.plMenu.Controls.Add(this.btnEx);
            this.plMenu.Controls.Add(this.btnSting);
            this.plMenu.Controls.Add(this.btnAltic);
            this.plMenu.Controls.Add(this.btnChkout);
            this.plMenu.Controls.Add(this.btnChkin);
            this.plMenu.Controls.Add(this.btnFind);
            this.plMenu.Controls.Add(this.btnRoomManage);
            this.plMenu.Controls.Add(this.plLogo);
            this.plMenu.Location = new System.Drawing.Point(0, 0);
            this.plMenu.Name = "plMenu";
            this.plMenu.Size = new System.Drawing.Size(230, 720);
            this.plMenu.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::QLKS_Winform.Properties.Resources.exits;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 551);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(230, 60);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = " Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Image = global::QLKS_Winform.Properties.Resources.icons8_user_24;
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Location = new System.Drawing.Point(0, 491);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAccount.Size = new System.Drawing.Size(230, 60);
            this.btnAccount.TabIndex = 8;
            this.btnAccount.Text = " My account";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnEx
            // 
            this.btnEx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEx.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEx.FlatAppearance.BorderSize = 0;
            this.btnEx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEx.ForeColor = System.Drawing.Color.White;
            this.btnEx.Image = global::QLKS_Winform.Properties.Resources.end;
            this.btnEx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEx.Location = new System.Drawing.Point(0, 660);
            this.btnEx.Name = "btnEx";
            this.btnEx.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnEx.Size = new System.Drawing.Size(230, 60);
            this.btnEx.TabIndex = 7;
            this.btnEx.Text = " Exit";
            this.btnEx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEx.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEx.UseVisualStyleBackColor = true;
            this.btnEx.Click += new System.EventHandler(this.btnEx_Click);
            // 
            // btnSting
            // 
            this.btnSting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSting.FlatAppearance.BorderSize = 0;
            this.btnSting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSting.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSting.ForeColor = System.Drawing.Color.White;
            this.btnSting.Image = global::QLKS_Winform.Properties.Resources.setting;
            this.btnSting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSting.Location = new System.Drawing.Point(0, 431);
            this.btnSting.Name = "btnSting";
            this.btnSting.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSting.Size = new System.Drawing.Size(230, 60);
            this.btnSting.TabIndex = 6;
            this.btnSting.Text = " Employees manager";
            this.btnSting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSting.UseVisualStyleBackColor = true;
            this.btnSting.Click += new System.EventHandler(this.btnSting_Click);
            // 
            // btnAltic
            // 
            this.btnAltic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAltic.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAltic.FlatAppearance.BorderSize = 0;
            this.btnAltic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltic.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltic.ForeColor = System.Drawing.Color.White;
            this.btnAltic.Image = global::QLKS_Winform.Properties.Resources.analytics;
            this.btnAltic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltic.Location = new System.Drawing.Point(0, 371);
            this.btnAltic.Name = "btnAltic";
            this.btnAltic.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAltic.Size = new System.Drawing.Size(230, 60);
            this.btnAltic.TabIndex = 5;
            this.btnAltic.Text = " Analytics";
            this.btnAltic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAltic.UseVisualStyleBackColor = true;
            // 
            // btnChkout
            // 
            this.btnChkout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChkout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChkout.FlatAppearance.BorderSize = 0;
            this.btnChkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChkout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChkout.ForeColor = System.Drawing.Color.White;
            this.btnChkout.Image = global::QLKS_Winform.Properties.Resources.remove;
            this.btnChkout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChkout.Location = new System.Drawing.Point(0, 311);
            this.btnChkout.Name = "btnChkout";
            this.btnChkout.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnChkout.Size = new System.Drawing.Size(230, 60);
            this.btnChkout.TabIndex = 4;
            this.btnChkout.Text = " Check out";
            this.btnChkout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChkout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChkout.UseVisualStyleBackColor = true;
            this.btnChkout.Click += new System.EventHandler(this.btnChkout_Click);
            // 
            // btnChkin
            // 
            this.btnChkin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChkin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChkin.FlatAppearance.BorderSize = 0;
            this.btnChkin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChkin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChkin.ForeColor = System.Drawing.Color.White;
            this.btnChkin.Image = global::QLKS_Winform.Properties.Resources.add;
            this.btnChkin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChkin.Location = new System.Drawing.Point(0, 251);
            this.btnChkin.Name = "btnChkin";
            this.btnChkin.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnChkin.Size = new System.Drawing.Size(230, 60);
            this.btnChkin.TabIndex = 3;
            this.btnChkin.Text = " Check in";
            this.btnChkin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChkin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChkin.UseVisualStyleBackColor = true;
            this.btnChkin.Click += new System.EventHandler(this.btnChkin_Click);
            // 
            // btnFind
            // 
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Image = global::QLKS_Winform.Properties.Resources.find;
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.Location = new System.Drawing.Point(0, 191);
            this.btnFind.Name = "btnFind";
            this.btnFind.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnFind.Size = new System.Drawing.Size(230, 60);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = " Find Client";
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnRoomManage
            // 
            this.btnRoomManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoomManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoomManage.FlatAppearance.BorderSize = 0;
            this.btnRoomManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomManage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomManage.ForeColor = System.Drawing.Color.White;
            this.btnRoomManage.Image = global::QLKS_Winform.Properties.Resources.dataprovider;
            this.btnRoomManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoomManage.Location = new System.Drawing.Point(0, 131);
            this.btnRoomManage.Name = "btnRoomManage";
            this.btnRoomManage.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnRoomManage.Size = new System.Drawing.Size(230, 60);
            this.btnRoomManage.TabIndex = 1;
            this.btnRoomManage.Text = " Room Management";
            this.btnRoomManage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoomManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRoomManage.UseVisualStyleBackColor = true;
            this.btnRoomManage.Click += new System.EventHandler(this.btnRoomManage_Click);
            // 
            // plLogo
            // 
            this.plLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(53)))));
            this.plLogo.Controls.Add(this.ptrLogo);
            this.plLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.plLogo.Location = new System.Drawing.Point(0, 0);
            this.plLogo.Name = "plLogo";
            this.plLogo.Size = new System.Drawing.Size(230, 131);
            this.plLogo.TabIndex = 0;
            // 
            // ptrLogo
            // 
            this.ptrLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptrLogo.Image = global::QLKS_Winform.Properties.Resources.logo2;
            this.ptrLogo.Location = new System.Drawing.Point(0, 0);
            this.ptrLogo.Name = "ptrLogo";
            this.ptrLogo.Size = new System.Drawing.Size(230, 131);
            this.ptrLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrLogo.TabIndex = 0;
            this.ptrLogo.TabStop = false;
            // 
            // plData
            // 
            this.plData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.plData.Controls.Add(this.uC_FindClient1);
            this.plData.Controls.Add(this.uC_MyAccount1);
            this.plData.Controls.Add(this.uC_RoomManagement1);
            this.plData.Controls.Add(this.uC_CheckOut1);
            this.plData.Controls.Add(this.uC_CheckIn1);
            this.plData.Controls.Add(this.uC_Employees1);
            this.plData.Location = new System.Drawing.Point(230, 59);
            this.plData.Name = "plData";
            this.plData.Size = new System.Drawing.Size(1050, 574);
            this.plData.TabIndex = 1;
            // 
            // uC_MyAccount1
            // 
            this.uC_MyAccount1.Location = new System.Drawing.Point(0, 0);
            this.uC_MyAccount1.Name = "uC_MyAccount1";
            this.uC_MyAccount1.Size = new System.Drawing.Size(1050, 574);
            this.uC_MyAccount1.TabIndex = 5;
            this.uC_MyAccount1.Visible = false;
            // 
            // uC_RoomManagement1
            // 
            this.uC_RoomManagement1.Location = new System.Drawing.Point(0, 0);
            this.uC_RoomManagement1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_RoomManagement1.MaximumSize = new System.Drawing.Size(1050, 574);
            this.uC_RoomManagement1.MinimumSize = new System.Drawing.Size(1050, 574);
            this.uC_RoomManagement1.Name = "uC_RoomManagement1";
            this.uC_RoomManagement1.Size = new System.Drawing.Size(1050, 574);
            this.uC_RoomManagement1.TabIndex = 4;
            this.uC_RoomManagement1.Visible = false;
            // 
            // uC_CheckOut1
            // 
            this.uC_CheckOut1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_CheckOut1.Location = new System.Drawing.Point(0, 0);
            this.uC_CheckOut1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uC_CheckOut1.Name = "uC_CheckOut1";
            this.uC_CheckOut1.Size = new System.Drawing.Size(1050, 574);
            this.uC_CheckOut1.TabIndex = 2;
            this.uC_CheckOut1.Visible = false;
            // 
            // uC_CheckIn1
            // 
            this.uC_CheckIn1.Location = new System.Drawing.Point(0, 0);
            this.uC_CheckIn1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uC_CheckIn1.MaximumSize = new System.Drawing.Size(1050, 574);
            this.uC_CheckIn1.MinimumSize = new System.Drawing.Size(1050, 574);
            this.uC_CheckIn1.Name = "uC_CheckIn1";
            this.uC_CheckIn1.Size = new System.Drawing.Size(1050, 574);
            this.uC_CheckIn1.TabIndex = 1;
            this.uC_CheckIn1.Visible = false;
            // 
            // uC_Employees1
            // 
            this.uC_Employees1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Employees1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_Employees1.Location = new System.Drawing.Point(0, 0);
            this.uC_Employees1.Name = "uC_Employees1";
            this.uC_Employees1.Size = new System.Drawing.Size(1050, 574);
            this.uC_Employees1.TabIndex = 0;
            this.uC_Employees1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Location = new System.Drawing.Point(230, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 59);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Location = new System.Drawing.Point(230, 634);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1050, 87);
            this.panel2.TabIndex = 3;
            // 
            // uC_FindClient1
            // 
            this.uC_FindClient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_FindClient1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_FindClient1.Location = new System.Drawing.Point(0, 0);
            this.uC_FindClient1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_FindClient1.Name = "uC_FindClient1";
            this.uC_FindClient1.Size = new System.Drawing.Size(1050, 574);
            this.uC_FindClient1.TabIndex = 6;
            this.uC_FindClient1.Visible = false;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.plData);
            this.Controls.Add(this.plMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trong Vu Hotel Management";
            this.Load += new System.EventHandler(this.Index_Load);
            this.plMenu.ResumeLayout(false);
            this.plLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptrLogo)).EndInit();
            this.plData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plMenu;
        private System.Windows.Forms.Panel plData;
        private System.Windows.Forms.Button btnRoomManage;
        private System.Windows.Forms.Button btnSting;
        private System.Windows.Forms.Button btnAltic;
        private System.Windows.Forms.Button btnChkout;
        private System.Windows.Forms.Button btnChkin;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.PictureBox ptrLogo;
        private System.Windows.Forms.Panel plLogo;
        private System.Windows.Forms.Button btnEx;
        private UC_Employees uC_Employees1;
        private UC_CheckIn uC_CheckIn1;
        private System.Windows.Forms.Panel panel1;
        private UC_CheckOut uC_CheckOut1;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnLogout;
        private UC_RoomManagement uC_RoomManagement1;
        private UC_MyAccount uC_MyAccount1;
        private System.Windows.Forms.Panel panel2;
        private UC_FindClient uC_FindClient1;
    }
}