namespace DnDProjekt
{
    partial class SignInForm
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
            SignIn = new Button();
            Title = new Label();
            username = new TextBox();
            password = new TextBox();
            passwordCheck = new TextBox();
            UsernameL = new Label();
            PasswordL = new Label();
            PasswordCheckL = new Label();
            LoginLink = new LinkLabel();
            SuspendLayout();
            // 
            // SignIn
            // 
            SignIn.Location = new Point(164, 205);
            SignIn.Name = "SignIn";
            SignIn.Size = new Size(87, 23);
            SignIn.TabIndex = 1;
            SignIn.Text = "Sign In";
            SignIn.UseVisualStyleBackColor = true;
            SignIn.Click += SignIn_Click;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Location = new Point(143, 23);
            Title.Name = "Title";
            Title.Size = new Size(108, 15);
            Title.TabIndex = 2;
            Title.Text = "Zde se zaregistrujte";
            // 
            // username
            // 
            username.Location = new Point(159, 67);
            username.Name = "username";
            username.Size = new Size(100, 23);
            username.TabIndex = 3;
            // 
            // password
            // 
            password.Location = new Point(159, 114);
            password.Name = "password";
            password.Size = new Size(99, 23);
            password.TabIndex = 4;
            // 
            // passwordCheck
            // 
            passwordCheck.Location = new Point(158, 155);
            passwordCheck.Name = "passwordCheck";
            passwordCheck.Size = new Size(100, 23);
            passwordCheck.TabIndex = 5;
            // 
            // UsernameL
            // 
            UsernameL.AutoSize = true;
            UsernameL.Location = new Point(45, 70);
            UsernameL.Name = "UsernameL";
            UsernameL.Size = new Size(102, 15);
            UsernameL.TabIndex = 6;
            UsernameL.Text = "Uživatelské jméno";
            // 
            // PasswordL
            // 
            PasswordL.AutoSize = true;
            PasswordL.Location = new Point(110, 117);
            PasswordL.Name = "PasswordL";
            PasswordL.Size = new Size(37, 15);
            PasswordL.TabIndex = 7;
            PasswordL.Text = "Heslo";
            // 
            // PasswordCheckL
            // 
            PasswordCheckL.AutoSize = true;
            PasswordCheckL.Location = new Point(73, 158);
            PasswordCheckL.Name = "PasswordCheckL";
            PasswordCheckL.Size = new Size(74, 15);
            PasswordCheckL.TabIndex = 8;
            PasswordCheckL.Text = "Znovu Heslo";
            // 
            // LoginLink
            // 
            LoginLink.AutoSize = true;
            LoginLink.LinkColor = Color.Black;
            LoginLink.Location = new Point(170, 248);
            LoginLink.Name = "LoginLink";
            LoginLink.Size = new Size(81, 15);
            LoginLink.TabIndex = 9;
            LoginLink.TabStop = true;
            LoginLink.Text = "Už máte účet?";
            LoginLink.LinkClicked += LoginLink_LinkClicked;
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 289);
            Controls.Add(LoginLink);
            Controls.Add(PasswordCheckL);
            Controls.Add(PasswordL);
            Controls.Add(UsernameL);
            Controls.Add(passwordCheck);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(Title);
            Controls.Add(SignIn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SignInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SignIn;
        private Label Title;
        private TextBox username;
        private TextBox password;
        private TextBox passwordCheck;
        private Label UsernameL;
        private Label PasswordL;
        private Label PasswordCheckL;
        private LinkLabel LoginLink;
    }
}