
namespace Monthly_Payment_Calculator
{
    partial class Main
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
            this.PurchasePriceBox = new System.Windows.Forms.TextBox();
            this.DownPaymentAmountBox = new System.Windows.Forms.TextBox();
            this.InterestRateBox = new System.Windows.Forms.TextBox();
            this.TermBox = new System.Windows.Forms.TextBox();
            this.AmountToFinanceBox = new System.Windows.Forms.TextBox();
            this.MonthlyPaymentBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PurchasePriceBox
            // 
            this.PurchasePriceBox.Location = new System.Drawing.Point(192, 35);
            this.PurchasePriceBox.Name = "PurchasePriceBox";
            this.PurchasePriceBox.Size = new System.Drawing.Size(228, 23);
            this.PurchasePriceBox.TabIndex = 0;
            // 
            // DownPaymentAmountBox
            // 
            this.DownPaymentAmountBox.Location = new System.Drawing.Point(192, 80);
            this.DownPaymentAmountBox.Name = "DownPaymentAmountBox";
            this.DownPaymentAmountBox.Size = new System.Drawing.Size(228, 23);
            this.DownPaymentAmountBox.TabIndex = 1;
            // 
            // InterestRateBox
            // 
            this.InterestRateBox.Location = new System.Drawing.Point(192, 125);
            this.InterestRateBox.Name = "InterestRateBox";
            this.InterestRateBox.Size = new System.Drawing.Size(228, 23);
            this.InterestRateBox.TabIndex = 2;
            // 
            // TermBox
            // 
            this.TermBox.Location = new System.Drawing.Point(192, 170);
            this.TermBox.Name = "TermBox";
            this.TermBox.Size = new System.Drawing.Size(228, 23);
            this.TermBox.TabIndex = 3;
            // 
            // AmountToFinanceBox
            // 
            this.AmountToFinanceBox.Enabled = false;
            this.AmountToFinanceBox.Location = new System.Drawing.Point(637, 36);
            this.AmountToFinanceBox.Name = "AmountToFinanceBox";
            this.AmountToFinanceBox.Size = new System.Drawing.Size(228, 23);
            this.AmountToFinanceBox.TabIndex = 4;
            // 
            // MonthlyPaymentBox
            // 
            this.MonthlyPaymentBox.Enabled = false;
            this.MonthlyPaymentBox.Location = new System.Drawing.Point(637, 84);
            this.MonthlyPaymentBox.Name = "MonthlyPaymentBox";
            this.MonthlyPaymentBox.Size = new System.Drawing.Size(228, 23);
            this.MonthlyPaymentBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Purchase Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Down Payment Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Interest Rate (annual):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Loan Term (months):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(501, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Amount to Finance:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(501, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Monthly Payment:";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(32, 224);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 12;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(790, 224);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 13;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(192, 224);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 14;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 257);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MonthlyPaymentBox);
            this.Controls.Add(this.AmountToFinanceBox);
            this.Controls.Add(this.TermBox);
            this.Controls.Add(this.InterestRateBox);
            this.Controls.Add(this.DownPaymentAmountBox);
            this.Controls.Add(this.PurchasePriceBox);
            this.Name = "Main";
            this.Text = "Monthly Payment Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PurchasePriceBox;
        private System.Windows.Forms.TextBox DownPaymentAmountBox;
        private System.Windows.Forms.TextBox InterestRateBox;
        private System.Windows.Forms.TextBox TermBox;
        private System.Windows.Forms.TextBox AmountToFinanceBox;
        private System.Windows.Forms.TextBox MonthlyPaymentBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button ResetButton;
    }
}

