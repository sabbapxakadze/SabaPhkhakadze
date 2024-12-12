public class Order
{
    public int OrderID { get; set; }
    public long Date { get; set; }
    public string Product { get; set; }
    public decimal Price { get; set; }
    public int CustomerID { get; set; }
    public Order(int orderID, long date, string product, decimal price, int customerID)
    {
        OrderID = orderID;
        Date = date;
        Product = product;
        Price = price;
        CustomerID = customerID;
    }
}