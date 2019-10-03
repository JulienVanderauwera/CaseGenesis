using AutoMapper;
using CaseGenesis.Areas.AddressArea.RequestModels;
using CaseGenesis.Extensions;
using CaseGenesis.Models;
using EnterpriseContact.Domain.AddressManagement;
using EnterpriseContact.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CaseGenesis.Areas.AddressArea.Controllers
{
    public class AddressController : Controller
    {
        private readonly IAddressService _addressService;
        private readonly IMapper _mapper;

        public AddressController(IAddressService addressService, IMapper mapper)
        {
            _addressService = addressService;
            _mapper = mapper;
        }

        public ActionResult PingAddressController()
        {
            var model = "Ping";

            return Json(model, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult AddAddressToPerson(AddAddressRequestModel model)
        {
                var result = false;
                this.HandleClientCall(() =>
                {
                    var addressModel = _mapper.Map<AddressModel>(model);
                    result = _addressService.AddAddressToEnterprise(addressModel,  model.IdPerson);
                });
                return Json(result, JsonRequestBehavior.AllowGet);           
        }

        [HttpPost]
        public ActionResult UpdateAddress(AddressRequestModel model)
        {
            var result = false;
            this.HandleClientCall(() =>
            {
                var addressModel = _mapper.Map<AddressModel>(model);
                result = _addressService.UpdateAddress(addressModel);
            });
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult SetAsHeadquarters(SetHeadquartersRequestModel model)
        {
            var result = false;
            this.HandleClientCall(() =>
            {
                result = _addressService.SetAsHeadquarters(model.IdAddress, model.IdPerson);
            });
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}