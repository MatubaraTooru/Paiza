using System;
using System.Collections.Generic;
using System.Linq;

class Vtuber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var superchats = new Dictionary<string, int>();
        var memberships = new List<string>();

        for (int i = 0; i < n; i++)
        {
            string eventContent = Console.ReadLine();
            string[] eventParts = eventContent.Split();

            string name = eventParts[0];
            string eventType = eventParts[1];

            if (eventType == "give")
            {
                int money = int.Parse(eventParts[2]);
                if (superchats.ContainsKey(name))
                    superchats[name] += money;
                else
                    superchats[name] = money;
            }
            else if (eventType == "join")
            {
                memberships.Add(name);
            }
        }

        var sortedSuperchats = superchats.OrderByDescending(pair => pair.Value).ThenByDescending(pair => pair.Key);
        memberships.Sort();

        foreach (var superchat in sortedSuperchats)
        {
            Console.WriteLine(superchat.Key);
        }

        foreach (var membership in memberships)
        {
            Console.WriteLine(membership);
        }
    }
}
