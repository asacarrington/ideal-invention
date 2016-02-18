using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lumia_Trial.Models
{
    public class DeviceViewModel
    {
        public string Name { get; set; }

        public Guid Id { get; set; }

        public bool Checked { get; set; }

        public bool Enabled { get; set; }
    }
}