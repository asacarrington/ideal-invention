﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lumia_Trial.DataAccess.Context;
using Lumia_Trial.DataAccess.DataEntites;
using Lumia_Trial.Services.Interfaces;

namespace Lumia_Trial.Services
{
    public class SelectionDateService : ISelectionDateService
    {
        public SelectionDateService()
        {
        }

        public IEnumerable<SelectionDate> GetAll(Guid regionGuid)
        {
            using (var context = new LumiaContext())
            {
                return context.SelectionDates.Where(x => x.RegionId == regionGuid).ToList();
            }
        }

        public SelectionDate Get(Guid selectedDateGuid)
        {
            using (var context = new LumiaContext())
            {
                return context.SelectionDates.FirstOrDefault(x => x.Id == selectedDateGuid);
            }
        }
    }
}