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
            this.btnEx = new System.Windows.Forms.Button();
            this.btnSting = new System.Windows.Forms.Button();
            this.btnAltic = new System.Windows.Forms.Button();
            this.btnChkout = new System.Windows.Forms.Button();
            this.btnChkin = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnData = new System.Windows.Forms.Button();
            this.plLogo = new System.Windows.Forms.Panel();
            this.ptrLogo = new System.Windows.Forms.PictureBox();
            this.plData = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.uC_CheckIn1 = new QLKS_Winform.UC_CheckIn();
            this.uC_Employees1 = new QLKS_Winform.UC_Employees();
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
            this.plMenu.Controls.Add(this.btnEx);
            this.plMenu.Controls.Add(this.btnSting);
            this.plMenu.Controls.Add(this.btnAltic);
            this.plMenu.Controls.Add(this.btnChkout);
            this.plMenu.Controls.Add(this.btnChkin);
            this.plMenu.Controls.Add(this.btnFind);
            this.plMenu.Controls.Add(this.btnData);
            this.plMenu.Controls.Add(this.plLogo);
            this.plMenu.Location = new System.Drawing.Point(0, 0);
            this.plMenu.Name = "plMenu";
            this.plMenu.Size = new System.Drawing.Size(230, 720);
            this.plMenu.TabIndex = 0;
            // 
            // btnEx
            // 
            this.btnEx.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEx.FlatAppearance.BorderSize = 0;
            this.btnEx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEx.ForeColor = System.Drawing.Color.White;
            this.btnEx.Image = global::QLKS_Winform.Properties.Resources.exits;
            this.btnEx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEx.Location = new System.Drawing.Point(0, 491);
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
            // 
            // btnChkin
            // 
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
            this.btnFind.Text = " Find";
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // btnData
            // 
            this.btnData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnData.FlatAppearance.BorderSize = 0;
            this.btnData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnData.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnData.ForeColor = System.Drawing.Color.White;
            this.btnData.Image = global::QLKS_Winform.Properties.Resources.dataprovider;
            this.btnData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnData.Location = new System.Drawing.Point(0, 131);
            this.btnData.Name = "btnData";
            this.btnData.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnData.Size = new System.Drawing.Size(230, 60);
            this.btnData.TabIndex = 1;
            this.btnData.Text = " Guest data";
            this.btnData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnData.UseVisualStyleBackColor = true;
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
            this.plData.Controls.Add(this.uC_CheckIn1);
            this.plData.Controls.Add(this.uC_Employees1);
            this.plData.Location = new System.Drawing.Point(230, 59);
            this.plData.Name = "plData";
            this.plData.Size = new System.Drawing.Size(1050, 574);
            this.plData.TabIndex = 1;
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
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
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
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Button btnSting;
        private System.Windows.Forms.Button btnAltic;
        private System.Windows.Forms.Button btnChkout;
        private System.Windows.Forms.Button btnChkin;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.PictureBox ptrLogo;
        private System.Windows.Forms.Panel plLogo;
        private System.Windows.Forms.Button btnEx;
        private UC_Employees uC_Employees1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private UC_CheckIn uC_CheckIn1;
    }
}