namespace PZ10MDK0101
{
    public class Order
    {
        public Guid ID { get; set; }
        public double Price { get; set; }
        public Client? client { get; set; }
        public string? description { get; set; }
    }
}
