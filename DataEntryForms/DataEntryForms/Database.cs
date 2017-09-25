using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntryForms
{
    class Database
    {

        private string str_connection;

        private SqlConnection sql_connection;
        private SqlCommand sql_command;

        public Database(string str_connection)
        {

            this.str_connection = str_connection;

        }

        public void InsertJobFair(JobFair jobFair)
        {

            string str_command = "" +
                "INSERT INTO TestJobFairs" +
                "(" +
                    "Title, " +
                    "Description, " +
                    "StartDate, " +
                    "EndDate, " +
                    "VenueID, " +
                    "Website, " +
                    "Phone " +
                ")" +
                "Values " +
                "(" +
                    "'" + jobFair.Title + "'," +
                    "'" + jobFair.Description + "'," +
                    "'" + jobFair.StartDate + "'," +
                    "'" + jobFair.EndDate + "'," +
                    "'" + jobFair.VenueID + "'," +
                    "'" + jobFair.Website + "'," +
                    "'" + jobFair.PhoneNumber + "'" +
                ")";

            ExecuteCommand(str_command);

        }
        
        public void InsertPerson(Person person)
        {

            string str_command = "" +
                "INSERT INTO People" +
                "(" +
                    "First, "       +
                    "MI, "          +
                    "Last, "        +
                    "Title, "       +
                    "Address1, "    +
                    "Address2, "    +
                    "City, State, " +
                    "Zip, "         +
                    "Email, "       +
                    "Phone"         +
                ")" +
                "Values " +
                "(" +
                    "'" + person.FirstName     + "'," +
                    "'" + person.MiddleInitial + "'," +
                    "'" + person.LastName      + "'," +
                    "'" + person.Title         + "'," +
                    "'" + person.AddressOne    + "'," +
                    "'" + person.AddressTwo    + "'," +
                    "'" + person.City          + "'," +
                    "'" + person.State         + "'," +
                    "'" + person.ZipCode       + "'," +
                    "'" + person.EmailAddress  + "'," +
                    "'" + person.PhoneNumber   + "'"  +
                ")";

            ExecuteCommand(str_command);
        }

        public void InsertVenue(Venue venue)
        {

            string str_command = "" +
                "INSERT INTO TestVenues" +
                "(" +
                    "Name, " +
                    "JobFairID, " +
                    "ShortDescription, " +
                    "LongDescription" +
                ")" +
                "Values " +
                "(" +
                    "'" + venue.Name + "'," +
                    "'" + venue.JobFairID + "'," +
                    "'" + venue.ShortDescription + "'," +
                    "'" + venue.LongDescription + "'" +
                ")";

            ExecuteCommand(str_command);

        }

        private int ExecuteCommand(string str_command)
        {

            int retVal;
            
            // Actual sending of the command to the database.
            sql_connection = new SqlConnection(str_connection);
            sql_command = new SqlCommand
            {
                CommandText = str_command,
                CommandType = System.Data.CommandType.Text,
                Connection = sql_connection
            };
            sql_connection.Open();
            retVal = sql_command.ExecuteNonQuery();
            sql_connection.Close();

            return retVal;
        }

    }
}
