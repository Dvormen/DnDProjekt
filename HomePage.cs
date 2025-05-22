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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            FormClosed += new FormClosedEventHandler(hPClosed);
        }
        private void hPClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
