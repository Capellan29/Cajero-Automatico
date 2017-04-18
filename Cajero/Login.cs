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
    public partial class Login : Form
    {
        DataModel db = new DataModel();
        
        public Login()
        {
            InitializeComponent();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Close();
            Home hm = new Home();
            hm.Show();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() != "" || txtPass.Text.Trim() != "")
            {
                User usuario = db.User
                .Where(u => u.UserName == txtName.Text)
                .Single();

                if (usuario != null && usuario.UserPasss == txtPass.Text)
                {
                    new Panel().Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Datos incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Focus();
                }
            }
            else
            {
                MessageBox.Show("Ingresa tu informacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
            }
        }
    }
}
