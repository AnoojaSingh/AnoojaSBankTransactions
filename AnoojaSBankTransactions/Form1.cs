namespace AnoojaSBankTransactions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCalInterest_Click(object sender, EventArgs e)
        {
            string AccountNumber;
            string AccountName;
            double DepositAmt;
            //keep old balance so it can be output
            double CurrentBalance = 100;
            double Balance = CurrentBalance;


            //input
            AccountNumber = txtAccNum.Text;
            AccountName = txtAccName.Text;
            DepositAmt= double.Parse(txtDepositAmt.Text);

            //Processing
            Balance = CurrentBalance + DepositAmt;
    

            //Output
            lstOut.Items.Add("Account Number:" + AccountNumber);
            lstOut.Items.Add("Account Name:" + AccountName);
            lstOut.Items.Add("Deposit Amount:" + DepositAmt);
            lstOut.Items.Add("New Balance is:" + Balance);

            btnClear.Focus();

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {

        }

        private void btnWithdrawals_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAccNum.Clear();
            txtAccName.Clear();
            txtDepositAmt.Clear();
            lstOut.Items.Clear();
            txtAccNum.Focus();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAccName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDepositAmt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAccNum_Enter(object sender, EventArgs e)
        {
            txtAccNum.BackColor = Color.Bisque;
        }

        private void txtAccNum_Leave(object sender, EventArgs e)
        {
            txtAccNum.BackColor = SystemColors.Window;
        }

        private void txtAccName_Enter(object sender, EventArgs e)
        {
            txtAccName.BackColor = Color.Bisque;
        }

        private void txtAccName_Leave(object sender, EventArgs e)
        {
            txtAccName.BackColor = SystemColors.Window;
        }

        private void txtDepositAmt_Enter(object sender, EventArgs e)
        {
            txtDepositAmt.BackColor = Color.Bisque;
        }

        private void txtDepositAmt_Leave(object sender, EventArgs e)
        {
            txtDepositAmt.BackColor = SystemColors.Window;
        }
    }
}
