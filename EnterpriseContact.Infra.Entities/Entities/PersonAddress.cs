using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnterpriseContact.Infra.Entities
{
    [Table(nameof(PersonAddress))]
    public partial class PersonAddress
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IdPersonAddress { get; set; }


        [ForeignKey(nameof(Address))]
        [Index("ix_PersonAddress", IsUnique = true, Order = 1)]
        public Guid IdAddress { get; set; }

        [Index("ix_PersonAddress", IsUnique = true, Order = 3)]
        [ForeignKey(nameof(Person))]
        public Guid IdPerson { get; set; }
        public bool IsHeadquarters { get; set; }

        public virtual Person Person { get; set; }
        public virtual Address Address { get; set; }
    }
}
