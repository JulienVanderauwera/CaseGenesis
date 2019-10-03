using AutoMapper;
using CaseGenesis.Areas.ContactArea.RequestModel;
using CaseGenesis.Areas.ContactArea.ViewModels;
using CaseGenesis.Extensions;
using EnterpriseContact.Domain.AddressManagement;
using EnterpriseContact.Domain.ContactManagement;
using System;
using System.Net;
using System.Web.Mvc;

namespace CaseGenesis.Areas.ContactArea.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }
        public ActionResult PingContactController()
        {
            var model = "Ping";

            return Json(model, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Create(ContactRequestModel model)
        {
            var result = false;
            this.HandleClientCall(() =>
            {
                var newContactModel = _mapper.Map<ContactModel>(model);
                result = _contactService.CreateContact(newContactModel);
            });
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult Update(ContactRequestModel model)
        {
            var result = false; 
            this.HandleClientCall(() =>
            {
                var updateModel = _mapper.Map<ContactModel>(model);
                result =  _contactService.UpdateContact(updateModel);
            });
            return Json(result, JsonRequestBehavior.AllowGet);

        }
        [HttpPost]
        public ActionResult Delete(Guid idPerson)
        {
            var result = false;
            this.HandleClientCall(() =>
            {
                result = _contactService.DeleteContact(idPerson);
            });
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}