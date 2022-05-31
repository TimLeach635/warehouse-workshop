using WarehouseWorkshop.Transactions;

namespace WarehouseWorkshop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Item apple = new Item("apple", 0.75m, "groceries");
            Item pear = new Item("pear", 1.50m, "groceries");
            Item ps4 = new Item("playstation 4", 200m, "entertainment");
            Item megaDrive = new Item("sega mega drive", 30m, "entertainment");
            Item ratm = new Item("rage against the machine anniversary edition", 10m, "music");

            Warehouse warehouse = new Warehouse(
                new Dictionary<Item, int>
                {
                    { apple, 50 },
                    { pear, 20 },
                    { ps4, 4 },
                    { megaDrive, 10 },
                    { ratm, 30 },
                }
            );

            Console.WriteLine("Stock to begin:");
            foreach (Item item in warehouse.Stock.Keys)
            {
                Console.WriteLine($"\tThere are {warehouse.Stock[item]} of item \"{item.Name}\" at £{item.Price} each");
            }

            Account tim = new Account(300);
            Account jemma = new Account(300);

            warehouse.SellItems(
                new Dictionary<Item, int>
                {
                    { ratm, 1 },
                    { apple, 6 },
                },
                tim,
                "cash"
            );

            warehouse.SellItems(
                new Dictionary<Item, int>
                {
                    { ps4, 1 },
                    { pear, 2 },
                },
                jemma,
                "card"
            );

            Console.WriteLine("Stock after purchases:");
            foreach (Item item in warehouse.Stock.Keys)
            {
                Console.WriteLine($"\tThere are {warehouse.Stock[item]} of item \"{item.Name}\" at £{item.Price} each");
            }

            Console.WriteLine($"Tim now has £{tim.Amount}");
            Console.WriteLine($"Jemma now has £{jemma.Amount}");

            Console.WriteLine("Warehouse transactions list:");
            foreach (Transaction transaction in warehouse.Transactions)
            {
                Console.WriteLine($"\tTransaction made at {transaction.DateTime}");
            }
        }
    }
}
