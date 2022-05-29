using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using TaxiWebAPI.Models.DbCtx;
using TaxiWebAPI.Models.Entities;

namespace TaxiWebAPI.Models.DAL
{
    public static partial class _DAL
    {
        public static class Clients
        {
            public static async Task<Client> Register(Client newClient)
            {
                using (var db = new TaxiDbContext())
                {
                    db.Clients.Add(newClient);
                    await db.SaveChangesAsync();

                    return newClient;
                }
            }
        }
    }
}