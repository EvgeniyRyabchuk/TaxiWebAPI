using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TaxiWebAPI.Models.Entities
{
    [Table("Clients")]
    public class Client
    {
        [Key]
        public int ClientID { get; set; }
        public string ClientName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public string ClientAddress { get; set; }
        public DateTime? ClientDateOfBirth { get; set; }
    }
}