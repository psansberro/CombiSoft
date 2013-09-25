using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CombiSoft.Models
{
    public class ClienteRepository : IClienteRepository
    {
        public List<Cliente> GetAll()
        {
            using (var context = new ClienteIndexContext())
            {
                return (from m in context.Clientes
                        select m).ToList();
            }
        }

        public List<Cliente> GetByName(string name)
        {
            using (var context = new ClienteIndexContext())
            {
                return (from m in context.Clientes
                        where m.Apellido.StartsWith(name)
                        select m).ToList();
            }
        }

        public Cliente GetById(int id)
        {
            using (var context = new ClienteIndexContext())
            {
                return (from m in context.Clientes
                        where m.Codigo == id
                        select m).SingleOrDefault();
            }
        }

        public void Create(Cliente cliente)
        {
            using (var context = new ClienteIndexContext())
            {
                context.Clientes.Add(cliente);

                context.SaveChanges();
            }
        }

        public void Update(Cliente cliente)
        {
            using (var context = new ClienteIndexContext())
            {
                context.Entry(cliente).State = EntityState.Modified;

                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = new ClienteIndexContext())
            {
                var cliente = context.Clientes.Find(id);
                context.Clientes.Remove(cliente);

                context.SaveChanges();
            }
        }
    }
}