using BLSeguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BLFacturacionSB
{
    public class ClientesBL
    {
        contexto _contexto;
        public BindingList<Cliente> ListaCliente { get; set; }

        public ClientesBL()
        {

            _contexto = new contexto();
            ListaCliente = new BindingList<Cliente>();

        }

        public BindingList<Cliente> ObtenerClientes()
        {
            _contexto.cliente.Load();
            ListaCliente = _contexto.cliente.Local.ToBindingList();




            return ListaCliente;
        }

        public bool GuardarCliente(Cliente cliente)
        {
            _contexto.SaveChanges();
            return true;
        }


        public void AgregarCliente()
        {
            var nuevoCliente = new Cliente();
            ListaCliente.Add(nuevoCliente);

        }

        public bool EliminarCliente(int id)
        {
            foreach (var cliente in ListaCliente)
            {
                if (cliente.Id == id)
                {
                    ListaCliente.Remove(cliente);
                    _contexto.SaveChanges();
                    return true;
                   }
                }
                
                    return false;
            }
    }
    
      
    public class Cliente
    {
        public int Id { get; set; }
        public string RazonSocial { get; set; }
        public string RtnCliente  { get; set; }
        public string TipoCliente { get; set; }
        public string TermPago { get; set; }
        public string Nombrecont { get; set; }
        public string Puesto { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public bool Activo { get; set; }
    }
  }

