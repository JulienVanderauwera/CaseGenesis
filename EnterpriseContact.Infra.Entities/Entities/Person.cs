using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnterpriseContact.Infra.Entities
{
    [Table(nameof(Person))]
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IdPerson { get; set; }

        public string VATNumber { get; set; }
    }
}
