namespace SmartwareHouse
{
    public class Storage<T> where T : IItem
    {
        private List<T> items;

        public Storage()
        {
            items = new List<T>();
        }

        public void AddItem(T item)
        {
            items.Add(item);
            Console.WriteLine($"Added item: {item.Name}, Quantity: {item.Quantity}");
        }

        public void DisplayItems()
        {
            Console.WriteLine("Items in Storage:");
            foreach (var item in items)
            {
                item.Display();
            }
        }
    }
}