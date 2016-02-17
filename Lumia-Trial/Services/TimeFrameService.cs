using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lumia_Trial.DataAccess.Context;
using Lumia_Trial.DataAccess.DataEntites;
using Lumia_Trial.Services.Interfaces;

namespace Lumia_Trial.Services
{
    public class TimeFrameService : ITimeFrameService
    {
        public TimeFrameService()
        {
        }

        public TimeFrame Get(Guid regionId)
        {
            using (var context = new LumiaContext())
            {
                return context.TimeFrames.FirstOrDefault(x => x.RegionId == regionId);
            }
        }

    }
}
    