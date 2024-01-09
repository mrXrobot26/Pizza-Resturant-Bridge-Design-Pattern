using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Resturant_Bridge_Design_Pattern
{
    internal class CheckenPizza : IPizza
    {
        public string PreparPizza()
        {
            return "this is chiken pizza";
        }
    }
}
