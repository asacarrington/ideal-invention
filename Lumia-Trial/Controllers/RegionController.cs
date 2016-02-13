using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lumia_Trial.Models;
using Lumia_Trial.Services.Interfaces;

namespace Lumia_Trial.Controllers
{
    public class RegionController : Controller
    {
        private readonly IRegionService regionService;
        private readonly ISelectionDateService selectionDateService;
        private readonly ILumiaTrialFormDataService lumiaTrialFormDataService;


        public RegionController(IRegionService regionService, ISelectionDateService selectionDateService, ILumiaTrialFormDataService lumiaTrialFormDataService)
        {
            this.regionService = regionService;
            this.selectionDateService = selectionDateService;
            this.lumiaTrialFormDataService = lumiaTrialFormDataService;
        }

        public ActionResult Index()
        {
            var model = new RegionViewModel();
            this.BuildViewModel(model);

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(RegionViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return View();
        }

        private void BuildViewModel(RegionViewModel model)
        {
            model.Regions = this.regionService.GetAll().ToList();
        }
    }
}