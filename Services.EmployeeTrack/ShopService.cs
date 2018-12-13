using System;
using System.Threading.Tasks;
using Persistence.Context;

namespace Services.EmployeeTrack
{
    public class ShopService : IShopService
    {
        private EyeeTrackDb db ;
        public async Task<Shop> GetShopById(int? id)
        {
            using (db = new EyeeTrackDb())
            {
                return await db.Shops.FindAsync(id);
            }
        }

        public bool DeleteShop(int id)
        {
            throw new NotImplementedException();
        }
    }
}