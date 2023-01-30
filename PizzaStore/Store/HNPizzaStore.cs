using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Store
{
    public class HNPizzaStore : PizzaStore
    {
      
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "chesse":return new HNChessePizza();
                case "greek":return new HNGreekPizza();
                case "pepperoni":return new HNPepperoniPizza();
                default:return null;
            } 
        }
    }
}
