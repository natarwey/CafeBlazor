namespace CafeBlazor.ApiRequest.Model
{
    public class OrderDetails
    {
        public int Id { get; set; }
        public int TableNumber { get; set; }
        public string WaiterName { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public List<OrderItemDetails> Items { get; set; } = new List<OrderItemDetails>();
    }

    public class OrderItemDetails
    {
        public string MenuItemName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
