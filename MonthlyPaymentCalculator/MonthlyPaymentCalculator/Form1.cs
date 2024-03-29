/*
 * Keith Evans
 * 
 * 3/4/2024
 * 
 * Monthly Payment Calculator
 * 
 */



namespace MonthlyPaymentCalculator
{
    public partial class frmMonthlyPaymentCalculator : Form
    {
        public frmMonthlyPaymentCalculator()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            





            // Verify Data
            // Verify Purchase Price
            if (double.TryParse(txtPurchasePrice.Text, out double purchasePrice)) { // purchase price

                // Parsing is successful
                // double purchasePrice created.
                txtPurchasePrice.BackColor = Color.White;

            } else if (txtPurchasePrice.Text == "") {

                txtPurchasePrice.BackColor = Color.IndianRed;
                MessageBox.Show("The inputs on this form cannot be empty. ", "Input Left Empty", MessageBoxButtons.OK);


            } else { // Parsing was not successful

                txtPurchasePrice.BackColor = Color.IndianRed;
                MessageBox.Show("This input's value must be a valid decimal. ", "Invalid Data Entered", MessageBoxButtons.OK);
            }







            // Verify Down Payment
            if (double.TryParse(txtDownPaymentAmount.Text, out double downPayment)) { 

                // Parsing is successful
                // double downPayment created.
                txtDownPaymentAmount.BackColor = Color.White;

            } else if (txtDownPaymentAmount.Text == "") {

                txtDownPaymentAmount.BackColor = Color.IndianRed;
                MessageBox.Show("The inputs on this form cannot be empty. ", "Input Left Empty", MessageBoxButtons.OK);


            } else { // Parsing was not successful
                
                txtDownPaymentAmount.BackColor = Color.IndianRed;
                MessageBox.Show("This input's value must be a valid decimal. ", "Invalid Data Entered", MessageBoxButtons.OK);
            }







            // Verify Interest Rate
            if (double.TryParse(txtInterestRate.Text, out double interestRate)) { // entered as decimal value such as 5.00 which is 5%

                // Parsing is successful
                // double interestRate created.
                txtInterestRate.BackColor = Color.White;

            } else if (txtInterestRate.Text == "") {

                txtInterestRate.BackColor = Color.IndianRed;
                MessageBox.Show("The inputs on this form cannot be empty. ", "Input Left Empty", MessageBoxButtons.OK);


            } else { // Parsing was not successful

                txtInterestRate.BackColor = Color.IndianRed;
                MessageBox.Show("This input's value must be a valid decimal. ", "Invalid Data Entered", MessageBoxButtons.OK);
            }




            // Verify Loan Term
            if (int.TryParse(txtLoanTerm.Text, out int term)) { // number of months for the loan. ie. 60months is 5 years. 

                // Parsing is successful
                // int term created.
                txtLoanTerm.BackColor = Color.White;

            } else if (txtLoanTerm.Text == "") {

                txtLoanTerm.BackColor = Color.IndianRed;
                MessageBox.Show("The inputs on this form cannot be empty. ", "Input Left Empty", MessageBoxButtons.OK);


            } else { // Parsing was not successful

                txtLoanTerm.BackColor = Color.IndianRed;
                MessageBox.Show("This input's value must be a valid integer. ", "Invalid Data Entered", MessageBoxButtons.OK);

            }



            // Calculations

            double amountToFinance = (purchasePrice - downPayment);
            double monthlyPayment = 0;

            double percentInterestRate = interestRate / 100; // Convert interest rate input as a % to decimal. 5% -> .05
            double monthlyPercentInterestRate = percentInterestRate / 12; // Convert interest rate from yearly amount to monthly amount.


            monthlyPayment = amountToFinance * (monthlyPercentInterestRate * Math.Pow(1 + monthlyPercentInterestRate, term)) / (Math.Pow(1 + monthlyPercentInterestRate, term) - 1);


            // Display Output
            txtAmountToFinance.Text = amountToFinance.ToString("C");


            int x = 4 / 8;


            txtMonthlyPayment.Text = x.ToString();













        }
    }
}
