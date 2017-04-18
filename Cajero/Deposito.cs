using Cajero.Controllers;
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
    public partial class Deposito : Form
    {
        public Deposito()
        {
            InitializeComponent();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Controller c = new Controller();
            c.Depositar(txtDeop.Text, txtNum.Text);
            Close();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            new Home().Show();
            Close();
        }
    }
}
