using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamPractice
{
    public partial class LoanGUI : Form
    {

        // ---- Members
        private bool loanAmountValid = false, interestRateValid = false;

        private Loan loan;
        private int loanId;
        private string agentName;
        private Customer customer;

        // ---- Constructor
            
        internal LoanGUI(int LoanID, string AgentName, Customer customer)
        {
            this.loanId = LoanID;
            this.agentName = AgentName;
            this.customer = customer;
            InitializeComponent();

            LoanIDTextBox.Text = LoanID.ToString();
            AgentNameTextBox.Text = AgentName;
            LoanAmountTextBox.Focus();
            CurrentAgeText.Text = customer.GetAge.ToString();
        }

        // ---- Button Handler

        private void SubmitBtn_Click(object sender, EventArgs e)
        {

            if(CheckInputs())
            {
                long loanAmount = Convert.ToInt64(LoanAmountTextBox.Text);
                double interestRate = Convert.ToDouble(InterestRateTextBox.Text);

                loan = new Loan(loanId, agentName, loanAmount, interestRate, customer);

                if(loan.IsEligible)
                {
                    MessageBox.Show("Loan Submtted Success");
                }
                else
                {
                    MessageBox.Show("I'm sorry. You are not old enough to submit a loan application. You have " +
                        $"{21-customer.GetAge} more year(s).");
                }
            }
           
        }

        // ---- Event Handlers

        private void LoanAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            if(IsEmpty(LoanAmountTextBox.Text))
            {
                loanAmountValid = false;
                LoanAmountInvalidText.Visible = false;
            }

            if(CheckLong(LoanAmountTextBox.Text) > 0)
            {
                loanAmountValid = true;
                LoanAmountInvalidText.Visible = false;
                CheckInputs();
            }
            else
            {
                loanAmountValid = false;
                LoanAmountInvalidText.Visible = true;
                CheckInputs();
            }


        }

        private void InterestRateTextBox_TextChanged(object sender, EventArgs e)
        {
            if (IsEmpty(InterestRateTextBox.Text))
            {
                loanAmountValid = false;
                InterestRateInvalidText.Visible = false;
            }

            if (CheckDouble(LoanAmountTextBox.Text) > 0.0)
            {
                interestRateValid = true;
                InterestRateInvalidText.Visible = false;
                CheckInputs();
            }
            else
            {
                interestRateValid = false;
                InterestRateInvalidText.Visible = true;
                CheckInputs();
            }

        }

        // ---- Error Handlers

        private bool CheckInputs()
        {
            if (loanAmountValid && interestRateValid)
            {
                SubmitBtn.Enabled = true;
                return true;
            }
            else
            {
                SubmitBtn.Enabled = false;
                return false;
            }
        }

        private double CheckDouble(string input)
        {
            double doubleReturned;

            if (Double.TryParse(input, out doubleReturned) && Convert.ToDouble(input) > 0)
            {
                return doubleReturned;
            }

            return 0.0;
        }

        private long CheckLong(string input)
        {
            long longReturned;

            if (Int64.TryParse(input, out longReturned) && Convert.ToInt64(input) > 0)
            {
                return longReturned;
            }

            return 0;
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
    }
}
