using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaseGenesis.Areas.AddressArea.RequestModels
{
    public class SetHeadquartersRequestModel 
    {
        public Guid IdPerson{ get; set; }
        public Guid IdAddress{ get; set; }
    }
}