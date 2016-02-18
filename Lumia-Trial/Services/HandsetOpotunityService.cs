using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lumia_Trial.DataAccess.Context;
using Lumia_Trial.DataAccess.DataEntites;
using Lumia_Trial.Services.Interfaces;

namespace Lumia_Trial.Services
{
    public class HandsetOpotunityService : IHandsetOpotunitiesService
    {
        public HandsetOpotunityService()
        {
        }
        public IList<HandsetOpotunity> GetAll()
        {
            using (var context = new LumiaContext())
            {
                return context.HandsetOpotunitieses.ToList();
            }
        }
        
        public HandsetOpotunity Get(Guid opotunityGuid)
        {
            using (var context = new LumiaContext())
            {
                return context.HandsetOpotunitieses.FirstOrDefault(x => x.Id == opotunityGuid);
            }
        }
    }
}