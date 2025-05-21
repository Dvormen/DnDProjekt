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
    }
}
