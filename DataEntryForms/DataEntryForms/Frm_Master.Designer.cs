namespace DataEntryForms
{
    partial class Frm_Master
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
            this.Btn_Venues = new System.Windows.Forms.Button();
            this.Btn_People = new System.Windows.Forms.Button();
            this.Btn_JobFair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Venues
            // 
            this.Btn_Venues.Location = new System.Drawing.Point(12, 66);
            this.Btn_Venues.Name = "Btn_Venues";
            this.Btn_Venues.Size = new System.Drawing.Size(141, 36);
            this.Btn_Venues.TabIndex = 0;
            this.Btn_Venues.Text = "Venues";
            this.Btn_Venues.UseVisualStyleBackColor = true;
            this.Btn_Venues.Click += new System.EventHandler(this.Btn_Venues_Click);
            // 
            // Btn_People
            // 
            this.Btn_People.Location = new System.Drawing.Point(12, 12);
            this.Btn_People.Name = "Btn_People";
            this.Btn_People.Size = new System.Drawing.Size(141, 36);
            this.Btn_People.TabIndex = 1;
            this.Btn_People.Text = "People";
            this.Btn_People.UseVisualStyleBackColor = true;
            this.Btn_People.Click += new System.EventHandler(this.Btn_People_Click);
            // 
            // Btn_JobFair
            // 
            this.Btn_JobFair.Location = new System.Drawing.Point(12, 120);
            this.Btn_JobFair.Name = "Btn_JobFair";
            this.Btn_JobFair.Size = new System.Drawing.Size(141, 36);
            this.Btn_JobFair.TabIndex = 2;
            this.Btn_JobFair.Text = "Job Fair";
            this.Btn_JobFair.UseVisualStyleBackColor = true;
            this.Btn_JobFair.Click += new System.EventHandler(this.Btn_JobFair_Click);
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 403);
            this.Controls.Add(this.Btn_JobFair);
            this.Controls.Add(this.Btn_People);
            this.Controls.Add(this.Btn_Venues);
            this.Name = "MasterForm";
            this.Text = "Job Fair Data Entry";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Venues;
        private System.Windows.Forms.Button Btn_People;
        private System.Windows.Forms.Button Btn_JobFair;
    }
}

