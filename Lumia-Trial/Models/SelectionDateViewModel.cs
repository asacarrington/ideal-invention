using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lumia_Trial.DataAccess.DataEntites;

namespace Lumia_Trial.Models
{
    public class SelectionDateViewModel
    {
        public Guid SelectionDateId { get; set; }
        public List<SelectionDate> SelectionDates { get; set; }
    }
}