using CoffeeSolution.Common.Enums;
using CoffeeSolution.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSolution.Common.Models
{
    public class Cuppaccino: Drink
    {
        public Cuppaccino(): base (5, 3, DrinkType.CUPPACCINO)
        {

        }
    }
}
