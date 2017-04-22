using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPractice
{
    class Loan
    {
        // ---- Members
        private int loanID;
        private string agentName;
        private long loanAmount;
        private double interestRate;
        private Customer customer;

        // ---- Properties

        public int LoanID { get => loanID; set => loanID = value; }
        public string AgentName { get => agentName; set => agentName = value; }
        public long LoanAmount { get => loanAmount; set => loanAmount = value; }
        public double InterestRate { get => interestRate; set => interestRate = value; }
        internal Customer Customer { get => customer; set => customer = value; }

        public bool IsEligible
        {
            get
            {
                if (customer.GetAge > 21)
                    return true;
                else
                    return false;
            }
        }

        // ---- Constructor

        public Loan(int LoanID, string AgentName, long LoanAmount, double InterestRate, Customer customer)
        {
            this.LoanID = LoanID;
            this.AgentName = AgentName;
            this.LoanAmount = LoanAmount;
            this.InterestRate = InterestRate;
            this.Customer = customer;
        } 
    }
}
