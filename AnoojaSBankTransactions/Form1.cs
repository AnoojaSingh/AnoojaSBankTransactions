using System.Configuration.Internal;
using System.Diagnostics;
//Anooja Singh
namespace AnoojaSBankTransactions
{
    public partial class Form1 : Form
    {
        private string CalculateType;
        const string INTEREST = "Interest";
        const string DEPOSIT = "Deposit";
        const string WITHDRAWAL = "Withdrawal";

        public Form1()
        {
            InitializeComponent();
        }


        private void btnNewBalance_Click(object sender, EventArgs e)
        {
            string AccNum;
            string AccountName;
            double TransactionAmt;
            //keep old balance so it can be output
            double CurrentBalance = 100;
            double Balance = CurrentBalance;
            bool DepositValid;

            double CalculateTypeBalance = 0;
            //input
            AccNum = txtAccNum.Text;
            AccountName = txtAccName.Text;
            //DepositAmt = double.Parse(txtDepositAmt.Text);
            DepositValid = double.TryParse(txtTransactionAmt.Text, out TransactionAmt);
            if (DepositValid)
            {
                switch (CalculateType)
                 {
                    case INTEREST:
                        CalculateTypeBalance = TransactionAmt + .05; 
                        break;
                    case DEPOSIT:
                        CalculateTypeBalance = TransactionAmt + Balance;
                        break;
                    case WITHDRAWAL:
                        CalculateTypeBalance = Balance - TransactionAmt;
                        break;
                    default:
                        lstOut.Items.Add("Invalid Selection");
                        break;
                
                }


                //Processing
                Balance = CurrentBalance + TransactionAmt;

                //Output
                lstOut.Items.Add("Account Number : " + AccNum);
                lstOut.Items.Add("Account Name : " + AccountName);
                lstOut.Items.Add("Calculate type is" + CalculateType);
                lstOut.Items.Add("Calculate Type Balance is" + CalculateTypeBalance.ToString("C"));
                lstOut.Items.Add("Transaction Amount : " + TransactionAmt.ToString("C2"));
                lstOut.Items.Add("New Balance is : " + Balance.ToString("C2"));


                btnClear.Focus();
            }
            else
            {

                lstOut.Items.Add("Please enter a valid numeric value for Transaction Amount.");



            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAccNum.Clear();
            txtAccName.Clear();
            txtTransactionAmt.Clear();
            lstOut.Items.Clear();
            txtAccNum.Focus();
            rdoInterest.Checked = true;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult ButtonSelected;
            ButtonSelected = MessageBox.Show(
                "Do you want to Quit?", "Exiting...",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (ButtonSelected == DialogResult.Yes)
            {
                this.Close();
            }

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
            txtTransactionAmt.BackColor = Color.Bisque;
        }

        private void txtDepositAmt_Leave(object sender, EventArgs e)
        {
            txtTransactionAmt.BackColor = SystemColors.Window;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdoInterest.Checked = true;
        }

        private void rdoInterest_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoInterest.Checked)
            {
                CalculateType = INTEREST;
            }
        }

        private void rdoDeposit_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDeposit.Checked)
            {
                CalculateType = DEPOSIT;
            }
        }

        private void rdoWithdrawal_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoWithdrawal.Checked)
            {
                CalculateType = WITHDRAWAL;
            }
        }
    }
}
