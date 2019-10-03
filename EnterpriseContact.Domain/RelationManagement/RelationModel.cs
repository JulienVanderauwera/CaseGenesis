using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseContact.Domain.RelationManagement
{
    public class RelationModel
    {
        public Guid? IdRelation { get; set; }

        public Guid IdPhysicalPerson { get; set; }

        public Guid IdMoralPerson { get; set; }
    }
}
