using AutoMapper;
using CaseGenesis.Areas.AddressArea.Models;
using CaseGenesis.Areas.EnterpriseArea.RequestModels;
using CaseGenesis.Areas.EnterpriseArea.ViewModels;
using CaseGenesis.Extensions;
using EnterpriseContact.Domain.EnterpriseManagement;
using System;
using System.Web.Mvc;

namespace CaseGenesis.Areas.EnterpriseArea.Controllers
{
    public class EnterpriseController : Controller
    {
        private readonly IEnterpriseService _enterpriseService;
        private readonly IMapper _mapper;

        public EnterpriseController(IEnterpriseService enterpriseService, IMapper mapper)
        {
            _enterpriseService = enterpriseService;
            _mapper = mapper;
        }

        public ActionResult PingEnterpriseController()
        {
            var model = "Ping";

            return Json(model, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Create(EnterpriseRequestModel model)
        {
            var result = false;
            this.HandleClientCall(() =>
            {
                var newContactModel = _mapper.Map<EnterpriseModel>(model);
                result = _enterpriseService.CreateEnterprise(newContactModel);
            });
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult Update(EnterpriseRequestModel model)
        {
            var result = false;
            this.HandleClientCall(() =>
            {
                var updateModel = _mapper.Map<EnterpriseModel>(model);
                result = _enterpriseService.UpdateEnterprise(updateModel);
            });
            return Json(result, JsonRequestBehavior.AllowGet);

        }
        [HttpPost]
        public ActionResult Delete(Guid idPerson)
        {
            var result = false;
            this.HandleClientCall(() =>
            {
                result = _enterpriseService.DeleteEnteprise(idPerson);
            });
            return Json(result, JsonRequestBehavior.AllowGet);
        } 
    }
}