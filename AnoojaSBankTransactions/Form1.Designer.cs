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
            txtDepositAmt = new TextBox();
            lstOut = new ListBox();
            btnCalInterest = new Button();
            btnDeposit = new Button();
            btnWithdrawals = new Button();
            btnClear = new Button();
            btnQuit = new Button();
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
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Fax", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(42, 140);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 5;
            label4.Text = "Deposit Amount:";
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
            // txtDepositAmt
            // 
            txtDepositAmt.Location = new Point(207, 137);
            txtDepositAmt.Margin = new Padding(2);
            txtDepositAmt.Name = "txtDepositAmt";
            txtDepositAmt.Size = new Size(241, 23);
            txtDepositAmt.TabIndex = 6;
            txtDepositAmt.TextChanged += txtDepositAmt_TextChanged;
            txtDepositAmt.Enter += txtDepositAmt_Enter;
            txtDepositAmt.Leave += txtDepositAmt_Leave;
            // 
            // lstOut
            // 
            lstOut.FormattingEnabled = true;
            lstOut.ItemHeight = 15;
            lstOut.Location = new Point(42, 249);
            lstOut.Margin = new Padding(2);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(790, 169);
            lstOut.TabIndex = 10;
            // 
            // btnCalInterest
            // 
            btnCalInterest.Location = new Point(157, 194);
            btnCalInterest.Margin = new Padding(2);
            btnCalInterest.Name = "btnCalInterest";
            btnCalInterest.Size = new Size(141, 32);
            btnCalInterest.TabIndex = 7;
            btnCalInterest.Text = "Calculate &Interest";
            btnCalInterest.UseVisualStyleBackColor = true;
            btnCalInterest.Click += btnCalInterest_Click;
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new Point(390, 194);
            btnDeposit.Margin = new Padding(2);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(130, 32);
            btnDeposit.TabIndex = 8;
            btnDeposit.Text = "View &Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnWithdrawals
            // 
            btnWithdrawals.Location = new Point(606, 194);
            btnWithdrawals.Margin = new Padding(2);
            btnWithdrawals.Name = "btnWithdrawals";
            btnWithdrawals.Size = new Size(142, 32);
            btnWithdrawals.TabIndex = 9;
            btnWithdrawals.Text = "View &Withdrawals";
            btnWithdrawals.UseVisualStyleBackColor = true;
            btnWithdrawals.Click += btnWithdrawals_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(270, 443);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(78, 42);
            btnClear.TabIndex = 11;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(512, 443);
            btnQuit.Margin = new Padding(2);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(78, 42);
            btnQuit.TabIndex = 12;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 496);
            Controls.Add(btnQuit);
            Controls.Add(btnClear);
            Controls.Add(btnWithdrawals);
            Controls.Add(btnDeposit);
            Controls.Add(btnCalInterest);
            Controls.Add(lstOut);
            Controls.Add(txtDepositAmt);
            Controls.Add(txtAccName);
            Controls.Add(txtAccNum);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "AnoojaS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtAccNum;
        private TextBox txtAccName;
        private TextBox txtDepositAmt;
        private ListBox lstOut;
        private Button btnCalInterest;
        private Button btnDeposit;
        private Button btnWithdrawals;
        private Button btnClear;
        private Button btnQuit;
    }
}
