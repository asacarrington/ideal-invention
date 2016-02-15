using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using Lumia_Trial.DataAccess.Context;
using Lumia_Trial.DataAccess.entites;
using Lumia_Trial.Services.Interfaces;

namespace Lumia_Trial.Services
{
    public class RegionService : IRegionService
    {
        public RegionService()
        {
        }

        public IList<Region> GetAll()
        {
            using (var context = new LumiaContext())
            {
                return context.Regions.Where(x => x.IsEnabled).ToList();
            }
        }
        
    }
}