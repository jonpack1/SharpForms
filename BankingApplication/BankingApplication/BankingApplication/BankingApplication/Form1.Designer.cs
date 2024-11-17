namespace BankingApplication
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
            txtCreditBasic = new TextBox();
            btnCreditBasic = new Button();
            txtDebitBasic = new TextBox();
            btnDebitBasic = new Button();
            lblBasicBalance = new Label();
            txtCreditSavings = new TextBox();
            btnCreditSavings = new Button();
            btnCalculateInterest = new Button();
            lblSavingsBalance = new Label();
            txtCreditChecking = new TextBox();
            txtDebitChecking = new TextBox();
            btnCreditChecking = new Button();
            btnDebitChecking = new Button();
            lblCheckingBalance = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 35);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 0;
            label1.Text = "Basic Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 166);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 1;
            label2.Text = "Savings Account";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 294);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 2;
            label3.Text = "Checking Account";
            // 
            // txtCreditBasic
            // 
            txtCreditBasic.Location = new Point(39, 81);
            txtCreditBasic.Name = "txtCreditBasic";
            txtCreditBasic.Size = new Size(125, 27);
            txtCreditBasic.TabIndex = 3;
            // 
            // btnCreditBasic
            // 
            btnCreditBasic.Location = new Point(39, 121);
            btnCreditBasic.Name = "btnCreditBasic";
            btnCreditBasic.Size = new Size(94, 29);
            btnCreditBasic.TabIndex = 4;
            btnCreditBasic.Text = "Credit";
            btnCreditBasic.UseVisualStyleBackColor = true;
            btnCreditBasic.Click += btnCreditBasic_Click;
            // 
            // txtDebitBasic
            // 
            txtDebitBasic.Location = new Point(223, 81);
            txtDebitBasic.Name = "txtDebitBasic";
            txtDebitBasic.Size = new Size(125, 27);
            txtDebitBasic.TabIndex = 5;
            // 
            // btnDebitBasic
            // 
            btnDebitBasic.Location = new Point(223, 121);
            btnDebitBasic.Name = "btnDebitBasic";
            btnDebitBasic.Size = new Size(94, 29);
            btnDebitBasic.TabIndex = 6;
            btnDebitBasic.Text = "Debit";
            btnDebitBasic.UseVisualStyleBackColor = true;
            btnDebitBasic.Click += btnDebitBasic_Click;
            // 
            // lblBasicBalance
            // 
            lblBasicBalance.AutoSize = true;
            lblBasicBalance.Location = new Point(418, 88);
            lblBasicBalance.Name = "lblBasicBalance";
            lblBasicBalance.Size = new Size(50, 20);
            lblBasicBalance.TabIndex = 7;
            lblBasicBalance.Text = "label4";
            // 
            // txtCreditSavings
            // 
            txtCreditSavings.Location = new Point(39, 205);
            txtCreditSavings.Name = "txtCreditSavings";
            txtCreditSavings.Size = new Size(125, 27);
            txtCreditSavings.TabIndex = 8;
            // 
            // btnCreditSavings
            // 
            btnCreditSavings.Location = new Point(39, 242);
            btnCreditSavings.Name = "btnCreditSavings";
            btnCreditSavings.Size = new Size(94, 29);
            btnCreditSavings.TabIndex = 9;
            btnCreditSavings.Text = "Credit";
            btnCreditSavings.UseVisualStyleBackColor = true;
            btnCreditSavings.Click += btnCreditSavings_Click;
            // 
            // btnCalculateInterest
            // 
            btnCalculateInterest.Location = new Point(223, 233);
            btnCalculateInterest.Name = "btnCalculateInterest";
            btnCalculateInterest.Size = new Size(125, 29);
            btnCalculateInterest.TabIndex = 10;
            btnCalculateInterest.Text = "Add Interest";
            btnCalculateInterest.UseVisualStyleBackColor = true;
            btnCalculateInterest.Click += btnCalculateInterest_Click;
            // 
            // lblSavingsBalance
            // 
            lblSavingsBalance.AutoSize = true;
            lblSavingsBalance.Location = new Point(418, 233);
            lblSavingsBalance.Name = "lblSavingsBalance";
            lblSavingsBalance.Size = new Size(50, 20);
            lblSavingsBalance.TabIndex = 11;
            lblSavingsBalance.Text = "label5";
            // 
            // txtCreditChecking
            // 
            txtCreditChecking.Location = new Point(39, 331);
            txtCreditChecking.Name = "txtCreditChecking";
            txtCreditChecking.Size = new Size(125, 27);
            txtCreditChecking.TabIndex = 12;
            // 
            // txtDebitChecking
            // 
            txtDebitChecking.Location = new Point(223, 331);
            txtDebitChecking.Name = "txtDebitChecking";
            txtDebitChecking.Size = new Size(125, 27);
            txtDebitChecking.TabIndex = 13;
            // 
            // btnCreditChecking
            // 
            btnCreditChecking.Location = new Point(39, 364);
            btnCreditChecking.Name = "btnCreditChecking";
            btnCreditChecking.Size = new Size(94, 29);
            btnCreditChecking.TabIndex = 14;
            btnCreditChecking.Text = "Credit";
            btnCreditChecking.UseVisualStyleBackColor = true;
            btnCreditChecking.Click += btnCreditChecking_Click;
            // 
            // btnDebitChecking
            // 
            btnDebitChecking.Location = new Point(223, 364);
            btnDebitChecking.Name = "btnDebitChecking";
            btnDebitChecking.Size = new Size(94, 29);
            btnDebitChecking.TabIndex = 15;
            btnDebitChecking.Text = "Debit";
            btnDebitChecking.UseVisualStyleBackColor = true;
            btnDebitChecking.Click += btnDebitChecking_Click;
            // 
            // lblCheckingBalance
            // 
            lblCheckingBalance.AutoSize = true;
            lblCheckingBalance.Location = new Point(409, 364);
            lblCheckingBalance.Name = "lblCheckingBalance";
            lblCheckingBalance.Size = new Size(50, 20);
            lblCheckingBalance.TabIndex = 16;
            lblCheckingBalance.Text = "label6";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCheckingBalance);
            Controls.Add(btnDebitChecking);
            Controls.Add(btnCreditChecking);
            Controls.Add(txtDebitChecking);
            Controls.Add(txtCreditChecking);
            Controls.Add(lblSavingsBalance);
            Controls.Add(btnCalculateInterest);
            Controls.Add(btnCreditSavings);
            Controls.Add(txtCreditSavings);
            Controls.Add(lblBasicBalance);
            Controls.Add(btnDebitBasic);
            Controls.Add(txtDebitBasic);
            Controls.Add(btnCreditBasic);
            Controls.Add(txtCreditBasic);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Test App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCreditBasic;
        private Button btnCreditBasic;
        private TextBox txtDebitBasic;
        private Button btnDebitBasic;
        private Label lblBasicBalance;
        private TextBox txtCreditSavings;
        private Button btnCreditSavings;
        private Button btnCalculateInterest;
        private Label lblSavingsBalance;
        private TextBox txtCreditChecking;
        private TextBox txtDebitChecking;
        private Button btnCreditChecking;
        private Button btnDebitChecking;
        private Label lblCheckingBalance;
    }
}
