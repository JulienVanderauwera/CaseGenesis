using EnterpriseContact.Infra.Entities;
using EnterpriseContact.Infra.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseContact.Infra.Repositories
{
    public class EnterpriseContactDBContext : DbContext
    {
        public EnterpriseContactDBContext()
          : base("name=EnterpriseContactConnectionString")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<EnterpriseContactDBContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<MoralPerson> MoralPerson { get; set; }        
        public virtual DbSet<PhysicalPerson> PhysicalPerson { get; set; }
        public virtual DbSet<PersonAddress> PersonAddress { get; set; }
        public virtual DbSet<Relation> Relation { get; set; }

        public DbContext DbContext => this;
    }
}
