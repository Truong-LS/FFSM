using DataAccessObject;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
    public interface IDiscountsRepository
    {
        Discount GetDiscountByCode(string code);
        bool UseDiscount(string code);
    }
}
