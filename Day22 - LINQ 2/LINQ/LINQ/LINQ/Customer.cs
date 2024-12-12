public class Customer
{
    public int CustomerID { get; set; }
    public string CustomerName { get; set; }
    public Customer(int customerID, string name)
    {
        CustomerID = customerID;
        CustomerName = name;
    }
}