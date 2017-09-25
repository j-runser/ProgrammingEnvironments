namespace DataEntryForms
{
    partial class Frm_JobFair
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
            this.components = new System.ComponentModel.Container();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_startDate = new System.Windows.Forms.Label();
            this.lbl_endDate = new System.Windows.Forms.Label();
            this.lbl_venu = new System.Windows.Forms.Label();
            this.lbl_website = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_contact = new System.Windows.Forms.Label();
            this.txtBox_title = new System.Windows.Forms.TextBox();
            this.txtBox_description = new System.Windows.Forms.TextBox();
            this.txtBox_website = new System.Windows.Forms.TextBox();
            this.txtBox_phone = new System.Windows.Forms.TextBox();
            this.txtBox_contact = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.datePick_start = new System.Windows.Forms.DateTimePicker();
            this.datePick_end = new System.Windows.Forms.DateTimePicker();
            this.cmb_venue = new System.Windows.Forms.ComboBox();
            this.testVenuesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobFairDataSet1 = new DataEntryForms.JobFairDataSet1();
            this.testVenuesTableAdapter = new DataEntryForms.JobFairDataSet1TableAdapters.TestVenuesTableAdapter();
            this.lbl_venueID = new System.Windows.Forms.Label();
            this.lbl_venueName = new System.Windows.Forms.Label();
            this.lbl_venueShortDesc = new System.Windows.Forms.Label();
            this.lbl_venueLongDescript = new System.Windows.Forms.Label();
            this.txtBox_venueID = new System.Windows.Forms.TextBox();
            this.txtBox_venueName = new System.Windows.Forms.TextBox();
            this.rTxtBox_venueShortDescript = new System.Windows.Forms.RichTextBox();
            this.rTxtBox_venueLongDescript = new System.Windows.Forms.RichTextBox();
            this.grpBox_venueInfo = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.testVenuesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobFairDataSet1)).BeginInit();
            this.grpBox_venueInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(94, 15);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(42, 20);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Title:";
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(43, 46);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(93, 20);
            this.lbl_description.TabIndex = 1;
            this.lbl_description.Text = "Description:";
            // 
            // lbl_startDate
            // 
            this.lbl_startDate.AutoSize = true;
            this.lbl_startDate.Location = new System.Drawing.Point(49, 79);
            this.lbl_startDate.Name = "lbl_startDate";
            this.lbl_startDate.Size = new System.Drawing.Size(87, 20);
            this.lbl_startDate.TabIndex = 2;
            this.lbl_startDate.Text = "Start Date:";
            // 
            // lbl_endDate
            // 
            this.lbl_endDate.AutoSize = true;
            this.lbl_endDate.Location = new System.Drawing.Point(55, 104);
            this.lbl_endDate.Name = "lbl_endDate";
            this.lbl_endDate.Size = new System.Drawing.Size(81, 20);
            this.lbl_endDate.TabIndex = 3;
            this.lbl_endDate.Text = "End Date:";
            // 
            // lbl_venu
            // 
            this.lbl_venu.AutoSize = true;
            this.lbl_venu.Location = new System.Drawing.Point(76, 139);
            this.lbl_venu.Name = "lbl_venu";
            this.lbl_venu.Size = new System.Drawing.Size(60, 20);
            this.lbl_venu.TabIndex = 4;
            this.lbl_venu.Text = "Venue:";
            // 
            // lbl_website
            // 
            this.lbl_website.AutoSize = true;
            this.lbl_website.Location = new System.Drawing.Point(65, 172);
            this.lbl_website.Name = "lbl_website";
            this.lbl_website.Size = new System.Drawing.Size(71, 20);
            this.lbl_website.TabIndex = 5;
            this.lbl_website.Text = "Website:";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(77, 203);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(59, 20);
            this.lbl_phone.TabIndex = 6;
            this.lbl_phone.Text = "Phone:";
            // 
            // lbl_contact
            // 
            this.lbl_contact.AutoSize = true;
            this.lbl_contact.Location = new System.Drawing.Point(13, 234);
            this.lbl_contact.Name = "lbl_contact";
            this.lbl_contact.Size = new System.Drawing.Size(123, 20);
            this.lbl_contact.TabIndex = 7;
            this.lbl_contact.Text = "Contact Person:";
            // 
            // txtBox_title
            // 
            this.txtBox_title.Location = new System.Drawing.Point(142, 12);
            this.txtBox_title.Name = "txtBox_title";
            this.txtBox_title.Size = new System.Drawing.Size(199, 26);
            this.txtBox_title.TabIndex = 8;
            // 
            // txtBox_description
            // 
            this.txtBox_description.Location = new System.Drawing.Point(142, 43);
            this.txtBox_description.Name = "txtBox_description";
            this.txtBox_description.Size = new System.Drawing.Size(199, 26);
            this.txtBox_description.TabIndex = 9;
            // 
            // txtBox_website
            // 
            this.txtBox_website.Location = new System.Drawing.Point(142, 169);
            this.txtBox_website.Name = "txtBox_website";
            this.txtBox_website.Size = new System.Drawing.Size(199, 26);
            this.txtBox_website.TabIndex = 13;
            // 
            // txtBox_phone
            // 
            this.txtBox_phone.Location = new System.Drawing.Point(142, 200);
            this.txtBox_phone.Name = "txtBox_phone";
            this.txtBox_phone.Size = new System.Drawing.Size(199, 26);
            this.txtBox_phone.TabIndex = 14;
            // 
            // txtBox_contact
            // 
            this.txtBox_contact.Location = new System.Drawing.Point(142, 231);
            this.txtBox_contact.Name = "txtBox_contact";
            this.txtBox_contact.Size = new System.Drawing.Size(199, 26);
            this.txtBox_contact.TabIndex = 15;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(142, 262);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(199, 44);
            this.btn_submit.TabIndex = 16;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // datePick_start
            // 
            this.datePick_start.Location = new System.Drawing.Point(142, 74);
            this.datePick_start.Name = "datePick_start";
            this.datePick_start.Size = new System.Drawing.Size(199, 26);
            this.datePick_start.TabIndex = 17;
            this.datePick_start.Value = new System.DateTime(2017, 9, 25, 0, 0, 0, 0);
            this.datePick_start.ValueChanged += new System.EventHandler(this.datePick_start_ValueChanged);
            // 
            // datePick_end
            // 
            this.datePick_end.Location = new System.Drawing.Point(142, 105);
            this.datePick_end.Name = "datePick_end";
            this.datePick_end.Size = new System.Drawing.Size(199, 26);
            this.datePick_end.TabIndex = 18;
            this.datePick_end.ValueChanged += new System.EventHandler(this.datePick_end_ValueChanged);
            // 
            // cmb_venue
            // 
            this.cmb_venue.DataSource = this.testVenuesBindingSource;
            this.cmb_venue.DisplayMember = "Name";
            this.cmb_venue.FormattingEnabled = true;
            this.cmb_venue.Location = new System.Drawing.Point(142, 136);
            this.cmb_venue.Name = "cmb_venue";
            this.cmb_venue.Size = new System.Drawing.Size(199, 28);
            this.cmb_venue.TabIndex = 19;
            this.cmb_venue.SelectedIndexChanged += new System.EventHandler(this.cmb_venue_SelectedIndexChanged);
            // 
            // testVenuesBindingSource
            // 
            this.testVenuesBindingSource.DataMember = "TestVenues";
            this.testVenuesBindingSource.DataSource = this.jobFairDataSet1;
            // 
            // jobFairDataSet1
            // 
            this.jobFairDataSet1.DataSetName = "JobFairDataSet1";
            this.jobFairDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testVenuesTableAdapter
            // 
            this.testVenuesTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_venueID
            // 
            this.lbl_venueID.AutoSize = true;
            this.lbl_venueID.Location = new System.Drawing.Point(109, 26);
            this.lbl_venueID.Name = "lbl_venueID";
            this.lbl_venueID.Size = new System.Drawing.Size(30, 20);
            this.lbl_venueID.TabIndex = 20;
            this.lbl_venueID.Text = "ID:";
            // 
            // lbl_venueName
            // 
            this.lbl_venueName.AutoSize = true;
            this.lbl_venueName.Location = new System.Drawing.Point(84, 59);
            this.lbl_venueName.Name = "lbl_venueName";
            this.lbl_venueName.Size = new System.Drawing.Size(55, 20);
            this.lbl_venueName.TabIndex = 21;
            this.lbl_venueName.Text = "Name:";
            // 
            // lbl_venueShortDesc
            // 
            this.lbl_venueShortDesc.AutoSize = true;
            this.lbl_venueShortDesc.Location = new System.Drawing.Point(16, 92);
            this.lbl_venueShortDesc.Name = "lbl_venueShortDesc";
            this.lbl_venueShortDesc.Size = new System.Drawing.Size(123, 20);
            this.lbl_venueShortDesc.TabIndex = 22;
            this.lbl_venueShortDesc.Text = "Sort Description";
            // 
            // lbl_venueLongDescript
            // 
            this.lbl_venueLongDescript.AutoSize = true;
            this.lbl_venueLongDescript.Location = new System.Drawing.Point(6, 195);
            this.lbl_venueLongDescript.Name = "lbl_venueLongDescript";
            this.lbl_venueLongDescript.Size = new System.Drawing.Size(133, 20);
            this.lbl_venueLongDescript.TabIndex = 23;
            this.lbl_venueLongDescript.Text = "Long Description:";
            // 
            // txtBox_venueID
            // 
            this.txtBox_venueID.Location = new System.Drawing.Point(145, 23);
            this.txtBox_venueID.Name = "txtBox_venueID";
            this.txtBox_venueID.Size = new System.Drawing.Size(100, 26);
            this.txtBox_venueID.TabIndex = 24;
            // 
            // txtBox_venueName
            // 
            this.txtBox_venueName.Location = new System.Drawing.Point(145, 56);
            this.txtBox_venueName.Name = "txtBox_venueName";
            this.txtBox_venueName.Size = new System.Drawing.Size(200, 26);
            this.txtBox_venueName.TabIndex = 25;
            // 
            // rTxtBox_venueShortDescript
            // 
            this.rTxtBox_venueShortDescript.Location = new System.Drawing.Point(145, 89);
            this.rTxtBox_venueShortDescript.Name = "rTxtBox_venueShortDescript";
            this.rTxtBox_venueShortDescript.Size = new System.Drawing.Size(200, 96);
            this.rTxtBox_venueShortDescript.TabIndex = 26;
            this.rTxtBox_venueShortDescript.Text = "";
            // 
            // rTxtBox_venueLongDescript
            // 
            this.rTxtBox_venueLongDescript.Location = new System.Drawing.Point(145, 192);
            this.rTxtBox_venueLongDescript.Name = "rTxtBox_venueLongDescript";
            this.rTxtBox_venueLongDescript.Size = new System.Drawing.Size(200, 200);
            this.rTxtBox_venueLongDescript.TabIndex = 27;
            this.rTxtBox_venueLongDescript.Text = "";
            // 
            // grpBox_venueInfo
            // 
            this.grpBox_venueInfo.Controls.Add(this.lbl_venueID);
            this.grpBox_venueInfo.Controls.Add(this.rTxtBox_venueLongDescript);
            this.grpBox_venueInfo.Controls.Add(this.lbl_venueName);
            this.grpBox_venueInfo.Controls.Add(this.rTxtBox_venueShortDescript);
            this.grpBox_venueInfo.Controls.Add(this.lbl_venueShortDesc);
            this.grpBox_venueInfo.Controls.Add(this.txtBox_venueName);
            this.grpBox_venueInfo.Controls.Add(this.lbl_venueLongDescript);
            this.grpBox_venueInfo.Controls.Add(this.txtBox_venueID);
            this.grpBox_venueInfo.Location = new System.Drawing.Point(348, 12);
            this.grpBox_venueInfo.Name = "grpBox_venueInfo";
            this.grpBox_venueInfo.Size = new System.Drawing.Size(365, 408);
            this.grpBox_venueInfo.TabIndex = 28;
            this.grpBox_venueInfo.TabStop = false;
            this.grpBox_venueInfo.Text = "Venue Informatoin";
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(17, 262);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(119, 44);
            this.btn_cancel.TabIndex = 29;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // Frm_JobFair
            // 
            this.AcceptButton = this.btn_submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(1121, 836);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.grpBox_venueInfo);
            this.Controls.Add(this.cmb_venue);
            this.Controls.Add(this.datePick_end);
            this.Controls.Add(this.datePick_start);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txtBox_contact);
            this.Controls.Add(this.txtBox_phone);
            this.Controls.Add(this.txtBox_website);
            this.Controls.Add(this.txtBox_description);
            this.Controls.Add(this.txtBox_title);
            this.Controls.Add(this.lbl_contact);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.lbl_website);
            this.Controls.Add(this.lbl_venu);
            this.Controls.Add(this.lbl_endDate);
            this.Controls.Add(this.lbl_startDate);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.lbl_title);
            this.Name = "Frm_JobFair";
            this.Text = "Frm_JobFair";
            this.Load += new System.EventHandler(this.Frm_JobFair_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testVenuesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobFairDataSet1)).EndInit();
            this.grpBox_venueInfo.ResumeLayout(false);
            this.grpBox_venueInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_startDate;
        private System.Windows.Forms.Label lbl_endDate;
        private System.Windows.Forms.Label lbl_venu;
        private System.Windows.Forms.Label lbl_website;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_contact;
        private System.Windows.Forms.TextBox txtBox_title;
        private System.Windows.Forms.TextBox txtBox_description;
        private System.Windows.Forms.TextBox txtBox_website;
        private System.Windows.Forms.TextBox txtBox_phone;
        private System.Windows.Forms.TextBox txtBox_contact;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.DateTimePicker datePick_start;
        private System.Windows.Forms.DateTimePicker datePick_end;
        private System.Windows.Forms.ComboBox cmb_venue;
        private JobFairDataSet1 jobFairDataSet1;
        private System.Windows.Forms.BindingSource testVenuesBindingSource;
        private JobFairDataSet1TableAdapters.TestVenuesTableAdapter testVenuesTableAdapter;
        private System.Windows.Forms.Label lbl_venueID;
        private System.Windows.Forms.Label lbl_venueName;
        private System.Windows.Forms.Label lbl_venueShortDesc;
        private System.Windows.Forms.Label lbl_venueLongDescript;
        private System.Windows.Forms.TextBox txtBox_venueID;
        private System.Windows.Forms.TextBox txtBox_venueName;
        private System.Windows.Forms.RichTextBox rTxtBox_venueShortDescript;
        private System.Windows.Forms.RichTextBox rTxtBox_venueLongDescript;
        private System.Windows.Forms.GroupBox grpBox_venueInfo;
        private System.Windows.Forms.Button btn_cancel;
    }
}