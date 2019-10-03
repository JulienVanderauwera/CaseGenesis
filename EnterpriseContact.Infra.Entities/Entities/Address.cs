using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnterpriseContact.Infra.Entities
{
    [Table(nameof(Address))]
    public class Address
    {
        public Address()
        {
            PersonAddresses = new HashSet<PersonAddress>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IdAddress { get; set; }

        [StringLength(800)]
        public string Number { get; set; }

        [StringLength(15)]
        public string Box { get; set; }

        [StringLength(800)]
        public string StreetName { get; set; }
        public string CityName{ get; set; }
        public string ZipCode{ get; set; }
        public string CountryName { get; set; }

        public virtual ICollection<PersonAddress> PersonAddresses { get; set; }
    }
}
