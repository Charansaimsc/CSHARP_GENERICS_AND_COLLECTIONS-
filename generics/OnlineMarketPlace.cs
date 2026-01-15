namespace OnlineMarketplace
{
    public static class MarketplaceApp
    {
        public static void Run()
        {
            Product<BookCategory> book =
                new Product<BookCategory>("C# in Depth", 500);

            Product<ClothingCategory> shirt =
                new Product<ClothingCategory>("T-Shirt", 1000);

            DiscountService.ApplyDiscount(book, 10);
            DiscountService.ApplyDiscount(shirt, 20);

            book.Display();
            shirt.Display();
        }
    }
}
