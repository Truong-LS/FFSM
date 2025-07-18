using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class ItemsDAO
    {
        private readonly FastFoodManagermentSystemContext _fastFoodDbContext;
        public ItemsDAO()
        {
            _fastFoodDbContext = new FastFoodManagermentSystemContext();
        }
        public List<Item> GetAllItems()
        {
            return _fastFoodDbContext.Items.ToList();
        }
        public List<Item> SearchItems(string keyword)
        {
            return _fastFoodDbContext.Items
                .Where(item => item.Name.Contains(keyword))
                .ToList();
        }
        public List<Item> GetItemsByCategory(int categoryID)
        {
            return _fastFoodDbContext.Items
                .Where(item => item.CategoryId == categoryID)
                .ToList();
        }
    }
}
