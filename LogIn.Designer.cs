namespace DnDProjekt
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
            DevButton = new Button();
            SuspendLayout();
            // 
            // LogIn
            // 
            LogIn.AccessibleName = "";
            LogIn.Location = new Point(177, 244);
            LogIn.Name = "LogIn";
            LogIn.Size = new Size(96, 23);
            LogIn.TabIndex = 0;
            LogIn.Text = "Log In";
            LogIn.UseVisualStyleBackColor = true;
            LogIn.Click += LogIn_Click;
            // 
            // SignIn
            // 
            SignIn.AccessibleName = "";
            SignIn.AutoSize = true;
            SignIn.LinkColor = Color.Black;
            SignIn.Location = new Point(205, 270);
            SignIn.Name = "SignIn";
            SignIn.Size = new Size(43, 15);
            SignIn.TabIndex = 1;
            SignIn.TabStop = true;
            SignIn.Text = "Sign In";
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
            Username.Location = new Point(111, 155);
            Username.Name = "Username";
            Username.Size = new Size(60, 15);
            Username.TabIndex = 4;
            Username.Text = "Username";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(114, 202);
            Password.Name = "Password";
            Password.Size = new Size(57, 15);
            Password.TabIndex = 5;
            Password.Text = "Password";
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Title.AutoSize = true;
            Title.Location = new Point(82, 40);
            Title.Name = "Title";
            Title.Size = new Size(253, 15);
            Title.TabIndex = 6;
            Title.Text = "Welcome to DnD Character and Dice Manager!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 55);
            label1.Name = "label1";
            label1.Size = new Size(317, 15);
            label1.TabIndex = 7;
            label1.Text = "Log In or Sign In to view and edit your characters and dices";
            // 
            // DevButton
            // 
            DevButton.Location = new Point(356, 288);
            DevButton.Name = "DevButton";
            DevButton.Size = new Size(75, 23);
            DevButton.TabIndex = 8;
            DevButton.Text = "DevButton";
            DevButton.UseVisualStyleBackColor = true;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 311);
            Controls.Add(DevButton);
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
            Text = "Manager";
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
        private Button DevButton;
    }
}
