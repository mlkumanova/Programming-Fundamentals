using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Files
{
    static void Main()
    {
        var filesByRoot = new Dictionary<string, Dictionary<string, long>>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var routeParms = Console.ReadLine().Split('\\');

            string root = routeParms[0];
            string[] fileWithSize = routeParms[routeParms.Length-1].Split(';'); 

            string fileNameWithExtension = fileWithSize[0];
            long fileSize = long.Parse(fileWithSize[1]);
            
            if (!filesByRoot.ContainsKey(root))
            {
                filesByRoot.Add(root, new Dictionary<string, long>());
            }
            if (!filesByRoot[root].ContainsKey(fileNameWithExtension))
            {
                filesByRoot[root].Add(fileNameWithExtension, fileSize);
            }
            else
            {
                filesByRoot[root][fileNameWithExtension] = fileSize;
            }
        }

        string[] queryParms = Console.ReadLine().Split();

        string queryExtentions = queryParms[0];
        string queryRoot = queryParms[2];

        if (filesByRoot.ContainsKey(queryRoot))
        {
            Dictionary<string, long> foundFiles = filesByRoot[queryRoot];


            foreach (var file in foundFiles.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                if (file.Key.EndsWith(queryExtentions))
                {
                    Console.WriteLine($@"{file.Key} - {file.Value} KB");
                }
            }

        }
        else
        {
            Console.WriteLine("No");
        }

    }
}

