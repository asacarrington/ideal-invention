using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lumia_Trial.DataAccess.DataEntites;

namespace Lumia_Trial.Services.Interfaces
{
    public interface IHandsetOpotunitiesService
    {
        IList<HandsetOpotunity> GetAll();
    }
}
