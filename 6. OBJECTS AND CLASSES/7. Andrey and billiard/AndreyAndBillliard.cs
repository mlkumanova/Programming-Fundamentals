using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Customer
{
    public string Name { get; set; }
    public Dictionary<string, decimal> ShopList { get; set; }
    public decimal Bill { get; set; }
}


    class AndreyAndBillliard
    {
    static void Main()
    {
        //20/100
        var n = int.Parse(Console.ReadLine());

        var availableProducts = new Dictionary<string, decimal>();

        var price = 0.0m;
        for (var i = 0; i < n; i++)
        {
            var inputEntities = Console.ReadLine().Split('-');
            var product = inputEntities[0];
            price = decimal.Parse(inputEntities[1]);

            if (!availableProducts.ContainsKey(product))
            {
                availableProducts.Add(product, price);
            }
            else
            {
                availableProducts[product] = price;
            }


        }
        var allClients = new List<Customer>();

        var listOfClients = Console.ReadLine().Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

        while (true)
        {
            var customerName = listOfClients[0];

            if(customerName== "end of clients")
            {
                break;
            }
            var wantedProduct = listOfClients[1];
            var wantedQuantity = decimal.Parse(listOfClients[2]);
            //----
            if (!availableProducts.ContainsKey(wantedProduct))
            {
               break;
            }

            var customer = new Customer();
            customer.ShopList = new Dictionary<string, decimal>();
            customer.Name = listOfClients[0];
            customer.ShopList.Add(wantedProduct, wantedQuantity);

            if (allClients.Any(c => c.Name == customerName))
            {
                var exisistingCustomer = allClients.First(c => c.Name == customerName);
                if (exisistingCustomer.ShopList.ContainsKey(wantedProduct))
                {
                    exisistingCustomer.ShopList[wantedProduct] += wantedQuantity;
                }
                else
                {
                    exisistingCustomer.ShopList[wantedProduct] = wantedQuantity;
                }
            }
            else
            {
                allClients.Add(customer);
            }
            
        listOfClients = Console.ReadLine().Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        foreach (var customer in allClients)
        {
            foreach (var item in customer.ShopList)
            {
                foreach (var product in availableProducts)
                {
                    if (item.Key == product.Key)
                    {
                        customer.Bill += item.Value * product.Value;
                    }
                }
            }
        }
        var ordered = allClients
            .OrderBy(x => x.Name)
            .ThenBy(x => x.Bill)
            .ToList();

        foreach (var customer in ordered)
        {
            Console.WriteLine(customer.Name);
            foreach (var item in customer.ShopList)
            {
                Console.WriteLine($"-- {item.Key} - {item.Value}");
            }
            Console.WriteLine($"Bill: {customer.Bill:f2}");
        }
        Console.WriteLine($"Total bill: {allClients.Sum(c => c.Bill):f2}");
    }
        
    }


