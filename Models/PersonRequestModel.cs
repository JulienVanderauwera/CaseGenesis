using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaseGenesis.Models
{
    public class PersonRequestModel : AddressRequestModel
    {
        public Guid? IdPerson { get; set; }        
    }
}