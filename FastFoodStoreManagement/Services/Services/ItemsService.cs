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
    public class ItemsService : IItemsService
    {
        private readonly IItemsRepository _itemsRepository;
        public ItemsService()
        {
            _itemsRepository = new ItemRepository();
        }
        public List<Item> GetAllItems()
        {
            var items = _itemsRepository.GetAllItems();
            if(items == null)
            {
                return new List<Item>();
            }
            return items;
        }
        public List<Item> SearchItems(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                return new List<Item>();
            }
            return _itemsRepository.SearchItems(keyword);
        }
        public List<Item> GetItemsByCategory(int categoryId)
        {
            if (categoryId <= 0)
            {
                return new List<Item>();
            }
            var items = _itemsRepository.GetItemsByCategory(categoryId);
            if (items == null)
            {
                return new List<Item>();
            }
            return items;
        }
    }
}
