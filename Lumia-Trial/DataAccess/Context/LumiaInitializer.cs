using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lumia_Trial.DataAccess.DataEntites;
using Lumia_Trial.DataAccess.entites;

namespace Lumia_Trial.DataAccess.Context
{
    public class LumiaInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<LumiaContext>
    {
        protected override void Seed(LumiaContext context)
        {
            var regions = new List<Region>
            {
                new Region{Id = Guid.NewGuid(), Name = "spain", IsEnabled = true},
                new Region{Id = Guid.NewGuid(), Name = "england", IsEnabled = true},
                new Region{Id = Guid.NewGuid(), Name = "usa", IsEnabled = true},
                new Region{Id = Guid.NewGuid(), Name = "mexico", IsEnabled = false}
            };

            regions.ForEach(s => context.Regions.Add(s));
            context.SaveChanges();

            var devices = new List<Device>
            {
                new Device{Id = Guid.NewGuid(), Name = "L1", RegionId = regions[0].Id, isEnabled = true},
                new Device{Id = Guid.NewGuid(), Name = "L2", RegionId = regions[0].Id, isEnabled = true},
                new Device{Id = Guid.NewGuid(), Name = "L3", RegionId = regions[0].Id, isEnabled = true},
                new Device{Id = Guid.NewGuid(), Name = "L4", RegionId = regions[0].Id, isEnabled = false}
            };
            devices.ForEach(s => context.Devices.Add(s));
            context.SaveChanges();

            var selectionDates = new List<SelectionDate>
            {
                new SelectionDate{Id = Guid.NewGuid(),RegionId = regions[0].Id, Selection = DateTime.Now},
                new SelectionDate{Id = Guid.NewGuid(),RegionId = regions[0].Id, Selection = DateTime.Now},
                new SelectionDate{Id = Guid.NewGuid(),RegionId = regions[0].Id, Selection = DateTime.Now},
                new SelectionDate{Id = Guid.NewGuid(),RegionId = regions[0].Id, Selection = DateTime.Now}
            };
            selectionDates.ForEach(s => context.SelectionDates.Add(s));
            context.SaveChanges();


            var timeFrames = new List<TimeFrame>
            {
                new TimeFrame(){Id = Guid.NewGuid(),RegionId = regions[0].Id, DayCount = 2},
                new TimeFrame(){Id = Guid.NewGuid(),RegionId = regions[0].Id, DayCount = 2},
                new TimeFrame(){Id = Guid.NewGuid(),RegionId = regions[0].Id, DayCount = 2},
                new TimeFrame(){Id = Guid.NewGuid(),RegionId = regions[0].Id, DayCount = 2}
            };
            timeFrames.ForEach(s => context.TimeFrames.Add(s));
            context.SaveChanges();
        }
    }
}