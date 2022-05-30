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
        public static class Orders
        {
            public static Order Add(Order newOrder)
            {
                using (var db = new TaxiDbContext())
                {
                    Client orderClient = db.Clients.Where(c => c.ClientID == newOrder.Client.ClientID).First();

                    newOrder.Client = orderClient;

                    db.Orders.Add(newOrder);
                    db.SaveChanges();

                    return newOrder;
                }
            }

            public static List<Order> All()
            {
                using (var db = new TaxiDbContext())
                {
                    return db.Orders.ToList();
                }
            }

            //public static Task<Client> ById(int id)
            //{
            //    using (var db = new TaxiDbContext())
            //    {
            //        Client clientById = null;

            //        IQueryable<Client> searchResult = db.Clients.Where(c => c.ClientID == id);

            //        if (searchResult.Any())
            //        {
            //            clientById = searchResult.First();
            //        }

            //        return Task.FromResult(clientById);
            //    }
            //}

            //public async static Task<bool> DeleteById(int id)
            //{
            //    int numberOfRecordsAffected = 0;

            //    using (var db = new TaxiDbContext())
            //    {
            //        Client clientToDelete = null;

            //        IQueryable<Client> searchResult = db.Clients.Where(c => c.ClientID == id);

            //        if (searchResult.Any())
            //        {
            //            clientToDelete = searchResult.First();

            //            db.Clients.Remove(clientToDelete);

            //            numberOfRecordsAffected = await db.SaveChangesAsync();
            //        }
            //    }

            //    return numberOfRecordsAffected > 0;
            //}

            //public static async Task<bool> Update(Client clientToUpdate)
            //{
            //    int numberOfRecordsAffected = 0;

            //    using (var db = new TaxiDbContext())
            //    {
            //        Client clientFromDb = null;

            //        IQueryable<Client> searchResult = db.Clients.Where(c => c.ClientID == clientToUpdate.ClientID);

            //        if (searchResult.Any())
            //        {
            //            clientFromDb = searchResult.First();

            //            clientFromDb.ClientName = clientToUpdate.ClientName;
            //            clientFromDb.ClientDateOfBirth = clientToUpdate.ClientDateOfBirth;
            //            clientFromDb.ClientAddress = clientToUpdate.ClientAddress;

            //            numberOfRecordsAffected = await db.SaveChangesAsync();
            //        }
            //    }

            //    return numberOfRecordsAffected > 0;
            //}
        }
    }

}