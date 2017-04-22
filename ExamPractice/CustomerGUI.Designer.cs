namespace ExamPractice
{
    partial class CustomerGUI
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
            this.CustomerIDLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.DOBLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.DOB = new System.Windows.Forms.DateTimePicker();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.IdInvalidInputText = new System.Windows.Forms.Label();
            this.FirstNameInvalidtext = new System.Windows.Forms.Label();
            this.LastNameInvalidText = new System.Windows.Forms.Label();
            this.EmailInvalidText = new System.Windows.Forms.Label();
            this.PhoneNumberInvalidText = new System.Windows.Forms.Label();
            this.RequestLoanBtn = new System.Windows.Forms.Button();
            this.RetrieveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.AutoSize = true;
            this.CustomerIDLabel.Location = new System.Drawing.Point(177, 35);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(26, 20);
            this.CustomerIDLabel.TabIndex = 0;
            this.CustomerIDLabel.Text = "ID";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(177, 76);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(86, 20);
            this.FirstNameLabel.TabIndex = 1;
            this.FirstNameLabel.Text = "First Name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(177, 114);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(86, 20);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Last Name";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(177, 154);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(53, 20);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "E-mail";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(177, 197);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(115, 20);
            this.PhoneNumberLabel.TabIndex = 4;
            this.PhoneNumberLabel.Text = "Phone Number";
            // 
            // DOBLabel
            // 
            this.DOBLabel.AutoSize = true;
            this.DOBLabel.Location = new System.Drawing.Point(177, 244);
            this.DOBLabel.Name = "DOBLabel";
            this.DOBLabel.Size = new System.Drawing.Size(99, 20);
            this.DOBLabel.TabIndex = 5;
            this.DOBLabel.Text = "Date of Birth";
            // 
            // IDTextBox
            // 
            this.IDTextBox.BackColor = System.Drawing.Color.White;
            this.IDTextBox.Location = new System.Drawing.Point(293, 35);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(217, 26);
            this.IDTextBox.TabIndex = 6;
            this.IDTextBox.TextChanged += new System.EventHandler(this.IDTextBox_TextChanged);
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(293, 70);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(217, 26);
            this.FirstNameTextBox.TabIndex = 7;
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextChanged);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(293, 111);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(217, 26);
            this.LastNameTextBox.TabIndex = 8;
            this.LastNameTextBox.TextChanged += new System.EventHandler(this.LastNameTextBox_TextChanged);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(293, 151);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(217, 26);
            this.EmailTextBox.TabIndex = 9;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(293, 197);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(217, 26);
            this.PhoneNumberTextBox.TabIndex = 10;
            this.PhoneNumberTextBox.TextChanged += new System.EventHandler(this.PhoneNumberTextBox_TextChanged);
            // 
            // DOB
            // 
            this.DOB.Location = new System.Drawing.Point(293, 244);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(295, 26);
            this.DOB.TabIndex = 11;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Enabled = false;
            this.SaveBtn.Location = new System.Drawing.Point(328, 299);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(130, 41);
            this.SaveBtn.TabIndex = 12;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // IdInvalidInputText
            // 
            this.IdInvalidInputText.AutoSize = true;
            this.IdInvalidInputText.Font = new System.Drawing.Font("Open Sans", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdInvalidInputText.ForeColor = System.Drawing.Color.Red;
            this.IdInvalidInputText.Location = new System.Drawing.Point(530, 37);
            this.IdInvalidInputText.Name = "IdInvalidInputText";
            this.IdInvalidInputText.Size = new System.Drawing.Size(113, 22);
            this.IdInvalidInputText.TabIndex = 13;
            this.IdInvalidInputText.Text = "Invalid Input";
            this.IdInvalidInputText.Visible = false;
            // 
            // FirstNameInvalidtext
            // 
            this.FirstNameInvalidtext.AutoSize = true;
            this.FirstNameInvalidtext.Font = new System.Drawing.Font("Open Sans", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameInvalidtext.ForeColor = System.Drawing.Color.Red;
            this.FirstNameInvalidtext.Location = new System.Drawing.Point(530, 72);
            this.FirstNameInvalidtext.Name = "FirstNameInvalidtext";
            this.FirstNameInvalidtext.Size = new System.Drawing.Size(113, 22);
            this.FirstNameInvalidtext.TabIndex = 14;
            this.FirstNameInvalidtext.Text = "Invalid Input";
            this.FirstNameInvalidtext.Visible = false;
            // 
            // LastNameInvalidText
            // 
            this.LastNameInvalidText.AutoSize = true;
            this.LastNameInvalidText.Font = new System.Drawing.Font("Open Sans", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameInvalidText.ForeColor = System.Drawing.Color.Red;
            this.LastNameInvalidText.Location = new System.Drawing.Point(530, 111);
            this.LastNameInvalidText.Name = "LastNameInvalidText";
            this.LastNameInvalidText.Size = new System.Drawing.Size(113, 22);
            this.LastNameInvalidText.TabIndex = 15;
            this.LastNameInvalidText.Text = "Invalid Input";
            this.LastNameInvalidText.Visible = false;
            // 
            // EmailInvalidText
            // 
            this.EmailInvalidText.AutoSize = true;
            this.EmailInvalidText.Font = new System.Drawing.Font("Open Sans", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailInvalidText.ForeColor = System.Drawing.Color.Red;
            this.EmailInvalidText.Location = new System.Drawing.Point(530, 151);
            this.EmailInvalidText.Name = "EmailInvalidText";
            this.EmailInvalidText.Size = new System.Drawing.Size(113, 22);
            this.EmailInvalidText.TabIndex = 16;
            this.EmailInvalidText.Text = "Invalid Input";
            this.EmailInvalidText.Visible = false;
            // 
            // PhoneNumberInvalidText
            // 
            this.PhoneNumberInvalidText.AutoSize = true;
            this.PhoneNumberInvalidText.Font = new System.Drawing.Font("Open Sans", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberInvalidText.ForeColor = System.Drawing.Color.Red;
            this.PhoneNumberInvalidText.Location = new System.Drawing.Point(530, 199);
            this.PhoneNumberInvalidText.Name = "PhoneNumberInvalidText";
            this.PhoneNumberInvalidText.Size = new System.Drawing.Size(113, 22);
            this.PhoneNumberInvalidText.TabIndex = 17;
            this.PhoneNumberInvalidText.Text = "Invalid Input";
            this.PhoneNumberInvalidText.Visible = false;
            // 
            // RequestLoanBtn
            // 
            this.RequestLoanBtn.Location = new System.Drawing.Point(478, 299);
            this.RequestLoanBtn.Name = "RequestLoanBtn";
            this.RequestLoanBtn.Size = new System.Drawing.Size(130, 41);
            this.RequestLoanBtn.TabIndex = 18;
            this.RequestLoanBtn.Text = "Request Loan";
            this.RequestLoanBtn.UseVisualStyleBackColor = true;
            this.RequestLoanBtn.Visible = false;
            this.RequestLoanBtn.Click += new System.EventHandler(this.RequestLoanBtn_Click);
            // 
            // RetrieveBtn
            // 
            this.RetrieveBtn.Location = new System.Drawing.Point(181, 299);
            this.RetrieveBtn.Name = "RetrieveBtn";
            this.RetrieveBtn.Size = new System.Drawing.Size(130, 41);
            this.RetrieveBtn.TabIndex = 19;
            this.RetrieveBtn.Text = "Retrieve";
            this.RetrieveBtn.UseVisualStyleBackColor = true;
            this.RetrieveBtn.Visible = false;
            this.RetrieveBtn.Click += new System.EventHandler(this.RetrieveBtn_Click);
            // 
            // CustomerGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 357);
            this.Controls.Add(this.RetrieveBtn);
            this.Controls.Add(this.RequestLoanBtn);
            this.Controls.Add(this.PhoneNumberInvalidText);
            this.Controls.Add(this.EmailInvalidText);
            this.Controls.Add(this.LastNameInvalidText);
            this.Controls.Add(this.FirstNameInvalidtext);
            this.Controls.Add(this.IdInvalidInputText);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.DOBLabel);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.CustomerIDLabel);
            this.Name = "CustomerGUI";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerIDLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label DOBLabel;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.DateTimePicker DOB;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label IdInvalidInputText;
        private System.Windows.Forms.Label FirstNameInvalidtext;
        private System.Windows.Forms.Label LastNameInvalidText;
        private System.Windows.Forms.Label EmailInvalidText;
        private System.Windows.Forms.Label PhoneNumberInvalidText;
        private System.Windows.Forms.Button RequestLoanBtn;
        private System.Windows.Forms.Button RetrieveBtn;
    }
}

