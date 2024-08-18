using Library.BLL.Services.Interfaces;
using Library.BLL.ViewModels;
using Microsoft.Win32;

namespace Library
{
    public partial class MainForm : Form
    {
        private UserVM? currentUser;
        private readonly IUserService _userService;
        private readonly IAuthService _authService;
        private readonly IBookService _bookService;

        public MainForm(IUserService userService, IAuthService authService, IBookService bookService)
        {
            InitializeComponent();
            currentUser = null;
            _userService = userService;
            _authService = authService;
            _bookService = bookService;

            StartPosition = FormStartPosition.CenterScreen;
        }

        private RegistryKey OpenRegistryKey()
        {
            var softwareKey = Registry.CurrentUser.OpenSubKey("Software", true);
            softwareKey ??= Registry.CurrentUser.CreateSubKey("Software", true);

            var libraryKey = softwareKey.OpenSubKey("Library", true);
            libraryKey ??= softwareKey.CreateSubKey("Library", true);

            return libraryKey;
        }

        private async void UpdateUserBooksList()
        {
            var books = await _bookService.GetBooksByUserIdAsync(Guid.Parse(currentUser.Id));
            currentUser.Books = books;
            dataGridViewUserBooks.DataSource = currentUser.Books;
        }

        private async Task AuthUserAsync()
        {
            if (currentUser == null)
            {
                var libraryKey = OpenRegistryKey();
                var userId = (string?)libraryKey.GetValue("uid");

                if (userId != null)
                {
                    currentUser = await _userService.GetUserByIdAsync(userId);

                    if (currentUser != null)
                    {
                        return;
                    }
                }


                var signInForm = new AuthForm(_authService);
                signInForm.ShowDialog();

                currentUser = signInForm.currentUser;

                if (currentUser == null)
                {
                    Close();
                }
                else
                {
                    libraryKey = OpenRegistryKey();
                    libraryKey.SetValue("uid", currentUser.Id);
                }
            }
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            await AuthUserAsync();

            labelUserEmail.Text = currentUser.Email;

            UpdateUserBooksList();
        }

        private async void buttonDeleteBook_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewUserBooks.SelectedRows[0];

            if (selectedRow != null)
            {
                var bookId = Guid.Parse(selectedRow.Cells["Id"].Value.ToString());
                await _userService.DeleteBookByUserAsync(Guid.Parse(currentUser.Id), bookId);
                UpdateUserBooksList();
            }
        }

        private void buttonAddNewBook_Click(object sender, EventArgs e)
        {
            var booksForm = new BooksForm(_bookService, _userService, Guid.Parse(currentUser.Id));
            booksForm.ShowDialog();
            UpdateUserBooksList();
        }
    }
}
