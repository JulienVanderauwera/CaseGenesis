using CaseGenesis.Areas.AddressArea.Models;
using CaseGenesis.Areas.ContactArea.RequestModel;
using System;

namespace CaseGenesis.Areas.ContactArea.ViewModels
{
    public class ContactCreationViewModel
    {
        public Guid IdPerson { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string VATNumber { get; set; }
        public AddressViewModel Address {get;set;}
    }
}