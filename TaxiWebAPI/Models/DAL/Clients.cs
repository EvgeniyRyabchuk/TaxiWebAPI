using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using TaxiWebAPI.Models.DbCtx;
using TaxiWebAPI.Models.DTO;
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

            public static Task<Client> ByPhoneNumber(string phoneNumber)
            {
                using (var db = new TaxiDbContext())
                {
                    Client clientByPhoneNumber = null;

                    IQueryable<Client> searchResult = db.Clients.Where(c => c.PhoneNumber == phoneNumber);

                    if (searchResult.Any())
                    {
                        clientByPhoneNumber = searchResult.First();
                    }

                    return Task.FromResult(clientByPhoneNumber);
                }
            }

            public static Task<List<Client>> All()
            {
                using (var db = new TaxiDbContext())
                {
                    return Task.FromResult(db.Clients.ToList());
                }
            }

            public static Task<Client> ById(int id)
            {
                using (var db = new TaxiDbContext())
                {
                    Client clientById = null;

                    IQueryable<Client> searchResult = db.Clients.Where(c => c.ClientID == id);

                    if (searchResult.Any())
                    {
                        clientById = searchResult.First();
                    }

                    return Task.FromResult(clientById);
                }
            }

            public async static Task<bool> DeleteById(int id)
            {
                int numberOfRecordsAffected = 0;

                using (var db = new TaxiDbContext())
                {
                    Client clientToDelete = null;

                    IQueryable<Client> searchResult = db.Clients.Where(c => c.ClientID == id);

                    if (searchResult.Any())
                    {
                        clientToDelete = searchResult.First();

                        db.Clients.Remove(clientToDelete);

                        numberOfRecordsAffected = await db.SaveChangesAsync();
                    }
                }

                return numberOfRecordsAffected > 0;
            }

            public static async Task<bool> Update(Client clientToUpdate)
            {
                int numberOfRecordsAffected = 0;

                using (var db = new TaxiDbContext())
                {
                    Client clientFromDb = null;

                    IQueryable<Client> searchResult = db.Clients.Where(c => c.ClientID == clientToUpdate.ClientID);

                    if (searchResult.Any())
                    {
                        clientFromDb = searchResult.First();

                        clientFromDb.ClientName = clientToUpdate.ClientName;
                        clientFromDb.ClientDateOfBirth = clientToUpdate.ClientDateOfBirth;
                        clientFromDb.ClientAddress = clientToUpdate.ClientAddress;

                        numberOfRecordsAffected = await db.SaveChangesAsync();
                    }
                }

                return numberOfRecordsAffected > 0;
            }
        }
    }
}