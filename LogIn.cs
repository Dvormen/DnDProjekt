namespace DnDProjekt
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
            PasswordBox.PasswordChar = '*';
            this.FormClosed += new FormClosedEventHandler(LogFormClosed);
        }
        private void LogFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            Ucet ucet = new Ucet(UsernameBox.Text, PasswordBox.Text);
            string res = ucet.logIn(ucet);
                MessageBox.Show(res);
            if (res.Equals("Pøihlášeno"))
            {
                Hide();
                new HomePage().Show();
            }   
        }

        private void SignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new SignInForm().Show();
        }
    }
}
