using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class HCMChessePizza : Pizza
    {
        public HCMChessePizza()
        {
            name = "HCM The best is Chesse Pizza";
            dough = "HCM Very Thin dough";
            sauce = "HCM Very spicy sauce";
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
