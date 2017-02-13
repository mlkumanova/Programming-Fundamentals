using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Sale
{
    public decimal Price { get; set; }
    public string Town { get; set; }
    public string Product { get; set; }
    public decimal Quantity { get; set; }


}
class salesReport
    {
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var sales = new List<Sale>();

        for (int i = 0; i < n; i++)
        {
            var currentSalePart = Console.ReadLine().Split(' ');

            var currentSale = new Sale
            {
                Town = currentSalePart[0],
                Product = currentSalePart[1],
                Price = decimal.Parse(currentSalePart[2]),
                Quantity = decimal.Parse(currentSalePart[3])
            };

            sales.Add(currentSale);
        }
        var result = new SortedDictionary<string, decimal>();


        foreach (var item in sales)
        {
            if (!result.ContainsKey(item.Town))
            {
                result[item.Town] = 0;
            }
            
                result[item.Town] = result[item.Town] + item.Price * item.Quantity;
            
        }
        foreach (var kvp in result)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value:f2}");
        }
      


    }

    }

