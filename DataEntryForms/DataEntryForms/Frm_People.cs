using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataEntryForms
{
    public partial class Frm_People : Form
    {

        Person person;
        List<USState> states;

        public Frm_People(Person person)
        {
            InitializeComponent();
            
            this.person = person;

            // Populate and set up the cmbBox_state
            states = USStateList.States();
            this.cmbBox_state.DataSource = states;
            this.cmbBox_state.DisplayMember = "Name";
            this.cmbBox_state.ValueMember = "Abbreviation";

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {

            person.FirstName = txtBox_firstName.Text;
            person.MiddleInitial = txtBox_mi.Text;
            person.LastName = txtBox_lastName.Text;
            person.Title = cmb_title.SelectedIndex + "";
            person.AddressOne = txtBox_addressOne.Text;
            person.AddressTwo = txtBox_addressTwo.Text;
            person.City = txtBox_city.Text;
            person.State = cmbBox_state.ValueMember;
            person.ZipCode = txtBox_zip.Text;
            person.EmailAddress = txtBox_email.Text;
            person.PhoneNumber = txtBox_phone.Text;
            
            this.DialogResult = DialogResult.OK;
            Close();

        }

        private void FormatPhoneNumber()
        {

            // Regex (regular expression) that reconizes any charecter that is 
            // not (^) a digit (\d).
            Regex rx_nonDigit = new Regex(@"^\d");

            string str_raw = txtBox_phone.Text;
            // Replace non-digits with empty
            str_raw = rx_nonDigit.Replace(str_raw, "");

            if (str_raw.Length == 10)
            {
                str_raw = "(" + str_raw.Substring(0, 3) + ")" + str_raw.Substring(3, 3) + "-" + str_raw.Substring(4);
                txtBox_phone.Text = str_raw;
            }
            else if (str_raw.Length == 0)
            {
                return;
            }
            else
            {
                // do something for invalid phone number
            }

        }
    }
}
