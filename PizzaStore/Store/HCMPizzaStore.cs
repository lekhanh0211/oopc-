using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Store
{
    public class HCMPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "chesse":
                    return new HCMChessePizza();
                case "greek":
                    return new HCMGreekPizza();
                case "pepperoni":
                    return new HCMPepperoniPizza();
                default:
                    return null;
            }
        }
    }
}
