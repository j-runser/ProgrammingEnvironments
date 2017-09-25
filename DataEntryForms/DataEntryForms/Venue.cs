using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntryForms
{
    public class Venue
    {

        private string str_name;
        private string str_shortDescript;
        private string str_longDescript;
        private string str_jobFairID;

        public Venue()
        {

            str_name = "";
            str_shortDescript = "";
            str_longDescript = "";
            str_jobFairID = "";

        }

        public string Name { get => str_name; set => str_name = value; }
        public string ShortDescription { get => str_shortDescript; set => str_shortDescript = value; }
        public string LongDescription { get => str_longDescript; set => str_longDescript = value; }
        public string JobFairID { get => str_jobFairID; set => str_jobFairID = value; }
    }
}
