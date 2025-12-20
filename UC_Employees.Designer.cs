namespace QLKS_Winform
{
    partial class UC_Employees
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
            this.components = new System.ComponentModel.Container();
            this.lblID = new System.Windows.Forms.Label();
            this.lblEmplName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtEmplName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbPosition = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtDOBEmpl = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbGender = new System.Windows.Forms.ComboBox();
            this.btnDelClient = new System.Windows.Forms.Button();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.txtSeachID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSeachPhoneNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSeachEmplName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvEmpl = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbSeachPosition = new System.Windows.Forms.ComboBox();
            this.timeStop = new System.Windows.Forms.Timer(this.components);
            this.cbbSeachEmpl = new System.Windows.Forms.ComboBox();
            this.lblListEmp = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpl)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(23, 12);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 17);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // lblEmplName
            // 
            this.lblEmplName.AutoSize = true;
            this.lblEmplName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmplName.Location = new System.Drawing.Point(23, 72);
            this.lblEmplName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmplName.Name = "lblEmplName";
            this.lblEmplName.Size = new System.Drawing.Size(48, 17);
            this.lblEmplName.TabIndex = 1;
            this.lblEmplName.Text = "Name:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(23, 132);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(57, 17);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Gender:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(23, 266);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(73, 17);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Phone No:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(23, 395);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(70, 17);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Password:";
            // 
            // txtEmplName
            // 
            this.txtEmplName.Location = new System.Drawing.Point(26, 93);
            this.txtEmplName.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmplName.Name = "txtEmplName";
            this.txtEmplName.Size = new System.Drawing.Size(239, 25);
            this.txtEmplName.TabIndex = 9;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(26, 33);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(239, 25);
            this.txtID.TabIndex = 8;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(26, 416);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(239, 25);
            this.txtPass.TabIndex = 13;
            this.txtPass.Text = "123456";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(26, 287);
            this.txtPhoneNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(239, 25);
            this.txtPhoneNo.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbPosition);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dtDOBEmpl);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbbGender);
            this.panel1.Controls.Add(this.btnDelClient);
            this.panel1.Controls.Add(this.btnEditClient);
            this.panel1.Controls.Add(this.btnAddClient);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.txtPhoneNo);
            this.panel1.Controls.Add(this.lblEmplName);
            this.panel1.Controls.Add(this.lblGender);
            this.panel1.Controls.Add(this.txtEmplName);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.lblPhone);
            this.panel1.Location = new System.Drawing.Point(0, 72);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 502);
            this.panel1.TabIndex = 14;
            // 
            // cbbPosition
            // 
            this.cbbPosition.AutoCompleteCustomSource.AddRange(new string[] {
            "Quản lý",
            "Lễ tân",
            "Kế toán",
            "Bảo vệ"});
            this.cbbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPosition.FormattingEnabled = true;
            this.cbbPosition.Items.AddRange(new object[] {
            "Lễ tân",
            "Quản lý",
            "Bảo vệ",
            "Kế toán"});
            this.cbbPosition.Location = new System.Drawing.Point(27, 358);
            this.cbbPosition.Name = "cbbPosition";
            this.cbbPosition.Size = new System.Drawing.Size(239, 25);
            this.cbbPosition.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 331);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Position:";
            // 
            // dtDOBEmpl
            // 
            this.dtDOBEmpl.CustomFormat = "yyyy/MM/dd";
            this.dtDOBEmpl.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDOBEmpl.Location = new System.Drawing.Point(26, 224);
            this.dtDOBEmpl.Name = "dtDOBEmpl";
            this.dtDOBEmpl.Size = new System.Drawing.Size(239, 25);
            this.dtDOBEmpl.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 199);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "DOB:";
            // 
            // cbbGender
            // 
            this.cbbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGender.FormattingEnabled = true;
            this.cbbGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbbGender.Location = new System.Drawing.Point(26, 153);
            this.cbbGender.Name = "cbbGender";
            this.cbbGender.Size = new System.Drawing.Size(239, 25);
            this.cbbGender.TabIndex = 17;
            // 
            // btnDelClient
            // 
            this.btnDelClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(27)))), ((int)(((byte)(53)))));
            this.btnDelClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelClient.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelClient.ForeColor = System.Drawing.Color.White;
            this.btnDelClient.Location = new System.Drawing.Point(238, 463);
            this.btnDelClient.Name = "btnDelClient";
            this.btnDelClient.Size = new System.Drawing.Size(97, 32);
            this.btnDelClient.TabIndex = 16;
            this.btnDelClient.Text = "Delete";
            this.btnDelClient.UseVisualStyleBackColor = false;
            this.btnDelClient.Click += new System.EventHandler(this.btnDelClient_Click);
            // 
            // btnEditClient
            // 
            this.btnEditClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(27)))), ((int)(((byte)(53)))));
            this.btnEditClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditClient.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditClient.ForeColor = System.Drawing.Color.White;
            this.btnEditClient.Location = new System.Drawing.Point(123, 463);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(97, 32);
            this.btnEditClient.TabIndex = 15;
            this.btnEditClient.Text = "Edit";
            this.btnEditClient.UseVisualStyleBackColor = false;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(27)))), ((int)(((byte)(53)))));
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClient.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.ForeColor = System.Drawing.Color.White;
            this.btnAddClient.Location = new System.Drawing.Point(6, 463);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(97, 32);
            this.btnAddClient.TabIndex = 14;
            this.btnAddClient.Text = "Add";
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // txtSeachID
            // 
            this.txtSeachID.Location = new System.Drawing.Point(464, 83);
            this.txtSeachID.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeachID.Name = "txtSeachID";
            this.txtSeachID.Size = new System.Drawing.Size(239, 25);
            this.txtSeachID.TabIndex = 24;
            this.txtSeachID.TextChanged += new System.EventHandler(this.txtSeachID_TextChanged);
            this.txtSeachID.VisibleChanged += new System.EventHandler(this.txtSeachID_VisibleChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID:";
            // 
            // txtSeachPhoneNo
            // 
            this.txtSeachPhoneNo.Location = new System.Drawing.Point(464, 157);
            this.txtSeachPhoneNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeachPhoneNo.Name = "txtSeachPhoneNo";
            this.txtSeachPhoneNo.Size = new System.Drawing.Size(239, 25);
            this.txtSeachPhoneNo.TabIndex = 27;
            this.txtSeachPhoneNo.TextChanged += new System.EventHandler(this.txtSeachID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Name:";
            // 
            // txtSeachEmplName
            // 
            this.txtSeachEmplName.Location = new System.Drawing.Point(464, 120);
            this.txtSeachEmplName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeachEmplName.Name = "txtSeachEmplName";
            this.txtSeachEmplName.Size = new System.Drawing.Size(239, 25);
            this.txtSeachEmplName.TabIndex = 25;
            this.txtSeachEmplName.TextChanged += new System.EventHandler(this.txtSeachID_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(353, 164);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Phone No:";
            // 
            // dgvEmpl
            // 
            this.dgvEmpl.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmpl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpl.Location = new System.Drawing.Point(354, 240);
            this.dgvEmpl.Name = "dgvEmpl";
            this.dgvEmpl.RowHeadersWidth = 51;
            this.dgvEmpl.Size = new System.Drawing.Size(681, 332);
            this.dgvEmpl.TabIndex = 29;
            this.dgvEmpl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpl_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(353, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Position:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(27)))), ((int)(((byte)(53)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1050, 72);
            this.label5.TabIndex = 33;
            this.label5.Text = "Employee Management";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbSeachPosition
            // 
            this.cbbSeachPosition.AutoCompleteCustomSource.AddRange(new string[] {
            "Quản lý",
            "Lễ tân",
            "Kế toán",
            "Bảo vệ"});
            this.cbbSeachPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSeachPosition.FormattingEnabled = true;
            this.cbbSeachPosition.Items.AddRange(new object[] {
            "",
            "Lễ tân",
            "Quản lý",
            "Bảo vệ",
            "Kế toán"});
            this.cbbSeachPosition.Location = new System.Drawing.Point(464, 199);
            this.cbbSeachPosition.Name = "cbbSeachPosition";
            this.cbbSeachPosition.Size = new System.Drawing.Size(239, 25);
            this.cbbSeachPosition.TabIndex = 34;
            this.cbbSeachPosition.SelectedIndexChanged += new System.EventHandler(this.cbbSeachPosition_SelectedIndexChanged);
            // 
            // timeStop
            // 
            this.timeStop.Interval = 500;
            this.timeStop.Tick += new System.EventHandler(this.timeStop_Tick);
            // 
            // cbbSeachEmpl
            // 
            this.cbbSeachEmpl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSeachEmpl.FormattingEnabled = true;
            this.cbbSeachEmpl.Items.AddRange(new object[] {
            "All Employees",
            "Active Employees",
            "Terminated Employees"});
            this.cbbSeachEmpl.Location = new System.Drawing.Point(780, 81);
            this.cbbSeachEmpl.Name = "cbbSeachEmpl";
            this.cbbSeachEmpl.Size = new System.Drawing.Size(239, 25);
            this.cbbSeachEmpl.TabIndex = 35;
            this.cbbSeachEmpl.SelectedIndexChanged += new System.EventHandler(this.cbbSeachPosition_SelectedIndexChanged);
            // 
            // lblListEmp
            // 
            this.lblListEmp.AutoSize = true;
            this.lblListEmp.Location = new System.Drawing.Point(731, 84);
            this.lblListEmp.Name = "lblListEmp";
            this.lblListEmp.Size = new System.Drawing.Size(34, 17);
            this.lblListEmp.TabIndex = 36;
            this.lblListEmp.Text = "List:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(27)))), ((int)(((byte)(53)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(912, 194);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 32);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // UC_Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblListEmp);
            this.Controls.Add(this.cbbSeachEmpl);
            this.Controls.Add(this.cbbSeachPosition);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvEmpl);
            this.Controls.Add(this.txtSeachID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSeachPhoneNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSeachEmplName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_Employees";
            this.Size = new System.Drawing.Size(1050, 574);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblEmplName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtEmplName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelClient;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.ComboBox cbbGender;
        private System.Windows.Forms.TextBox txtSeachID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSeachPhoneNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSeachEmplName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvEmpl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtDOBEmpl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbPosition;
        private System.Windows.Forms.ComboBox cbbSeachPosition;
        private System.Windows.Forms.Timer timeStop;
        private System.Windows.Forms.ComboBox cbbSeachEmpl;
        private System.Windows.Forms.Label lblListEmp;
        private System.Windows.Forms.Button btnClear;
    }
}
