namespace Library
{
    partial class AuthForm
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
            textBoxEmail = new TextBox();
            groupBoxEmail = new GroupBox();
            groupBoxPassword = new GroupBox();
            textBoxPassword = new TextBox();
            buttonSignIn = new Button();
            buttonToSignUp = new Button();
            groupBoxEmail.SuspendLayout();
            groupBoxPassword.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.Dock = DockStyle.Top;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(431, 79);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Логін";
            labelTitle.TextAlign = ContentAlignment.BottomCenter;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Dock = DockStyle.Fill;
            textBoxEmail.Location = new Point(3, 23);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(244, 27);
            textBoxEmail.TabIndex = 1;
            // 
            // groupBoxEmail
            // 
            groupBoxEmail.Controls.Add(textBoxEmail);
            groupBoxEmail.Location = new Point(87, 126);
            groupBoxEmail.Name = "groupBoxEmail";
            groupBoxEmail.Size = new Size(250, 56);
            groupBoxEmail.TabIndex = 2;
            groupBoxEmail.TabStop = false;
            groupBoxEmail.Text = "Email";
            // 
            // groupBoxPassword
            // 
            groupBoxPassword.Controls.Add(textBoxPassword);
            groupBoxPassword.Location = new Point(87, 206);
            groupBoxPassword.Name = "groupBoxPassword";
            groupBoxPassword.Size = new Size(250, 56);
            groupBoxPassword.TabIndex = 3;
            groupBoxPassword.TabStop = false;
            groupBoxPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Dock = DockStyle.Fill;
            textBoxPassword.Location = new Point(3, 23);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(244, 27);
            textBoxPassword.TabIndex = 1;
            // 
            // buttonSignIn
            // 
            buttonSignIn.Location = new Point(87, 292);
            buttonSignIn.Name = "buttonSignIn";
            buttonSignIn.Size = new Size(94, 29);
            buttonSignIn.TabIndex = 4;
            buttonSignIn.Text = "Увійти";
            buttonSignIn.UseVisualStyleBackColor = true;
            buttonSignIn.Click += buttonSignIn_Click;
            // 
            // buttonToSignUp
            // 
            buttonToSignUp.Location = new Point(187, 292);
            buttonToSignUp.Name = "buttonToSignUp";
            buttonToSignUp.Size = new Size(150, 29);
            buttonToSignUp.TabIndex = 5;
            buttonToSignUp.Text = "Зареєструватися";
            buttonToSignUp.UseVisualStyleBackColor = true;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 477);
            Controls.Add(buttonToSignUp);
            Controls.Add(buttonSignIn);
            Controls.Add(groupBoxPassword);
            Controls.Add(groupBoxEmail);
            Controls.Add(labelTitle);
            Name = "AuthForm";
            Text = "Вхід";
            Load += AuthForm_Load;
            groupBoxEmail.ResumeLayout(false);
            groupBoxEmail.PerformLayout();
            groupBoxPassword.ResumeLayout(false);
            groupBoxPassword.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelTitle;
        private TextBox textBoxEmail;
        private GroupBox groupBoxEmail;
        private GroupBox groupBoxPassword;
        private TextBox textBoxPassword;
        private Button buttonSignIn;
        private Button buttonToSignUp;
    }
}