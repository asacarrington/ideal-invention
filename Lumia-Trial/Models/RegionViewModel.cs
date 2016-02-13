using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lumia_Trial.DataAccess.entites;

namespace Lumia_Trial.Models
{
    public class RegionViewModel
    {
        public Guid RegionId { get; set; }
        public List<Region> Regions { get; set; }
    }
}