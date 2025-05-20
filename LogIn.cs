namespace DnDProjekt
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
            PasswordBox.PasswordChar = '*';
        }

        private void LogIn_Click(object sender, EventArgs e) // Až budu mít databázi, tak po kliknutí zkontroluje usery v databázi a jestli bude matchovat heslo tak ho pustí dál
        {

        }

        private void SignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // Otevøe nové okno, kde se uživatel pøihlásí
        {
            this.Hide();
            new SignInForm().Show();
        }
    }
}
