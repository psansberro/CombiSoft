using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CombiSoft.Models
{
    public class ChoferIndexContext : DbContext
    {
        public DbSet<ChoferModel> Choferes
        {
            get;
            set;
        }
    }

    public class ChoferDb
    {
        public static Dictionary<int, ChoferModel> Choferes = new Dictionary<int, ChoferModel>();
    }
}  