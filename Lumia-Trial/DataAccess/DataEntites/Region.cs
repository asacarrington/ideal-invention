using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumia_Trial.DataAccess.entites
{
    public class Region
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public bool IsEnabled { get; set; }

    }
}
