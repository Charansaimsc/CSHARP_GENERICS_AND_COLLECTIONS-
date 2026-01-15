namespace SmartwareHouse
{
    public class Groceries : IItem
    {
        public string Name { get; private set; }
        public int Quantity { get; private set; }
        public string ExpiryDate { get; private set; }

        public Groceries(string name, int quantity, string expiryDate)
        {
            Name = name;
            Quantity = quantity;
            ExpiryDate = expiryDate;
        }

        public void Display()
        {
            Console.WriteLine($"Groceries - Name: {Name}, Quantity: {Quantity}, Expiry Date: {ExpiryDate}");
        }
    }
}