﻿namespace DnDProjekt
{
    partial class LogInForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LogIn = new Button();
            SignIn = new LinkLabel();
            PasswordBox = new TextBox();
            UsernameBox = new TextBox();
            Username = new Label();
            Password = new Label();
            Title = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // LogIn
            // 
            LogIn.AccessibleName = "";
            LogIn.Location = new Point(177, 244);
            LogIn.Name = "LogIn";
            LogIn.Size = new Size(96, 23);
            LogIn.TabIndex = 0;
            LogIn.Text = "Přihlásit se";
            LogIn.UseVisualStyleBackColor = true;
            LogIn.Click += LogIn_Click;
            // 
            // SignIn
            // 
            SignIn.AccessibleName = "";
            SignIn.AutoSize = true;
            SignIn.LinkColor = Color.Black;
            SignIn.Location = new Point(177, 270);
            SignIn.Name = "SignIn";
            SignIn.Size = new Size(90, 15);
            SignIn.TabIndex = 1;
            SignIn.TabStop = true;
            SignIn.Text = "Zaregistrovat se";
            SignIn.LinkClicked += SignIn_LinkClicked;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(177, 199);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(100, 23);
            PasswordBox.TabIndex = 2;
            // 
            // UsernameBox
            // 
            UsernameBox.Location = new Point(177, 152);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(100, 23);
            UsernameBox.TabIndex = 3;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(69, 155);
            Username.Name = "Username";
            Username.Size = new Size(102, 15);
            Username.TabIndex = 4;
            Username.Text = "Uživatelské jméno";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(134, 202);
            Password.Name = "Password";
            Password.Size = new Size(37, 15);
            Password.TabIndex = 5;
            Password.Text = "Heslo";
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Title.AutoSize = true;
            Title.Location = new Point(111, 40);
            Title.Name = "Title";
            Title.Size = new Size(220, 15);
            Title.TabIndex = 6;
            Title.Text = "Vítejte v DnD Manageru Postav a Kostek!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 55);
            label1.Name = "label1";
            label1.Size = new Size(166, 15);
            label1.TabIndex = 7;
            label1.Text = "Přihlašte se nebo se registrujte";
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 311);
            Controls.Add(label1);
            Controls.Add(Title);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(UsernameBox);
            Controls.Add(PasswordBox);
            Controls.Add(SignIn);
            Controls.Add(LogIn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LogInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LogIn;
        private LinkLabel SignIn;
        private TextBox PasswordBox;
        private TextBox UsernameBox;
        private Label Username;
        private Label Password;
        private Label Title;
        private Label label1;
    }
}
