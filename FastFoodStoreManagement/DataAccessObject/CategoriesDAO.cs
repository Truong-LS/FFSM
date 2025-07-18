
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class CategoriesDAO
    {
        private readonly FastFoodManagermentSystemContext _fastFoodDbContext;
        public CategoriesDAO()
        {
            _fastFoodDbContext = new FastFoodManagermentSystemContext();
        }
        public List<Category> GetAllCategories()
        {
            return _fastFoodDbContext.Categories.ToList();
        }
    }
}
