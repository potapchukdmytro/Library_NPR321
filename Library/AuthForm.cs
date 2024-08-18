using Library.BLL.Services.Interfaces;
using Library.BLL.ViewModels;

namespace Library
{
    public partial class AuthForm : Form
    {
        private readonly IAuthService _authService;
        public UserVM? currentUser;

        public AuthForm(IAuthService authService)
        {
            InitializeComponent();

            _authService = authService;
            currentUser = null;

            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {

        }

        private async void buttonSignIn_Click(object sender, EventArgs e)
        {
            var model = new SignInVM
            {
                Email = textBoxEmail.Text,
                Password = textBoxPassword.Text
            };

            if(string.IsNullOrEmpty(model.Email) || string.IsNullOrEmpty(model.Password))
            {
                return;
            }

            var res = await _authService.SignInAsync(model);

            if(res.Success)
            {
                currentUser = (UserVM?)res.Payload;
                Close();
            }
            else
            {
                MessageBox.Show(res.Message, "error");
            }
        }
    }
}
