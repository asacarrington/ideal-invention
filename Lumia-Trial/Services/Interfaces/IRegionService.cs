using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lumia_Trial.DataAccess.entites;

namespace Lumia_Trial.Services.Interfaces
{
    public interface IRegionService
    {
        IEnumerable<Region> GetAll();
    }
}
