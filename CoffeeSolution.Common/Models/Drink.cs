using CoffeeSolution.Common.Enums;
using CoffeeSolution.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSolution.Common.Models
{
    public class Drink : IDrink
    {
        internal int _beans;
        internal int _milk;
        internal readonly DrinkType _drinkType;

        public Drink(int beans, int milk, DrinkType drinkType)
        {
            _beans = beans;
            _drinkType = drinkType;
            _milk = milk;
        }

        public virtual int GetBeans()
        {
            return _beans;
        }

        public virtual int GetMilk()
        {
            return _milk;
        }

        public DrinkType GetDrinkType()
        {
            return _drinkType;
        }
    }
}
