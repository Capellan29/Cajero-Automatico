using Cajero.Controllers;
using Cajero.Models;
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
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            User usr = new User
            {
                UserName = txtUser.Text,
                UserPasss = txtPass.Text
            };
            Controller cl = new Controller();
            cl.AgregarUsuario(usr);
            Close();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            new Home().Show();
            Close();
        }
    }
}
