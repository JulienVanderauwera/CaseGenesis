using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseContact.Infra.Entities.Entities
{
    [Table(nameof(Relation))]
    public class Relation
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IdRelation{ get; set; }

        [ForeignKey(nameof(PersonSource))]
        [Index("ix_Relation", IsUnique = true, Order = 1)]
        public Guid IdPhysicalPerson{ get; set; }

        [ForeignKey(nameof(PersonTarget))]

        [Index("ix_Relation", IsUnique = true, Order = 2)]

        public Guid IdMoralePerson{ get; set; }

        public virtual PhysicalPerson PersonSource { get; set; }

        public virtual MoralPerson PersonTarget { get; set; }
    }
}
