using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Resturant_Bridge_Design_Pattern
{
    internal class AmericanWayResturant : Resturant
    {
        public AmericanWayResturant(IPizza pizza) : base(pizza)
        {
            
        }

        public override void OrderFood()
        {
            Console.WriteLine(pizzaImpelementor.PreparPizza() + " in amrican way");
        }
    }
}
