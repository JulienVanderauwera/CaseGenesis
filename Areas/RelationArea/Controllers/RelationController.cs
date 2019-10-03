using AutoMapper;
using CaseGenesis.Areas.RelationArea.RequestModels;
using CaseGenesis.Extensions;
using EnterpriseContact.Domain.RelationManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CaseGenesis.Areas.RelationArea.Controllers
{
    public class RelationController : Controller
    {
        private readonly IRelationService _relationService;
        private readonly IMapper _mapper;

        public RelationController(IRelationService relationService, IMapper mapper)
        {
            _relationService = relationService;
            _mapper = mapper;
        }

        public ActionResult PingRelationController()
        {
            var model = "Ping";

            return Json(model, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult AddRelation(RelationRequestModel newRelation)
        {
            var result = false;
            this.HandleClientCall(() =>
            {
                var updateModel = _mapper.Map<RelationModel>(newRelation);
                result = _relationService.CreateRelation(updateModel);
            });
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult DeleteRelation(Guid idRelation)
        {
            var result = false;
            this.HandleClientCall(() =>
            {
                result = _relationService.DeleteRelation(idRelation);
            });
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}