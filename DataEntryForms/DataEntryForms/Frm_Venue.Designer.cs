namespace DataEntryForms
{
    partial class Frm_Venue
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_shortDescript = new System.Windows.Forms.Label();
            this.lbl_longDescript = new System.Windows.Forms.Label();
            this.txtBox_longDescript = new System.Windows.Forms.TextBox();
            this.txtBox_shortDescipt = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.jobFairDataSet = new DataEntryForms.JobFairDataSet();
            this.txtBox_name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.jobFairDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(93, 10);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(55, 20);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name:";
            // 
            // lbl_shortDescript
            // 
            this.lbl_shortDescript.AutoSize = true;
            this.lbl_shortDescript.Location = new System.Drawing.Point(12, 42);
            this.lbl_shortDescript.Name = "lbl_shortDescript";
            this.lbl_shortDescript.Size = new System.Drawing.Size(136, 20);
            this.lbl_shortDescript.TabIndex = 2;
            this.lbl_shortDescript.Text = "Short Description:";
            // 
            // lbl_longDescript
            // 
            this.lbl_longDescript.AutoSize = true;
            this.lbl_longDescript.Location = new System.Drawing.Point(15, 74);
            this.lbl_longDescript.Name = "lbl_longDescript";
            this.lbl_longDescript.Size = new System.Drawing.Size(133, 20);
            this.lbl_longDescript.TabIndex = 3;
            this.lbl_longDescript.Text = "Long Description:";
            // 
            // txtBox_longDescript
            // 
            this.txtBox_longDescript.Location = new System.Drawing.Point(154, 71);
            this.txtBox_longDescript.Name = "txtBox_longDescript";
            this.txtBox_longDescript.Size = new System.Drawing.Size(100, 26);
            this.txtBox_longDescript.TabIndex = 4;
            // 
            // txtBox_shortDescipt
            // 
            this.txtBox_shortDescipt.Location = new System.Drawing.Point(154, 39);
            this.txtBox_shortDescipt.Name = "txtBox_shortDescipt";
            this.txtBox_shortDescipt.Size = new System.Drawing.Size(100, 26);
            this.txtBox_shortDescipt.TabIndex = 7;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(19, 104);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(234, 32);
            this.btn_submit.TabIndex = 8;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // jobFairDataSet
            // 
            this.jobFairDataSet.DataSetName = "JobFairDataSet";
            this.jobFairDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtBox_name
            // 
            this.txtBox_name.Location = new System.Drawing.Point(154, 7);
            this.txtBox_name.Name = "txtBox_name";
            this.txtBox_name.Size = new System.Drawing.Size(100, 26);
            this.txtBox_name.TabIndex = 5;
            // 
            // Frm_Venue
            // 
            this.AcceptButton = this.btn_submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 642);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txtBox_shortDescipt);
            this.Controls.Add(this.txtBox_name);
            this.Controls.Add(this.txtBox_longDescript);
            this.Controls.Add(this.lbl_longDescript);
            this.Controls.Add(this.lbl_shortDescript);
            this.Controls.Add(this.lbl_name);
            this.Name = "Frm_Venue";
            this.Text = "Venue";
            ((System.ComponentModel.ISupportInitialize)(this.jobFairDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_shortDescript;
        private System.Windows.Forms.Label lbl_longDescript;
        private System.Windows.Forms.TextBox txtBox_longDescript;
        private System.Windows.Forms.TextBox txtBox_shortDescipt;
        private System.Windows.Forms.Button btn_submit;
        private JobFairDataSet jobFairDataSet;
        private System.Windows.Forms.TextBox txtBox_name;
    }
}