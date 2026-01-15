/*Smart Warehouse Management System
o Concepts: Generic Classes, Constraints, Variance
o Problem Statement: Develop a warehouse system that manages
different types of items (Electronics, Groceries, Furniture).
o Hints:
▪ Create an abstract class WarehouseItem that all items
extend (Electronics, Groceries, Furniture).
▪ Implement a generic class Storage<T> where T :
WarehouseItem to store items safely.
▪ Implement a method to display all items using List<T>.*/

namespace SmartwareHouse
{
    public static class SmartWareHouses
    {
        public static void Run()
        {
            // Create storage for Electronics
            Storage<Electronics> electronicsStorage = new Storage<Electronics>();
            electronicsStorage.AddItem(new Electronics("Laptop", 10, "Dell"));
            electronicsStorage.AddItem(new Electronics("Smartphone", 20, "Samsung"));

            // Create storage for Furniture
            Storage<Furniture> furnitureStorage = new Storage<Furniture>();
            furnitureStorage.AddItem(new Furniture("Chair", 15, "Wood"));
            furnitureStorage.AddItem(new Furniture("Table", 5, "Metal"));

            // Display items in Electronics storage
            Console.WriteLine("\nElectronics Storage:");
            electronicsStorage.DisplayItems();

            // Display items in Furniture storage
            Console.WriteLine("\nFurniture Storage:");
            furnitureStorage.DisplayItems();
        }
    }
}
