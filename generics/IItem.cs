namespace SmartwareHouse
{
    public interface IItem
    {
        string Name { get; }
        int Quantity { get; }

        void Display();
    }
}