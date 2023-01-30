using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class HUEChessePizza : Pizza
    {
        public HUEChessePizza()
        {
            name = "HUE The best is Chesse Pizza";
            dough = "HUE Very Thin dough";
            sauce = "HUE Very spicy sauce";
            toppings.Add("Black Olives");
            toppings.Add("Chesse");
        }

        public override void Box()
        {
            base.Box();
            Console.WriteLine(dough);
        }
    }
}
