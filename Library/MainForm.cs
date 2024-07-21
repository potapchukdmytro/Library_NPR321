using Library.DAL.Repositories.Interfaces;
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
    public partial class MainForm : Form
    {
        private readonly IUserRepository _userRepository;

        public MainForm(IUserRepository userRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var users = _userRepository.Users.ToArray();

            dataGridView1.DataSource = users;
        }
    }
}
