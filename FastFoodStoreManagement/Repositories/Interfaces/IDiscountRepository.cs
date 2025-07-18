using Models;

namespace Repositories.Interfaces
{
    public interface IDiscountRepository
    {
        IEnumerable<Discount> GetAllDiscounts();
        Discount GetDiscountById(int discountId);
        void AddDiscount(Discount discount);
        void UpdateDiscount(Discount discount);
        void DeleteDiscount(int discountId);
        Discount GetDiscountByCode(string code);
    }
}
