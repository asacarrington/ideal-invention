﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lumia_Trial.DataAccess.Context;
using Lumia_Trial.DataAccess.DataEntites;
using Lumia_Trial.Services.Interfaces;

namespace Lumia_Trial.Services
{
    public class DeviceService : IDeviceService
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