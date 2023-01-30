using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class HNGreekPizza : Pizza
    {
        public HNGreekPizza()
        {
            name = "HN A good greek pizza";
            dough = "HN Thin dough";
            sauce = "HN Chilli sauce";
            toppings.Add("Tomato");
            toppings.Add("potato");
        }
    }
}
