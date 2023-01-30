using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class HNPepperoniPizza : Pizza
    {
        public HNPepperoniPizza()
        {
            name = "HN The best pepperoni pizza";
            dough = "HN Thick dough";
            sauce = "HN Sweet sauce";
            toppings.Add("Tomato");
        }
    }
}
