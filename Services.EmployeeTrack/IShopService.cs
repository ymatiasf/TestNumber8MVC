using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistence.Context;

namespace Services.EmployeeTrack
{
    public interface IShopService
    {
        Task<Shop> GetShopById(int? id);
        bool DeleteShop(int id);

    }
}
