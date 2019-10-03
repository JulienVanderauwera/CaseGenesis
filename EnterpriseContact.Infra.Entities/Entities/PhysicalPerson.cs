using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnterpriseContact.Infra.Entities
{
    [Table(nameof(PhysicalPerson))]
    public class PhysicalPerson : Person
    {
        [Required]
        [StringLength(100)]
        [Index("ix_PhysicalPerson", IsUnique = true, Order = 1)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        [Index("ix_PhysicalPerson", IsUnique = true, Order = 2)]
        public string LastName { get; set; }
    }
}
