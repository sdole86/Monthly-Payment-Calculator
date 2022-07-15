using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monthly_Payment_Calculator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double interestRate, purchase, downPayment, loanRate;

            bool interestParseSuccess = double.TryParse(InterestRateBox.Text, out interestRate);
            bool purchaseParseSuccess = double.TryParse(PurchasePriceBox.Text, out purchase);
            bool downParseSuccess = double.TryParse(DownPaymentAmountBox.Text, out downPayment);
            bool loanParseSuccess = double.TryParse(TermBox.Text, out loanRate);

            if (InterestRateBox.Text == "" || PurchasePriceBox.Text == "" || TermBox.Text == "" || DownPaymentAmountBox.Text == "")
            {
                string message = "All forms must be filled out!";
                string title = "Missing input";
                MessageBox.Show(message, title);
            }
            else if (interestParseSuccess == false || purchaseParseSuccess == false || downParseSuccess == false || loanParseSuccess == false)
            {
                string message = "Invalid data entry!";
                string title = "Invalid input";
                MessageBox.Show(message, title);
            }
            else {
                interestRate = double.Parse(InterestRateBox.Text);

                double totalFinanceAmount = double.Parse(PurchasePriceBox.Text) - double.Parse(DownPaymentAmountBox.Text);
                double totalPayments = double.Parse(TermBox.Text);

                double monthlyInterestRateMonthly = interestRate / 100 / 12;
                double monthlyPayment = monthlyInterestRateMonthly * totalFinanceAmount * Math.Pow((1 + monthlyInterestRateMonthly), totalPayments) / (Math.Pow((1 + monthlyInterestRateMonthly), totalPayments) - 1);

                AmountToFinanceBox.Text = totalFinanceAmount.ToString("C2");
                MonthlyPaymentBox.Text = monthlyPayment.ToString("C2");
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            AmountToFinanceBox.Text = "";
            MonthlyPaymentBox.Text = "";
            InterestRateBox.Text = "";
            TermBox.Text = "";
            PurchasePriceBox.Text = "";
            DownPaymentAmountBox.Text = "";
        }
    }
}
