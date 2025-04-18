namespace CafeBlazor.ApiRequest.Model
{
    public class OrderItem
    {
        public int OrderId { get; set; }
        public int MenuItemId { get; set; }
        public int Quantity { get; set; }
    }

    public class OrderCreateDto
    {
        public int TableNumber { get; set; }
        public int WaiterId { get; set; }
        public List<OrderItemDto> OrderItems { get; set; } = new();
    }

    public class OrderItemDto
    {
        public int MenuItemId { get; set; }
        public int Quantity { get; set; }
    }
}
