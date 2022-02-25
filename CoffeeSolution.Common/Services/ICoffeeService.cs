using CoffeeSolution.Common.Interfaces;
using CoffeeSolution.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSolution.Common.Services
{
    public interface ICoffeeService
    {
        Drink GetSelectedDrinkOption(int drinkType);
        bool PrepareDrink(IDrink drink);
    }
}
