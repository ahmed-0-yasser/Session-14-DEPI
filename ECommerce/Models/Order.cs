namespace Session_14.Models;

public class Order
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }

    public int CustomerId { get; set; }

    public Customer Customer { get; set; }

    public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}