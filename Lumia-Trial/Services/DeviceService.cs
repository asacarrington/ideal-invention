using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lumia_Trial.DataAccess.Context;
using Lumia_Trial.DataAccess.DataEntites;

namespace Lumia_Trial.Services
{
    public class DeviceService
    {
        public DeviceService()
        {
        }

        public IList<Device> GetAll(Guid regionGuid)
        {
            using (var context = new LumiaContext())
            {
                return context.Devices.Where(x => x.RegionId == regionGuid).ToList();
            }
        }
    }
}