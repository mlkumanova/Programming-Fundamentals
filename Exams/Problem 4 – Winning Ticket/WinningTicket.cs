using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


class WinningTicket
{
    public class Result
    {
        public int Count { get; set; }
        public char Symbol { get; set; }
    }

    public static Result FindReapitingSymbols(char[] symbols)
    {
        var prevSymbol = symbols.First();
        var count = 1;
        var maxCount = 0;
        var maxSymbol = default(char);

        for (int i = 1; i < symbols.Length; i++)
        {
            var currSymbol = symbols[i];
            if (prevSymbol == currSymbol)
            {
                count++;
            }
            else
            {
                if (count > maxCount)
                {
                    maxCount = count;
                    maxSymbol = prevSymbol;
                }
                count = 1;
            }
            if (count > maxCount)
            {
                maxCount = count;
                maxSymbol = prevSymbol;
            }
            prevSymbol = currSymbol;
        }
        return new Result
        {
            Count = maxCount,
            Symbol = maxSymbol
        };
    }

    static void Main()
    {

        var tickets = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(t => t.Trim()).ToArray();

        foreach (var ticket in tickets)
        {
            if (ticket.Length != 20)
            {
                Console.WriteLine("invalid ticket");
                continue;
            }

            var left = ticket.Take(10).ToArray();
            var right = ticket.Skip(10).ToArray();

            var winningTicket = false;

            var leftResult = FindReapitingSymbols(left);
            if (leftResult .Symbol == '@'|| leftResult.Symbol == '#' || leftResult.Symbol == '$' || leftResult.Symbol == '^' && leftResult.Count >= 6)
            {
                var rightResult = FindReapitingSymbols(right);
                if (leftResult.Symbol == rightResult.Symbol && rightResult.Count >= 6)
                {
                    var jackpot = leftResult.Count == 10 && rightResult.Count == 10 ? " Jackpot!" : string.Empty;
                    Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(leftResult.Count, rightResult.Count)}{leftResult.Symbol}{jackpot}");

                    winningTicket = true;
                }                
            }
            if (!winningTicket)
            {
                Console.WriteLine($"ticket \"{ticket}\" - no match");
            }


            
             




        }

        //100/100 
        //var tickets = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(t => t.Trim()).ToArray();

        //foreach (var ticket in tickets)
        //{
        //    if (ticket.Length != 20)
        //    {
        //        Console.WriteLine("invalid ticket");
        //        continue;
        //    }

        //    var left = new string(ticket.Take(10).ToArray());
        //    var right = new string(ticket.Skip(10).ToArray());

        //    var winningSymbols = new string[] { "@","\\$","#","\\^" };
        //    var winningTicket = false;
        //    foreach (var winningSymbol in winningSymbols)
        //    {
        //        var regex = new Regex($"{winningSymbol}{{6,}}");
        //        var leftMatch = regex.Match(left);
        //        if (leftMatch.Success)
        //        {
        //            var rightMatch = regex.Match(right);
        //            if (rightMatch.Success)
        //            {
        //                winningTicket = true;

        //                var lengthOfSymbolsleft = leftMatch.Value.Length;

        //                var lengthOfSymbolsright = rightMatch.Value.Length;

        //                var jackpot = lengthOfSymbolsleft == 10 && lengthOfSymbolsright == 10 ? " Jackpot!" : string.Empty;
        //                Console.WriteLine($@"ticket ""{ticket}"" - {Math.Min(lengthOfSymbolsleft, lengthOfSymbolsright)}{winningSymbol.Trim('\\')}{jackpot}");
        //                break;
        //            }
        //        }
        //    }

        //    if (!winningTicket)
        //    {
        //        Console.WriteLine($@"ticket ""{ticket}"" - no match");
        //    }
        //}


        //-----------

