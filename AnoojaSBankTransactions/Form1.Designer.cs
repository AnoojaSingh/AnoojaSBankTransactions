
namespace AnoojaSBankTransactions
{
    partial class Form1
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
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtAccNum = new TextBox();
            txtAccName = new TextBox();
            txtTransactionAmt = new TextBox();
            lstOut = new ListBox();
            btnNewBalance = new Button();
            btnClear = new Button();
            btnQuit = new Button();
            groupBox1 = new GroupBox();
            rdoWithdrawal = new RadioButton();
            rdoDeposit = new RadioButton();
            rdoInterest = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(260, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(365, 29);
            label1.TabIndex = 0;
            label1.Text = "Bank Account - Transactions";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(42, 77);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 1;
            label2.Text = "Account Number:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Fax", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(42, 107);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 3;
            label3.Text = "Account Name:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Fax", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(42, 140);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(141, 15);
            label4.TabIndex = 5;
            label4.Text = "Transaction Amount:";
            label4.Click += label4_Click;
            // 
            // txtAccNum
            // 
            txtAccNum.Location = new Point(207, 73);
            txtAccNum.Margin = new Padding(2);
            txtAccNum.Name = "txtAccNum";
            txtAccNum.Size = new Size(241, 23);
            txtAccNum.TabIndex = 2;
            txtAccNum.TextChanged += textBox1_TextChanged;
            txtAccNum.Enter += txtAccNum_Enter;
            txtAccNum.Leave += txtAccNum_Leave;
            // 
            // txtAccName
            // 
            txtAccName.Location = new Point(207, 103);
            txtAccName.Margin = new Padding(2);
            txtAccName.Name = "txtAccName";
            txtAccName.Size = new Size(241, 23);
            txtAccName.TabIndex = 4;
            txtAccName.TextChanged += txtAccName_TextChanged;
            txtAccName.Enter += txtAccName_Enter;
            txtAccName.Leave += txtAccName_Leave;
            // 
            // txtTransactionAmt
            // 
            txtTransactionAmt.Location = new Point(207, 137);
            txtTransactionAmt.Margin = new Padding(2);
            txtTransactionAmt.Name = "txtTransactionAmt";
            txtTransactionAmt.Size = new Size(241, 23);
            txtTransactionAmt.TabIndex = 6;
            txtTransactionAmt.TextChanged += txtDepositAmt_TextChanged;
            txtTransactionAmt.Enter += txtDepositAmt_Enter;
            txtTransactionAmt.Leave += txtDepositAmt_Leave;
            // 
            // lstOut
            // 
            lstOut.FormattingEnabled = true;
            lstOut.ItemHeight = 15;
            lstOut.Location = new Point(42, 271);
            lstOut.Margin = new Padding(2);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(790, 214);
            lstOut.TabIndex = 10;
            lstOut.TabStop = false;
            lstOut.SelectedIndexChanged += lstOut_SelectedIndexChanged;
            // 
            // btnNewBalance
            // 
            btnNewBalance.Location = new Point(107, 498);
            btnNewBalance.Margin = new Padding(2);
            btnNewBalance.Name = "btnNewBalance";
            btnNewBalance.Size = new Size(141, 32);
            btnNewBalance.TabIndex = 7;
            btnNewBalance.Text = "View &New Balance";
            btnNewBalance.UseVisualStyleBackColor = true;
            btnNewBalance.Click += btnNewBalance_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(370, 498);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(78, 32);
            btnClear.TabIndex = 11;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(606, 498);
            btnQuit.Margin = new Padding(2);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(78, 32);
            btnQuit.TabIndex = 12;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoWithdrawal);
            groupBox1.Controls.Add(rdoDeposit);
            groupBox1.Controls.Add(rdoInterest);
            groupBox1.Location = new Point(42, 182);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(790, 79);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Calculate Type";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // rdoWithdrawal
            // 
            rdoWithdrawal.AutoSize = true;
            rdoWithdrawal.Location = new Point(564, 41);
            rdoWithdrawal.Name = "rdoWithdrawal";
            rdoWithdrawal.Size = new Size(85, 19);
            rdoWithdrawal.TabIndex = 2;
            rdoWithdrawal.TabStop = true;
            rdoWithdrawal.Text = "Withdrawal";
            rdoWithdrawal.UseVisualStyleBackColor = true;
            rdoWithdrawal.CheckedChanged += rdoWithdrawal_CheckedChanged;
            // 
            // rdoDeposit
            // 
            rdoDeposit.AutoSize = true;
            rdoDeposit.Location = new Point(328, 41);
            rdoDeposit.Name = "rdoDeposit";
            rdoDeposit.Size = new Size(65, 19);
            rdoDeposit.TabIndex = 1;
            rdoDeposit.TabStop = true;
            rdoDeposit.Text = "Deposit";
            rdoDeposit.UseVisualStyleBackColor = true;
            rdoDeposit.CheckedChanged += rdoDeposit_CheckedChanged;
            // 
            // rdoInterest
            // 
            rdoInterest.AutoSize = true;
            rdoInterest.Location = new Point(142, 41);
            rdoInterest.Name = "rdoInterest";
            rdoInterest.Size = new Size(64, 19);
            rdoInterest.TabIndex = 0;
            rdoInterest.TabStop = true;
            rdoInterest.Text = "Interest";
            rdoInterest.UseVisualStyleBackColor = true;
            rdoInterest.CheckedChanged += rdoInterest_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 577);
            Controls.Add(groupBox1);
            Controls.Add(btnQuit);
            Controls.Add(btnClear);
            Controls.Add(btnNewBalance);
            Controls.Add(lstOut);
            Controls.Add(txtTransactionAmt);
            Controls.Add(txtAccName);
            Controls.Add(txtAccNum);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "AnoojaS";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lstOut_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtAccName_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtDepositAmt_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtAccNum;
        private TextBox txtAccName;
        private TextBox txtTransactionAmt;
        private ListBox lstOut;
        private Button btnNewBalance;
        private Button btnClear;
        private Button btnQuit;
        private GroupBox groupBox1;
        private RadioButton rdoWithdrawal;
        private RadioButton rdoDeposit;
        private RadioButton rdoInterest;
    }
}
