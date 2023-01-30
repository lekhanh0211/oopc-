using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Store
{
    public class HUEPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "chesse":
                    return new HUEChessePizza();
                case "greek":
                    return new HUEGreekPizza();
                case "pepperoni":
                    return new HUEPepperoniPizza();
                default:
                    return null;
            }
        }
    }
}
