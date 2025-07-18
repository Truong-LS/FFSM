using Microsoft.EntityFrameworkCore.Query.Internal;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class DiscountsDAO
    {
        private readonly FastFoodManagermentSystemContext _fastFoodDbContext;
        public DiscountsDAO()
        {
            _fastFoodDbContext = new FastFoodManagermentSystemContext();
        }
        public Discount GetDiscountByCode(string code)
        {
            var discount = _fastFoodDbContext.Discounts
                .FirstOrDefault(d => d.Code == code && d.IsActive == true && d.StartDate <= DateTime.Now && d.EndDate >= DateTime.Now);
            if (discount != null)
            {
                return discount;
            }
            return null;
        }
        public bool UseDiscount(string code)
        {
            var discount = _fastFoodDbContext.Discounts
                .FirstOrDefault(d => d.Code == code && d.IsActive == true && d.StartDate <= DateTime.Now && d.EndDate >= DateTime.Now);
            
            if (discount != null)
            {
                discount.IsActive = false;
                _fastFoodDbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