        //     var result = new StringBuilder();
        //
        //     var tickets = Console.ReadLine()
        //         .Split(new[] { ' ', ',' }, //StringSplitOptions.RemoveEmptyEntries)
        //         .Select(x => x.Trim());
        //
        //     var pattern = @"(\@{6,}|\${6,}|\^{6,}|\#{6,})";
        //     var reg = new Regex(pattern);
        //
        //     foreach (var ticket in tickets)
        //     {
        //         if (ticket.Length != 20)
        //         {
        //             result.Append($"invalid ticket//{Environment.NewLine}");
        //             continue;
        //         }
        //
        //         var leftMatch = reg.Match(ticket.Substring/(0, /10));
        //         var rightMatch = reg.Match(ticket.Substring/(10));
        //         var minLen = Math.Min(leftMatch.Length, //rightMatch.Length);
        //
        //         if (!leftMatch.Success || !rightMatch.Success)
        //         {
        //             result.Append($"ticket \"{ ticket}\" - no //match{Environment.NewLine}");
        //             continue;
        //         }
        //
        //         var leftPart = leftMatch.Value.Substring(0, //minLen);
        //         var rightPart = rightMatch.Value.Substring(0, //minLen);
        //
        //         if (leftPart.Equals(rightPart))
        //         {
        //             if (leftPart.Length == 10)
        //             {
        //                 result.Append($"ticket \"{ ticket}\" - //{minLen}{leftPart.Substring(0, 1)} Jackpot!//{Environment.NewLine}");
        //             }
        //             else
        //             {
        //                 result.Append($"ticket \"{ ticket}\" - //{minLen}{leftPart.Substring(0, 1)}//{Environment.NewLine}");
        //             }
        //         }
        //         else
        //         {
        //             result.Append($"ticket \"{ ticket}\" - no //match{Environment.NewLine}");
        //         }
        //     }
        //
        //     Console.Write(result.ToString());


        //   var tickets = Console.ReadLine().Split(new char[] { ',',' '},StringSplitOptions.RemoveEmptyEntries).ToList();
        //   
        //  
        //   var pattern1 = @"$$$$$$$$$$$$$$$$$$$$";
        //   var pattern2 = @"####################";
        //   var pattern3 = @"@@@@@@@@@@@@@@@@@@@@";
        //   var pattern4 = @"^^^^^^^^^^^^^^^^^^^^";
        //
        //   var pattern5 = @"\${6,9}|\@{6,9}|\^{6,9}|\#{6,9}";
        //   var regex = new Regex(pattern5);
        //
        //   foreach (var ticket in tickets)
        //   {
        //       if (ticket.Length == 20 )
        //       {
        //           if (regex.IsMatch(ticket) && !(ticket == pattern1) && !(ticket == pattern2) && !(ticket == pattern3) && !(ticket == pattern4))
        //           {
        //              
        //               if (ticket.Contains("@"))
        //               {
        //                   var counting1 = (Regex.Matches(Regex.Escape(ticket), ("@")).Count) / 2;
        //
        //                   Console.WriteLine($@"ticket ""{ticket}"" - {counting1}@");
        //               }
        //               if (ticket.Contains("$"))
        //               {
        //                   var counting2 = (Regex.Matches(Regex.Escape(ticket), ("$")).Count) / 2;
        //
        //                   Console.WriteLine($@"ticket ""{ticket}"" - {counting2}$");
        //               }
        //               if (ticket.Contains("#"))
        //               {
        //                   var counting3 = (Regex.Matches(Regex.Escape(ticket), ("#")).Count) / 2;
        //
        //                   Console.WriteLine($@"ticket ""{ticket}"" - {counting3}#");
        //               }
        //               if (ticket.Contains("^"))
        //               {
        //                   var counting4 = (Regex.Matches(Regex.Escape(ticket), ("^")).Count) / 2;
        //
        //                   Console.WriteLine($@"ticket ""{ticket}"" - {counting4}^");
        //               }
        //
        //
        //           }
        //           //JackPOts
        //           if (ticket == pattern1)
        //           {
        //               Console.WriteLine($@"ticket ""{ticket}"" - 10$ Jackpot!"); 
        //           }
        //           else if ( ticket == pattern2)
        //           {
        //
        //               Console.WriteLine($@"ticket ""{ticket}"" - 10# Jackpot!");
        //           }
        //           else if (ticket == pattern3)
        //           {
        //               Console.WriteLine($@"ticket ""{ticket}"" - 10@ Jackpot!");
        //           }
        //           else if (ticket == pattern4)
        //           {
        //               Console.WriteLine($@"ticket ""{ticket}"" - 10^ Jackpot!");
        //           }
        //           //JACKPOTS--
        //           else if (!(ticket.Contains("@")) && !(ticket.Contains("$")) && !(ticket.Contains("#")) && !(ticket.Contains("^")))
        //           {
        //               Console.WriteLine($@"ticket ""{ticket}"" - no match");
        //           }
        //             
        //        }
        //
        //        else if (ticket.Length < 20 || ticket.Length > 20 )
        //        {
        //            Console.WriteLine($@"invalid ticket");
        //
        //        }
        //    }
    }
}

