using EnterpriseContact.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseContact.Domain.EnterpriseManagement
{
    public class EnterpriseModel : PersonModel
    {
        public string Name { get; set; }
        public bool IsHeadquarters { get; set; }
        public AddressModel Address{ get; set; }
    }
}
