using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CombiSoft.Models
{
    public class ClienteIndexContext : DbContext
    {
        public DbSet<ClienteModel> Clientes
        {
            get;
            set;
        }


        
    }
    public class ClienteDb
    {
        public static Dictionary<int, ClienteModel> Clientes = new Dictionary<int, ClienteModel>();
    }
}