using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
class Demon
{
    public string Name { get; set; }
    public decimal Health { get; set; }
    public decimal Damage { get; set; }

    public static Demon Parse(string demonName)
    {
        var demon = new Demon();

        demon.Name = demonName;
        
        demon.Health = CalculateDemonHealth(demonName);
        demon.Damage = CalculateDemonDamage(demonName);

        return demon;
    }

    private static decimal CalculateDemonDamage(string demonName)
    {
        var damgeNumberPattern = @"[+-]?\d+(?:\.?\d+)?";
        var damageNumbers = Regex.Matches(demonName, damgeNumberPattern);

        var damageSum = 0m;
        foreach (Match match in damageNumbers)
        {
            damageSum += decimal.Parse(match.Value);

        }

        var modifiers = demonName.Where(a => a == '*' || a == '/');
        foreach (var modifier in modifiers)
        {
            switch (modifier)
            {
                case '*': damageSum *= 2; break;
                case '/': damageSum /= 2; break;
            }

        }
        return damageSum;
    }

    private static decimal CalculateDemonHealth(string demonName)
    {
        var healthPattern = @"[^0-9+\-*\/\.]";

        var healthChars = Regex.Matches(demonName, healthPattern);
        var healthValues = new List<int>();

        foreach (Match match in healthChars)
        {
            healthValues.Add(char.Parse(match.Value));

        }
        var health = healthValues.Sum();
        return health;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var deamons = Console.ReadLine()
            .Split(", ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries)
            .Select(Demon.Parse)
            .OrderBy(a => a.Name)
            .ToArray();
        foreach (var demon in deamons)
        {
            Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage");
        }
        
    }
    
        }
   

