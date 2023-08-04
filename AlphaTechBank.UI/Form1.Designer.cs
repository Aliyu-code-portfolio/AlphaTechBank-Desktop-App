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
            bankName = new Label();
            loginGroup = new GroupBox();
            errorMessage = new Label();
            loginButton = new Button();
            registerButton = new Button();
            passwordTextBox = new TextBox();
            label1 = new Label();
            emailTextBox = new TextBox();
            label2 = new Label();
            dashboardPanel = new Panel();
            logoutBotton = new Button();
            createAccountButton = new Button();
            transferButton = new Button();
            withdrawalButton = new Button();
            depositButton = new Button();
            accountsList = new ListBox();
            label5 = new Label();
            panel2 = new Panel();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            listBox1 = new ListBox();
            label18 = new Label();
            depositPanel = new Panel();
            transferPanel = new Panel();
            panel3 = new Panel();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            listBox2 = new ListBox();
            label19 = new Label();
            label9 = new Label();
            accountName = new Label();
            verify = new Button();
            label20 = new Label();
            accountNumber = new TextBox();
            tranferAccount = new Label();
            backTransfer = new Button();
            errorTransfer = new Label();
            label14 = new Label();
            label15 = new Label();
            amountTransfer = new TextBox();
            transferSubmit = new Button();
            label16 = new Label();
            accountNumberLabel = new Label();
            backDeposit = new Button();
            errorDeposit = new Label();
            label10 = new Label();
            label13 = new Label();
            accountNumberText = new TextBox();
            submitDeposit = new Button();
            label17 = new Label();
            createAccountPanel = new Panel();
            backDashboard = new Button();
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
            panel2.SuspendLayout();
            depositPanel.SuspendLayout();
            transferPanel.SuspendLayout();
            panel3.SuspendLayout();
            createAccountPanel.SuspendLayout();
            SuspendLayout();
            // 
            // loginPanel
            // 
            loginPanel.BackColor = SystemColors.HotTrack;
            loginPanel.Controls.Add(bankName);
            loginPanel.Controls.Add(loginGroup);
            loginPanel.Location = new Point(2, 0);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(930, 507);
            loginPanel.TabIndex = 1;
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
            // dashboardPanel
            // 
            dashboardPanel.BackColor = SystemColors.HotTrack;
            dashboardPanel.Controls.Add(logoutBotton);
            dashboardPanel.Controls.Add(createAccountButton);
            dashboardPanel.Controls.Add(transferButton);
            dashboardPanel.Controls.Add(withdrawalButton);
            dashboardPanel.Controls.Add(depositButton);
            dashboardPanel.Controls.Add(accountsList);
            dashboardPanel.Controls.Add(label5);
            dashboardPanel.Controls.Add(panel2);
            dashboardPanel.Location = new Point(3, 0);
            dashboardPanel.Name = "dashboardPanel";
            dashboardPanel.Size = new Size(859, 507);
            dashboardPanel.TabIndex = 5;
            dashboardPanel.Paint += panel1_Paint;
            // 
            // logoutBotton
            // 
            logoutBotton.Location = new Point(17, 247);
            logoutBotton.Name = "logoutBotton";
            logoutBotton.Size = new Size(109, 41);
            logoutBotton.TabIndex = 6;
            logoutBotton.Text = "Logout";
            logoutBotton.UseVisualStyleBackColor = true;
            logoutBotton.Click += logoutBotton_Click;
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
            transferButton.Click += transferButton_Click;
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
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(listBox1);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(depositPanel);
            panel2.Location = new Point(-1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(859, 507);
            panel2.TabIndex = 5;
            // 
            // button3
            // 
            button3.Location = new Point(17, 247);
            button3.Name = "button3";
            button3.Size = new Size(109, 41);
            button3.TabIndex = 6;
            button3.Text = "Logout";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(498, 404);
            button4.Name = "button4";
            button4.Size = new Size(162, 41);
            button4.TabIndex = 5;
            button4.Text = "Create an account";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(517, 300);
            button5.Name = "button5";
            button5.Size = new Size(109, 41);
            button5.TabIndex = 4;
            button5.Text = "Transfer";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(517, 196);
            button6.Name = "button6";
            button6.Size = new Size(109, 41);
            button6.TabIndex = 3;
            button6.Text = "Withdrawal";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(517, 101);
            button7.Name = "button7";
            button7.Size = new Size(109, 41);
            button7.TabIndex = 2;
            button7.Text = "Deposit";
            button7.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.HighlightText;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(197, 101);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(195, 345);
            listBox1.TabIndex = 1;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Enabled = false;
            label18.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = SystemColors.ControlLight;
            label18.Location = new Point(46, 34);
            label18.Name = "label18";
            label18.Size = new Size(170, 30);
            label18.TabIndex = 0;
            label18.Text = "AlphaTech Bank";
            // 
            // depositPanel
            // 
            depositPanel.BackColor = SystemColors.HotTrack;
            depositPanel.Controls.Add(accountNumberLabel);
            depositPanel.Controls.Add(backDeposit);
            depositPanel.Controls.Add(errorDeposit);
            depositPanel.Controls.Add(label10);
            depositPanel.Controls.Add(label13);
            depositPanel.Controls.Add(accountNumberText);
            depositPanel.Controls.Add(submitDeposit);
            depositPanel.Controls.Add(label17);
            depositPanel.Location = new Point(0, 1);
            depositPanel.Name = "depositPanel";
            depositPanel.Size = new Size(930, 507);
            depositPanel.TabIndex = 20;
            // 
            // transferPanel
            // 
            transferPanel.BackColor = SystemColors.HotTrack;
            transferPanel.Controls.Add(label9);
            transferPanel.Controls.Add(accountName);
            transferPanel.Controls.Add(verify);
            transferPanel.Controls.Add(label20);
            transferPanel.Controls.Add(accountNumber);
            transferPanel.Controls.Add(tranferAccount);
            transferPanel.Controls.Add(backTransfer);
            transferPanel.Controls.Add(errorTransfer);
            transferPanel.Controls.Add(label14);
            transferPanel.Controls.Add(label15);
            transferPanel.Controls.Add(amountTransfer);
            transferPanel.Controls.Add(transferSubmit);
            transferPanel.Controls.Add(label16);
            transferPanel.Location = new Point(2, 3);
            transferPanel.Name = "transferPanel";
            transferPanel.Size = new Size(930, 507);
            transferPanel.TabIndex = 21;
            transferPanel.Paint += transferPanel_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HotTrack;
            panel3.Controls.Add(button8);
            panel3.Controls.Add(button9);
            panel3.Controls.Add(button10);
            panel3.Controls.Add(button11);
            panel3.Controls.Add(button12);
            panel3.Controls.Add(listBox2);
            panel3.Controls.Add(label19);
            panel3.Location = new Point(0, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(859, 507);
            panel3.TabIndex = 5;
            // 
            // button8
            // 
            button8.Location = new Point(17, 247);
            button8.Name = "button8";
            button8.Size = new Size(109, 41);
            button8.TabIndex = 6;
            button8.Text = "Logout";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(498, 404);
            button9.Name = "button9";
            button9.Size = new Size(162, 41);
            button9.TabIndex = 5;
            button9.Text = "Create an account";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(517, 300);
            button10.Name = "button10";
            button10.Size = new Size(109, 41);
            button10.TabIndex = 4;
            button10.Text = "Transfer";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(517, 196);
            button11.Name = "button11";
            button11.Size = new Size(109, 41);
            button11.TabIndex = 3;
            button11.Text = "Withdrawal";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Location = new Point(517, 101);
            button12.Name = "button12";
            button12.Size = new Size(109, 41);
            button12.TabIndex = 2;
            button12.Text = "Deposit";
            button12.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            listBox2.BackColor = SystemColors.HighlightText;
            listBox2.BorderStyle = BorderStyle.None;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(197, 101);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(195, 345);
            listBox2.TabIndex = 1;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Enabled = false;
            label19.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = SystemColors.ControlLight;
            label19.Location = new Point(46, 34);
            label19.Name = "label19";
            label19.Size = new Size(170, 30);
            label19.TabIndex = 0;
            label19.Text = "AlphaTech Bank";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Enabled = false;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlLight;
            label9.Location = new Point(409, 72);
            label9.Name = "label9";
            label9.Size = new Size(94, 30);
            label9.TabIndex = 22;
            label9.Text = "Transfer";
            // 
            // accountName
            // 
            accountName.AutoSize = true;
            accountName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            accountName.ForeColor = Color.Chartreuse;
            accountName.Location = new Point(420, 200);
            accountName.Name = "accountName";
            accountName.Size = new Size(52, 21);
            accountName.TabIndex = 24;
            accountName.Text = "Name";
            accountName.Visible = false;
            // 
            // verify
            // 
            verify.Location = new Point(420, 226);
            verify.Name = "verify";
            verify.Size = new Size(117, 26);
            verify.TabIndex = 23;
            verify.Text = "Verify Name";
            verify.UseVisualStyleBackColor = true;
            verify.Click += verify_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(314, 177);
            label20.Name = "label20";
            label20.Size = new Size(99, 15);
            label20.TabIndex = 22;
            label20.Text = "Account Number";
            // 
            // accountNumber
            // 
            accountNumber.Location = new Point(419, 174);
            accountNumber.Name = "accountNumber";
            accountNumber.Size = new Size(209, 23);
            accountNumber.TabIndex = 21;
            // 
            // tranferAccount
            // 
            tranferAccount.AutoSize = true;
            tranferAccount.Enabled = false;
            tranferAccount.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            tranferAccount.ForeColor = SystemColors.ControlLight;
            tranferAccount.Location = new Point(409, 127);
            tranferAccount.Name = "tranferAccount";
            tranferAccount.Size = new Size(93, 25);
            tranferAccount.TabIndex = 20;
            tranferAccount.Text = "Account: ";
            // 
            // backTransfer
            // 
            backTransfer.Location = new Point(23, 245);
            backTransfer.Name = "backTransfer";
            backTransfer.Size = new Size(109, 41);
            backTransfer.TabIndex = 7;
            backTransfer.Text = "< Back";
            backTransfer.UseVisualStyleBackColor = true;
            backTransfer.Click += backTransfer_Click;
            // 
            // errorTransfer
            // 
            errorTransfer.AutoSize = true;
            errorTransfer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            errorTransfer.ForeColor = Color.Red;
            errorTransfer.Location = new Point(409, 296);
            errorTransfer.Name = "errorTransfer";
            errorTransfer.Size = new Size(45, 21);
            errorTransfer.TabIndex = 19;
            errorTransfer.Text = "Error";
            errorTransfer.Visible = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Enabled = false;
            label14.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.ControlLight;
            label14.Location = new Point(414, 74);
            label14.Name = "label14";
            label14.Size = new Size(25, 30);
            label14.TabIndex = 18;
            label14.Text = "  ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(319, 267);
            label15.Name = "label15";
            label15.Size = new Size(51, 15);
            label15.TabIndex = 13;
            label15.Text = "Amount";
            // 
            // amountTransfer
            // 
            amountTransfer.Location = new Point(419, 259);
            amountTransfer.Name = "amountTransfer";
            amountTransfer.Size = new Size(209, 23);
            amountTransfer.TabIndex = 12;
            // 
            // transferSubmit
            // 
            transferSubmit.Location = new Point(375, 384);
            transferSubmit.Name = "transferSubmit";
            transferSubmit.Size = new Size(162, 41);
            transferSubmit.TabIndex = 5;
            transferSubmit.Text = "Transfer";
            transferSubmit.UseVisualStyleBackColor = true;
            transferSubmit.Click += transferSubmit_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Enabled = false;
            label16.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = SystemColors.ControlLight;
            label16.Location = new Point(46, 34);
            label16.Name = "label16";
            label16.Size = new Size(170, 30);
            label16.TabIndex = 0;
            label16.Text = "AlphaTech Bank";
            // 
            // accountNumberLabel
            // 
            accountNumberLabel.AutoSize = true;
            accountNumberLabel.Enabled = false;
            accountNumberLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            accountNumberLabel.ForeColor = SystemColors.ControlLight;
            accountNumberLabel.Location = new Point(409, 127);
            accountNumberLabel.Name = "accountNumberLabel";
            accountNumberLabel.Size = new Size(93, 25);
            accountNumberLabel.TabIndex = 20;
            accountNumberLabel.Text = "Account: ";
            // 
            // backDeposit
            // 
            backDeposit.Location = new Point(23, 245);
            backDeposit.Name = "backDeposit";
            backDeposit.Size = new Size(109, 41);
            backDeposit.TabIndex = 7;
            backDeposit.Text = "< Back";
            backDeposit.UseVisualStyleBackColor = true;
            backDeposit.Click += backDeposit_Click;
            // 
            // errorDeposit
            // 
            errorDeposit.AutoSize = true;
            errorDeposit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            errorDeposit.ForeColor = Color.Red;
            errorDeposit.Location = new Point(409, 296);
            errorDeposit.Name = "errorDeposit";
            errorDeposit.Size = new Size(45, 21);
            errorDeposit.TabIndex = 19;
            errorDeposit.Text = "Error";
            errorDeposit.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Enabled = false;
            label10.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlLight;
            label10.Location = new Point(414, 74);
            label10.Name = "label10";
            label10.Size = new Size(88, 30);
            label10.TabIndex = 18;
            label10.Text = "Deposit";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(347, 262);
            label13.Name = "label13";
            label13.Size = new Size(51, 15);
            label13.TabIndex = 13;
            label13.Text = "Amount";
            // 
            // accountNumberText
            // 
            accountNumberText.Location = new Point(409, 259);
            accountNumberText.Name = "accountNumberText";
            accountNumberText.Size = new Size(225, 23);
            accountNumberText.TabIndex = 12;
            // 
            // submitDeposit
            // 
            submitDeposit.Location = new Point(375, 384);
            submitDeposit.Name = "submitDeposit";
            submitDeposit.Size = new Size(162, 41);
            submitDeposit.TabIndex = 5;
            submitDeposit.Text = "Submit";
            submitDeposit.UseVisualStyleBackColor = true;
            submitDeposit.Click += submitDeposit_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Enabled = false;
            label17.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.ControlLight;
            label17.Location = new Point(46, 34);
            label17.Name = "label17";
            label17.Size = new Size(170, 30);
            label17.TabIndex = 0;
            label17.Text = "AlphaTech Bank";
            // 
            // createAccountPanel
            // 
            createAccountPanel.BackColor = SystemColors.HotTrack;
            createAccountPanel.Controls.Add(loginPanel);
            createAccountPanel.Controls.Add(panel3);
            createAccountPanel.Controls.Add(transferPanel);
            createAccountPanel.Controls.Add(backDashboard);
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
            createAccountPanel.Controls.Add(dashboardPanel);
            createAccountPanel.Location = new Point(1, 0);
            createAccountPanel.Name = "createAccountPanel";
            createAccountPanel.Size = new Size(930, 507);
            createAccountPanel.TabIndex = 6;
            // 
            // backDashboard
            // 
            backDashboard.Location = new Point(23, 245);
            backDashboard.Name = "backDashboard";
            backDashboard.Size = new Size(109, 41);
            backDashboard.TabIndex = 7;
            backDashboard.Text = "< Back";
            backDashboard.UseVisualStyleBackColor = true;
            backDashboard.Click += backDashboard_Click;
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
            Controls.Add(createAccountPanel);
            Name = "Form1";
            Text = "AlphaTech Bank";
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            loginGroup.ResumeLayout(false);
            loginGroup.PerformLayout();
            dashboardPanel.ResumeLayout(false);
            dashboardPanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            depositPanel.ResumeLayout(false);
            depositPanel.PerformLayout();
            transferPanel.ResumeLayout(false);
            transferPanel.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private Button logoutBotton;
        private Button backDashboard;
        private Panel depositPanel;
        private Label accountNumberLabel;
        private Button backDeposit;
        private Label errorDeposit;
        private Label label10;
        private Label label13;
        private TextBox accountNumberText;
        private Button submitDeposit;
        private Label label17;
        private Panel panel2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private ListBox listBox1;
        private Label label18;
        private Panel transferPanel;
        private Label tranferAccount;
        private Button backTransfer;
        private Label errorTransfer;
        private Label label14;
        private Label label15;
        private TextBox amountTransfer;
        private Button transferSubmit;
        private Label label16;
        private Panel panel3;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private ListBox listBox2;
        private Label label19;
        private Label label20;
        private TextBox accountNumber;
        private Label accountName;
        private Button verify;
        private Label label9;
    }
}