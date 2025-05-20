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

        private void LogIn_Click(object sender, EventArgs e) // Až budu mít databázi, tak po kliknutí zkontroluje usery v databázi a jestli bude matchovat heslo tak ho pustí dál
        {

        }

        private void SignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new SignInForm().Show();
        }
    }
}
