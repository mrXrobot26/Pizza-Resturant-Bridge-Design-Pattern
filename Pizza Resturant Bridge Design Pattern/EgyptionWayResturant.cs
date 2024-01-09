using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Resturant_Bridge_Design_Pattern
{
    internal class EgyptionWayResturant : Resturant
    {
        public EgyptionWayResturant(IPizza PizzaImplementor) : base(PizzaImplementor) { }
        
        public override void OrderFood()
        {
            Console.WriteLine(pizzaImpelementor.PreparPizza()+" in egyption way");
        }
    }
}
