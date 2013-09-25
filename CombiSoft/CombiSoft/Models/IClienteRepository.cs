using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CombiSoft.Models
{
    interface IClienteRepository
    {
        List<Cliente> GetAll();

        List<Cliente> GetByName(string name);

        Cliente GetById(int id);

        void Create(Cliente cliente);

        void Update(Cliente cliente);

        void Delete(int id);
    }
}
