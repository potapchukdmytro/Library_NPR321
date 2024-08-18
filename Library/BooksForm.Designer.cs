namespace Library
{
    partial class BooksForm
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
            labelTitle = new Label();
            dataGridViewLibraryBooks = new DataGridView();
            buttonAdd = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLibraryBooks).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.Dock = DockStyle.Top;
            labelTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(1102, 45);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Наша бібліотека";
            labelTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridViewLibraryBooks
            // 
            dataGridViewLibraryBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLibraryBooks.Dock = DockStyle.Top;
            dataGridViewLibraryBooks.Location = new Point(0, 45);
            dataGridViewLibraryBooks.Name = "dataGridViewLibraryBooks";
            dataGridViewLibraryBooks.RowHeadersWidth = 51;
            dataGridViewLibraryBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLibraryBooks.Size = new Size(1102, 437);
            dataGridViewLibraryBooks.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(12, 488);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(106, 56);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Додати";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(153, 488);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(106, 56);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Скасувати";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // BooksForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 548);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewLibraryBooks);
            Controls.Add(labelTitle);
            Name = "BooksForm";
            Text = "BooksForm";
            Load += BooksForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLibraryBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelTitle;
        private DataGridView dataGridViewLibraryBooks;
        private Button buttonAdd;
        private Button buttonCancel;
    }
}