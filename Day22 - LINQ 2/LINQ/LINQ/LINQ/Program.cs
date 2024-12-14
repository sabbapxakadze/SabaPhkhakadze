//using (FileStream fs = new FileStream("customers.txt", FileMode.Create, FileAccess.Write))
//{
//    using (StreamWriter sw = new StreamWriter(fs))
//    {
//        sw.WriteLine("1|Lasha");
//        sw.WriteLine("2|Beka");
//        sw.WriteLine("3|Dimitri");
//        sw.WriteLine("4|Giorgi");
//        sw.WriteLine("5|Saba");
//    }
//}

//using (FileStream fs = new FileStream("orders.txt", FileMode.Create, FileAccess.Write))
//{
//    using (StreamWriter sw = new StreamWriter(fs))
//    {
//        sw.WriteLine("1|20201212|Coca-cola|3.0|1");
//        sw.WriteLine("2|20201111|Pepsi|3.0|2");
//        sw.WriteLine("3|20200909|Staropramen|4.0|2");
//        sw.WriteLine("4|20201212|Argo|2.0|3");
//        sw.WriteLine("5|20201010|Fanta|2.5|1");
//        sw.WriteLine("6|20201115|Sprite|3.5|2");
//        sw.WriteLine("7|20200920|Zedazeni|2.0|3");
//        sw.WriteLine("8|20201201|Nataxtari|4.5|1");
//        sw.WriteLine("9|20201030|Heineken|5.0|2");
//        sw.WriteLine("10|20201125|Ravi|6.0|3");
//        sw.WriteLine("11|20201205|RCCola|3.0|1");
//        sw.WriteLine("12|20201208|Xashuris-Limonati|2.8|2");
//        sw.WriteLine("13|20200912|MoguMogu|4.2|3");
//        sw.WriteLine("14|20201220|Tonic|2.0|1");
//        sw.WriteLine("15|20201015|Bakuriani|3.0|2");
//        sw.WriteLine("16|20201110|Es|3.3|3");
//        sw.WriteLine("17|20200925|Baxmaro|2.7|1");
//        sw.WriteLine("18|20201218|Likani|4.0|2");
//        sw.WriteLine("19|20201005|Nabeglavi|4.8|3");
//        sw.WriteLine("20|20201122|Mirinda|5.5|1");
//    }
//}

using System.Text.RegularExpressions;

List<Customer> customerList = new List<Customer>();
List<Order> orderList = new List<Order>();


using (FileStream fs = new FileStream("customers.txt", FileMode.Open, FileAccess.Read))
{
    using (StreamReader sr = new StreamReader(fs))
    {
        string line;
        while ((line = sr.ReadLine()) != null)
        {
            var customerArr = line.Split('|');
            if (customerArr.Length != 2)
            {
                Console.WriteLine("Wrong customer line!");
                continue;
            }
            int id = int.Parse(customerArr[0]);
            string name = customerArr[1];
            Customer cust = new Customer(id, name);
            customerList.Add(cust);
        }
    }
}

using (FileStream fs = new FileStream("orders.txt", FileMode.Open, FileAccess.Read))
{
    using (StreamReader sr = new StreamReader(fs))
    {
        string line;
        while ((line = sr.ReadLine()) != null)
        {
            var orderArr = line.Split('|');
            if (orderArr.Length != 5)
            {
                Console.WriteLine("Wrong order line!");
                continue;
            }
            int orderId = int.Parse(orderArr[0]);
            long date = long.Parse(orderArr[1]);
            string product = orderArr[2];
            decimal price = decimal.Parse(orderArr[3]);
            int customerId = int.Parse(orderArr[4]);

            Order ord = new Order(orderId, date, product, price, customerId);
            orderList.Add(ord);
        }
    }
}

var eachClientOrderCountQuery = from o in orderList
                                 group o by o.CustomerID into customerGroup
                                 select new
                                 {
                                     CustomerID = customerGroup.Key,
                                     OrderCount = customerGroup.Count()
                                 };

var eachClienOrderCountMethod = orderList.GroupBy(o => o.CustomerID)
                                         .Select(group => new
                                         {
                                             CustomerId = group.Key,
                                             OrderCount = group.Count()
                                         });

var eachClientOrderSumQuery = from o in orderList
                              group o by o.CustomerID into customerGroup
                              select new
                              {
                                  CustomerId = customerGroup.Key,
                                  orderSum = customerGroup.Sum(o => o.Price)
                              };
var eachClietnOrderSumMethod = orderList.GroupBy(o => o.CustomerID)
                               .Select(group => new
                               {
                                   CustomerId = group.Key,
                                   orderSum = group.Sum(o => o.Price)
                               });

var eachClientMinOrderQuery = from o in orderList
                              group o by o.CustomerID into customerGroup
                              select new
                              {
                                  CustomerId = customerGroup.Key,
                                  MinOrderPrice = customerGroup.Min(o => o.Price)
                              };

var eachClientMinOrderMethod = orderList.GroupBy(o => o.CustomerID)
                               .Select(group => new
                               {
                                   CustomerId = group.Key,
                                   orderSum = group.Min(o => o.Price)
                               });

var clientsWithMoreThan1OrderQuery = from o in orderList
                                     group o by o.CustomerID into customerGroup
                                     where customerGroup.Count() > 1
                                     select new
                                     {
                                         CustomerId = customerGroup.Key,
                                         OrderCount = customerGroup.Count()
                                     };
                                     
var clientsWithMoreThan1OrderMethod = orderList.GroupBy(o => o.CustomerID)
                               .Where(group => group.Count() > 1)
                               .Select(group => new
                               {
                                   CustomerId = group.Key,
                                   OrderCount = group.Count()
                               });

var clientsWithAverageMoreThan10Query = from o in orderList
                                        group o by o.CustomerID into customerGroup
                                        where customerGroup.Average(o => o.Price) > 10
                                        select new
                                        {
                                            CustomerId = customerGroup.Key,
                                            AverageAmount = customerGroup.Average(o => o.Price)
                                        };

var clientsWithAverageMoreThan10Method = orderList.GroupBy(o => o.CustomerID)
                                        .Where(group => group.Average(o => o.Price) > 10)
                                        .Select(group => new
                                        {
                                            CustomerId = group.Key,
                                            AverageAmount = group.Average(o => o.Price)
                                        });