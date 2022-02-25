using CoffeeSolution.Common.Interfaces;
using CoffeeSolution.Common.Models;
using CoffeeSolution.Common.Services;
using CoffeeSolution.Core.Services;
using NUnit.Framework;
using System;
using System.IO;

namespace CoffeeSolution.Test
{
    [TestFixture]
    public class CoffeeMachineServiceTes
    {
        [Test(Description ="Only 12 coffee's can be prepared at defualt settings")]        
        public void Prepare_Normal_Coffee_Should_Prepare_Twelve_Cups()
        {
            ICoffeeMachineService coffeeMachineService = new CoffeeMachineService();
            IDrink drink = new Coffee();

            StringWriter stringwriter = new StringWriter();
            Console.SetOut(stringwriter);

            string answer = "";
            for (int i = 1; i <= 13; i++)
            {
                if (i % 2 == 0)
                    answer = "y";
                else answer = "n";

                var stringReader = new StringReader(answer);
                Console.SetIn(stringReader);

                if (i <= 12)
                    Assert.AreEqual(coffeeMachineService.PrepareDrink(drink), true);
                else
                    Assert.AreEqual(coffeeMachineService.PrepareDrink(drink), false);
            }
        }

        [Test(Description = "Only 5 cuppacino's can be prepared at defualt settings")]
        public void Prepare_Normal_Cuppacino_Should_Prepare_Five_Cups()
        {
            ICoffeeMachineService coffeeMachineService = new CoffeeMachineService();
            IDrink drink = new Cuppaccino();

            StringWriter stringwriter = new StringWriter();
            Console.SetOut(stringwriter);

            for (int i = 1; i <= 6; i++)
            {
                var stringReader = new StringReader(i.ToString());
                Console.SetIn(stringReader);

                if (i <= 5)
                    Assert.AreEqual(coffeeMachineService.PrepareDrink(drink), true);
                else
                    Assert.AreEqual(coffeeMachineService.PrepareDrink(drink), false);
            }
        }

        [Test(Description = "Only 8 latte's can be prepared at defualt settings")]
        public void Prepare_Normal_Latte_Should_Prepare_Eight_Cups()
        {
            ICoffeeMachineService coffeeMachineService = new CoffeeMachineService();
            IDrink drink = new Latte();

            for (int i = 1; i <= 9; i++)
            {
                if (i <= 8)
                    Assert.AreEqual(coffeeMachineService.PrepareDrink(drink), true);
                else
                    Assert.AreEqual(coffeeMachineService.PrepareDrink(drink), false);
            }
        }

        [Test(Description = "Check if the ingredients are being tracked")]
        public void Check_Ingredient_tracking()
        {
            ICoffeeMachineService coffeeMachineService = new CoffeeMachineService();
            IDrink drink = new Latte();

            int lastBeans = coffeeMachineService.BeansQuantity;
            int lastMilk = coffeeMachineService.MilkQuantity;

            coffeeMachineService.PrepareDrink(drink);
            Assert.AreEqual(coffeeMachineService.BeansQuantity, lastBeans - drink.GetBeans());
            Assert.AreEqual(coffeeMachineService.MilkQuantity, lastMilk - drink.GetMilk());
        }

        [Test(Description = "Check coffee without milk doesnt decrease ingredient")]
        public void Check_Milk_tracking_For_Coffee_Without_Milk()
        {
            ICoffeeMachineService coffeeMachineService = new CoffeeMachineService();
            IDrink drink = new Coffee();
            int lastMilk = coffeeMachineService.MilkQuantity;

            var stringwriter = new StringWriter();
            Console.SetOut(stringwriter);
            var stringReader = new StringReader("n");
            Console.SetIn(stringReader);

            coffeeMachineService.PrepareDrink(drink);
            Assert.AreEqual(coffeeMachineService.MilkQuantity, lastMilk);
        }
    }
}