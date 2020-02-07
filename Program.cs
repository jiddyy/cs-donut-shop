using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace cs_donut_shop
{
    class Program
    {
        static Dictionary<string, List<Donut>> loadDonuts()
        {
            string donuts = File.ReadAllText(@"./donuts.json");
            return JsonConvert.DeserializeObject<Dictionary<string, List<Donut>>>(donuts);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
