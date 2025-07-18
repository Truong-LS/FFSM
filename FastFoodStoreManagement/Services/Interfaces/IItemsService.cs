using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IItemsService
    {
        List<Models.Item> GetAllItems();
        List<Item> SearchItems(string keyword);
        List<Item> GetItemsByCategory(int categoryId);
    }
}
