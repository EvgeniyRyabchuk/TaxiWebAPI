using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiWebAPI.Models.DTO
{
    public class AddOrderDTO
    {
        public string FromAddress { get; set; }

        public string ToAddress { get; set; }

        public string PhoneNumber { get; set; }

    }
}