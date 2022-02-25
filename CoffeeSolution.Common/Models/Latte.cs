using CoffeeSolution.Common.Enums;
using CoffeeSolution.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSolution.Common.Models
{
    public class Latte:Drink
    {
        public Latte():base(3, 2, DrinkType.LATTE)
        {

        }
    }
}
