using Cajero.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cajero.Controllers
{
    public class Controller
    {
        DataModel db = new DataModel();

        public void AgregarUsuario(User usuario)
        {
            db.User.Add(usuario);
            db.SaveChanges();
        }

        public void EliminarUsuario(int? id)
        {
            User usuario = db.User.Find(id);
            db.Entry(usuario).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public void AgregarCliente(Client cliente)
        {
            db.Client.Add(cliente);
            db.SaveChanges();
        }

        public void EliminarCliente(int? id)
        {
            Client cliente = db.Client.Find(id);
            db.Entry(cliente).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public void Depositar(string deposito, string cuenta)
        {
            var query = from c in db.Client
                        where c.Number == cuenta
                        select c;

            Client cliente = null;
            foreach (Client cl in query)
            {
                if (cl.Number == cuenta)
                {
                    cliente = cl;
                    break;
                }
            }

            if (cliente != null)
            {
                cliente.Saldo += Convert.ToInt16(deposito);
                db.Entry(cliente).State = EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Deposito realizado con exito", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nuermo de cuenta incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
