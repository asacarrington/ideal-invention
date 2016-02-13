using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Web;

namespace Lumia_Trial.Models
{
    public class CompanyViewModel
    {

        public List<string> Countries { get; set; }

        public List<string> RefreshDate { get; set; }

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

        public string HandsetOpotunities { get; set; }

        public string HandsetRefreshDate { get; set; }

        public string CurrentHandsetProvider { get; set; }

        public string CurrentHandsetOperator { get; set; }

        public bool IsLumia950 { get; set; }

        public bool IsLumia640 { get; set; }

        public bool IsLumia650 { get; set; }

        public bool IsLumia950XL { get; set; }

        public bool IsLumia640XL { get; set; }

        public bool IsMicrosoftDisplayDock { get; set; }

        [Required]
        public bool IsTermsAcepted { get; set; }

        public bool IsSharedInformationAllowed { get; set; }

    }
}