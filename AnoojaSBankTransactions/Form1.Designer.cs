﻿namespace AnoojaSBankTransactions
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
            btnClear = new Button();
            btnQuit = new Button();
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
            label3.Location = new Point(60, 178);
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
            label4.Location = new Point(60, 233);
            label4.Name = "label4";
            label4.Size = new Size(172, 21);
            label4.TabIndex = 5;
            label4.Text = "Deposit Amount:";
            label4.Click += label4_Click;
            // 
            // txtAccNum
            // 
            txtAccNum.Location = new Point(296, 122);
            txtAccNum.Name = "txtAccNum";
            txtAccNum.Size = new Size(343, 31);
            txtAccNum.TabIndex = 2;
            txtAccNum.TextChanged += textBox1_TextChanged;
            txtAccNum.Enter += txtAccNum_Enter;
            txtAccNum.Leave += txtAccNum_Leave;
            // 
            // txtAccName
            // 
            txtAccName.Location = new Point(296, 172);
            txtAccName.Name = "txtAccName";
            txtAccName.Size = new Size(343, 31);
            txtAccName.TabIndex = 4;
            txtAccName.TextChanged += txtAccName_TextChanged;
            txtAccName.Enter += txtAccName_Enter;
            txtAccName.Leave += txtAccName_Leave;
            // 
            // txtDepositAmt
            // 
            txtDepositAmt.Location = new Point(296, 228);
            txtDepositAmt.Name = "txtDepositAmt";
            txtDepositAmt.Size = new Size(343, 31);
            txtDepositAmt.TabIndex = 6;
            txtDepositAmt.TextChanged += txtDepositAmt_TextChanged;
            txtDepositAmt.Enter += txtDepositAmt_Enter;
            txtDepositAmt.Leave += txtDepositAmt_Leave;
            // 
            // lstOut
            // 
            lstOut.FormattingEnabled = true;
            lstOut.ItemHeight = 25;
            lstOut.Location = new Point(60, 317);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(1127, 354);
            lstOut.TabIndex = 10;
            // 
            // btnCalInterest
            // 
            btnCalInterest.Location = new Point(157, 709);
            btnCalInterest.Name = "btnCalInterest";
            btnCalInterest.Size = new Size(201, 53);
            btnCalInterest.TabIndex = 7;
            btnCalInterest.Text = "View &New Balance";
            btnCalInterest.UseVisualStyleBackColor = true;
            btnCalInterest.Click += btnCalInterest_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(528, 709);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(111, 53);
            btnClear.TabIndex = 11;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(833, 709);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(111, 53);
            btnQuit.TabIndex = 12;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 827);
            Controls.Add(btnQuit);
            Controls.Add(btnClear);
            Controls.Add(btnCalInterest);
            Controls.Add(lstOut);
            Controls.Add(txtDepositAmt);
            Controls.Add(txtAccName);
            Controls.Add(txtAccNum);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Button btnClear;
        private Button btnQuit;
    }
}
