using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDProjekt
{
    /// <summary>
    /// Třída, která dělá nové učivatele a přidává je do databáze
    /// </summary>
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
            password.PasswordChar = '*';
            passwordCheck.PasswordChar = '*';
            FormClosed += new FormClosedEventHandler(SignClosed);
        }
        /// <summary>
        /// tato metoda po zavření formy zavře celou aplikaci
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Tato metoda otevře novej form log in a schodá tento form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new LogInForm().Show();
        }


        /// <summary>
        /// tato metoda zkontroluje jestli jsou uživatelovy přihlašovací údaje validní a přidá ho do databáze
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignIn_Click(object sender, EventArgs e)
        {
            string jmeno = username.Text;
            string heslo = password.Text;
            string heslok = passwordCheck.Text;
            if (heslo.Equals("")) 
            {
                MessageBox.Show("Heslo nesmí být prázdné");
            }
            else 
            {
            
            if(heslo.Equals(heslok))
            {
                Ucet ucet = new Ucet(jmeno,heslo);
                if (!ucet.pridat(ucet)) 
                {
                    MessageBox.Show("Toto uživatelské jméno již existuje");
                }
                else
                {
                    MessageBox.Show("Uživatel přidán");
                    Hide();
                    new LogInForm().Show();
                }
            }
            else
            {
                MessageBox.Show("Hesla se neshodují");
            }
            }
            
        }
    }
}
