using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class HNChessePizza : Pizza
    {
        public HNChessePizza()
        {
            name = "HN The best is Chesse Pizza";
            dough = "HN Very Thin dough";
            sauce = "HN Very spicy sauce";
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
