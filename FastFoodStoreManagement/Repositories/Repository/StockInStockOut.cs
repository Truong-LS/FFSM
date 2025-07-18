using DataAccessObject;
using Model;
using Models;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repository
{
    public class StockInStockOut : IStockInStockOut
    {
        public void AddStockLog(InventoryLog inv)
        {
            StockDAO.Instance.AddStockLog(inv);
        }

        public List<InventoryLogViewModel> GetAllLog()
        {
            return StockDAO.Instance.GetAllLog();
        }

        public List<Materials> GetAllMaterials()
        {
            return StockDAO.Instance.GetAllMaterials();
        }

        public List<Supplier> GetAllSuppliers()
        {
            return StockDAO.Instance.GetAllSuppliers();
        }
    }
}
