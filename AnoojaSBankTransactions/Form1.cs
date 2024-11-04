using System.Configuration.Internal;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
//Anooja Singh
namespace AnoojaSBankTransactions
{
    public partial class Form1 : Form
    {
        private string TransactionType;
        const string INTEREST = "Interest";
        const string DEPOSIT = "Deposit";
        const string WITHDRAWAL = "Withdrawal";
        private double InterestRate = .05;

        private string BankTransactionLog = "BankTransLog.txt";
        private string BankConfig = "BankConfig.txt";

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
            StreamWriter sw;

            double CalculateTypeBalance = 0;
            //input
            AccNum = txtAccNum.Text;
            AccountName = txtAccName.Text;
            //DepositAmt = double.Parse(txtDepositAmt.Text);
            DepositValid = double.TryParse(txtTransactionAmt.Text, out TransactionAmt);
            if (DepositValid)
            {
                switch (TransactionType)
                 {
                    case INTEREST:
                        CalculateTypeBalance = Balance * InterestRate; 
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
                lstOut.Items.Add("Transaction Amount : " + TransactionAmt.ToString("C2"));
                lstOut.Items.Add("Tranaction Type is : " + TransactionType);
                lstOut.Items.Add("Account Balance is : " + CalculateTypeBalance.ToString("C2"));
                sw = File.AppendText(BankTransactionLog);
                sw.WriteLine("*********** Beginning of Transaction at " +
                            DateTime.Now.ToString("G") + " **********");
                sw.WriteLine("Account Number : " + AccNum);
                sw.WriteLine("Account Name : " + AccountName);
                sw.WriteLine("Transaction Amount : " + TransactionAmt.ToString("C2"));
                sw.WriteLine("Transaction type is" + TransactionType);
                sw.WriteLine("Account Balance is : " + CalculateTypeBalance.ToString("C2"));

                sw.Close();

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
            //StreamReader reader;
            //bool valValid;
            //bool fileBad = true;
           // do
           // {
                //try
                //{

                    //reader = File.OpenText(BankConfig);
                    //valValid = double.TryParse(reader.ReadLine(), out InterestRate);
                   // reader.Close();
               // }
               // catch (Exception ex)
                //{
                    //MessageBox.Show("The configuration file was not found. Please select a different file \n Error message",
                        //ex.Message
                       // );
                    //openFileDialog1.InitialDirectory = Application.StartupPath;
                   // openFileDialog2.ShowDialog();
                   //BankConfig = openFileDialog1.FileName;
              //  }
          // } while (fileBad);
       }

        private void rdoInterest_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoInterest.Checked)
            {
                TransactionType = INTEREST;
                txtTransactionAmt.Enabled = true; 
            }
            else
            {
                txtTransactionAmt.Enabled = false;
            }
        }

        private void rdoDeposit_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDeposit.Checked)
            {
                TransactionType = DEPOSIT;
            }
        }

        private void rdoWithdrawal_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoWithdrawal.Checked)
            {
                TransactionType = WITHDRAWAL;
            }
        }
        

    }
}
