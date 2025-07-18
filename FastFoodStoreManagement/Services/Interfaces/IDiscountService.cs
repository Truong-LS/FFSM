using Models;

namespace Services.Interfaces
{
    public interface IDiscountService
    {
        IEnumerable<Discount> GetAllDiscounts();
        Discount GetDiscountById(int discountId);
        void AddDiscount(Discount discount);
        void UpdateDiscount(Discount discount);
        void DeleteDiscount(int discountId);
        Discount GetDiscountByCode(string code);
    }
}
