using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaxiWebAPI.Models.DTO;
using Mapster;
using TaxiWebAPI.Models.Entities;
using TaxiWebAPI.Models.DAL;

namespace TaxiWebAPI.Services
{
    public class OrderService
    {
        public IEnumerable<OrderDTO> GetAll()
        {
            List<Order> allOrders = _DAL.Orders.All();

            return allOrders.Adapt<List<OrderDTO>>();
        }

        internal OrderDTO GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public OrderDTO Add(AddOrderDTO newOrderDTO)
        {
            Order orderToAdd = newOrderDTO.Adapt<Order>();

            Client orderClient = (_DAL.Clients.ByPhoneNumber(newOrderDTO.PhoneNumber)).Result;

            if (orderClient == null)
                orderClient = (_DAL.Clients.Register(new Client { PhoneNumber = newOrderDTO.PhoneNumber })).Result;

            orderToAdd.Client = new Client { ClientID = orderClient.ClientID };

            orderToAdd.OrderDateTime = DateTime.Now;

            Order addedOrder = _DAL.Orders.Add(orderToAdd);

            return addedOrder.Adapt<OrderDTO>();
        }

        internal bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}