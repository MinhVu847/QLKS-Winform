namespace QLKS_Winform
{
    partial class UC_RoomManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPirce = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cbbRoomType = new System.Windows.Forms.ComboBox();
            this.cbbNumberOfBeds = new System.Windows.Forms.ComboBox();
            this.grbRoomManage = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtClear = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtSeachNumOfBeds = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbSeachRoomType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSeachRoomName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSeachRoomID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.grbRoomManage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(27)))), ((int)(((byte)(53)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.MaximumSize = new System.Drawing.Size(1050, 72);
            this.label1.MinimumSize = new System.Drawing.Size(1050, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1050, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRoomID
            // 
            this.txtRoomID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomID.Location = new System.Drawing.Point(57, 55);
            this.txtRoomID.Margin = new System.Windows.Forms.Padding(2);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(212, 30);
            this.txtRoomID.TabIndex = 1;
            // 
            // txtRoomName
            // 
            this.txtRoomName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomName.Location = new System.Drawing.Point(57, 121);
            this.txtRoomName.Margin = new System.Windows.Forms.Padding(2);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(212, 30);
            this.txtRoomName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Room ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Room Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Room Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 262);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Number of Beds: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 343);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Price:";
            // 
            // txtPirce
            // 
            this.txtPirce.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPirce.Location = new System.Drawing.Point(57, 362);
            this.txtPirce.Margin = new System.Windows.Forms.Padding(2);
            this.txtPirce.Name = "txtPirce";
            this.txtPirce.Size = new System.Drawing.Size(212, 30);
            this.txtPirce.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(27)))), ((int)(((byte)(53)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(11, 439);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 32);
            this.btnAdd.TabIndex = 59;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(27)))), ((int)(((byte)(53)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(221, 439);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 32);
            this.btnDelete.TabIndex = 60;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(27)))), ((int)(((byte)(53)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(116, 439);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(97, 32);
            this.btnEdit.TabIndex = 61;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // cbbRoomType
            // 
            this.cbbRoomType.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbRoomType.FormattingEnabled = true;
            this.cbbRoomType.Items.AddRange(new object[] {
            "Tiêu Chuẩn",
            "Cao Cấp",
            "VIP",
            "Tổng thống"});
            this.cbbRoomType.Location = new System.Drawing.Point(57, 199);
            this.cbbRoomType.Margin = new System.Windows.Forms.Padding(2);
            this.cbbRoomType.Name = "cbbRoomType";
            this.cbbRoomType.Size = new System.Drawing.Size(212, 31);
            this.cbbRoomType.TabIndex = 62;
            // 
            // cbbNumberOfBeds
            // 
            this.cbbNumberOfBeds.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNumberOfBeds.FormattingEnabled = true;
            this.cbbNumberOfBeds.Items.AddRange(new object[] {
            "Đơn",
            "Đôi",
            "Ba"});
            this.cbbNumberOfBeds.Location = new System.Drawing.Point(57, 281);
            this.cbbNumberOfBeds.Margin = new System.Windows.Forms.Padding(2);
            this.cbbNumberOfBeds.Name = "cbbNumberOfBeds";
            this.cbbNumberOfBeds.Size = new System.Drawing.Size(212, 31);
            this.cbbNumberOfBeds.TabIndex = 63;
            // 
            // grbRoomManage
            // 
            this.grbRoomManage.Controls.Add(this.txtRoomID);
            this.grbRoomManage.Controls.Add(this.cbbNumberOfBeds);
            this.grbRoomManage.Controls.Add(this.label6);
            this.grbRoomManage.Controls.Add(this.txtRoomName);
            this.grbRoomManage.Controls.Add(this.txtPirce);
            this.grbRoomManage.Controls.Add(this.cbbRoomType);
            this.grbRoomManage.Controls.Add(this.label5);
            this.grbRoomManage.Controls.Add(this.label2);
            this.grbRoomManage.Controls.Add(this.btnAdd);
            this.grbRoomManage.Controls.Add(this.btnEdit);
            this.grbRoomManage.Controls.Add(this.label4);
            this.grbRoomManage.Controls.Add(this.label3);
            this.grbRoomManage.Controls.Add(this.btnDelete);
            this.grbRoomManage.Location = new System.Drawing.Point(0, 72);
            this.grbRoomManage.Margin = new System.Windows.Forms.Padding(2);
            this.grbRoomManage.MaximumSize = new System.Drawing.Size(332, 502);
            this.grbRoomManage.MinimumSize = new System.Drawing.Size(332, 502);
            this.grbRoomManage.Name = "grbRoomManage";
            this.grbRoomManage.Padding = new System.Windows.Forms.Padding(2);
            this.grbRoomManage.Size = new System.Drawing.Size(332, 502);
            this.grbRoomManage.TabIndex = 65;
            this.grbRoomManage.TabStop = false;
            this.grbRoomManage.Text = "Room Management";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtClear);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.txtSeachNumOfBeds);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbbSeachRoomType);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtSeachRoomName);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtSeachRoomID);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dgvRoom);
            this.groupBox2.Location = new System.Drawing.Point(332, 72);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(718, 502);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Room Search";
            // 
            // txtClear
            // 
            this.txtClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(27)))), ((int)(((byte)(53)))));
            this.txtClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtClear.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClear.ForeColor = System.Drawing.Color.White;
            this.txtClear.Location = new System.Drawing.Point(603, 105);
            this.txtClear.Margin = new System.Windows.Forms.Padding(4);
            this.txtClear.Name = "txtClear";
            this.txtClear.Size = new System.Drawing.Size(97, 32);
            this.txtClear.TabIndex = 72;
            this.txtClear.Text = "Clear";
            this.txtClear.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(355, 78);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 23);
            this.label10.TabIndex = 70;
            this.label10.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(357, 94);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(160, 29);
            this.txtPrice.TabIndex = 71;
            // 
            // txtSeachNumOfBeds
            // 
            this.txtSeachNumOfBeds.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeachNumOfBeds.FormattingEnabled = true;
            this.txtSeachNumOfBeds.Items.AddRange(new object[] {
            "Đơn",
            "Đôi",
            "Ba"});
            this.txtSeachNumOfBeds.Location = new System.Drawing.Point(159, 94);
            this.txtSeachNumOfBeds.Margin = new System.Windows.Forms.Padding(2);
            this.txtSeachNumOfBeds.Name = "txtSeachNumOfBeds";
            this.txtSeachNumOfBeds.Size = new System.Drawing.Size(160, 29);
            this.txtSeachNumOfBeds.TabIndex = 69;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(157, 78);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 23);
            this.label9.TabIndex = 68;
            this.label9.Text = "Number of Beds: ";
            // 
            // cbbSeachRoomType
            // 
            this.cbbSeachRoomType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSeachRoomType.FormattingEnabled = true;
            this.cbbSeachRoomType.Items.AddRange(new object[] {
            "Tiêu Chuẩn",
            "Cao Cấp",
            "VIP",
            "Tổng thống"});
            this.cbbSeachRoomType.Location = new System.Drawing.Point(438, 36);
            this.cbbSeachRoomType.Margin = new System.Windows.Forms.Padding(2);
            this.cbbSeachRoomType.Name = "cbbSeachRoomType";
            this.cbbSeachRoomType.Size = new System.Drawing.Size(160, 29);
            this.cbbSeachRoomType.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(436, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 23);
            this.label8.TabIndex = 66;
            this.label8.Text = "Room Type:";
            // 
            // txtSeachRoomName
            // 
            this.txtSeachRoomName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeachRoomName.Location = new System.Drawing.Point(254, 36);
            this.txtSeachRoomName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSeachRoomName.Name = "txtSeachRoomName";
            this.txtSeachRoomName.Size = new System.Drawing.Size(160, 29);
            this.txtSeachRoomName.TabIndex = 64;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(252, 20);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 23);
            this.label11.TabIndex = 65;
            this.label11.Text = "Room Name:";
            // 
            // txtSeachRoomID
            // 
            this.txtSeachRoomID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeachRoomID.Location = new System.Drawing.Point(69, 36);
            this.txtSeachRoomID.Margin = new System.Windows.Forms.Padding(2);
            this.txtSeachRoomID.Name = "txtSeachRoomID";
            this.txtSeachRoomID.Size = new System.Drawing.Size(160, 29);
            this.txtSeachRoomID.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(67, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Room ID:";
            // 
            // dgvRoom
            // 
            this.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoom.Location = new System.Drawing.Point(19, 143);
            this.dgvRoom.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.RowHeadersWidth = 51;
            this.dgvRoom.RowTemplate.Height = 24;
            this.dgvRoom.Size = new System.Drawing.Size(681, 355);
            this.dgvRoom.TabIndex = 0;
            // 
            // UC_RoomManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbRoomManage);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1050, 574);
            this.MinimumSize = new System.Drawing.Size(1050, 574);
            this.Name = "UC_RoomManagement";
            this.Size = new System.Drawing.Size(1050, 574);
            this.grbRoomManage.ResumeLayout(false);
            this.grbRoomManage.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPirce;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cbbRoomType;
        private System.Windows.Forms.ComboBox cbbNumberOfBeds;
        private System.Windows.Forms.GroupBox grbRoomManage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox txtSeachNumOfBeds;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbSeachRoomType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSeachRoomName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSeachRoomID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvRoom;
        private System.Windows.Forms.Button txtClear;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrice;
    }
}
