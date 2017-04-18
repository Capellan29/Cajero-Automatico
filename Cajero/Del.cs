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
    public partial class Del : Form
    {
        DataModel db = new DataModel();
        public Del()
        {
            InitializeComponent();
        }

        private void Del_Load(object sender, EventArgs e)
        {
            var query = (from cl in db.Client
                select cl.Number
                );
            cmbCliente.DisplayMember = "Number";
            cmbCliente.DataSource = query.Distinct().ToList();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            string number = cmbCliente.SelectedItem.ToString();
            Client cliente = db.Client.Where(c => c.Number == number).Single();
            new Controller().EliminarCliente(cliente.ID);
            MessageBox.Show("El cliente ha sido eliminado correctamente.");
            Close();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            new Home().Show();
            Close();
        }
    }
}
    