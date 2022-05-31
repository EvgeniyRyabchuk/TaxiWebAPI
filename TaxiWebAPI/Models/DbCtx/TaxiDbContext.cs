using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using TaxiWebAPI.Models.Entities;

namespace TaxiWebAPI.Models.DbCtx
{
    public class TaxiDbContext : DbContext
    {
        public TaxiDbContext() : base("TaxiDb") { }  

        public DbSet<Client> Clients { get; set; }
    }
}