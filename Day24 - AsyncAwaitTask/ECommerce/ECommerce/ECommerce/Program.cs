var orders = new List<Order>
{
    new Order() { OrderID=1 },
    new Order() { OrderID=2 },
    new Order() { OrderID=3 },
    new Order() { OrderID=4 },
    new Order() { OrderID=5 }
};

var tasks = orders.Select(o => o.ProcessOrder(o.OrderID));

await Task.WhenAll(tasks);

Console.WriteLine("All orders have been processed!");