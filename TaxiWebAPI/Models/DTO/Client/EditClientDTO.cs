using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiWebAPI.Models.DTO
{
    public class EditClientDTO
    {
        public int ClientID { get; set; }
        public string ClientName { get; set; }
        public string ClientAddress { get; set; }
        public DateTime? ClientDateOfBirth { get; set; }
    }
}