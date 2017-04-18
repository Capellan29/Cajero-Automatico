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
    public partial class Pin : Form
    {
        Client client;
        public Pin(Client cliente)
        {
            client = cliente;
            InitializeComponent();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Agregar("1");
        }

        void Agregar(string numero)
        {
            txtPin.Text += numero;
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Agregar("2");
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            Agregar("3");
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            Agregar("4");
        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            Agregar("5");
        }

        private void materialRaisedButton6_Click(object sender, EventArgs e)
        {
            Agregar("6");
        }

        private void materialRaisedButton7_Click(object sender, EventArgs e)
        {
            Agregar("7");
        }

        private void materialRaisedButton8_Click(object sender, EventArgs e)
        {
            Agregar("8");
        }

        private void materialRaisedButton9_Click(object sender, EventArgs e)
        {
            Agregar("9");
        }

        private void materialRaisedButton11_Click(object sender, EventArgs e)
        {
            Agregar("0");
        }

        private void materialRaisedButton10_Click(object sender, EventArgs e)
        {
            if(txtPin.Text != "")
            {
                txtPin.Text = txtPin.Text.Substring(0, txtPin.TextLength - 1);
            }
        }

        private void materialRaisedButton12_Click(object sender, EventArgs e)
        {
            if(txtPin.Text == client.Pass.ToString())
            {
                new Opciones(client).Show();
                Close();
            }
            else
            {
                MessageBox.Show("Pin incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPin.Clear();
            }
        }
    }
}
