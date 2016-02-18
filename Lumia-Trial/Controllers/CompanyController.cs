using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using Lumia_Trial.DataAccess.DataEntites;
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
        private readonly ITimeFrameService timeFrameService;
        private readonly IHandsetOpotunitiesService handsetOpotunitiesService;
        private readonly IEmailService emailService;
        private CompanyViewModel companyViewModel;

        public CompanyController(IEmailService emailService, IHandsetOpotunitiesService handsetOpotunitiesService, ITimeFrameService timeFrameService, IDeviceService deviceService, IRegionService regionService, ISelectionDateService selectionDateService, ILumiaTrialFormDataService lumiaTrialFormDataService)
        {
            this.deviceService = deviceService;
            this.regionService = regionService;
            this.selectionDateService = selectionDateService;
            this.lumiaTrialFormDataService = lumiaTrialFormDataService;
            this.timeFrameService = timeFrameService;
            this.handsetOpotunitiesService = handsetOpotunitiesService;
            this.emailService = emailService;
            this.companyViewModel = new CompanyViewModel();
        }

        public ActionResult First(Guid regionGuid, Guid selectionDateGuid)
        {
            this.companyViewModel = new CompanyViewModel();
            this.companyViewModel.RegionGuid = regionGuid;
            this.companyViewModel.SelectedDateGuid = selectionDateGuid;

            BuildViewModel(this.companyViewModel);

            return View(this.companyViewModel);
        }

        [HttpPost]
        public ActionResult First(CompanyViewModel model)
        {
            if (!ModelState.IsValid)
            {
                BuildViewModel(model);
                return View(model);
            }

            this.companyViewModel = model;
            BuildViewModel(this.companyViewModel);
          
            return View("Second", this.companyViewModel);
        }

        public ActionResult FormComplete(Guid regionGuid)
        {
            var model = new CompanyFormCompleteViewModel();
            model.TimeFrame = this.timeFrameService.Get(regionGuid);
       
            return View(model);
        }

        [HttpPost]
        public ActionResult Second(CompanyViewModel model)
        {
            if (!ModelState.IsValid)
            {
                BuildViewModel(model);
                return View(model);
            }

            model.SelectedRegionName = regionService.Get(model.RegionGuid).Name;
            model.SelectionDateName = selectionDateService.Get(model.SelectedDateGuid).Selection.ToShortDateString();
            model.SelectedHandsetOpotunityName = this.handsetOpotunitiesService.Get(model.HandsetOpotunitiesId).Name;

            //this.emailService.Send(model);
            return RedirectToAction("FormComplete", new { regionGuid = model.RegionGuid});
        }

        private void BuildViewModel(CompanyViewModel model)
        {
            model.TimeFrame = this.timeFrameService.Get(model.RegionGuid);
            model.Devices = this.deviceService.GetAll(model.RegionGuid).Select(x => new DeviceViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Enabled = x.isEnabled,
                Checked = false
            }).ToList();
            model.HandsetOpotunities = this.handsetOpotunitiesService.GetAll().ToList();
            model.SelectedHandsetRefreshDate = this.selectionDateService.Get(model.SelectedDateGuid).Selection.ToLongDateString();
        }
    }
}