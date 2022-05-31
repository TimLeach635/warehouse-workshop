namespace WarehouseWorkshop.Transactions
{
    public class Transaction
    {
        public Dictionary<Item, int> Items { get; }
        public DateTime DateTime { get; }
        public Account Buyer { get; }
        public Account Seller { get; }
        public string ModeOfPayment { get; }

        public Transaction(
            Dictionary<Item, int> items,
            DateTime dateTime,
            Account buyer,
            Account seller,
            string modeOfPayment
        ) {
            Items = items;
            DateTime = dateTime;
            Buyer = buyer;
            Seller = seller;
            ModeOfPayment = modeOfPayment;
        }
    }
}
