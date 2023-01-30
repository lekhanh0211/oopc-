using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class DNChessePizza : Pizza
    {
        public DNChessePizza()
        {
            name = "DN The best is Chesse Pizza";
            dough = "DN Very Thin dough";
            sauce = "DN Very spicy sauce";
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
