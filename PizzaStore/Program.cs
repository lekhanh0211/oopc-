using PizzaStore.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var huepizzaStore = new HUEPizzaStore();
            huepizzaStore.OrderPizza("pepperoni");



            var dnpizzaStore = new DNPizzaStore();
            dnpizzaStore.OrderPizza("greek");

            var hcmpizzaStore = new HCMPizzaStore();
            hcmpizzaStore.OrderPizza("chesse");

            var hnpizzaStore = new HNPizzaStore();
            hnpizzaStore.OrderPizza("cabc");
            /*  pizzaStore.OrderPizza("greek");
              pizzaStore.OrderPizza("pepperoni");
              pizzaStore.OrderPizza("ldk");
  */
        }
    }
}
