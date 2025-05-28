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
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
            password.PasswordChar = '*';
            passwordCheck.PasswordChar = '*';
            FormClosed += new FormClosedEventHandler(SignClosed);
        }
        private void SignClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new LogInForm().Show();
        }

        private void SignIn_Click(object sender, EventArgs e)// heslo nesmí být nic
        {
            string jmeno = username.Text;
            string heslo = password.Text;
            string heslok = passwordCheck.Text;
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
