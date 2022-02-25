using CoffeeSolution.Common.Interfaces;
using CoffeeSolution.Common.Models;
using CoffeeSolution.Common.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSolution.Core.Services
{
    public class CoffeeService:ICoffeeService
    {
        private readonly ICoffeeMachineService _coffeeMachineService;

        public CoffeeService(ICoffeeMachineService coffeeMachineService)
        {
            _coffeeMachineService = coffeeMachineService;
        }

        public Drink GetSelectedDrinkOption(int drinkType)
        {
            return drinkType switch
            { 
                1 => new Cuppaccino(),
                2 => new Coffee(),
                3 => new Latte(),
                _ => throw new Exception("Invalid selection option.")
            };
        }

        public bool PrepareDrink(IDrink drink)
        {
            return _coffeeMachineService.PrepareDrink(drink);
        }
    }
}
