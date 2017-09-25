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
    public partial class Frm_Master : Form
    {

        private Frm_JobFair frm_jobFair;
        private Frm_People  frm_people;
        private Frm_Venue   frm_venue;

        private JobFair jobFair;
        private Person person;
        private Venue venue;

        private Database database;

        public Frm_Master()
        {
            InitializeComponent();

            jobFair = new JobFair();
            person = new Person();
            venue  = new Venue();
            

            frm_jobFair = new Frm_JobFair(jobFair);
            frm_people  = new Frm_People(person);
            frm_venue   = new Frm_Venue(venue);

            database = new Database("Data Source=JOESMAC-WINDOWS;Initial Catalog=JobFair;Integrated Security=True");
        }

        private void Btn_People_Click(object sender, EventArgs e)
        {

            if(frm_people.ShowDialog() == DialogResult.OK)
            {
                database.InsertPerson(person);
            }
            
        }

        private void Btn_Venues_Click(object sender, EventArgs e)
        {

            if(frm_venue.ShowDialog() == DialogResult.OK)
            {
                database.InsertVenue(venue);
            }
            
        }

        private void Btn_JobFair_Click(object sender, EventArgs e)
        {
            if (frm_jobFair.ShowDialog() == DialogResult.OK)
            {
                database.InsertJobFair(jobFair);
            }
        }
    }
}
