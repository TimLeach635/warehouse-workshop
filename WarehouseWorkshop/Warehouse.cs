namespace WarehouseWorkshop
{
    public class Warehouse
    {
        public Dictionary<Item, int> Stock { get; } = new Dictionary<Item, int>();

        public Warehouse(Dictionary<Item, int> initialStock)
        {
            Stock = initialStock;
        }
    }
}
