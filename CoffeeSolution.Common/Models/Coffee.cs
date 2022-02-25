using CoffeeSolution.Common.Enums;
using CoffeeSolution.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSolution.Common.Models
{
    public class Coffee: Drink
    {
        public Coffee():base(2, 1, DrinkType.COFFEE)
        {
                
        }

        public override int GetMilk()
        {
            bool selectionValid = false;

            do
            {
                Console.WriteLine("Would you like milk with your coffee? Y / N");
                var addMilk = Console.ReadLine().ToUpper();

                if (addMilk == "off")
                    Environment.Exit(0);

                if (addMilk == "Y" || addMilk == "N")
                {
                    selectionValid = true;

                    if (addMilk == "N")
                        return 0;
                }

                if (!selectionValid)
                {
                    Console.WriteLine("Invalid Selection");
                }
            }
            while (!selectionValid);

            return base.GetMilk();
        }
    }
}
