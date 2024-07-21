using Library.BLL.Services.Interfaces;

namespace Library
{
    public partial class MainForm : Form
    {
        private readonly IUserService _userService;

        public MainForm(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            var users = await _userService.GetAllUsersAsync();

            dataGridView1.DataSource = users;
        }
    }
}
