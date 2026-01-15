namespace SmartwareHouse
{
    public class Electronics : IItem
    {
        public string Name { get; private set; }
        public int Quantity { get; private set; }
        public string Brand { get; private set; }

        public Electronics(string name, int quantity, string brand)
        {
            Name = name;
            Quantity = quantity;
            Brand = brand;
        }

        public void Display()
        {
            Console.WriteLine($"Electronics - Name: {Name}, Quantity: {Quantity}, Brand: {Brand}");
        }
    }
}