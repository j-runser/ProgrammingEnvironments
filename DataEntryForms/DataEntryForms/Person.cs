using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntryForms
{
    public class Person
    {

        private string str_firstName;
        private string str_mi;
        private string str_lastName;
        private string str_title;
        private string str_addressOne;
        private string str_addressTwo;
        private string str_city;
        private string str_state;
        private string str_zip;
        private string str_email;
        private string str_phone;

        public Person()
        {

        }
        
        // Auto-generated accessors for all of the requred person feilds.
        public string FirstName { get => str_firstName; set => str_firstName = value; }
        public string MiddleInitial { get => str_mi; set => str_mi = value; }
        public string LastName { get => str_lastName; set => str_lastName = value; }
        public string Title { get => str_title; set => str_title = value; }
        public string AddressOne { get => str_addressOne; set => str_addressOne = value; }
        public string AddressTwo { get => str_addressTwo; set => str_addressTwo = value; }
        public string City { get => str_city; set => str_city = value; }
        public string State { get => str_state; set => str_state = value; }
        public string ZipCode { get => str_zip; set => str_zip = value; }
        public string EmailAddress { get => str_email; set => str_email = value; }
        public string PhoneNumber { get => str_phone; set => str_phone = value; }
    }
}
