using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamPractice
{
    public partial class CustomerGUI : Form
    {

        // ---- Members

        private bool idValid = false, firstNameValid = false, lastNameValid = false,
            phoneNumberValid = false, emailValid = false;

        private Customer customer;

        // ---- Properties

        internal Customer Customer { get => customer; set => customer = value; }

        // ---- Constructor

        public CustomerGUI()
        {
            InitializeComponent();
        }

        // ---- Button Handlers

        private void SaveBtn_Click(object sender, EventArgs e)
        {

            if(CheckInputs())
            {
                int id = Convert.ToInt32(IDTextBox.Text);
                string firstName = FirstNameTextBox.Text;
                string lastName = LastNameTextBox.Text;
                string email = EmailTextBox.Text;
                DateTime dateOfBirth = DOB.Value;
                long phoneNumber = Convert.ToInt64(PhoneNumberTextBox.Text);

                Customer = new Customer(id, firstName, lastName, email, dateOfBirth, phoneNumber);

                ClearInputs();
                RetrieveBtn.Visible = true;
                RequestLoanBtn.Visible = true;
            }

        }

        private void RequestLoanBtn_Click(object sender, EventArgs e)
        {
            LoanGUI loanGUI = new LoanGUI(123, "Don Cheadle", Customer);
            loanGUI.Show();
        }

        private void RetrieveBtn_Click(object sender, EventArgs e)
        {
            IDTextBox.Text = Customer.CustomerID.ToString();
            FirstNameTextBox.Text = Customer.FirstName.ToString();
            LastNameTextBox.Text = Customer.LastName.ToString();
            EmailTextBox.Text = Customer.Email.ToString();
            DOB.Value = Customer.DateOfBirth;
            PhoneNumberTextBox.Text = Customer.PhoneNumber.ToString();
        }

        // ---- Event Handlers

        private void IDTextBox_TextChanged(object sender, EventArgs e)
        {

            if (CheckInteger(IDTextBox.Text) > 0)
            {
                IdInvalidInputText.Visible = false;
                idValid = true;
                CheckInputs();
            }
            else
            {
                IdInvalidInputText.Visible = true;
                idValid = false;
                CheckInputs();
            }
        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            string eval = FirstNameTextBox.Text;

            if (CheckString(eval) == null || ContainsDigits(eval))
            {
                firstNameValid = false;
                FirstNameInvalidtext.Visible = true;
                CheckInputs();
            }
            else
            {
                firstNameValid = true;
                FirstNameInvalidtext.Visible = false;
                CheckInputs();
            }
        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            string eval = LastNameTextBox.Text;

            if (CheckString(eval) == null || ContainsDigits(eval))
            {
                lastNameValid = false;
                LastNameInvalidText.Visible = true;
                CheckInputs();

            }
            else
            {
                lastNameValid = true;
                CheckInputs();
                LastNameInvalidText.Visible = false;
            }
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (IsEmail(EmailTextBox.Text))
            {
                emailValid = true;
                EmailInvalidText.Visible = false;
                CheckInputs();
            }
            else
            {
                emailValid = false;
                EmailInvalidText.Visible = true;
                CheckInputs();
            }
        }

        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (IsPhoneNumber(PhoneNumberTextBox.Text))
            {
                phoneNumberValid = true;
                PhoneNumberInvalidText.Visible = false;
                CheckInputs();
            }
            else
            {
                phoneNumberValid = false;
                PhoneNumberInvalidText.Visible = true;
                CheckInputs();
            }
        }

        // ---- Error Handlers

        private bool CheckInputs()
        {
            if (idValid && firstNameValid && lastNameValid && phoneNumberValid &&
                emailValid)
            {
                SaveBtn.Enabled = true;
                return true;
            }
            else
            {
                SaveBtn.Enabled = false;
                return false;
            }
        }

        private int CheckInteger(string input)
        {
            int integerReturned;

            if (Int32.TryParse(input, out integerReturned) && Convert.ToInt32(input) > 0)
            {
                return integerReturned;
            }

            return 0;
        }

        private string CheckString(string input)
        {
            if (!string.IsNullOrWhiteSpace(input))
            {
                return input;
            }

            return null;
        }

        /* Code from StackOverflow answer
         * http://stackoverflow.com/questions/5342375/regex-email-validation
         * */

        public bool IsEmail(string emailaddress)
        {

            if (IsEmpty(emailaddress))
            {
                return false;
            }

            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private bool IsEmpty(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsPhoneNumber(string number)
        {

            if (string.IsNullOrWhiteSpace(number))
            {
                return false;
            }

            return Regex.Match(number, @"\b\d{3}[-.]?\d{3}[-.]?\d{4}\b").Success;
        }

        // ---- Helper Methods

        private void ClearInputs()
        {
            IDTextBox.Clear();
            FirstNameTextBox.Clear();
            LastNameTextBox.Clear();
            EmailTextBox.Clear();
            DOB.Value = DateTime.Now;
            PhoneNumberTextBox.Clear();

            HideErrorMessages();
            CheckInputs();
        }

        private void HideErrorMessages()
        {
            IdInvalidInputText.Visible = false;
            FirstNameInvalidtext.Visible = false;
            LastNameInvalidText.Visible = false;
            EmailInvalidText.Visible = false;
            PhoneNumberInvalidText.Visible = false;
        }

        private bool ContainsDigits(string input)
        {
            if(input.Any(char.IsDigit))
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }


        
    }
}
