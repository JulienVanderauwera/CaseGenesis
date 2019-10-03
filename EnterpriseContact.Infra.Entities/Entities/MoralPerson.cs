using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnterpriseContact.Infra.Entities
{
    [Table(nameof(MoralPerson))]
    public class MoralPerson : Person
    {
        [Required]
        [StringLength(100)]
        [Index("ix_MoralPerson", IsUnique = true, Order = 1)]
        public string Name { get; set; }
    }
}
