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
            createAccountPanel = new Panel();
            firstName = new TextBox();
            button1 = new Button();
            label3 = new Label();
            createAccountButton = new Button();
            transferButton = new Button();
            withdrawalButton = new Button();
            depositButton = new Button();
            accountsList = new ListBox();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            textBox3 = new TextBox();
            label8 = new Label();
            lastName = new TextBox();
            label9 = new Label();
            textBox5 = new TextBox();
            label10 = new Label();
            textBox6 = new TextBox();
            label11 = new Label();
            textBox7 = new TextBox();
            label12 = new Label();
            textBox8 = new TextBox();
            loginPanel.SuspendLayout();
            loginGroup.SuspendLayout();
            dashboardPanel.SuspendLayout();
            createAccountPanel.SuspendLayout();
            SuspendLayout();
            // 
            // loginPanel
            // 
            loginPanel.BackColor = SystemColors.HotTrack;
            loginPanel.Controls.Add(loginGroup);
            loginPanel.Controls.Add(bankName);
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
            dashboardPanel.Location = new Point(12, 15);
            dashboardPanel.Name = "dashboardPanel";
            dashboardPanel.Size = new Size(930, 507);
            dashboardPanel.TabIndex = 5;
            dashboardPanel.Paint += panel1_Paint;
            // 
            // createAccountPanel
            // 
            createAccountPanel.BackColor = SystemColors.HotTrack;
            createAccountPanel.Controls.Add(label9);
            createAccountPanel.Controls.Add(textBox5);
            createAccountPanel.Controls.Add(label10);
            createAccountPanel.Controls.Add(textBox6);
            createAccountPanel.Controls.Add(label11);
            createAccountPanel.Controls.Add(textBox7);
            createAccountPanel.Controls.Add(label12);
            createAccountPanel.Controls.Add(textBox8);
            createAccountPanel.Controls.Add(label8);
            createAccountPanel.Controls.Add(lastName);
            createAccountPanel.Controls.Add(label7);
            createAccountPanel.Controls.Add(textBox3);
            createAccountPanel.Controls.Add(label6);
            createAccountPanel.Controls.Add(textBox2);
            createAccountPanel.Controls.Add(label4);
            createAccountPanel.Controls.Add(firstName);
            createAccountPanel.Controls.Add(button1);
            createAccountPanel.Controls.Add(label3);
            createAccountPanel.Location = new Point(9, 18);
            createAccountPanel.Name = "createAccountPanel";
            createAccountPanel.Size = new Size(930, 507);
            createAccountPanel.TabIndex = 6;
            // 
            // firstName
            // 
            firstName.Location = new Point(457, 98);
            firstName.Name = "firstName";
            firstName.Size = new Size(225, 23);
            firstName.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(403, 439);
            button1.Name = "button1";
            button1.Size = new Size(162, 41);
            button1.TabIndex = 5;
            button1.Text = "Create an account";
            button1.UseVisualStyleBackColor = true;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(316, 106);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 7;
            label4.Text = "First Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(316, 219);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 9;
            label6.Text = "First Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(457, 211);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(225, 23);
            textBox2.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(316, 182);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 11;
            label7.Text = "First Name";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(457, 174);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(225, 23);
            textBox3.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(316, 144);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 13;
            label8.Text = "Last Name";
            // 
            // lastName
            // 
            lastName.Location = new Point(457, 136);
            lastName.Name = "lastName";
            lastName.Size = new Size(225, 23);
            lastName.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(316, 302);
            label9.Name = "label9";
            label9.Size = new Size(64, 15);
            label9.TabIndex = 21;
            label9.Text = "First Name";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(457, 294);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(225, 23);
            textBox5.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(316, 340);
            label10.Name = "label10";
            label10.Size = new Size(64, 15);
            label10.TabIndex = 19;
            label10.Text = "First Name";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(457, 332);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(225, 23);
            textBox6.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(316, 377);
            label11.Name = "label11";
            label11.Size = new Size(64, 15);
            label11.TabIndex = 17;
            label11.Text = "First Name";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(457, 369);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(225, 23);
            textBox7.TabIndex = 16;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(316, 264);
            label12.Name = "label12";
            label12.Size = new Size(64, 15);
            label12.TabIndex = 15;
            label12.Text = "First Name";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(457, 256);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(225, 23);
            textBox8.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 510);
            Controls.Add(createAccountPanel);
            Controls.Add(dashboardPanel);
            Controls.Add(loginPanel);
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
        private Button button1;
        private Label label3;
        private Label label9;
        private TextBox textBox5;
        private Label label10;
        private TextBox textBox6;
        private Label label11;
        private TextBox textBox7;
        private Label label12;
        private TextBox textBox8;
        private Label label8;
        private TextBox lastName;
        private Label label7;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox2;
        private Label label4;
    }
}