namespace AnoojaSBankTransactions
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtInterestRate = new TextBox();
            btnSetReturn = new Button();
            lblErrorMsg = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(19, 18);
            label1.Name = "label1";
            label1.Size = new Size(278, 35);
            label1.TabIndex = 0;
            label1.Text = "Bank Configuration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 92);
            label2.Name = "label2";
            label2.Size = new Size(109, 22);
            label2.TabIndex = 1;
            label2.Text = "Interest Rate";
            // 
            // txtInterestRate
            // 
            txtInterestRate.Location = new Point(140, 87);
            txtInterestRate.Name = "txtInterestRate";
            txtInterestRate.Size = new Size(150, 31);
            txtInterestRate.TabIndex = 2;
            txtInterestRate.Leave += txtInterestRate_Leave;
            // 
            // btnSetReturn
            // 
            btnSetReturn.Location = new Point(67, 142);
            btnSetReturn.Name = "btnSetReturn";
            btnSetReturn.Size = new Size(149, 33);
            btnSetReturn.TabIndex = 3;
            btnSetReturn.Text = "&Set && Return";
            btnSetReturn.UseVisualStyleBackColor = true;
            btnSetReturn.Click += btnSetReturn_Click;
            // 
            // lblErrorMsg
            // 
            lblErrorMsg.AutoSize = true;
            lblErrorMsg.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblErrorMsg.Location = new Point(46, 188);
            lblErrorMsg.Name = "lblErrorMsg";
            lblErrorMsg.Size = new Size(0, 22);
            lblErrorMsg.TabIndex = 4;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 235);
            Controls.Add(lblErrorMsg);
            Controls.Add(btnSetReturn);
            Controls.Add(txtInterestRate);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "BankSettings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnSetReturn;
        public TextBox txtInterestRate;
        private Label lblErrorMsg;
    }
}