namespace MonthlyPaymentCalculator
{
    partial class frmMonthlyPaymentCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            btnCalculate = new Button();
            btnClose = new Button();
            lblPurchasePrice = new Label();
            txtPurchasePrice = new TextBox();
            txtDownPaymentAmount = new TextBox();
            lblDownPaymentAmount = new Label();
            txtInterestRate = new TextBox();
            lblInterestRate = new Label();
            txtLoanTerm = new TextBox();
            lblLoanTerm = new Label();
            txtAmountToFinance = new TextBox();
            lblAmountToFinance = new Label();
            txtMonthlyPayment = new TextBox();
            lblMonthlyPayment = new Label();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(23, 300);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 0;
            btnCalculate.TabStop = false;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(713, 300);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 1;
            btnClose.TabStop = false;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblPurchasePrice
            // 
            lblPurchasePrice.AutoSize = true;
            lblPurchasePrice.Location = new Point(92, 46);
            lblPurchasePrice.Name = "lblPurchasePrice";
            lblPurchasePrice.Size = new Size(90, 15);
            lblPurchasePrice.TabIndex = 2;
            lblPurchasePrice.Text = "Purchase Price: ";
            // 
            // txtPurchasePrice
            // 
            txtPurchasePrice.Location = new Point(188, 43);
            txtPurchasePrice.Name = "txtPurchasePrice";
            txtPurchasePrice.Size = new Size(153, 23);
            txtPurchasePrice.TabIndex = 0;
            // 
            // txtDownPaymentAmount
            // 
            txtDownPaymentAmount.Location = new Point(188, 104);
            txtDownPaymentAmount.Name = "txtDownPaymentAmount";
            txtDownPaymentAmount.Size = new Size(153, 23);
            txtDownPaymentAmount.TabIndex = 1;
            // 
            // lblDownPaymentAmount
            // 
            lblDownPaymentAmount.AutoSize = true;
            lblDownPaymentAmount.Location = new Point(41, 112);
            lblDownPaymentAmount.Name = "lblDownPaymentAmount";
            lblDownPaymentAmount.Size = new Size(141, 15);
            lblDownPaymentAmount.TabIndex = 4;
            lblDownPaymentAmount.Text = "Down Payment Amount: ";
            // 
            // txtInterestRate
            // 
            txtInterestRate.Location = new Point(188, 172);
            txtInterestRate.Name = "txtInterestRate";
            txtInterestRate.Size = new Size(153, 23);
            txtInterestRate.TabIndex = 2;
            // 
            // lblInterestRate
            // 
            lblInterestRate.AutoSize = true;
            lblInterestRate.Location = new Point(41, 175);
            lblInterestRate.Name = "lblInterestRate";
            lblInterestRate.Size = new Size(125, 15);
            lblInterestRate.TabIndex = 6;
            lblInterestRate.Text = "Interest Rate (annual): ";
            // 
            // txtLoanTerm
            // 
            txtLoanTerm.Location = new Point(188, 227);
            txtLoanTerm.Name = "txtLoanTerm";
            txtLoanTerm.Size = new Size(153, 23);
            txtLoanTerm.TabIndex = 3;
            // 
            // lblLoanTerm
            // 
            lblLoanTerm.AutoSize = true;
            lblLoanTerm.Location = new Point(41, 235);
            lblLoanTerm.Name = "lblLoanTerm";
            lblLoanTerm.Size = new Size(120, 15);
            lblLoanTerm.TabIndex = 8;
            lblLoanTerm.Text = "Loan Term (months): ";
            // 
            // txtAmountToFinance
            // 
            txtAmountToFinance.Location = new Point(665, 43);
            txtAmountToFinance.Name = "txtAmountToFinance";
            txtAmountToFinance.ReadOnly = true;
            txtAmountToFinance.Size = new Size(123, 23);
            txtAmountToFinance.TabIndex = 11;
            txtAmountToFinance.TabStop = false;
            // 
            // lblAmountToFinance
            // 
            lblAmountToFinance.AutoSize = true;
            lblAmountToFinance.Location = new Point(544, 46);
            lblAmountToFinance.Name = "lblAmountToFinance";
            lblAmountToFinance.Size = new Size(115, 15);
            lblAmountToFinance.TabIndex = 10;
            lblAmountToFinance.Text = "Amount to Finance: ";
            // 
            // txtMonthlyPayment
            // 
            txtMonthlyPayment.Location = new Point(665, 104);
            txtMonthlyPayment.Name = "txtMonthlyPayment";
            txtMonthlyPayment.ReadOnly = true;
            txtMonthlyPayment.Size = new Size(123, 23);
            txtMonthlyPayment.TabIndex = 13;
            txtMonthlyPayment.TabStop = false;
            // 
            // lblMonthlyPayment
            // 
            lblMonthlyPayment.AutoSize = true;
            lblMonthlyPayment.Location = new Point(551, 107);
            lblMonthlyPayment.Name = "lblMonthlyPayment";
            lblMonthlyPayment.Size = new Size(108, 15);
            lblMonthlyPayment.TabIndex = 12;
            lblMonthlyPayment.Text = "Monthly Payment: ";
            // 
            // frmMonthlyPaymentCalculator
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 328);
            Controls.Add(txtMonthlyPayment);
            Controls.Add(lblMonthlyPayment);
            Controls.Add(txtAmountToFinance);
            Controls.Add(lblAmountToFinance);
            Controls.Add(txtLoanTerm);
            Controls.Add(lblLoanTerm);
            Controls.Add(txtInterestRate);
            Controls.Add(lblInterestRate);
            Controls.Add(txtDownPaymentAmount);
            Controls.Add(lblDownPaymentAmount);
            Controls.Add(txtPurchasePrice);
            Controls.Add(lblPurchasePrice);
            Controls.Add(btnClose);
            Controls.Add(btnCalculate);
            Name = "frmMonthlyPaymentCalculator";
            Text = "Monthly Payment Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private Button btnClose;
        private Label lblPurchasePrice;
        private TextBox txtPurchasePrice;
        private TextBox txtDownPaymentAmount;
        private Label lblDownPaymentAmount;
        private TextBox txtInterestRate;
        private Label lblInterestRate;
        private TextBox txtLoanTerm;
        private Label lblLoanTerm;
        private TextBox txtAmountToFinance;
        private Label lblAmountToFinance;
        private TextBox txtMonthlyPayment;
        private Label lblMonthlyPayment;
    }
}
