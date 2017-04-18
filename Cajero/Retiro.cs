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
    public partial class Retiro : Form
    {
        Client cliente;
        public Retiro(Client client)
        {
            cliente = client;
            InitializeComponent();
        }

        private void Retirar(double monto)
        {
            if(monto <= cliente.Saldo)
            {
                cliente.Saldo -= monto;
                DataModel db = new DataModel();
                db.Entry(cliente).State = EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Su retiro ha sido completado con exito");
            }
            else
            {
                MessageBox.Show("La cantidad que desea retirar es mayor que su saldo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Close();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Retirar(2000);
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Retirar(1000);
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            Retirar(500);
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            Retirar(200);
        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            Retirar(100);
        }

        private void materialRaisedButton6_Click(object sender, EventArgs e)
        {
            Retirar(50);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
