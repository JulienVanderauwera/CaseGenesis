using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CaseGenesis.Models
{
    public class AddressRequestModel
    {
        public Guid? IdAddress { get; set; }
        [Required]
        public string StreetName { get; set; }
        [Required]
        public string Number { get; set; }
        public string Box { get; set; }
        [Required]
        public string CityName { get; set; }
        [Required]
        public string ZipCode { get; set; }
        [Required]
        public string CountryName { get; set; }
        public bool IsHeadquarters { get; set; }
    }
}