using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lumia_Trial.DataAccess.DataEntites
{
    public class HandsetOpotunity
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}