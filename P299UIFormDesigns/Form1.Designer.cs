namespace P299UIFormDesigns
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.companysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.positionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interviewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDeleteModifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byInterviewDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byJobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCorpName = new System.Windows.Forms.Label();
            this.txtCorpName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblFax = new System.Windows.Forms.Label();
            this.lblDescrpt = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCityState = new System.Windows.Forms.TextBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.mskPhoneNum = new System.Windows.Forms.MaskedTextBox();
            this.mskFaxNum = new System.Windows.Forms.MaskedTextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtEmailWebAddress = new System.Windows.Forms.TextBox();
            this.lblRecordNum = new System.Windows.Forms.Label();
            this.txtRecordID = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.companysToolStripMenuItem,
            this.positionsToolStripMenuItem,
            this.interviewsToolStripMenuItem,
            this.addDeleteModifyToolStripMenuItem,
            this.fullTableToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(574, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // companysToolStripMenuItem
            // 
            this.companysToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byCompanyToolStripMenuItem});
            this.companysToolStripMenuItem.Name = "companysToolStripMenuItem";
            this.companysToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.companysToolStripMenuItem.Text = "Company";
            // 
            // positionsToolStripMenuItem
            // 
            this.positionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byJobsToolStripMenuItem});
            this.positionsToolStripMenuItem.Name = "positionsToolStripMenuItem";
            this.positionsToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.positionsToolStripMenuItem.Text = "Positions";
            // 
            // interviewsToolStripMenuItem
            // 
            this.interviewsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byInterviewDateToolStripMenuItem});
            this.interviewsToolStripMenuItem.Name = "interviewsToolStripMenuItem";
            this.interviewsToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.interviewsToolStripMenuItem.Text = "Interviews";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // addDeleteModifyToolStripMenuItem
            // 
            this.addDeleteModifyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteRecordToolStripMenuItem,
            this.modifyRecordToolStripMenuItem});
            this.addDeleteModifyToolStripMenuItem.Name = "addDeleteModifyToolStripMenuItem";
            this.addDeleteModifyToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.addDeleteModifyToolStripMenuItem.Text = "Add/Delete/Modify";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.addToolStripMenuItem.Text = "Add New Record";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // deleteRecordToolStripMenuItem
            // 
            this.deleteRecordToolStripMenuItem.Name = "deleteRecordToolStripMenuItem";
            this.deleteRecordToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.deleteRecordToolStripMenuItem.Text = "Delete Record";
            // 
            // modifyRecordToolStripMenuItem
            // 
            this.modifyRecordToolStripMenuItem.Name = "modifyRecordToolStripMenuItem";
            this.modifyRecordToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.modifyRecordToolStripMenuItem.Text = "Modify Record";
            // 
            // byInterviewDateToolStripMenuItem
            // 
            this.byInterviewDateToolStripMenuItem.Name = "byInterviewDateToolStripMenuItem";
            this.byInterviewDateToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.byInterviewDateToolStripMenuItem.Text = "By Interview Date";
            // 
            // byJobsToolStripMenuItem
            // 
            this.byJobsToolStripMenuItem.Name = "byJobsToolStripMenuItem";
            this.byJobsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.byJobsToolStripMenuItem.Text = "By Jobs";
            // 
            // byCompanyToolStripMenuItem
            // 
            this.byCompanyToolStripMenuItem.Name = "byCompanyToolStripMenuItem";
            this.byCompanyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.byCompanyToolStripMenuItem.Text = "By Company";
            // 
            // fullTableToolStripMenuItem
            // 
            this.fullTableToolStripMenuItem.Name = "fullTableToolStripMenuItem";
            this.fullTableToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.fullTableToolStripMenuItem.Text = "Full Table";
            // 
            // lblCorpName
            // 
            this.lblCorpName.AutoSize = true;
            this.lblCorpName.Location = new System.Drawing.Point(12, 45);
            this.lblCorpName.Name = "lblCorpName";
            this.lblCorpName.Size = new System.Drawing.Size(87, 15);
            this.lblCorpName.TabIndex = 1;
            this.lblCorpName.Text = "Company Name";
            // 
            // txtCorpName
            // 
            this.txtCorpName.Location = new System.Drawing.Point(105, 37);
            this.txtCorpName.Name = "txtCorpName";
            this.txtCorpName.Size = new System.Drawing.Size(295, 23);
            this.txtCorpName.TabIndex = 2;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(12, 79);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(46, 15);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(12, 110);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(61, 15);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "City/State";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(12, 138);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(51, 15);
            this.lblZipCode.TabIndex = 5;
            this.lblZipCode.Text = "Zip Code";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(12, 168);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(40, 15);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Phone";
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Location = new System.Drawing.Point(12, 199);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(25, 15);
            this.lblFax.TabIndex = 7;
            this.lblFax.Text = "Fax";
            // 
            // lblDescrpt
            // 
            this.lblDescrpt.AutoSize = true;
            this.lblDescrpt.Location = new System.Drawing.Point(12, 225);
            this.lblDescrpt.Name = "lblDescrpt";
            this.lblDescrpt.Size = new System.Drawing.Size(66, 15);
            this.lblDescrpt.TabIndex = 8;
            this.lblDescrpt.Text = "Description";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(12, 273);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(35, 15);
            this.lblNotes.TabIndex = 9;
            this.lblNotes.Text = "Notes";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 327);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(72, 15);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Web Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(105, 71);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(457, 23);
            this.txtAddress.TabIndex = 11;
            // 
            // txtCityState
            // 
            this.txtCityState.Location = new System.Drawing.Point(105, 102);
            this.txtCityState.Name = "txtCityState";
            this.txtCityState.Size = new System.Drawing.Size(154, 23);
            this.txtCityState.TabIndex = 12;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(105, 130);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(107, 23);
            this.txtZipCode.TabIndex = 13;
            // 
            // mskPhoneNum
            // 
            this.mskPhoneNum.Location = new System.Drawing.Point(105, 159);
            this.mskPhoneNum.Mask = "(999) 000-0000";
            this.mskPhoneNum.Name = "mskPhoneNum";
            this.mskPhoneNum.Size = new System.Drawing.Size(132, 23);
            this.mskPhoneNum.TabIndex = 14;
            // 
            // mskFaxNum
            // 
            this.mskFaxNum.Location = new System.Drawing.Point(105, 188);
            this.mskFaxNum.Mask = "(999) 000-0000";
            this.mskFaxNum.Name = "mskFaxNum";
            this.mskFaxNum.Size = new System.Drawing.Size(132, 23);
            this.mskFaxNum.TabIndex = 15;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(105, 217);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(443, 42);
            this.txtDescription.TabIndex = 16;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(105, 265);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(443, 43);
            this.txtNotes.TabIndex = 17;
            // 
            // txtEmailWebAddress
            // 
            this.txtEmailWebAddress.Location = new System.Drawing.Point(105, 319);
            this.txtEmailWebAddress.Name = "txtEmailWebAddress";
            this.txtEmailWebAddress.Size = new System.Drawing.Size(319, 23);
            this.txtEmailWebAddress.TabIndex = 18;
            // 
            // lblRecordNum
            // 
            this.lblRecordNum.AutoSize = true;
            this.lblRecordNum.Location = new System.Drawing.Point(12, 366);
            this.lblRecordNum.Name = "lblRecordNum";
            this.lblRecordNum.Size = new System.Drawing.Size(58, 15);
            this.lblRecordNum.TabIndex = 19;
            this.lblRecordNum.Text = "Record ID";
            // 
            // txtRecordID
            // 
            this.txtRecordID.Location = new System.Drawing.Point(105, 358);
            this.txtRecordID.Name = "txtRecordID";
            this.txtRecordID.Size = new System.Drawing.Size(100, 23);
            this.txtRecordID.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 401);
            this.Controls.Add(this.txtRecordID);
            this.Controls.Add(this.lblRecordNum);
            this.Controls.Add(this.txtEmailWebAddress);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.mskFaxNum);
            this.Controls.Add(this.mskPhoneNum);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.txtCityState);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.lblDescrpt);
            this.Controls.Add(this.lblFax);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblZipCode);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtCorpName);
            this.Controls.Add(this.lblCorpName);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Rockwell Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Resume Tracking";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem companysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem positionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interviewsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDeleteModifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byCompanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byJobsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byInterviewDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullTableToolStripMenuItem;
        private System.Windows.Forms.Label lblCorpName;
        private System.Windows.Forms.TextBox txtCorpName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.Label lblDescrpt;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCityState;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.MaskedTextBox mskPhoneNum;
        private System.Windows.Forms.MaskedTextBox mskFaxNum;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtEmailWebAddress;
        private System.Windows.Forms.Label lblRecordNum;
        private System.Windows.Forms.TextBox txtRecordID;
    }
}

