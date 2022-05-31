using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TaxiWebAPI.Models.DTO;
using TaxiWebAPI.Services;

namespace TaxiWebAPI.Controllers
{
    public class OrdersController : ApiController
    {
        private readonly OrderService _orderService;

        public OrdersController()
        {
            _orderService = new OrderService();
        }

        // GET: api/Orders
        public IEnumerable<OrderDTO> Get()
        {
            return _orderService.GetAll();
        }

        // GET: api/Orders/5
        public OrderDTO Get(int id)
        {
            return _orderService.GetByID(id);
        }

        // POST: api/Orders
        public OrderDTO Post([FromBody] AddOrderDTO newOrder)
        {
            return _orderService.Add(newOrder);
        }

        // DELETE: api/Orders/5
        public bool Delete(int id)
        {
            return _orderService.Delete(id);
        }
    }
}
