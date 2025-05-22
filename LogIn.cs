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

        private void LogIn_Click(object sender, EventArgs e) // A� budu m�t datab�zi, tak po kliknut� zkontroluje usery v datab�zi a jestli bude matchovat heslo tak ho pust� d�l
        {
            Ucet ucet = new Ucet(UsernameBox.Text, PasswordBox.Text);
            if (ucet.logIn(ucet)) 
            {
                Hide();
                new HomePage().Show();
            }
            else 
            {
                Title.Text = "�patn� login nebo heslo";
            }
        }

        private void SignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new SignInForm().Show();
        }
    }
}
