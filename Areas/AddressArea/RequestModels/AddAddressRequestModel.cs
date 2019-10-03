using CaseGenesis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaseGenesis.Areas.AddressArea.RequestModels
{
    public class AddAddressRequestModel : AddressRequestModel
    {
        public Guid IdPerson { get; set; }
    }
}