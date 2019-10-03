using CaseGenesis.Areas.AddressArea.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace CaseGenesis.Areas.EnterpriseArea.ViewModels
{
    public class EnterpriseViewModel 
    {
        [Required]
        public AddressViewModel address { get; set; }
        [Required]
        public string Name { get; set; }
        public Guid IdPerson{ get; set; }
    }
}