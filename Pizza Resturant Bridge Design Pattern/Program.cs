namespace Pizza_Resturant_Bridge_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            AmericanWayResturant americanWayResturant = new AmericanWayResturant(new CheckenPizza());
            americanWayResturant.OrderFood();

            Console.WriteLine("=================================");

            EgyptionWayResturant egyptionWayResturant = new EgyptionWayResturant(new ZngrPizza());
            egyptionWayResturant.OrderFood();

        }
    }
}
