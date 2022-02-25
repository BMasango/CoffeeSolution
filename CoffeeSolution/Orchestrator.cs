using CoffeeSolution.Common.Interfaces;
using CoffeeSolution.Common.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CoffeeSolution
{
    public class Orchestrator
    {
        private readonly ICoffeeService _coffeeService;
        private IDrink drink; 

        public Orchestrator(ICoffeeService coffeeService)
        {
            _coffeeService = coffeeService;
            StartCoffeeMachine();
        }

        private void StartCoffeeMachine()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Available coffee selections");
                Console.WriteLine("1: Cuppacino");
                Console.WriteLine("2: Coffee");
                Console.WriteLine("3: Latte");
                Console.WriteLine("Please make a coffee selection");

                var drinkType = Console.ReadLine().ToLower();
                if (drinkType == "off")
                    Environment.Exit(0);

                if (int.TryParse(drinkType, out int selection))
                {
                    drink = _coffeeService.GetSelectedDrinkOption(selection);
                    _coffeeService.PrepareDrink(drink);
                }

                Console.ReadLine();
            }
        }
    }
}
