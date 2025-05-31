namespace DnDProjekt
{
    public partial class LogInForm : Form
    {
        /// <summary>
        /// Tato t��da pou�t� u�ivatele do zbytku aplikace
        /// </summary>
        public LogInForm()
        {
            InitializeComponent();
            PasswordBox.PasswordChar = '*';
            this.FormClosed += new FormClosedEventHandler(LogFormClosed);
        }

        /// <summary>
        /// Zav�e aplikaci pokud se zav�e forma
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// po kliknut� se p�ihl�s� u�ivatel a m��e pou�it aplikaci
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogIn_Click(object sender, EventArgs e)
        {
            Ucet ucet = new Ucet(UsernameBox.Text, PasswordBox.Text);
            string res = ucet.logIn(ucet);
                MessageBox.Show(res);
            if (res.Equals("P�ihl�eno"))
            {
                Hide();
                new HomePage().Show();
            }   
        }

        /// <summary>
        /// otev�e nov� okno
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
