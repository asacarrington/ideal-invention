using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lumia_Trial.Models;
using Lumia_Trial.Services.Interfaces;

namespace Lumia_Trial.Controllers
{
    public class SelectionDateController : Controller
    {
        private readonly IRegionService regionService;
        private readonly ISelectionDateService selectionDateService;
        private readonly ILumiaTrialFormDataService lumiaTrialFormDataService;
        private readonly ITimeFrameService timeFrameService;


        public SelectionDateController(ITimeFrameService timeFrameService, IRegionService regionService, ISelectionDateService selectionDateService, ILumiaTrialFormDataService lumiaTrialFormDataService)
        {
            this.regionService = regionService;
            this.timeFrameService = timeFrameService;
            this.selectionDateService = selectionDateService;
            this.lumiaTrialFormDataService = lumiaTrialFormDataService;
        }

        public ActionResult Index(Guid regionId)
        {
            var model = new SelectionDateViewModel();
            model.RegionId = regionId;
            this.BuildViewModel(model, regionId);

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(SelectionDateViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return RedirectToAction("First", "Company", new { regionGuid = model.RegionId, selectionDateGuid = model.SelectionDateId });
        }

        private void BuildViewModel(SelectionDateViewModel model, Guid regionId)
        {
            model.SelectionDates = this.selectionDateService.GetAll(regionId).ToList();
            model.TimeFrame = this.timeFrameService.Get(regionId);
        }
    }
}