using Library.BLL.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class BooksForm : Form
    {
        private readonly IBookService _bookService;
        private readonly IUserService _userService;
        private Guid _userId;

        public BooksForm(IBookService bookService, IUserService userService, Guid userId)
        {
            InitializeComponent();

            _bookService = bookService;

            StartPosition = FormStartPosition.CenterParent;
            _userService = userService;
            _userId = userId;
        }

        private async void BooksForm_Load(object sender, EventArgs e)
        {
            var books = await _bookService.GetAllBooksAsync();
            dataGridViewLibraryBooks.DataSource = books;
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            var selectedRows = dataGridViewLibraryBooks.SelectedRows;
            
            List<Guid> booksId = new List<Guid>();

            foreach (DataGridViewRow row in selectedRows)
            {
                var id = Guid.Parse(row.Cells["Id"].Value.ToString());
                booksId.Add(id);
            }

            await _userService.AddBooksForUserAsync(_userId, booksId);

            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
