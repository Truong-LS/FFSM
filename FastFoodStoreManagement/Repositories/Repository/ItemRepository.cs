using DataAccessObject;
using Models;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class ItemRepository : IItemsRepository
    {
        private readonly ItemsDAO _itemsDAO;
        public ItemRepository()
        {
            _itemsDAO = new ItemsDAO();
        }
        public List<Item> GetAllItems()
        {
            return _itemsDAO.GetAllItems();
        }
        public List<Item> SearchItems(string keyword)
        {
            return _itemsDAO.SearchItems(keyword);
        }
        public List<Item> GetItemsByCategory(int categoryId)
        {
            return _itemsDAO.GetItemsByCategory(categoryId);
        }
    }
}
