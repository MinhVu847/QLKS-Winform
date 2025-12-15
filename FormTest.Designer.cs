namespace QLKS_Winform
{
    partial class FormTest
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
            this.uC_CheckIn1 = new QLKS_Winform.UC_CheckIn();
            this.SuspendLayout();
            // 
            // uC_CheckIn1
            // 
            this.uC_CheckIn1.Location = new System.Drawing.Point(106, 107);
            this.uC_CheckIn1.Name = "uC_CheckIn1";
            this.uC_CheckIn1.Size = new System.Drawing.Size(1050, 574);
            this.uC_CheckIn1.TabIndex = 0;
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 681);
            this.Controls.Add(this.uC_CheckIn1);
            this.Name = "FormTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTest";
            this.ResumeLayout(false);

        }

        #endregion

        private UC_CheckIn uC_CheckIn1;
    }
}