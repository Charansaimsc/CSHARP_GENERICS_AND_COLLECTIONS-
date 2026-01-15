namespace OnlineMarketplace
{
    public static class DiscountService
    {
        public static void ApplyDiscount<T>(
            Product<T> product,
            double percentage
        ) where T : ICategory, new()
        {
            product.ApplyDiscount(percentage);
        }
    }
}
