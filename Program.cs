using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace cs_donut_shop
{
    class Program
    {
        static Donut loadDonuts()
        {
            string donuts = File.ReadAllText(@"./donuts.json");
            return JsonConvert.DeserializeObject<Donut>(donuts);
        }
        static string GetUserDonut(Donut donut)
        {
            foreach (var topping in donut.Topping)
            {
                Console.WriteLine("Here is a list of toppings that you can chose from: ");
                Console.WriteLine(topping);
                return topping;
            }
            foreach (var flavor in donut.Flavor)
            {
                Console.WriteLine("Here is a list of flavors that you can chose from: ");
                Console.WriteLine(flavor);
                return flavor;
            }
            return "oof";
        }
        static void Main(string[] args)
        {
            Donut donut = loadDonuts();
            string userService = GetUserDonut(donut);
            Console.WriteLine($"{userService}, awesome!");
        }
    }
}
