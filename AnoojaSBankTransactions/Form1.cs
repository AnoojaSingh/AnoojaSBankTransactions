using System.CodeDom.Compiler;
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
        private double interestRate;

        private Form2 settingForm;

        private string BankTransactionLog = "BankTransLog.txt";
        public string BankConfig = "BankConfig.txt";
        double Balance;

        public double InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNewBalance_Click(object sender, EventArgs e)
        {
            string AccNum;
            string AccountName;
            double TransactionAmt = 0;
            double InterestAmount = 0;
            //keep old balance so it can be output


            bool TransValid, BalanceValid;
            StreamWriter sw;

            double CalculateTypeBalance = 0;
            //input
            AccNum = txtAccNum.Text;
            AccountName = txtAccName.Text;
            //DepositAmt = double.Parse(txtDepositAmt.Text);
            BalanceValid = double.TryParse(txtBalance.Text, out Balance);
            double StartingBalance = Balance;
            if (!rdoInterest.Checked)
            {
                TransValid = double.TryParse(txtTransactionAmt.Text, out TransactionAmt);
            }
            else
            {
                TransValid = true;
            }
            if (TransValid && BalanceValid)
            {
                switch (TransactionType)
                {
                    case INTEREST:
                        InterestAmount = Balance * InterestRate;
                        Balance = Balance + InterestAmount;
                        break;
                    case DEPOSIT:
                        Balance = TransactionAmt + Balance;
                        break;
                    case WITHDRAWAL:
                        Balance = Balance - TransactionAmt;
                        break;
                    default:
                        lstOut.Items.Add("Invalid Selection");
                        break;
                }

                //Processing
                //  Balance = Balance + TransactionAmt;

                //Output
                lstOut.Items.Add("Account Number : " + AccNum);
                lstOut.Items.Add("Account Name : " + AccountName);

                lstOut.Items.Add("Starting Balance is : " + StartingBalance);
                lstOut.Items.Add("Transaction Type is : " + TransactionType);
                if (rdoInterest.Checked)
                {
                    lstOut.Items.Add("Interest Amount : " + InterestAmount.ToString("C2"));
                }
                else
                {
                    lstOut.Items.Add("Transaction Amount : " + TransactionAmt.ToString("C2"));
                }

                lstOut.Items.Add("Account Balance is : " + Balance.ToString("C2"));

                sw = File.AppendText(BankTransactionLog);
                sw.WriteLine("*********** Beginning of Transaction at " +
                            DateTime.Now.ToString("G") + " **********");
                sw.WriteLine("Account Number : " + AccNum);
                sw.WriteLine("Account Name : " + AccountName);

                sw.WriteLine("Starting Balance is : " + StartingBalance);
                sw.WriteLine("Transaction Type is : " + TransactionType);
                if (rdoInterest.Checked)
                {
                    sw.WriteLine("Interest Amount : " + InterestAmount.ToString("C2"));
                }
                else
                {
                    sw.WriteLine("Transaction Amount : " + TransactionAmt.ToString("C2"));
                }

                sw.WriteLine("Account Balance is : " + Balance.ToString("C2"));

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
            txtBalance.Clear();

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
            settingForm = new Form2(this);
            rdoInterest.Checked = true;
            StreamReader reader;
            bool valValid;
            bool fileBad = true;
            do
            {
                try
                {

                    reader = File.OpenText(BankConfig);
                    fileBad = false;
                    double tempValue;
                    valValid = double.TryParse(reader.ReadLine(), out tempValue);
                    InterestRate = tempValue;
                    reader.Close();
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show("The configuration file was not found. Please select a different file \n Error message",
                        ex.Message
                        );
                    openFileDialog1.InitialDirectory = Application.StartupPath;
                    openFileDialog1.ShowDialog();
                    BankConfig = openFileDialog1.FileName;
                }
            } while (fileBad);
        }

        private void rdoInterest_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoInterest.Checked)
            {
                TransactionType = INTEREST;
                txtTransactionAmt.Enabled = false;
            }
            else
            {
                txtTransactionAmt.Enabled = true;
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
            if (rdoWithdrawal.Checked)
            {
                TransactionType = WITHDRAWAL;

            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingForm.txtInterestRate.Text = InterestRate.ToString(); 
            settingForm.ShowDialog();   
        }

        public void setValuesOnSecondForm()
        {
            settingForm.txtInterestRate.Text = InterestRate.ToString();
        }
    }
}
