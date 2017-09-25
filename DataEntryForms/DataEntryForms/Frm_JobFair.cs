using System;
using System.Data;
using System.Windows.Forms;

namespace DataEntryForms
{
    public partial class Frm_JobFair : Form
    {
        private JobFair jobFair;

        public Frm_JobFair(JobFair jobFair)
        {
            InitializeComponent();

            this.jobFair = jobFair;

            datePick_start.Value = DateTime.Today;
            datePick_end.Value = DateTime.Today;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {

            jobFair.Title = txtBox_title.Text;
            jobFair.Description = txtBox_description.Text;
            jobFair.StartDate = datePick_start.Value.ToString("yyyy-MM-dd");
            jobFair.EndDate = datePick_end.Value.ToString("yyyy-MM-dd");
            jobFair.VenueID = cmb_venue.SelectedIndex + "";
            jobFair.Website = txtBox_website.Text;
            jobFair.PhoneNumber = txtBox_phone.Text;
            jobFair.ContactPerson = txtBox_contact.Text;

            this.DialogResult = DialogResult.OK;
            Close();

        }

        private void Frm_JobFair_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jobFairDataSet1.TestVenues' table. You can move, or remove it, as needed.
            this.testVenuesTableAdapter.Fill(this.jobFairDataSet1.TestVenues);

        }

        private void cmb_venue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_venue.SelectedIndex != null)
            {
                DataRow venue = ((DataRowView)cmb_venue.SelectedItem).Row;
                txtBox_venueID.Text = venue["ID"].ToString();
                txtBox_venueName.Text = venue["Name"].ToString();
                rTxtBox_venueShortDescript.Text = venue["ShortDescription"].ToString();
                rTxtBox_venueLongDescript.Text = venue["LongDescription"].ToString();
            }
        }

        private void datePick_start_ValueChanged(object sender, EventArgs e)
        {
            if(datePick_start.Value > datePick_end.Value)
            {
                datePick_end.Value = datePick_start.Value;
            }
        }

        private void datePick_end_ValueChanged(object sender, EventArgs e)
        {
            if(datePick_start.Value > datePick_end.Value)
            {
                datePick_end.Value = datePick_start.Value;
            }
        }
    }
}
