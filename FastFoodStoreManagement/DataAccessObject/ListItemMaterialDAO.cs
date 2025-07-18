using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class ListItemMaterialDAO
    {
        private readonly FastFoodManagermentSystemContext _fastFoodDbContext;
        public ListItemMaterialDAO()
        {
            _fastFoodDbContext = new FastFoodManagermentSystemContext();
        }
        public List<ListItemMaterial> GetListItemMaterialByItemId(int itemId)
        {
            return _fastFoodDbContext.ListItemMaterials.Where(x => x.ItemId == itemId).ToList();
        }
    }
}
