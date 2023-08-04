using AlphaTechBank.Core.ServiceManager.Abstraction;
using AlphaTechBank.Model.Model;

namespace AlphaTechBank.UI
{
    public partial class Form1 : Form
    {
        private IServiceManager _serviceManager;
        User _user;
        Account _account;
        BindingSource bindingAccounts;
        public Form1(IServiceManager serviceManager)
        {
            bindingAccounts = new BindingSource();
            _serviceManager = serviceManager;
            InitializeComponent();
        }

        private async void registerButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                errorMessage.Text = "Fill in the form";
                return;
            }
            loginButton.Enabled = false;
            var result = await _serviceManager.AuthenticationService.RegisterUser(email, password);
            if (!result.status)
            {
                errorMessage.Text = result.error;
                errorMessage.Visible = true;
            }
            else
            {
                MessageBox.Show("You have successfull registered. Please login");
            }
            loginButton.Enabled = true;
        }
        private async void loginButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                errorMessage.Text = "Fill in the form";
                return;
            }
            loginButton.Enabled = false;
            var result = await _serviceManager.AuthenticationService.LoginUser(email, password);
            if (result.user is null)
            {
                errorMessage.Text = result.error;
                errorMessage.Visible = true;
            }
            else
            {
                _user = result.user;
                MessageBox.Show("Login Successfull.");
                bindingAccounts.DataSource = await _serviceManager.AccountService.GetAllUserAccounts(result.user.Id);
                accountsList.DataSource = bindingAccounts;
                loginPanel.Hide();
                dashboardPanel.Show();
                dashboardPanel.BringToFront();
            }
            loginButton.Enabled = true;
        }
        private void depositButton_Click(object sender, EventArgs e)
        {
            _account = (Account)accountsList.SelectedItem;
            accountNumberLabel.Text += _account.AccountNumber;
            depositPanel.Show();
            depositPanel.BringToFront();

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            dashboardPanel.Hide();
            createAccountPanel.Show();
            createAccountPanel.BringToFront();
        }

        private void savings_CheckedChanged(object sender, EventArgs e)
        {
            if (savings.Checked)
            {
                current.Checked = false;
            }
        }

        private void current_CheckedChanged(object sender, EventArgs e)
        {
            if (current.Checked)
            {
                savings.Checked = false;
            }
        }

        private async void createAccount_Click(object sender, EventArgs e)
        {
            string firstname = firstName.Text;
            string lastname = lastName.Text;
            bool isValidPin = int.TryParse(pin.Text, out int PIN);
            string phoneNumber = phone.Text;
            string accountType = string.Empty;
            if (savings.Checked)
            {
                accountType = "savings";
            }
            else if (current.Checked)
            {
                accountType = "current";
            }
            else
            {
                createAcctError.Text = "Select the account type";
                createAcctError.Show();
                return;
            }

            if (string.IsNullOrWhiteSpace(firstname) || string.IsNullOrWhiteSpace(lastname) || string.IsNullOrWhiteSpace(phoneNumber) || isValidPin)
            {
                createAcctError.Text = "Invalid form inputs";
                createAcctError.Show();
                return;
            }
            Account account = await _serviceManager.AccountService
                .CreateAccount(_user.Id, firstname, lastname, _user.Email, PIN, phoneNumber, accountType);
            bindingAccounts.Add(account);
            MessageBox.Show("Successfully created your account. Account Number: " + account.AccountNumber);
            createAccountPanel.Hide();
            dashboardPanel.Show();
            dashboardPanel.BringToFront();
        }

        private void logoutBotton_Click(object sender, EventArgs e)
        {
            _user = null;
            loginPanel.Show();
            loginPanel.BringToFront();
        }

        private void backDashboard_Click(object sender, EventArgs e)
        {
            createAccountPanel.Hide();
            dashboardPanel.Show();
            dashboardPanel.BringToFront();
        }

        private async void submitDeposit_Click(object sender, EventArgs e)
        {
            bool isValid = decimal.TryParse(accountNumberText.Text, out decimal amount);
            if (!isValid)
            {
                errorDeposit.Visible = true;
                errorDeposit.Text = "Invalid amount";
                return;
            }
            await _serviceManager.AccountService.Deposit(_account.AccountNumber, amount);
            _account.Balance += amount;
            MessageBox.Show($"Your deposit to account: {_account.AccountNumber} is successful");
            depositPanel.Hide();
            dashboardPanel.Show();
            dashboardPanel.BringToFront();
        }

        private void backDeposit_Click(object sender, EventArgs e)
        {
            depositPanel.Hide();
            dashboardPanel.Show();
            dashboardPanel.BringToFront();
        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            _account = (Account)accountsList.SelectedItem;
            tranferAccount.Text += _account.AccountNumber;
            transferSubmit.Enabled = false;
            transferPanel.Show();
            transferPanel.BringToFront();
        }

        private void backTransfer_Click(object sender, EventArgs e)
        {
            transferPanel.Hide();
            dashboardPanel.Show();
            dashboardPanel.BringToFront();
        }

        private void transferPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void verify_Click(object sender, EventArgs e)
        {
            verify.Enabled = false;
            string accountNumber = accountNumberText.Text;
            string name = await _serviceManager.AccountService
                .ValidateAccountNumber(accountNumber);
            if (string.IsNullOrWhiteSpace(name))
            {
                accountName.Text = "Not Found";
                transferSubmit.Enabled = false;
            }
            else
            {
                accountName.Text = name;
                transferSubmit.Enabled = true;
            }
            verify.Enabled = true;
        }

        private async void transferSubmit_Click(object sender, EventArgs e)
        {
            bool isValid = decimal.TryParse(amountTransfer.Text, out decimal amount);
            string name = await _serviceManager.AccountService
                .ValidateAccountNumber(accountNumber.Text);
            (bool status, string error) result;
            if (isValid && amount >= 50)
            {
                result = await _serviceManager.AccountService
                     .Transfer(_account.AccountNumber, accountNumber.Text, amount,
                     $"Transfer from {_account.FirstName} to {name}. Amount: {amount}", name);
            }
            else
            {
                errorTransfer.Text = "Invalid amount";
                errorTransfer.Visible = true;
                return;
            }
            if (!result.status)
            {
                errorTransfer.Text = result.error;
                errorTransfer.Visible = true;
            }
            else
            {
                MessageBox.Show($"Your transfer of {amount} to {name} is successful");
                transferPanel.Hide();
                dashboardPanel.Show();
                dashboardPanel.BringToFront();
            }
        }
    }
}