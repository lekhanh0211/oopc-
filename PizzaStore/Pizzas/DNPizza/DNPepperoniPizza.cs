﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class DNPepperoniPizza : Pizza
    {
        public DNPepperoniPizza()
        {
            name = "DN The best pepperoni pizza";
            dough = "DN Thick dough";
            sauce = "DN Sweet sauce";
            toppings.Add("Tomato");
        }
    }
}
