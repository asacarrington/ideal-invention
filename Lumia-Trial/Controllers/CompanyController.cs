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
        private IRegionService regionService;
        private ISelectionDateService selectionDateService;
        private ILumiaTrialFormDataService lumiaTrialFormDataService;


        public CompanyController(IRegionService regionService, ISelectionDateService selectionDateService, ILumiaTrialFormDataService lumiaTrialFormDataService)
        {
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
    }
}