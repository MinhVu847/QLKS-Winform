namespace QLKS_Winform
{
    partial class BillsCheckOut
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
            this.crBills = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crBills
            // 
            this.crBills.ActiveViewIndex = -1;
            this.crBills.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crBills.Cursor = System.Windows.Forms.Cursors.Default;
            this.crBills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crBills.Location = new System.Drawing.Point(0, 0);
            this.crBills.Name = "crBills";
            this.crBills.Size = new System.Drawing.Size(774, 770);
            this.crBills.TabIndex = 0;
            this.crBills.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // BillsCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 770);
            this.Controls.Add(this.crBills);
            this.Name = "BillsCheckOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BillsCheckOut";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crBills;
    }
}