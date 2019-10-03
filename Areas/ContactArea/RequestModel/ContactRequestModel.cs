using CaseGenesis.Areas.AddressArea.RequestModels;
using CaseGenesis.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace CaseGenesis.Areas.ContactArea.RequestModel
{
    public class ContactRequestModel : PersonRequestModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string VATNumber { get; set; }

    }
}