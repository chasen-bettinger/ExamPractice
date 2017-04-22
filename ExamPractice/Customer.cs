using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPractice
{
    class Customer
    {
        // ---- Members
        private int customerID;
        private long phoneNumber;
        private string firstName, lastName, email;
        private DateTime dateOfBirth;

        // ---- Properties

        public int CustomerID { get { return customerID; } set { customerID = value; } }
        public long PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string Email { get { return email; } set { email = value; } }
        public DateTime DateOfBirth { get { return dateOfBirth; } set { dateOfBirth = value; } }


        /* Retrieved from Ed Hassler code */

        public int GetAge
        {
            get
            {
                DateTime current = DateTime.Now;
                int age = current.Year - DateOfBirth.Year;
                if (current < DateOfBirth.AddYears(age))
                    age--;

                return age;
            }
        }

        // ---- Constructor

        public Customer(int customerID, string firstName, string lastName, string email, DateTime dateOfBirth, long phoneNumber)
        {
            this.customerID = customerID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.dateOfBirth = dateOfBirth;
            this.phoneNumber = phoneNumber;
        }
    }
}
