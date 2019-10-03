using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaseGenesis.Areas.RelationArea.RequestModels
{
    public class RelationRequestModel
    {
        public Guid? IdRelation { get; set; }

        public Guid IdPhysicalPerson { get; set; }

        public Guid IdMoralPerson { get; set; }
    }
}