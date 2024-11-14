
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
            openFileDialog1 = new OpenFileDialog();
            txtBalance = new TextBox();
            label5 = new Label();
            menuStrip1 = new MenuStrip();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(371, 33);
            label1.Name = "label1";
            label1.Size = new Size(516, 41);
            label1.TabIndex = 0;
            label1.Text = "Bank Account - Transactions";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(60, 128);
            label2.Name = "label2";
            label2.Size = new Size(176, 21);
            label2.TabIndex = 1;
            label2.Text = "Account Number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Fax", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(61, 175);
            label3.Name = "label3";
            label3.Size = new Size(154, 21);
            label3.TabIndex = 3;
            label3.Text = "Account Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Fax", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(60, 274);
            label4.Name = "label4";
            label4.Size = new Size(212, 21);
            label4.TabIndex = 5;
            label4.Text = "Transaction Amount:";
            // 
            // txtAccNum
            // 
            txtAccNum.Location = new Point(296, 122);
            txtAccNum.Name = "txtAccNum";
            txtAccNum.Size = new Size(343, 31);
            txtAccNum.TabIndex = 2;
            txtAccNum.Enter += txtAccNum_Enter;
            txtAccNum.Leave += txtAccNum_Leave;
            // 
            // txtAccName
            // 
            txtAccName.Location = new Point(297, 169);
            txtAccName.Name = "txtAccName";
            txtAccName.Size = new Size(343, 31);
            txtAccName.TabIndex = 4;
            txtAccName.Enter += txtAccName_Enter;
            txtAccName.Leave += txtAccName_Leave;
            // 
            // txtTransactionAmt
            // 
            txtTransactionAmt.Location = new Point(296, 269);
            txtTransactionAmt.Name = "txtTransactionAmt";
            txtTransactionAmt.Size = new Size(343, 31);
            txtTransactionAmt.TabIndex = 8;
            txtTransactionAmt.Enter += txtDepositAmt_Enter;
            txtTransactionAmt.Leave += txtDepositAmt_Leave;
            // 
            // lstOut
            // 
            lstOut.FormattingEnabled = true;
            lstOut.ItemHeight = 25;
            lstOut.Location = new Point(60, 452);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(1127, 354);
            lstOut.TabIndex = 10;
            lstOut.TabStop = false;
            // 
            // btnNewBalance
            // 
            btnNewBalance.Location = new Point(153, 830);
            btnNewBalance.Name = "btnNewBalance";
            btnNewBalance.Size = new Size(201, 53);
            btnNewBalance.TabIndex = 9;
            btnNewBalance.Text = "View &New Balance";
            btnNewBalance.UseVisualStyleBackColor = true;
            btnNewBalance.Click += btnNewBalance_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(529, 830);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(111, 53);
            btnClear.TabIndex = 10;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(866, 830);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(111, 53);
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
            groupBox1.Location = new Point(60, 322);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(1129, 113);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Transaction Type";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // rdoWithdrawal
            // 
            rdoWithdrawal.AutoSize = true;
            rdoWithdrawal.Location = new Point(806, 37);
            rdoWithdrawal.Margin = new Padding(4, 5, 4, 5);
            rdoWithdrawal.Name = "rdoWithdrawal";
            rdoWithdrawal.Size = new Size(126, 29);
            rdoWithdrawal.TabIndex = 2;
            rdoWithdrawal.TabStop = true;
            rdoWithdrawal.Text = "Withdrawal";
            rdoWithdrawal.UseVisualStyleBackColor = true;
            rdoWithdrawal.CheckedChanged += rdoWithdrawal_CheckedChanged;
            // 
            // rdoDeposit
            // 
            rdoDeposit.AutoSize = true;
            rdoDeposit.Location = new Point(469, 37);
            rdoDeposit.Margin = new Padding(4, 5, 4, 5);
            rdoDeposit.Name = "rdoDeposit";
            rdoDeposit.Size = new Size(99, 29);
            rdoDeposit.TabIndex = 1;
            rdoDeposit.TabStop = true;
            rdoDeposit.Text = "Deposit";
            rdoDeposit.UseVisualStyleBackColor = true;
            rdoDeposit.CheckedChanged += rdoDeposit_CheckedChanged;
            // 
            // rdoInterest
            // 
            rdoInterest.AutoSize = true;
            rdoInterest.Location = new Point(203, 37);
            rdoInterest.Margin = new Padding(4, 5, 4, 5);
            rdoInterest.Name = "rdoInterest";
            rdoInterest.Size = new Size(96, 29);
            rdoInterest.TabIndex = 0;
            rdoInterest.TabStop = true;
            rdoInterest.Text = "Interest";
            rdoInterest.UseVisualStyleBackColor = true;
            rdoInterest.CheckedChanged += rdoInterest_CheckedChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(296, 220);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(343, 31);
            txtBalance.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Fax", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkGreen;
            label5.Location = new Point(60, 225);
            label5.Name = "label5";
            label5.Size = new Size(163, 21);
            label5.TabIndex = 14;
            label5.Text = "Current Balance";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { settingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1240, 33);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(92, 29);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 962);
            Controls.Add(txtBalance);
            Controls.Add(label5);
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
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "AnoojaS";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private TextBox txtTransactionAmt;
        private ListBox lstOut;
        private Button btnNewBalance;
        private Button btnClear;
        private Button btnQuit;
        private GroupBox groupBox1;
        private RadioButton rdoWithdrawal;
        private RadioButton rdoDeposit;
        private RadioButton rdoInterest;
        private OpenFileDialog openFileDialog1;
        private TextBox txtBalance;
        private Label label5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem settingsToolStripMenuItem;
    }
}
