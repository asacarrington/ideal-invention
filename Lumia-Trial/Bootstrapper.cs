using System.Web.Mvc;
using Lumia_Trial.Services;
using Lumia_Trial.Services.Interfaces;
using Microsoft.Practices.Unity;
using Unity.Mvc3;

namespace Lumia_Trial
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<IRegionService, RegionService>();
            container.RegisterType<ISelectionDateService, SelectionDateService>();
            container.RegisterType<ILumiaTrialFormDataService, LumiaTrialFormDataService>();
            container.RegisterType<IEmailService, Services.EmailService>();
            container.RegisterType<ITimeFrameService, TimeFrameService>();
            container.RegisterType<IDeviceService, DeviceService>();
            container.RegisterType<IHandsetOpotunitiesService, HandsetOpotunityService>();

            return container;
        }
    }
}