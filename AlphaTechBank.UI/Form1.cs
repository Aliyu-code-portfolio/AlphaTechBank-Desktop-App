using AlphaTechBank.Core.ServiceManager.Abstraction;

namespace AlphaTechBank.UI
{
    public partial class Form1 : Form
    {
        private IServiceManager _serviceManager;
        public Form1(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
            InitializeComponent();
        }

        private async void registerButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;
            var result = await _serviceManager.AuthenticationService.RegisterUser(email, password);
            if (!result.status)
            {
                errorMessage.Text = result.error;
                errorMessage.Visible = true;
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

    }
}