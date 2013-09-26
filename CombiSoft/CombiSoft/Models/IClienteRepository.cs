using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CombiSoft.Models
{
    interface IClienteRepository
    {
        List<ClienteModel> GetAll();

        List<ClienteModel> GetByName(string name);

        ClienteModel GetById(int id);

        void Create(ClienteModel cliente);

        void Update(ClienteModel cliente);

        void Delete(int id);
    }
}
