namespace ExamPractice
{
    partial class LoanGUI
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
            this.InterestRateTextBox = new System.Windows.Forms.TextBox();
            this.LoanAmountTextBox = new System.Windows.Forms.TextBox();
            this.AgentNameTextBox = new System.Windows.Forms.TextBox();
            this.CustomerAgeLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.CustomerIDLabel = new System.Windows.Forms.Label();
            this.LoanIDTextBox = new System.Windows.Forms.TextBox();
            this.CurrentAgeText = new System.Windows.Forms.Label();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.LoanAmountInvalidText = new System.Windows.Forms.Label();
            this.InterestRateInvalidText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InterestRateTextBox
            // 
            this.InterestRateTextBox.Location = new System.Drawing.Point(177, 150);
            this.InterestRateTextBox.Name = "InterestRateTextBox";
            this.InterestRateTextBox.Size = new System.Drawing.Size(217, 26);
            this.InterestRateTextBox.TabIndex = 19;
            this.InterestRateTextBox.TextChanged += new System.EventHandler(this.InterestRateTextBox_TextChanged);
            // 
            // LoanAmountTextBox
            // 
            this.LoanAmountTextBox.Location = new System.Drawing.Point(177, 110);
            this.LoanAmountTextBox.Name = "LoanAmountTextBox";
            this.LoanAmountTextBox.Size = new System.Drawing.Size(217, 26);
            this.LoanAmountTextBox.TabIndex = 18;
            this.LoanAmountTextBox.TextChanged += new System.EventHandler(this.LoanAmountTextBox_TextChanged);
            // 
            // AgentNameTextBox
            // 
            this.AgentNameTextBox.Location = new System.Drawing.Point(177, 69);
            this.AgentNameTextBox.Name = "AgentNameTextBox";
            this.AgentNameTextBox.ReadOnly = true;
            this.AgentNameTextBox.Size = new System.Drawing.Size(217, 26);
            this.AgentNameTextBox.TabIndex = 17;
            // 
            // CustomerAgeLabel
            // 
            this.CustomerAgeLabel.AutoSize = true;
            this.CustomerAgeLabel.Location = new System.Drawing.Point(61, 196);
            this.CustomerAgeLabel.Name = "CustomerAgeLabel";
            this.CustomerAgeLabel.Size = new System.Drawing.Size(111, 20);
            this.CustomerAgeLabel.TabIndex = 15;
            this.CustomerAgeLabel.Text = "Customer Age";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(61, 153);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(103, 20);
            this.EmailLabel.TabIndex = 14;
            this.EmailLabel.Text = "Interest Rate";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(61, 113);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(105, 20);
            this.LastNameLabel.TabIndex = 13;
            this.LastNameLabel.Text = "Loan Amount";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(61, 75);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(98, 20);
            this.FirstNameLabel.TabIndex = 12;
            this.FirstNameLabel.Text = "Agent Name";
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.AutoSize = true;
            this.CustomerIDLabel.Location = new System.Drawing.Point(61, 34);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(66, 20);
            this.CustomerIDLabel.TabIndex = 11;
            this.CustomerIDLabel.Text = "Loan ID";
            // 
            // LoanIDTextBox
            // 
            this.LoanIDTextBox.Location = new System.Drawing.Point(177, 31);
            this.LoanIDTextBox.Name = "LoanIDTextBox";
            this.LoanIDTextBox.ReadOnly = true;
            this.LoanIDTextBox.Size = new System.Drawing.Size(217, 26);
            this.LoanIDTextBox.TabIndex = 20;
            // 
            // CurrentAgeText
            // 
            this.CurrentAgeText.AutoSize = true;
            this.CurrentAgeText.Location = new System.Drawing.Point(271, 196);
            this.CurrentAgeText.Name = "CurrentAgeText";
            this.CurrentAgeText.Size = new System.Drawing.Size(18, 20);
            this.CurrentAgeText.TabIndex = 21;
            this.CurrentAgeText.Text = "0";
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Enabled = false;
            this.SubmitBtn.Location = new System.Drawing.Point(217, 237);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(130, 41);
            this.SubmitBtn.TabIndex = 22;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // LoanAmountInvalidText
            // 
            this.LoanAmountInvalidText.AutoSize = true;
            this.LoanAmountInvalidText.Font = new System.Drawing.Font("Open Sans", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoanAmountInvalidText.ForeColor = System.Drawing.Color.Red;
            this.LoanAmountInvalidText.Location = new System.Drawing.Point(409, 114);
            this.LoanAmountInvalidText.Name = "LoanAmountInvalidText";
            this.LoanAmountInvalidText.Size = new System.Drawing.Size(113, 22);
            this.LoanAmountInvalidText.TabIndex = 25;
            this.LoanAmountInvalidText.Text = "Invalid Input";
            this.LoanAmountInvalidText.Visible = false;
            // 
            // InterestRateInvalidText
            // 
            this.InterestRateInvalidText.AutoSize = true;
            this.InterestRateInvalidText.Font = new System.Drawing.Font("Open Sans", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InterestRateInvalidText.ForeColor = System.Drawing.Color.Red;
            this.InterestRateInvalidText.Location = new System.Drawing.Point(409, 152);
            this.InterestRateInvalidText.Name = "InterestRateInvalidText";
            this.InterestRateInvalidText.Size = new System.Drawing.Size(113, 22);
            this.InterestRateInvalidText.TabIndex = 26;
            this.InterestRateInvalidText.Text = "Invalid Input";
            this.InterestRateInvalidText.Visible = false;
            // 
            // LoanGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 293);
            this.Controls.Add(this.InterestRateInvalidText);
            this.Controls.Add(this.LoanAmountInvalidText);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.CurrentAgeText);
            this.Controls.Add(this.LoanIDTextBox);
            this.Controls.Add(this.InterestRateTextBox);
            this.Controls.Add(this.LoanAmountTextBox);
            this.Controls.Add(this.AgentNameTextBox);
            this.Controls.Add(this.CustomerAgeLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.CustomerIDLabel);
            this.Name = "LoanGUI";
            this.Text = "LoanGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox InterestRateTextBox;
        private System.Windows.Forms.TextBox LoanAmountTextBox;
        private System.Windows.Forms.TextBox AgentNameTextBox;
        private System.Windows.Forms.Label CustomerAgeLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label CustomerIDLabel;
        private System.Windows.Forms.TextBox LoanIDTextBox;
        private System.Windows.Forms.Label CurrentAgeText;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Label LoanAmountInvalidText;
        private System.Windows.Forms.Label InterestRateInvalidText;
    }
}