using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Resturant_Bridge_Design_Pattern
{
    internal class ZngrPizza : IPizza
    {
        public string PreparPizza()
        {
            return "This is ZngrPizza";
        }
    }
}
