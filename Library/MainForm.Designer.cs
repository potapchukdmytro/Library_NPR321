namespace Library
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelUserEmail = new Label();
            dataGridViewUserBooks = new DataGridView();
            buttonAddNewBook = new Button();
            buttonDeleteBook = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUserBooks).BeginInit();
            SuspendLayout();
            // 
            // labelUserEmail
            // 
            labelUserEmail.Dock = DockStyle.Top;
            labelUserEmail.Location = new Point(0, 0);
            labelUserEmail.Name = "labelUserEmail";
            labelUserEmail.Size = new Size(1028, 25);
            labelUserEmail.TabIndex = 1;
            labelUserEmail.Text = "label1";
            labelUserEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dataGridViewUserBooks
            // 
            dataGridViewUserBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUserBooks.Dock = DockStyle.Top;
            dataGridViewUserBooks.Location = new Point(0, 25);
            dataGridViewUserBooks.MultiSelect = false;
            dataGridViewUserBooks.Name = "dataGridViewUserBooks";
            dataGridViewUserBooks.RowHeadersWidth = 51;
            dataGridViewUserBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUserBooks.Size = new Size(1028, 439);
            dataGridViewUserBooks.TabIndex = 2;
            // 
            // buttonAddNewBook
            // 
            buttonAddNewBook.Location = new Point(12, 470);
            buttonAddNewBook.Name = "buttonAddNewBook";
            buttonAddNewBook.Size = new Size(118, 48);
            buttonAddNewBook.TabIndex = 3;
            buttonAddNewBook.Text = "Додати нову книгу";
            buttonAddNewBook.UseVisualStyleBackColor = true;
            buttonAddNewBook.Click += buttonAddNewBook_Click;
            // 
            // buttonDeleteBook
            // 
            buttonDeleteBook.Location = new Point(146, 470);
            buttonDeleteBook.Name = "buttonDeleteBook";
            buttonDeleteBook.Size = new Size(118, 48);
            buttonDeleteBook.TabIndex = 4;
            buttonDeleteBook.Text = "Видалити книгу";
            buttonDeleteBook.UseVisualStyleBackColor = true;
            buttonDeleteBook.Click += buttonDeleteBook_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 530);
            Controls.Add(buttonDeleteBook);
            Controls.Add(buttonAddNewBook);
            Controls.Add(dataGridViewUserBooks);
            Controls.Add(labelUserEmail);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUserBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label labelUserEmail;
        private DataGridView dataGridViewUserBooks;
        private Button buttonAddNewBook;
        private Button buttonDeleteBook;
    }
}