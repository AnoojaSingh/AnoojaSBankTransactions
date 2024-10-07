namespace AnoojaSBankTransactions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnNewBalance_Click(object sender, EventArgs e)
        {
            double AccNum;
            string AccountName;
            double DepositAmt;
            //keep old balance so it can be output
            double CurrentBalance = 100;
            double Balance = CurrentBalance;


            //input
            AccNum = txtAccNum.Text;
            AccountName = txtAccName.Text;
            //DepositAmt = double.Parse(txtDepositAmt.Text);
            bool DepositValid, AccNumValid;
            DepositValid = double.TryParse(txtDepositAmt.Text, out DepositAmt);
            AccNumValid = double.TryParse(txtAccNum.Text, out AccNum);
            if (DepositValid && AccNumValid)
            {

                //Processing
                Balance = CurrentBalance + DepositAmt;

                //Output
                lstOut.Items.Add("Account Number : " + AccNum);
                lstOut.Items.Add("Account Name : " + AccountName);
                lstOut.Items.Add("Deposit Amount : " + DepositAmt.ToString("C2"));
                lstOut.Items.Add("New Balance is : " + Balance.ToString("C2"));

                btnClear.Focus();
            }else
            {
                if (!DepositValid)
                {
                    lstOut.Items.Add("Please enter a valid numeric value for Deposit Amount.");
                }
                if (!AccNumValid)
                {
                    lstOut.Items.Add("Please enter a valid numeric value for Account Number.");
                }
     
            }
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
