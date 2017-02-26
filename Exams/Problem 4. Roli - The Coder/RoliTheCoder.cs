using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


class RoliTheCoder
{
    static void Main()
    {
        //100

        string input = Console.ReadLine();

        SortedDictionary<int, SortedDictionary<string, List<string>>> eventList =
        new SortedDictionary<int, SortedDictionary<string, List<string>>>();


        while (!input.Equals("Time for Code"))
        {
            string[] inputArgs = input.Split(new char[] { ' ' },
                                     StringSplitOptions.RemoveEmptyEntries).ToArray();

            int id = int.Parse(inputArgs[0]);
            string eventWithHash = inputArgs[1];
            string eventName = inputArgs[1].Substring(1);
            List<string> participants = new List<string>(inputArgs.Skip(2));

            if (eventWithHash[0] != '#')
            {
                goto inpt;
            }
            if (!eventList.ContainsKey(id))
            {
                eventList.Add(id, new SortedDictionary<string, List<string>>());
            }
            else if (!eventList[id].ContainsKey(eventName))
            {
                goto inpt;
            }

            if (eventList[id].ContainsKey(eventName))
            {
                foreach (string participant in participants)
                {
                    if (!eventList[id][eventName].Contains(participant))
                    {
                        eventList[id][eventName].Add(participant);
                    }
                }
                goto inpt;
            }
            eventList[id][eventName] = participants.Distinct().ToList();

            inpt:
            input = Console.ReadLine();

        }

        foreach (var res in eventList.OrderByDescending(x => x.Value.Values.Sum(y => y.Count)))
        {
            List<string> helper = new List<string>();
            foreach (var meet in res.Value)
            {
                helper = meet.Value.Distinct().ToList();
                helper.Sort();
                int count = helper.Count;
                Console.WriteLine("{0} - {1}", meet.Key, count);
            }
            foreach (var help in helper)
            {
                Console.WriteLine("{0}", help);
            }
        }
    }




}

//-------100/100-------------
//   class Event {
//       public string Name { get; set; }
//       public List<string> Participants { get; set; }
//   }
//
//
//   static void Main()
//   {
//       var line = Console.ReadLine();
//
//       var events = new Dictionary<int, Event>();
//
//       const string eventPattern = @"(?<id>\d+)\s+#(?<eventName>[\w\d]+)(\s+(@\w+\s*)+)?";
//
//       while (line!= "Time for Code")
//       {
//           var eventDetails = Regex.Match(line, eventPattern);
//           if (eventDetails.Success)
//           {
//               var id = int.Parse(eventDetails.Groups["id"].Value);
//               var eventName = eventDetails.Groups["eventName"].Value;
//
//               var participants = new string[0];
//               var eventHasPArticipants = line.Contains("@");
//               if (eventHasPArticipants)
//               {
//                   participants = line.Substring(line.IndexOf('@')).Split().Where(a => a != string.Empty).ToArray();
//               }
//
//              
//               if (!events.ContainsKey(id))
//               {
//                   events[id] = new Event()
//                   {
//                       Name = eventName,
//                       Participants = new List<string>()
//                   };
//               }
//               if (events[id].Name == eventName)
//               {
//                   events[id].Participants.AddRange(participants);
//                   events[id].Participants = events[id]
//                       .Participants
//                       .Distinct()
//                       .ToList();
//               }
//              
//           }
//
//
//           line = Console.ReadLine();
//       }
//
//       var sortedEvents = events.OrderByDescending(a => a.Value.Participants.Count)
//           .ThenBy(a => a.Value.Name)
//           .ToArray();
//
//       foreach (var ev in sortedEvents)
//       {
//           var eventName = ev.Value.Name;
//           var participantCOunt = ev.Value.Participants.Count();
//
//           Console.WriteLine($"{eventName} - {participantCOunt}");
//
//           var paricipantSorted  = ev.Value.Participants.OrderBy(a => a);
//           foreach (var partic in paricipantSorted)
//           {
//               Console.WriteLine(partic);
//
//           }
// --------------------------------------------------------------------------------          

