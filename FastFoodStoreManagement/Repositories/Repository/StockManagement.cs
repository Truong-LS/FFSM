using DataAccessObject;
using Models;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repository
{
    public class StockManagement : IStockManagement
    {
        public List<Materials> GetAllMaterials()
        {
            return StockDAO.Instance.GetAllMaterials();
        }
    }
}
