using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseContact.Domain.Models
{
    public class AddressModel
    {
        public Guid IdAddress { get; set; }
        public string StreetName { get; set; }
        public string Number { get; set; }
        public string Box { get; set; }
        public string ZipCode { get; set; }
        public string CityName { get; set; }
        public string CountryName { get; set; }
        public bool IsHeadquarters { get; set; }
    }
}
