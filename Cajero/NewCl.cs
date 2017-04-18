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
    public partial class NewCl : Form
    {
        public NewCl()
        {
            InitializeComponent();
        }

        private void NewCl_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Client cliente = new Client
            {
                Number = txtNum.Text,
                Pass = Convert.ToInt16(txtPass.Text),
                Saldo = Convert.ToDouble(txtSaldo.Text)
            };
            Controller controller = new Controller();
            controller.AgregarCliente(cliente);
            Close();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            new Home().Show();
            Close();
        }

        private void materialRaisedButton2_Click_1(object sender, EventArgs e)
        {
            new Home().Show();
            Close();
        }
    }
}
