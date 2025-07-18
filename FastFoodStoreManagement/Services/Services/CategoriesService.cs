using Models;
using Repositories.Interfaces;
using Repositories.Repositories;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class CategoriesService : ICategoriesService
    {
        private readonly ICategoriesRepository _categoriesRepository;
        public CategoriesService()
        {
            _categoriesRepository = new CategoriesRepository();
        }
        public List<Category> GetAllCategories()
        {
            var categories = _categoriesRepository.GetAllCategories();
            if (categories == null)
            {
                return new List<Category>();
            }
            else
            {
                return categories;
            }
        }
    }
}
