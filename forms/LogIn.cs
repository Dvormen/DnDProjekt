namespace DnDProjekt
{
    public partial class LogInForm : Form
    {
        /// <summary>
        /// Tato tøída pouští uživatele do zbytku aplikace
        /// </summary>
        public LogInForm()
        {
            InitializeComponent();
            PasswordBox.PasswordChar = '*';
            this.FormClosed += new FormClosedEventHandler(LogFormClosed);
        }

        /// <summary>
        /// Zavøe aplikaci pokud se zavøe forma
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// po kliknutí se pøihlásí uživatel a mùže použit aplikaci
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// otevøe nové okno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new SignInForm().Show();
        }
    }
}
