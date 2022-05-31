using WarehouseWorkshop.Transactions;

namespace WarehouseWorkshop
{
    public class Warehouse
    {
        public Dictionary<Item, int> Stock { get; } = new Dictionary<Item, int>();
        public Account Account { get; } = new Account();
        public List<Transaction> Transactions { get; } = new List<Transaction>();

        public Warehouse(Dictionary<Item, int> initialStock)
        {
            Stock = initialStock;
        }

        public void SellItems(Dictionary<Item, int> items, Account buyer, string modeOfPayment)
        {
            foreach (Item item in items.Keys)
            {
                if (!Stock.ContainsKey(item))
                {
                    throw new ArgumentOutOfRangeException("Attempted to buy an item that the warehouse does not stock");
                }

                if (Stock[item] < items[item])
                {
                    throw new ArgumentOutOfRangeException("Attempted to buy more of an item than the warehouse has in stock");
                }
            }

            decimal total = 0;

            foreach (Item item in items.Keys)
            {
                Stock[item] -= items[item];
                total += item.Price * items[item];
            }

            Account.Amount += total;
            buyer.Amount -= total;

            Transaction transaction = new Transaction(
                items,
                DateTime.Now,
                buyer,
                Account,
                modeOfPayment
            );

            Transactions.Add(transaction);
        }
    }
}
