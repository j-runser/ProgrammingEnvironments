using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntryForms
{
    public class JobFair
    {

        private string str_title;
        private string str_description;
        private string str_startDate;
        private string str_endDate;
        private string str_venueID;
        private string str_website;
        private string str_phone;
        private string str_contactPerson;

        public JobFair()
        {
            
        }

        public string Title { get => str_title; set => str_title = value; }
        public string Description { get => str_description; set => str_description = value; }
        public string StartDate { get => str_startDate; set => str_startDate = value; }
        public string EndDate { get => str_endDate; set => str_endDate = value; }
        public string VenueID { get => str_venueID; set => str_venueID = value; }
        public string Website { get => str_website; set => str_website = value; }
        public string PhoneNumber { get => str_phone; set => str_phone = value; }
        public string ContactPerson { get => str_contactPerson; set => str_contactPerson = value; }
    }
}
