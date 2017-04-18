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
    public partial class Targeta : Form
    {
        public Targeta()
        {
            InitializeComponent();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if(txtCard.Text != "")
            {
                Client cl = new DataModel().Client.Where(c => c.Number == txtCard.Text).Single();
                if (cl == null)
                {
                    MessageBox.Show("Este nummero de tarjeta no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    new Pin(cl).Show();
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Por favor introduzca su numero de tarjeta");
                txtCard.Focus();
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            new Home().Show();
            Close();
        }
    }
}
