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
            loginGroup = new GroupBox();
            error = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            bankName = new Label();
            panel1 = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            accounts = new ListBox();
            label5 = new Label();
            loginPane.SuspendLayout();
            loginGroup.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // loginPane
            // 
            loginPane.BackColor = SystemColors.HotTrack;
            loginPane.Controls.Add(loginGroup);
            loginPane.Controls.Add(bankName);
            loginPane.Location = new Point(3, 4);
            loginPane.Name = "loginPane";
            loginPane.Size = new Size(930, 507);
            loginPane.TabIndex = 1;
            // 
            // loginGroup
            // 
            loginGroup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loginGroup.BackColor = Color.SteelBlue;
            loginGroup.Controls.Add(error);
            loginGroup.Controls.Add(button2);
            loginGroup.Controls.Add(button1);
            loginGroup.Controls.Add(textBox2);
            loginGroup.Controls.Add(label1);
            loginGroup.Controls.Add(textBox1);
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
            // error
            // 
            error.AutoSize = true;
            error.ForeColor = Color.Red;
            error.Location = new Point(181, 178);
            error.Name = "error";
            error.Size = new Size(49, 21);
            error.TabIndex = 7;
            error.Text = "Error";
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.Location = new Point(408, 220);
            button2.Name = "button2";
            button2.Size = new Size(99, 30);
            button2.TabIndex = 6;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Location = new Point(181, 220);
            button1.Name = "button1";
            button1.Size = new Size(99, 30);
            button1.TabIndex = 5;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(181, 132);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(326, 29);
            textBox2.TabIndex = 4;
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
            // textBox1
            // 
            textBox1.ForeColor = SystemColors.InactiveCaption;
            textBox1.Location = new Point(181, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(326, 29);
            textBox1.TabIndex = 3;
            textBox1.Text = "example@email.com";
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
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(accounts);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(3, 7);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 510);
            Controls.Add(panel1);
            Controls.Add(loginPane);
            Name = "Form1";
            Text = "AlphaTech Bank";
            loginPane.ResumeLayout(false);
            loginPane.PerformLayout();
            loginGroup.ResumeLayout(false);
            loginGroup.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel loginPane;
        private GroupBox loginGroup;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label bankName;
        private Panel panel1;
        private ListBox accounts;
        private Label label5;
        private Button button2;
        private Button button1;
        private Label error;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button6;
    }
}