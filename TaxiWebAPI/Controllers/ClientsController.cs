using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using TaxiWebAPI.Models.DTO;
using TaxiWebAPI.Services;

namespace TaxiWebAPI.Controllers
{
    public class ClientsController : ApiController
    {
        private readonly ClientService _clientService;

        public ClientsController()
        {
            _clientService = new ClientService(); 
        }

        // GET: api/Client
        public async Task<List<ClientShortDTO>> Get()
        {
            return await _clientService.GetAll();
        }

        // GET: api/Client/5
        public async Task<ClientShortDTO> Get(int id)
        {
            return await _clientService.GetById(id);
        }

        // POST: api/Client
        public async Task<ClientShortDTO> Post([FromBody] AddClientDTO newClient)
        {
            return await _clientService.RegisterClient(newClient);
        }

        // PUT: api/Client/5
        public async Task<bool> Put([FromBody] EditClientDTO clientToUpdate)
        {
            return await _clientService.UpdateClient(clientToUpdate);
        }

        // DELETE: api/Client/5
        public async Task<bool> Delete(int id)
        {
            return await _clientService.DeleteClientById(id);
        }
    }
}
