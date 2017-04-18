using Cajero.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cajero
{
    public partial class Depositar : Form
    {
        Client cliente;
        public Depositar(Client client)
        {
            cliente = client;
            InitializeComponent();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if(txtMmonto.Text != "")
            {
                try
                {
                    cliente.Saldo += Convert.ToDouble(txtMmonto.Text);
                    DataModel db = new DataModel();
                    db.Entry(cliente).State = EntityState.Modified;
                    db.SaveChanges();
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor introduzca la cantidad que desea depositar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
