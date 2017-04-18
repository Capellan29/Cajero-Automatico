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
    public partial class Opciones : Form
    {
        Client cliente;
        public Opciones(Client client)
        {
            cliente = client;
            InitializeComponent();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su saldo actual es: $" + cliente.Saldo.ToString("#.##"), "Informaion de saldo",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            new Depositar(cliente).ShowDialog();
            WindowState = FormWindowState.Normal;
        }

        private void closed(object sender, FormClosedEventArgs e)
        {
            new Home().Show();
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            new Retiro(cliente).ShowDialog();
            WindowState = FormWindowState.Normal;
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            new Home().Show();
            Close();
        }
    }
}
