using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Client/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Client
        public async Task<ClienShortDTO> Post([FromBody] AddClientDTO newClient)
        {
            return await _clientService.RegisterClient(newClient);
        }

        // PUT: api/Client/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Client/5
        public void Delete(int id)
        {
        }
    }
}
