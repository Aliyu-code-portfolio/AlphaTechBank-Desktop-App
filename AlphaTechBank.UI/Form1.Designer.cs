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
            loginPane = new Panel();
            panel1 = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            accounts = new ListBox();
            label5 = new Label();
            loginGroup = new GroupBox();
            errorMessage = new Label();
            loginButton = new Button();
            registerButton = new Button();
            passwordTextBox = new TextBox();
            label1 = new Label();
            emailTextBox = new TextBox();
            label2 = new Label();
            bankName = new Label();
            loginPane.SuspendLayout();
            panel1.SuspendLayout();
            loginGroup.SuspendLayout();
            SuspendLayout();
            // 
            // loginPane
            // 
            loginPane.BackColor = SystemColors.HotTrack;
            loginPane.Controls.Add(panel1);
            loginPane.Controls.Add(loginGroup);
            loginPane.Controls.Add(bankName);
            loginPane.Location = new Point(3, 4);
            loginPane.Name = "loginPane";
            loginPane.Size = new Size(930, 507);
            loginPane.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(accounts);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(771, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(930, 507);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // button6
            // 
            button6.Location = new Point(498, 404);
            button6.Name = "button6";
            button6.Size = new Size(162, 41);
            button6.TabIndex = 5;
            button6.Text = "Create an account";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
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
            // button4
            // 
            button4.Location = new Point(517, 196);
            button4.Name = "button4";
            button4.Size = new Size(109, 41);
            button4.TabIndex = 3;
            button4.Text = "Withdrawal";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(517, 101);
            button3.Name = "button3";
            button3.Size = new Size(109, 41);
            button3.TabIndex = 2;
            button3.Text = "Deposit";
            button3.UseVisualStyleBackColor = true;
            // 
            // accounts
            // 
            accounts.BackColor = SystemColors.HighlightText;
            accounts.BorderStyle = BorderStyle.None;
            accounts.FormattingEnabled = true;
            accounts.ItemHeight = 15;
            accounts.Location = new Point(197, 101);
            accounts.Name = "accounts";
            accounts.Size = new Size(195, 345);
            accounts.TabIndex = 1;
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
            emailTextBox.ForeColor = SystemColors.InactiveCaption;
            emailTextBox.Location = new Point(181, 70);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(326, 29);
            emailTextBox.TabIndex = 3;
            emailTextBox.Text = "example@email.com";
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 510);
            Controls.Add(loginPane);
            Name = "Form1";
            Text = "AlphaTech Bank";
            loginPane.ResumeLayout(false);
            loginPane.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            loginGroup.ResumeLayout(false);
            loginGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel loginPane;
        private GroupBox loginGroup;
        private TextBox passwordTextBox;
        private Label label1;
        private TextBox emailTextBox;
        private Label label2;
        private Label bankName;
        private Panel panel1;
        private ListBox accounts;
        private Label label5;
        private Button loginButton;
        private Button registerButton;
        private Label errorMessage;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button6;
    }
}