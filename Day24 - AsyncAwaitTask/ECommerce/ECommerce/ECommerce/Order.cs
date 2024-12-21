public class Order
{
    public int OrderID { get; set; }
    public OrderStatus Status { get; set; }


    public async Task<bool> ValidatePayment(int orderId)
    {
        Console.WriteLine($"Payment Validating for the order: {orderId}");
        await Task.Delay(1500);

        Console.WriteLine($"Payment validated for the order: {orderId}\n");
        return true;
    }

    public async Task<bool> CheckInventory(int orderId)
    {
        Console.WriteLine("Checking inventory...");
        await Task.Delay(2500);

        Console.WriteLine($"Inventory checked for the order: {orderId}\n");
        return true;
    }

    public async Task PrepareShipment(int orderId)
    {
        Console.WriteLine("Preparing shipment..");
        await Task.Delay(4000);

        Console.WriteLine($"Shipment prepared for the order: {orderId}\n");
    }

    public async Task ProcessOrder(int orderId)
    {
        try
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Processing order!!!");
            Status = OrderStatus.Processing;

            var paymentValidate = ValidatePayment(orderId);
            var inventoryValidate = CheckInventory(orderId);
            var shipmentValidate = PrepareShipment(orderId);

            
            await Task.WhenAll(paymentValidate, inventoryValidate, shipmentValidate);

            if (!paymentValidate.Result || !inventoryValidate.Result)
            {
                Status = OrderStatus.Failed;
                
                Console.WriteLine("Order failed due some issues..");
                return;
            }

            Status = OrderStatus.Shipped;
            Console.WriteLine("Order processed succesfully!\n\n");

        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occured: {ex.Message} \n\n");
            Status = OrderStatus.Failed;
        }
    }
}
public enum OrderStatus
{
    Processing,
    Failed,
    Shipped
}