namespace WarehouseWorkshop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Warehouse warehouse = new Warehouse(
                new Dictionary<Item, int>
                {
                    { new Item("apple", 0.75m, "groceries"), 50 },
                    { new Item("pear", 1.50m, "groceries"), 20 },
                    { new Item("playstation 4", 200m, "entertainment"), 4 },
                    { new Item("sega mega drive", 30m, "entertainment"), 10 },
                    { new Item("rage against the machine anniversary edition", 10m, "music"), 30 },
                }
            );

            foreach (Item item in warehouse.Stock.Keys)
            {
                Console.WriteLine($"There are {warehouse.Stock[item]} of item \"{item.Name}\" at £{item.Price} each");
            }
        }
    }
}
