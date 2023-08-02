namespace AlphaTechBank.UI
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
            loginPanel = new Panel();
            loginGroup = new GroupBox();
            errorMessage = new Label();
            loginButton = new Button();
            registerButton = new Button();
            passwordTextBox = new TextBox();
            label1 = new Label();
            emailTextBox = new TextBox();
            label2 = new Label();
            bankName = new Label();
            dashboardPanel = new Panel();
            createAccountButton = new Button();
            transferButton = new Button();
            withdrawalButton = new Button();
            depositButton = new Button();
            accountsList = new ListBox();
            label5 = new Label();
            createAccountPanel = new Panel();
            createAcctError = new Label();
            label6 = new Label();
            current = new CheckBox();
            savings = new CheckBox();
            label12 = new Label();
            label8 = new Label();
            lastName = new TextBox();
            label7 = new Label();
            pin = new TextBox();
            phoneLebel = new Label();
            phone = new TextBox();
            label4 = new Label();
            firstName = new TextBox();
            createAccount = new Button();
            label3 = new Label();
            loginPanel.SuspendLayout();
            loginGroup.SuspendLayout();
            dashboardPanel.SuspendLayout();
            createAccountPanel.SuspendLayout();
            SuspendLayout();
            // 
            // loginPanel
            // 
            loginPanel.BackColor = SystemColors.HotTrack;
            loginPanel.Controls.Add(bankName);
            loginPanel.Controls.Add(loginGroup);
            loginPanel.Controls.Add(dashboardPanel);
            loginPanel.Location = new Point(32, 12);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(930, 507);
            loginPanel.TabIndex = 1;
            // 
            // loginGroup
            // 
            loginGroup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loginGroup.BackColor = Color.SteelBlue;
            loginGroup.Controls.Add(errorMessage);
            loginGroup.Controls.Add(loginButton);
            loginGroup.Controls.Add(registerButton);
            loginGroup.Controls.Add(passwordTextBox);
            loginGroup.Controls.Add(label1);
            loginGroup.Controls.Add(emailTextBox);
            loginGroup.Controls.Add(label2);
            loginGroup.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            loginGroup.ForeColor = SystemColors.InfoText;
            loginGroup.Location = new Point(197, 130);
            loginGroup.Name = "loginGroup";
            loginGroup.Size = new Size(540, 276);
            loginGroup.TabIndex = 4;
            loginGroup.TabStop = false;
            loginGroup.Text = "Login / Register";
            // 
            // errorMessage
            // 
            errorMessage.AutoSize = true;
            errorMessage.ForeColor = Color.Red;
            errorMessage.Location = new Point(181, 178);
            errorMessage.Name = "errorMessage";
            errorMessage.Size = new Size(49, 21);
            errorMessage.TabIndex = 7;
            errorMessage.Text = "Error";
            errorMessage.Visible = false;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.Lime;
            loginButton.Location = new Point(408, 220);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(99, 30);
            loginButton.TabIndex = 6;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(181, 220);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(99, 30);
            registerButton.TabIndex = 5;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(181, 132);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(326, 29);
            passwordTextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(56, 74);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 1;
            label1.Text = "Email";
            // 
            // emailTextBox
            // 
            emailTextBox.ForeColor = SystemColors.Desktop;
            emailTextBox.Location = new Point(181, 70);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(326, 29);
            emailTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(56, 136);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // bankName
            // 
            bankName.AutoSize = true;
            bankName.Enabled = false;
            bankName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            bankName.ForeColor = SystemColors.ActiveCaptionText;
            bankName.Location = new Point(46, 34);
            bankName.Name = "bankName";
            bankName.Size = new Size(170, 30);
            bankName.TabIndex = 0;
            bankName.Text = "AlphaTech Bank";
            // 
            // dashboardPanel
            // 
            dashboardPanel.BackColor = SystemColors.HotTrack;
            dashboardPanel.Controls.Add(createAccountButton);
            dashboardPanel.Controls.Add(transferButton);
            dashboardPanel.Controls.Add(withdrawalButton);
            dashboardPanel.Controls.Add(depositButton);
            dashboardPanel.Controls.Add(accountsList);
            dashboardPanel.Controls.Add(label5);
            dashboardPanel.Location = new Point(3, 22);
            dashboardPanel.Name = "dashboardPanel";
            dashboardPanel.Size = new Size(859, 507);
            dashboardPanel.TabIndex = 5;
            dashboardPanel.Paint += panel1_Paint;
            // 
            // createAccountButton
            // 
            createAccountButton.Location = new Point(498, 404);
            createAccountButton.Name = "createAccountButton";
            createAccountButton.Size = new Size(162, 41);
            createAccountButton.TabIndex = 5;
            createAccountButton.Text = "Create an account";
            createAccountButton.UseVisualStyleBackColor = true;
            createAccountButton.Click += createAccountButton_Click;
            // 
            // transferButton
            // 
            transferButton.Location = new Point(517, 300);
            transferButton.Name = "transferButton";
            transferButton.Size = new Size(109, 41);
            transferButton.TabIndex = 4;
            transferButton.Text = "Transfer";
            transferButton.UseVisualStyleBackColor = true;
            // 
            // withdrawalButton
            // 
            withdrawalButton.Location = new Point(517, 196);
            withdrawalButton.Name = "withdrawalButton";
            withdrawalButton.Size = new Size(109, 41);
            withdrawalButton.TabIndex = 3;
            withdrawalButton.Text = "Withdrawal";
            withdrawalButton.UseVisualStyleBackColor = true;
            // 
            // depositButton
            // 
            depositButton.Location = new Point(517, 101);
            depositButton.Name = "depositButton";
            depositButton.Size = new Size(109, 41);
            depositButton.TabIndex = 2;
            depositButton.Text = "Deposit";
            depositButton.UseVisualStyleBackColor = true;
            depositButton.Click += depositButton_Click;
            // 
            // accountsList
            // 
            accountsList.BackColor = SystemColors.HighlightText;
            accountsList.BorderStyle = BorderStyle.None;
            accountsList.FormattingEnabled = true;
            accountsList.ItemHeight = 15;
            accountsList.Location = new Point(197, 101);
            accountsList.Name = "accountsList";
            accountsList.Size = new Size(195, 345);
            accountsList.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Enabled = false;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(46, 34);
            label5.Name = "label5";
            label5.Size = new Size(170, 30);
            label5.TabIndex = 0;
            label5.Text = "AlphaTech Bank";
            // 
            // createAccountPanel
            // 
            createAccountPanel.BackColor = SystemColors.HotTrack;
            createAccountPanel.Controls.Add(createAcctError);
            createAccountPanel.Controls.Add(label6);
            createAccountPanel.Controls.Add(current);
            createAccountPanel.Controls.Add(savings);
            createAccountPanel.Controls.Add(label12);
            createAccountPanel.Controls.Add(label8);
            createAccountPanel.Controls.Add(lastName);
            createAccountPanel.Controls.Add(label7);
            createAccountPanel.Controls.Add(pin);
            createAccountPanel.Controls.Add(phoneLebel);
            createAccountPanel.Controls.Add(phone);
            createAccountPanel.Controls.Add(label4);
            createAccountPanel.Controls.Add(firstName);
            createAccountPanel.Controls.Add(createAccount);
            createAccountPanel.Controls.Add(label3);
            createAccountPanel.Location = new Point(32, 12);
            createAccountPanel.Name = "createAccountPanel";
            createAccountPanel.Size = new Size(930, 507);
            createAccountPanel.TabIndex = 6;
            // 
            // createAcctError
            // 
            createAcctError.AutoSize = true;
            createAcctError.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            createAcctError.ForeColor = Color.Red;
            createAcctError.Location = new Point(391, 389);
            createAcctError.Name = "createAcctError";
            createAcctError.Size = new Size(45, 21);
            createAcctError.TabIndex = 19;
            createAcctError.Text = "Error";
            createAcctError.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Enabled = false;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLight;
            label6.Location = new Point(414, 74);
            label6.Name = "label6";
            label6.Size = new Size(220, 30);
            label6.TabIndex = 18;
            label6.Text = "Create Bank Account";
            // 
            // current
            // 
            current.AutoSize = true;
            current.Location = new Point(599, 353);
            current.Name = "current";
            current.Size = new Size(66, 19);
            current.TabIndex = 17;
            current.Text = "Current";
            current.UseVisualStyleBackColor = true;
            current.CheckedChanged += current_CheckedChanged;
            // 
            // savings
            // 
            savings.AutoSize = true;
            savings.Location = new Point(468, 351);
            savings.Name = "savings";
            savings.Size = new Size(66, 19);
            savings.TabIndex = 16;
            savings.Text = "Savings";
            savings.UseVisualStyleBackColor = true;
            savings.CheckedChanged += savings_CheckedChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(317, 353);
            label12.Name = "label12";
            label12.Size = new Size(79, 15);
            label12.TabIndex = 15;
            label12.Text = "Account Type";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(317, 188);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 13;
            label8.Text = "Last Name";
            // 
            // lastName
            // 
            lastName.Location = new Point(458, 180);
            lastName.Name = "lastName";
            lastName.Size = new Size(225, 23);
            lastName.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(317, 245);
            label7.Name = "label7";
            label7.Size = new Size(26, 15);
            label7.TabIndex = 11;
            label7.Text = "PIN";
            // 
            // pin
            // 
            pin.Location = new Point(458, 237);
            pin.Name = "pin";
            pin.Size = new Size(225, 23);
            pin.TabIndex = 10;
            // 
            // phoneLebel
            // 
            phoneLebel.AutoSize = true;
            phoneLebel.Location = new Point(317, 308);
            phoneLebel.Name = "phoneLebel";
            phoneLebel.Size = new Size(86, 15);
            phoneLebel.TabIndex = 9;
            phoneLebel.Text = "Phone number";
            phoneLebel.TextAlign = ContentAlignment.TopRight;
            // 
            // phone
            // 
            phone.Location = new Point(458, 300);
            phone.Name = "phone";
            phone.Size = new Size(225, 23);
            phone.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(317, 132);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 7;
            label4.Text = "First Name";
            // 
            // firstName
            // 
            firstName.Location = new Point(458, 124);
            firstName.Name = "firstName";
            firstName.Size = new Size(225, 23);
            firstName.TabIndex = 6;
            // 
            // createAccount
            // 
            createAccount.Location = new Point(401, 422);
            createAccount.Name = "createAccount";
            createAccount.Size = new Size(162, 41);
            createAccount.TabIndex = 5;
            createAccount.Text = "Create an account";
            createAccount.UseVisualStyleBackColor = true;
            createAccount.Click += createAccount_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(46, 34);
            label3.Name = "label3";
            label3.Size = new Size(170, 30);
            label3.TabIndex = 0;
            label3.Text = "AlphaTech Bank";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 510);
            Controls.Add(loginPanel);
            Controls.Add(createAccountPanel);
            Name = "Form1";
            Text = "AlphaTech Bank";
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            loginGroup.ResumeLayout(false);
            loginGroup.PerformLayout();
            dashboardPanel.ResumeLayout(false);
            dashboardPanel.PerformLayout();
            createAccountPanel.ResumeLayout(false);
            createAccountPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel loginPanel;
        private GroupBox loginGroup;
        private TextBox passwordTextBox;
        private Label label1;
        private TextBox emailTextBox;
        private Label label2;
        private Label bankName;
        private Panel dashboardPanel;
        private ListBox accountsList;
        private Label label5;
        private Button loginButton;
        private Button registerButton;
        private Label errorMessage;
        private Button transferButton;
        private Button withdrawalButton;
        private Button depositButton;
        private Button createAccountButton;
        private Panel createAccountPanel;
        private TextBox firstName;
        private Button createAccount;
        private Label label3;
        private Label label12;
        private Label label8;
        private TextBox lastName;
        private Label label7;
        private TextBox pin;
        private Label phoneLebel;
        private TextBox phone;
        private Label label4;
        private CheckBox current;
        private CheckBox savings;
        private Label label6;
        private Label createAcctError;
    }
}