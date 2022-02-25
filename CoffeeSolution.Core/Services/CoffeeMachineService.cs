using CoffeeSolution.Common.Interfaces;
using CoffeeSolution.Common.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSolution.Core.Services
{
    public class CoffeeMachineService:ICoffeeMachineService
    {
        private int _beanQuantity = 25;
        private int _milkQuantity = 25;

        public int BeansQuantity { get { return _beanQuantity; } }
        public int MilkQuantity { get { return _milkQuantity; } }

        public bool PrepareDrink(IDrink drink)
        {
            var beans = drink.GetBeans();
            if (!HasEnough(beans, _beanQuantity))
            {
                Console.WriteLine("Insufficient beans available to make your drink");
                return false;
            }

            var milk = drink.GetMilk();
            if (!HasEnough(milk, _milkQuantity))
            {
                Console.WriteLine("Insufficient milk available to make your drink");
                return false;
            }

            DispenseDrink(beans, milk);
            return true;
        }

        private void DispenseDrink(int beans, int milk)
        {
            _beanQuantity -= beans;
            _milkQuantity -= milk;

            Console.WriteLine("Enjoy your drink");
        }

        private bool HasEnough(int requiredQuantity, int availableQuantity)
        {
            return availableQuantity >= requiredQuantity;
        }
    }
}
