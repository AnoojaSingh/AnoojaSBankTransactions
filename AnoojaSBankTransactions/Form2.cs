using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnoojaSBankTransactions
{
    public partial class Form2 : Form
    {
        private Form1 ff;
        public Form2(Form1 form1)
        {
            ff = form1;
            InitializeComponent();
        }

        private void btnSetReturn_Click(object sender, EventArgs e)
        {
            bool InterestRateValid;
            double irtempValue;
            StreamWriter sw;

            InterestRateValid = double.TryParse(txtInterestRate.Text, out irtempValue);
            if (InterestRateValid)
            {
                ff.InterestRate = irtempValue;
                sw = File.CreateText(ff.BankConfig);
                sw.WriteLine(ff.InterestRate);

                sw.Close();
                this.Hide();
            }
            else
            {
                ff.setValuesOnSecondForm();
            }
        }

        private void txtInterestRate_Leave(object sender, EventArgs e)
        {
            bool InterestRateValid = false;
            double irtempValue;
            InterestRateValid = double.TryParse(txtInterestRate.Text, out irtempValue);
            if (!InterestRateValid) 
            {
                txtInterestRate.Focus();
                lblErrorMsg.Text = "Interest Rate is not valid.";
            }
            else
            {
                lblErrorMsg.Text = "";
            }

        }
    }
}
