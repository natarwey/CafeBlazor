namespace CafeBlazor.ApiRequest.Model
{
    public class OrderFilter
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? TableNumber { get; set; }
        public int? WaiterId { get; set; }
    }
}
