using Models;
using DataAccessObject;

namespace DataAccessObject
{
    public class DiscountDAO
    {
        private readonly FastFoodManagermentSystemContext _context;

        public DiscountDAO()
        {
            _context = new FastFoodManagermentSystemContext();
        }

        public IEnumerable<Discount> GetAllDiscounts()
        {
            return _context.Discounts.ToList();
        }

        public Discount GetDiscountById(int discountId)
        {
            return _context.Discounts.Find(discountId);
        }

        public void AddDiscount(Discount discount)
        {
            // Manually generate a new unique DiscountId
            var maxId = _context.Discounts.Any() ? _context.Discounts.Max(d => d.DiscountId) : 0;
            discount.DiscountId = maxId + 1;

            _context.Discounts.Add(discount);
            _context.SaveChanges();
        }

        public void UpdateDiscount(Discount discount)
        {
            var existingDiscount = _context.Discounts.Find(discount.DiscountId);
            if (existingDiscount != null)
            {
                existingDiscount.Code = discount.Code;
                existingDiscount.StartDate = discount.StartDate;
                existingDiscount.EndDate = discount.EndDate;
                existingDiscount.Type = discount.Type;
                existingDiscount.Value = discount.Value;
                existingDiscount.IsActive = discount.IsActive;

                _context.SaveChanges();
            }
        }

        public void DeleteDiscount(int discountId)
        {
            var discount = _context.Discounts.Find(discountId);
            if (discount != null)
            {
                _context.Discounts.Remove(discount);
                _context.SaveChanges();
            }
        }
        public Discount GetDiscountByCode(string code)
        {
            return _context.Discounts.FirstOrDefault(d => d.Code == code);
        }
    }
}
