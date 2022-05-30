using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiWebAPI.Models.DTO
{
    public class OrderDTO
    {
        public int OrderID { get; set; }

        public string FromAddress { get; set; }

        public string ToAddress { get; set; }

        public ClientShortDTO Client { get; set; }

        public DateTime OrderDateTime { get; set; }
    }
}