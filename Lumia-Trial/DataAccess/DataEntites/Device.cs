using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Lumia_Trial.DataAccess.entites;

namespace Lumia_Trial.DataAccess.DataEntites
{
    public class Device
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public bool isEnabled { get; set; }

        public Guid RegionId { get; set; }

        [ForeignKey("RegionId")]
        public virtual Region Region { get; set; }

    }
}