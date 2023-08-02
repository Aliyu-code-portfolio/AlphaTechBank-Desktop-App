using AlphaTechBank.Core.ServiceManager.Abstraction;
using AlphaTechBank.Model.Model;

namespace AlphaTechBank.UI
{
    public partial class Form1 : Form
    {
        private IServiceManager _serviceManager;
        User _user;
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

            if (string.IsNullOrWhiteSpace(firstname) || string.IsNullOrWhiteSpace(firstname) || string.IsNullOrWhiteSpace(phoneNumber) || isValidPin)
            {
                createAcctError.Text = "Invalid form inputs";
                createAcctError.Show();
                return;
            }
            Account account = await _serviceManager.AccountService.CreateAccount(_user.Id, firstname, lastname, _user.Email, PIN, phoneNumber, accountType);
            MessageBox.Show("Successfully created your account. Account Number: " + account.AccountNumber);
            createAccountPanel.Hide();
            dashboardPanel.Show();
            dashboardPanel.BringToFront();
        }
    }
}