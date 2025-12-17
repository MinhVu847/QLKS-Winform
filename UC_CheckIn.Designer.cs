namespace QLKS_Winform
{
    partial class UC_CheckIn
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
            this.label7 = new System.Windows.Forms.Label();
            this.dtCin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbGender = new System.Windows.Forms.ComboBox();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtNatiID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbRoomType = new System.Windows.Forms.ComboBox();
            this.cbbRoomName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbNumOfBeds = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 373);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 23);
            this.label7.TabIndex = 37;
            this.label7.Text = "NationalID";
            // 
            // dtCin
            // 
            this.dtCin.CustomFormat = "yyyy/MM/dd";
            this.dtCin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCin.Location = new System.Drawing.Point(460, 498);
            this.dtCin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtCin.Name = "dtCin";
            this.dtCin.Size = new System.Drawing.Size(317, 22);
            this.dtCin.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(456, 474);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "Check In Date:";
            // 
            // cbbGender
            // 
            this.cbbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGender.FormattingEnabled = true;
            this.cbbGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbbGender.Location = new System.Drawing.Point(56, 316);
            this.cbbGender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbGender.Name = "cbbGender";
            this.cbbGender.Size = new System.Drawing.Size(317, 24);
            this.cbbGender.TabIndex = 34;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.Black;
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnCheckIn.Location = new System.Drawing.Point(1177, 590);
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(129, 39);
            this.btnCheckIn.TabIndex = 31;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(56, 135);
            this.txtID.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(317, 22);
            this.txtID.TabIndex = 27;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(52, 110);
            this.lblID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(33, 23);
            this.lblID.TabIndex = 22;
            this.lblID.Text = "ID:";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(56, 479);
            this.txtPhoneNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(317, 22);
            this.txtPhoneNo.TabIndex = 29;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.Location = new System.Drawing.Point(52, 198);
            this.lblClientName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(62, 23);
            this.lblClientName.TabIndex = 23;
            this.lblClientName.Text = "Name:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(52, 292);
            this.lblGender.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(74, 23);
            this.lblGender.TabIndex = 24;
            this.lblGender.Text = "Gender:";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(56, 224);
            this.txtClientName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(317, 22);
            this.txtClientName.TabIndex = 28;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(52, 453);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(92, 23);
            this.lblPhone.TabIndex = 26;
            this.lblPhone.Text = "Phone No:";
            // 
            // txtNatiID
            // 
            this.txtNatiID.Location = new System.Drawing.Point(56, 399);
            this.txtNatiID.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNatiID.Name = "txtNatiID";
            this.txtNatiID.Size = new System.Drawing.Size(317, 22);
            this.txtNatiID.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 532);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 39;
            this.label1.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(56, 558);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(317, 22);
            this.txtAddress.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(456, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 23);
            this.label2.TabIndex = 41;
            this.label2.Text = "Room Type:";
            // 
            // cbbRoomType
            // 
            this.cbbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRoomType.FormattingEnabled = true;
            this.cbbRoomType.Location = new System.Drawing.Point(460, 134);
            this.cbbRoomType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbRoomType.Name = "cbbRoomType";
            this.cbbRoomType.Size = new System.Drawing.Size(317, 24);
            this.cbbRoomType.TabIndex = 42;
            this.cbbRoomType.SelectedIndexChanged += new System.EventHandler(this.cbbRoomType_SelectedIndexChanged);
            // 
            // cbbRoomName
            // 
            this.cbbRoomName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRoomName.FormattingEnabled = true;
            this.cbbRoomName.Location = new System.Drawing.Point(460, 329);
            this.cbbRoomName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbRoomName.Name = "cbbRoomName";
            this.cbbRoomName.Size = new System.Drawing.Size(317, 24);
            this.cbbRoomName.TabIndex = 43;
            this.cbbRoomName.SelectedIndexChanged += new System.EventHandler(this.cbbRoomName_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(456, 304);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 23);
            this.label3.TabIndex = 44;
            this.label3.Text = "Room Name:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(460, 415);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(317, 22);
            this.txtPrice.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(456, 389);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 23);
            this.label5.TabIndex = 45;
            this.label5.Text = "Price:";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(941, 162);
            this.txtNote.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(364, 105);
            this.txtNote.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(937, 137);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 23);
            this.label6.TabIndex = 47;
            this.label6.Text = "Note:";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1400, 89);
            this.label8.TabIndex = 49;
            this.label8.Text = "Check In";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(456, 199);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 23);
            this.label9.TabIndex = 51;
            this.label9.Text = "Number of Beds: ";
            // 
            // cbbNumOfBeds
            // 
            this.cbbNumOfBeds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNumOfBeds.FormattingEnabled = true;
            this.cbbNumOfBeds.Location = new System.Drawing.Point(460, 224);
            this.cbbNumOfBeds.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbNumOfBeds.Name = "cbbNumOfBeds";
            this.cbbNumOfBeds.Size = new System.Drawing.Size(317, 24);
            this.cbbNumOfBeds.TabIndex = 50;
            this.cbbNumOfBeds.SelectedIndexChanged += new System.EventHandler(this.cbbNumOfBeds_SelectedIndexChanged);
            // 
            // UC_CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbbNumOfBeds);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbRoomName);
            this.Controls.Add(this.cbbRoomType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtNatiID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtCin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbGender);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.lblPhone);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_CheckIn";
            this.Size = new System.Drawing.Size(1400, 706);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtCin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbGender;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtNatiID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbRoomType;
        private System.Windows.Forms.ComboBox cbbRoomName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbNumOfBeds;
    }
}
