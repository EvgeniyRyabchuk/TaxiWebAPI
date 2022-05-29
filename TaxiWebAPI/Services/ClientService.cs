using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using TaxiWebAPI.Models.DTO;
using TaxiWebAPI.Models.DAL;
using TaxiWebAPI.Models.Entities;
using Mapster;

namespace TaxiWebAPI.Services
{
    public class ClientService
    {
        public async Task<ClienShortDTO> RegisterClient(AddClientDTO newClient)
        {
            Client clientToRegister = newClient.Adapt<Client>();

            Client registeredClient = await _DAL.Clients.Register(clientToRegister);

            return registeredClient.Adapt<ClienShortDTO>();
        }
    }
}