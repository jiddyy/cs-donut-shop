namespace cs_donut_shop
{
    class Donut
    {
        public string Topping { get; set; }
        public string Flavor { get; set; }
        public Donut(string topping, string flavor)
        {
            Topping = topping;
            Flavor = flavor;
        }
    }
}