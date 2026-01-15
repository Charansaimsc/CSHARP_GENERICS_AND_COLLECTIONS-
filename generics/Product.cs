using System;

namespace OnlineMarketplace
{
    public class Product<T> where T : ICategory, new()
    {
        public string Name { get; private set; }
        public double Price { get; private set; }

        private T category;

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
            category = new T();
        }

        public void ApplyDiscount(double percentage)
        {
            Price = Price - (Price * percentage / 100);
        }

        public void Display()
        {
            Console.WriteLine(
                category.Name + ": " + Name + ", Price: " + Price
            );
        }
    }
}