//-------------------------------------------------------
//        string inputLine = Console.ReadLine();
//        Dictionary<int, Event> eventsBook = new Dictionary<int, Event>();

//        while (!inputLine.Equals("Time for Code"))
//        {
//            string[] inputElements = inputLine
//                .Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

//            if (!inputElements[1].Contains('#'))
//            {
//                inputLine = Console.ReadLine();
//                continue;
//            }

//            int eventId = int.Parse(inputElements[0]);
//            char[] eventName = inputElements[1].Skip(1).ToArray();
//            string name = string.Join("", eventName);

//            if (eventsBook.ContainsKey(eventId) && !eventsBook[eventId].Name.Equals(name))
//            {
//                inputLine = Console.ReadLine();
//                continue;
//            }

//            else if (eventsBook.ContainsKey(eventId) && eventsBook[eventId].Name.Equals(name))
//            {
//                for (int i = 2; i < inputElements.Length; i++)
//                {
//                    if (eventsBook[eventId].partisipant.Contains(inputElements[i]))
//                    {
//                        continue;
//                    }
//                    else
//                    {
//                        eventsBook[eventId].partisipant.Add(inputElements[i]);
//                    }
//                }
//            }

//            else
//            {
//                Event currentEvent = new Event();
//                currentEvent.Name = name;

//                for (int i = 2; i < inputElements.Length; i++)
//                {
//                    if (!inputElements[i].Contains('@'))
//                    {
//                        continue;
//                    }

//                    currentEvent.partisipant.Add(inputElements[i]);
//                }
//                eventsBook[eventId] = currentEvent;
//            }

//            inputLine = Console.ReadLine();
//        }
//        eventsBook = eventsBook
//            .OrderByDescending(v => v.Value.partisipant.Count())
//            .ThenBy(v => v.Value.Name)
//            .ToDictionary(x => x.Key, x => x.Value);

//        foreach (var evenT in eventsBook)
//        {
//            Console.WriteLine($"{evenT.Value.Name} - { evenT.Value.partisipant.Count()}");
//            foreach (var item in evenT.Value.partisipant.OrderBy(x => x))
//            {
//                Console.WriteLine(item);
//            }
//        }
//    }
//}

//public class Event
//{

//    public Event()
//    {
//        this.partisipant = new List<string>();
//    }
//    public List<string> partisipant { get; set; }
//    public string Name { get; set; }
//}

//---------------------------------------------------------------------

//90/100
//string input = Console.ReadLine();
//        Dictionary<int, string> eventsById = new Dictionary<int, string>();
//        Dictionary<string, List<string>> partsByEvent = new Dictionary<string, List<string>>();

//        while (!input.Equals("Time for Code"))
//        {
//            if (input.Contains("#"))
//            {
//                string[] info = input.Split(new char[] { ' ', '#' }, StringSplitOptions.RemoveEmptyEntries);
//                int id = int.Parse(info[0]);
//                string eventName = info[1];

//                List<string> participiants = new List<string>();
//                if (info.Length > 2)
//                {
//                    for (int i = 2; i < info.Length; i++)
//                    {
//                        participiants.Add(info[i]);
//                    }
//                }

//                if (!eventsById.ContainsKey(id))
//                {
//                    eventsById.Add(id, eventName);
//                    partsByEvent.Add(eventName, participiants);
//                }
//                else if (eventsById[id] == eventName)
//                {
//                    partsByEvent[eventName].AddRange(participiants);
//                }


//            }
//            input = Console.ReadLine();
//        }

//        foreach (var part in partsByEvent.OrderByDescending(x => x.Value.Distinct().Count()).ThenBy(x => x.Key))
//        {
//            Console.WriteLine($"{part.Key} - {part.Value.Distinct().Count()}");

//            foreach (var val in part.Value.OrderBy(x => x).Distinct())
//            {
//                Console.WriteLine(val);
//            }

//        input = Console.ReadLine();
//        }

//    }



