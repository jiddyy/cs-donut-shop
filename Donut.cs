using System.Collections.Generic;

namespace cs_donut_shop
{
    class Donut
    {
        public List<string> Topping { get; set; }
        public List<string> Flavor { get; set; }
        public Donut(List<string> topping, List<string> flavor)
        {
            Topping = topping;
            Flavor = flavor;
        }
    }
}