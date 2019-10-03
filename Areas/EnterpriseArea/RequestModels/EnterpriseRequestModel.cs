using CaseGenesis.Areas.AddressArea.RequestModels;
using CaseGenesis.Models;
using System.ComponentModel.DataAnnotations;

namespace CaseGenesis.Areas.EnterpriseArea.RequestModels
{
    public class EnterpriseRequestModel : PersonRequestModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string VATNumber { get; set; }
    }
}