using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Web;
using Lumia_Trial.DataAccess.DataEntites;
using Lumia_Trial.DataAccess.entites;

namespace Lumia_Trial.Models
{
    public class CompanyViewModel
    {

        public Guid RegionGuid { get; set; }

        public Guid SelectedDateGuid { get; set; }

        public List<SelectionDate> RefreshDates { get; set; }

        public List<Device> Devices { get; set; }

        [Required]
        public string ContactName { get; set; }

        [Required]
        public string EmailAddress { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Number { get; set; }

        [Required]
        public string PostCode { get; set; }

        [Required]
        public string JobTitle  { get; set; }

        [Required]
        public string CompanyName { get; set; }

        public List<HandsetOpotunity> HandsetOpotunities { get; set; }

        public Guid HandsetOpotunitiesId { get; set; }

        public string HandsetRefreshDate { get; set; }

        public string CurrentHandsetProvider { get; set; }

        public string CurrentHandsetOperator { get; set; }
        
        [Required]
        public bool IsTermsAcepted { get; set; }

        public bool IsSharedInformationAllowed { get; set; }

        public TimeFrame TimeFrame { get; set; }

    }
}