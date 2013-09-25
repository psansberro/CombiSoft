using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CombiSoft.Models
{
    public class ClienteIndexContext : DbContext
    {
        public DbSet<Cliente> Clientes
        {
            get;
            set;
        }
    }
}