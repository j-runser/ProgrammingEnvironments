using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataEntryForms
{
    public partial class Frm_Venue : Form
    {
        Venue venue;

        public Frm_Venue(Venue venue)
        {
            InitializeComponent();

            this.venue = venue;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {

            venue.Name             = txtBox_name.Text;
            venue.ShortDescription = txtBox_shortDescipt.Text;
            venue.LongDescription  = txtBox_longDescript.Text;

            this.DialogResult = DialogResult.OK;
            Close();

        }
    }
}
