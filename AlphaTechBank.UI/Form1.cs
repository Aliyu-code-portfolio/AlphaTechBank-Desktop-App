using AlphaTechBank.Core.ServiceManager.Abstraction;

namespace AlphaTechBank.UI
{
    public partial class Form1 : Form
    {
        private IServiceManager _serviceManager;
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
            createAccountPanel.BringToFront();
        }

    }
}