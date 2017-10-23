namespace Kpo4311_hnv.Main
{
    partial class FrmCompany
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
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxCategory = new System.Windows.Forms.TextBox();
            this.txtBoxLoss = new System.Windows.Forms.TextBox();
            this.txtBoxDowntime = new System.Windows.Forms.TextBox();
            this.btnCompanyDataEdit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(13, 16);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.ReadOnly = true;
            this.txtBoxName.Size = new System.Drawing.Size(147, 20);
            this.txtBoxName.TabIndex = 0;
            // 
            // txtBoxCategory
            // 
            this.txtBoxCategory.Location = new System.Drawing.Point(13, 42);
            this.txtBoxCategory.Name = "txtBoxCategory";
            this.txtBoxCategory.ReadOnly = true;
            this.txtBoxCategory.Size = new System.Drawing.Size(147, 20);
            this.txtBoxCategory.TabIndex = 1;
            // 
            // txtBoxLoss
            // 
            this.txtBoxLoss.Location = new System.Drawing.Point(12, 68);
            this.txtBoxLoss.Name = "txtBoxLoss";
            this.txtBoxLoss.ReadOnly = true;
            this.txtBoxLoss.Size = new System.Drawing.Size(147, 20);
            this.txtBoxLoss.TabIndex = 2;
            // 
            // txtBoxDowntime
            // 
            this.txtBoxDowntime.Location = new System.Drawing.Point(13, 94);
            this.txtBoxDowntime.Name = "txtBoxDowntime";
            this.txtBoxDowntime.ReadOnly = true;
            this.txtBoxDowntime.Size = new System.Drawing.Size(147, 20);
            this.txtBoxDowntime.TabIndex = 3;
            // 
            // btnCompanyDataEdit
            // 
            this.btnCompanyDataEdit.Location = new System.Drawing.Point(12, 120);
            this.btnCompanyDataEdit.Name = "btnCompanyDataEdit";
            this.btnCompanyDataEdit.Size = new System.Drawing.Size(71, 23);
            this.btnCompanyDataEdit.TabIndex = 4;
            this.btnCompanyDataEdit.Text = "Edit";
            this.btnCompanyDataEdit.UseVisualStyleBackColor = true;
            this.btnCompanyDataEdit.Click += new System.EventHandler(this.btnCompanyDataEdit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(88, 120);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(71, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseCompatibleTextRendering = true;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 154);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCompanyDataEdit);
            this.Controls.Add(this.txtBoxDowntime);
            this.Controls.Add(this.txtBoxLoss);
            this.Controls.Add(this.txtBoxCategory);
            this.Controls.Add(this.txtBoxName);
            this.Name = "FrmCompany";
            this.Text = "FrmCompany";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxCategory;
        private System.Windows.Forms.TextBox txtBoxLoss;
        private System.Windows.Forms.TextBox txtBoxDowntime;
        private System.Windows.Forms.Button btnCompanyDataEdit;
        private System.Windows.Forms.Button btnExit;
    }
}