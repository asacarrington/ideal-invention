using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Lumia_Trial.DataAccess.entites;

namespace Lumia_Trial.DataAccess.DataEntites
{
    public class SelectionDate
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime Selection { get; set; }

        public Guid RegionId { get; set; }

        [ForeignKey("RegionId")]
        public virtual Region Region { get; set; }

    }
}