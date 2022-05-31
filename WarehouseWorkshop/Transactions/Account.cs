namespace WarehouseWorkshop.Transactions
{
    public class Account
    {
        public decimal Amount { get; set; }

        public Account()
        {
            Amount = 0;
        }

        public Account(decimal initialAmount)
        {
            Amount = initialAmount;
        }
    }
}
