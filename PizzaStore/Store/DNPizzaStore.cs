using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Store
{
    public class DNPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "chesse":
                    return new DNChessePizza();
                case "greek":
                    return new DNGreekPizza();
                case "pepperoni":
                    return new DNPepperoniPizza();
                default:
                    return null;
            }
        }
    }
}
