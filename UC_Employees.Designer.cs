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
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.btnSeach = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtDOBEmpl = new System.Windows.Forms.DateTimePicker();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
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
            this.panel1.Controls.Add(this.txtPosition);
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
            // cbbGender
            // 
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
            this.btnDelClient.BackColor = System.Drawing.Color.Black;
            this.btnDelClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelClient.ForeColor = System.Drawing.Color.White;
            this.btnDelClient.Location = new System.Drawing.Point(238, 463);
            this.btnDelClient.Name = "btnDelClient";
            this.btnDelClient.Size = new System.Drawing.Size(97, 32);
            this.btnDelClient.TabIndex = 16;
            this.btnDelClient.Text = "Delete";
            this.btnDelClient.UseVisualStyleBackColor = false;
            // 
            // btnEditClient
            // 
            this.btnEditClient.BackColor = System.Drawing.Color.Black;
            this.btnEditClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditClient.ForeColor = System.Drawing.Color.White;
            this.btnEditClient.Location = new System.Drawing.Point(123, 463);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(97, 32);
            this.btnEditClient.TabIndex = 15;
            this.btnEditClient.Text = "Edit";
            this.btnEditClient.UseVisualStyleBackColor = false;
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.Color.Black;
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClient.ForeColor = System.Drawing.Color.White;
            this.btnAddClient.Location = new System.Drawing.Point(6, 463);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(97, 32);
            this.btnAddClient.TabIndex = 14;
            this.btnAddClient.Text = "Add";
            this.btnAddClient.UseVisualStyleBackColor = false;
            // 
            // txtSeachID
            // 
            this.txtSeachID.Location = new System.Drawing.Point(500, 81);
            this.txtSeachID.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeachID.Name = "txtSeachID";
            this.txtSeachID.Size = new System.Drawing.Size(239, 25);
            this.txtSeachID.TabIndex = 24;
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
            this.txtSeachPhoneNo.Location = new System.Drawing.Point(500, 155);
            this.txtSeachPhoneNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeachPhoneNo.Name = "txtSeachPhoneNo";
            this.txtSeachPhoneNo.Size = new System.Drawing.Size(239, 25);
            this.txtSeachPhoneNo.TabIndex = 27;
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
            this.txtSeachEmplName.Location = new System.Drawing.Point(500, 118);
            this.txtSeachEmplName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeachEmplName.Name = "txtSeachEmplName";
            this.txtSeachEmplName.Size = new System.Drawing.Size(239, 25);
            this.txtSeachEmplName.TabIndex = 25;
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
            // dgvClient
            // 
            this.dgvClient.BackgroundColor = System.Drawing.Color.White;
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Location = new System.Drawing.Point(354, 240);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.RowHeadersWidth = 51;
            this.dgvClient.Size = new System.Drawing.Size(681, 332);
            this.dgvClient.TabIndex = 29;
            // 
            // btnSeach
            // 
            this.btnSeach.BackColor = System.Drawing.Color.Black;
            this.btnSeach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeach.ForeColor = System.Drawing.Color.White;
            this.btnSeach.Location = new System.Drawing.Point(766, 200);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Size = new System.Drawing.Size(97, 32);
            this.btnSeach.TabIndex = 30;
            this.btnSeach.Text = "Seach";
            this.btnSeach.UseVisualStyleBackColor = false;
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
            // dtDOBEmpl
            // 
            this.dtDOBEmpl.Location = new System.Drawing.Point(26, 224);
            this.dtDOBEmpl.Name = "dtDOBEmpl";
            this.dtDOBEmpl.Size = new System.Drawing.Size(239, 25);
            this.dtDOBEmpl.TabIndex = 19;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(26, 352);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(4);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(239, 25);
            this.txtPosition.TabIndex = 21;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(500, 195);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 25);
            this.textBox1.TabIndex = 32;
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
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1050, 72);
            this.label5.TabIndex = 33;
            this.label5.Text = "Employee Management";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSeach);
            this.Controls.Add(this.dgvClient);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.Button btnSeach;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtDOBEmpl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}
