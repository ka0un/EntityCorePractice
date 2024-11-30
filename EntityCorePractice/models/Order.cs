namespace EntityCorePractice.models;

public class Order
{
    public int Id { get; set; }
    public DateTime OrderPlaced { get; set; }
    public DateTime? OrderFulfilled { get; set; }
    public int CustomerId { get; set; } // if you don't specify a navigation property, EF Core will create a shadow property like this so that it can create a foreign key relationship
    public Customer Customer { get; set; } = null!; // this represents that an order belongs to a customer
    public ICollection<OrderDetail> OrderDetails { get; set; } = null!;
}