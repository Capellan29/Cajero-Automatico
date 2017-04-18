using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cajero
{
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; 
            new NewCl().ShowDialog();
            WindowState = FormWindowState.Normal;
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            new Deposito().ShowDialog();
            WindowState = FormWindowState.Normal;
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            new NewUser().ShowDialog();
            WindowState = FormWindowState.Normal;
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            new Del().ShowDialog();
            WindowState = FormWindowState.Normal;
        }

        private void Panel_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Home().Show();
        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            new Home().Show();
            Close();
        }
    }
}
