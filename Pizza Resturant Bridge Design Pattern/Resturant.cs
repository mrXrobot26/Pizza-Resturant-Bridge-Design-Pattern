using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Resturant_Bridge_Design_Pattern
{
    internal abstract class Resturant
    {
        protected IPizza pizzaImpelementor;
        public Resturant(IPizza pizzaImpelementor)
        {
            this.pizzaImpelementor = pizzaImpelementor;
        }

        public abstract void OrderFood();
    }
}
