using CoffeeSolution.Common.Enums;
using CoffeeSolution.Common.Services;
using CoffeeSolution.Core.Services;
using NUnit.Framework;

namespace CoffeeSolution.Test
{
    [TestFixture]
    public class CoffeeServiceTest
    {
        [Test(Description = "Invalid drink selection should throw a KeyNotFoundException exception")]
        public void Invalid_Drink_Selection_Invalid_Key()
        {
            ICoffeeMachineService coffeeMachineService = new CoffeeMachineService();
            ICoffeeService coffeeService = new CoffeeService(coffeeMachineService);

            Assert.Throws<System.Exception>(() => coffeeService.GetSelectedDrinkOption(99));
        }

        [Test(Description = "Check valid selection for coffee")]
        public void Check_Valid_Selection_For_Coffee()
        {
            ICoffeeMachineService coffeeMachineService = new CoffeeMachineService();
            ICoffeeService coffeeService = new CoffeeService(coffeeMachineService);

            var drink = coffeeService.GetSelectedDrinkOption(2);
            Assert.AreEqual(drink.GetDrinkType(), DrinkType.COFFEE);
        }

        [Test(Description = "Check valid selection for latte")]
        public void Check_Valid_Selection_For_Latte()
        {
            ICoffeeMachineService coffeeMachineService = new CoffeeMachineService();
            ICoffeeService coffeeService = new CoffeeService(coffeeMachineService);

            var drink = coffeeService.GetSelectedDrinkOption(3);
            Assert.AreEqual(drink.GetDrinkType(), DrinkType.LATTE);
        }

        [Test(Description = "Check valid selection for cuppacino")]
        public void Check_Valid_Selection_For_Cuppacino()
        {
            ICoffeeMachineService coffeeMachineService = new CoffeeMachineService();
            ICoffeeService coffeeService = new CoffeeService(coffeeMachineService);

            var drink = coffeeService.GetSelectedDrinkOption(1);
            Assert.AreEqual(drink.GetDrinkType(), DrinkType.CUPPACCINO);
        }
    }
}
