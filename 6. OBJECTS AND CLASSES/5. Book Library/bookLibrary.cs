using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ReleaseDate { get; set; }
    public int ISBNNumber { get; set; }
    public double Price { get; set; }
}

public class Library
{
    public string Name { get; set; }
    public List<Book> Books { get; set; }
}

class bookLibrary
    {
        static void Main()
        {
        int n = int.Parse(Console.ReadLine());

        var library = new Library();
        library.Name = "bookStorage";
        library.Books = new List<Book>();
        for (int i = 0; i < n; i++)
        {
            var info = Console.ReadLine().Split(' ').ToList();
            
            var title = info[0];
            var author = info[1];
            var releaseDate = info[3];

            var price = double.Parse(info[5]);

            if (!library.Books.Any(a => a.Author == author))
            {
                Book newBook = new Book();
                newBook.Author = author;
                newBook.Price = price;

                library.Books.Add(newBook);

            }
            else
            {
                Book toUpgrade = library.Books.First(a => a.Author == author);
                toUpgrade.Price += price;
            }
        }
        foreach (var book in library.Books.OrderByDescending(p => p.Price).ThenBy(a=> a.Author))
        {
            Console.WriteLine($"{book.Author} -> {book.Price:f2}");
        }



        //16/100-------------------------------------------------------
    //   int n = int.Parse(Console.ReadLine());
    //   var moneyMade = new Dictionary<string, decimal>();
    //   for (int i = 0; i < n; i++)
    //   {
    //       var input = Console.ReadLine().Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries);
    //       var nameOfAuthor = input[1];
    //       decimal price = decimal.Parse(input[5]);
    //
    //       if (!moneyMade.ContainsKey(nameOfAuthor))
    //       {
    //           moneyMade.Add(nameOfAuthor, 0);
    //       }
    //       moneyMade[nameOfAuthor] = moneyMade[nameOfAuthor] + price;
    //   }
    //   moneyMade.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
    //   foreach (var item in moneyMade)
    //   {
    //       Console.WriteLine($"{item.Key} -> {item.Value}");
    //   }


        }
    }

