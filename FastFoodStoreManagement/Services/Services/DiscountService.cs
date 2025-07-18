using Models;
using Repositories.Interfaces;
using Repositories.Repositories;
using Services.Interfaces;

namespace Services.Services
{
    public class DiscountService : IDiscountService
    {
        private readonly IDiscountRepository _discountRepository;

        public DiscountService()
        {
            _discountRepository = new DiscountRepository();
        }

        public IEnumerable<Discount> GetAllDiscounts()
        {
            return _discountRepository.GetAllDiscounts();
        }

        public Discount GetDiscountById(int discountId)
        {
            return _discountRepository.GetDiscountById(discountId);
        }

        public Discount GetDiscountByCode(string code)
        {
            return _discountRepository.GetDiscountByCode(code);
        }

        public void AddDiscount(Discount discount)
        {
            if (_discountRepository.GetDiscountByCode(discount.Code) != null)
            {
                throw new InvalidOperationException("Mã coupon ?ã t?n t?i.");
            }
            _discountRepository.AddDiscount(discount);
        }

        public void UpdateDiscount(Discount discount)
        {
            var existingDiscount = _discountRepository.GetDiscountById(discount.DiscountId);
            if (existingDiscount != null && existingDiscount.Code != discount.Code && _discountRepository.GetDiscountByCode(discount.Code) != null)
            {
                throw new InvalidOperationException("Mã coupon ?ã t?n t?i.");
            }
            _discountRepository.UpdateDiscount(discount);
        }

        public void DeleteDiscount(int discountId)
        {
            _discountRepository.DeleteDiscount(discountId);
        }

        public IEnumerable<Discount> SearchDiscountsByCode(string code)
        {
            return _discountRepository.GetAllDiscounts().Where(d => d.Code.ToLower().Contains(code.ToLower())).ToList();
        }
    }
}
