using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public DateTime ReleaseDate { get; set; }
    public string ISBN { get; set; }
    public decimal Price { get; set; }
}

public class Library
{
    public string Name { get; set; }
    public List<Book> Books { get; set; }
}

class Program
{
    static void Main()
    {
        
        var library = new Library();
        library.Books = new List<Book>();
        library.Name = "";

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var data = Console.ReadLine().Split(' ').ToList();
            var title = data[0];
            var author = data[1];
            var publisher = data[2];
            var releaseDate = DateTime.ParseExact(data[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            var ISBNnumber = data[4];
            var price = decimal.Parse(data[5]);

            var book = new Book();
            book.Title = title;
            book.Author = author;
            book.Publisher = publisher;
            book.ReleaseDate = releaseDate;
            book.ISBN = ISBNnumber;
            book.Price = price;

            library.Books.Add(book);

        }
        var startDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

        Dictionary<string, DateTime> filteredBooks = new Dictionary<string, DateTime>();
        for (int i = 0; i < library.Books.Count; i++)
        {
            if (!filteredBooks.ContainsKey(library.Books[i].Title))
            {
                filteredBooks.Add(library.Books[i].Title, library.Books[i].ReleaseDate);
            }
            else
            {
                filteredBooks[library.Books[i].Title] = library.Books[i].ReleaseDate;
            }
        }
        foreach (var book in filteredBooks.Where(x => x.Value > startDate).OrderBy(x => x.Value).ThenBy(x => x.Key)) 
        {
            var date = book.Value.ToString("dd.MM.yyyy");
            Console.WriteLine($"{book.Key} -> {date}");
        }


    }
}


