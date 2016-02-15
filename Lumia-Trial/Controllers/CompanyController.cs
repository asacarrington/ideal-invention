using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using Lumia_Trial.Models;
using Lumia_Trial.Services.Interfaces;

namespace Lumia_Trial.Controllers
{
    public class CompanyController : Controller
    {
        private readonly IDeviceService deviceService;
        private readonly IRegionService regionService;
        private readonly ISelectionDateService selectionDateService;
        private readonly ILumiaTrialFormDataService lumiaTrialFormDataService;
     
        public CompanyController(IDeviceService deviceService, IRegionService regionService, ISelectionDateService selectionDateService, ILumiaTrialFormDataService lumiaTrialFormDataService)
        {
            this.deviceService = deviceService;
            this.regionService = regionService;
            this.selectionDateService = selectionDateService;
            this.lumiaTrialFormDataService = lumiaTrialFormDataService;
        }

        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Index(CompanyViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return View();
        }

        private void BuildViewModel(CompanyViewModel model)
        {
            model.Devices = this.deviceService.GetAll(new Guid()).ToList();
        }
    }
}