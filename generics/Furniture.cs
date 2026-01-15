namespace SmartwareHouse
{
    public class Furniture : IItem
    {
        public string Name { get; private set; }
        public int Quantity { get; private set; }
        public string Material { get; private set; }

        public Furniture(string name, int quantity, string material)
        {
            Name = name;
            Quantity = quantity;
            Material = material;
        }

        public void Display()
        {
            Console.WriteLine($"Furniture - Name: {Name}, Quantity: {Quantity}, Material: {Material}");
        }
    }
}