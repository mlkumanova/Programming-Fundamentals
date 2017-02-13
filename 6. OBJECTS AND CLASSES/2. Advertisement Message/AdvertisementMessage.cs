using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class AdvertisementMessage
    {
        static void Main()
        {
        int n = int.Parse(Console.ReadLine());

        var phrases = new List<string>();
            phrases.Add( "Excellent product");
            phrases.Add( "Such a great product.");
            phrases.Add( "I always use that product.");
            phrases.Add( "Best product of its category.");
            phrases.Add( "Exceptional product.");
            phrases.Add( "I can’t live without this product.");

        var events = new List<string>();
        events.Add("Now I feel good. ");
        events.Add("I have succeeded with this product.");
        events.Add("Makes miracles. I am happy of the results!");
        events.Add("I cannot believe but now I feel awesome.");
        events.Add("Try it yourself, I am very satisfied.");
        events.Add("I feel great!");

        var author = new List<string>();
        author.Add("Diana");
        author.Add("Petya");
        author.Add("Stella");
        author.Add("Elena");
        author.Add("Katya");
        author.Add("Iva");
        author.Add("Annie");
        author.Add("Eva");

        var cities = new List<string>();
        cities.Add("Burgas");
        cities.Add("Sofia");
        cities.Add("Plovdiv");
        cities.Add("Varna");
        cities.Add("Ruse");


        var randomPhrase = new Random();
        for (int i = 0; i < phrases.Count; i++)
        {
            var currPhrase = phrases[i];
            var randomIndexPhrase = randomPhrase.Next(0, phrases.Count);
            var tempPhrase = phrases[randomIndexPhrase];
            phrases[i] = tempPhrase;
            phrases[randomIndexPhrase] = currPhrase;
        }
       
        var randomEvent = new Random();

        for (int i = 0; i < events.Count; i++)
        {
            var currEvent = events[i];
            var randomIndexEvent = randomEvent.Next(0, events.Count);
            var tempEvent = events[randomIndexEvent];
            events[i] = tempEvent;
            events[randomIndexEvent] = currEvent;
           

        }

        var randomAuthor = new Random();
        for (int i = 0; i < author.Count; i++)
        {
            var currAuthor = author[i];
            var randomIndexAuthor = randomAuthor.Next(0, author.Count);
            var tempAuthor = author[randomIndexAuthor];
            author[i] = tempAuthor;
            author[randomIndexAuthor] = currAuthor;
        }

        var randomCities = new Random();
        for (int i = 0; i < cities.Count; i++)
        {
            var currCities = cities[i];
            var randomIndexCities = randomCities.Next(0, cities.Count);
            var tempCities = cities[randomIndexCities];
            cities[i] = tempCities;
            cities[randomIndexCities] = currCities;
        }
        for (int i = 0; i < n; i++)
        {

            Console.WriteLine($"{phrases[i]} {events[i]} {author[i]} - {cities[i]}");
        
        }


    }
    }

