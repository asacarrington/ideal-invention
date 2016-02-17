using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
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
        [DisplayName("Contact Name")]
        public string ContactName { get; set; }

        [Required]
        [DisplayName("Email Address")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        public string EmailAddress { get; set; }

        [Required]
        [DisplayName("Address")]
        public string Address { get; set; }

        [Required]
        public string Number { get; set; }

        [Required]
        [DisplayName("Postcode")]
        public string PostCode { get; set; }

        [Required]
        [DisplayName("Job Title")]
        public string JobTitle  { get; set; }

        [Required]
        [DisplayName("Company Name")]
        public string CompanyName { get; set; }

        [DisplayName("Handset Opotunities")]

        public List<HandsetOpotunity> HandsetOpotunities { get; set; }

        [DisplayName("Handset Opotunities")]
        public Guid HandsetOpotunitiesId { get; set; }
  
        [DisplayName("Handset Refresh Date")]
        public string HandsetRefreshDate { get; set; }

        [DisplayName("Current Handset Provider")]
        public string CurrentHandsetProvider { get; set; }

        [DisplayName("Currenct Handset Operator")]
        public string CurrentHandsetOperator { get; set; }
        
        [Required]
        [DisplayName("Accept Terms")]
        public bool IsTermsAcepted { get; set; }

        [DisplayName("Allow Data To Be Shared")]
        public bool IsSharedInformationAllowed { get; set; }

        public TimeFrame TimeFrame { get; set; }

    }
}