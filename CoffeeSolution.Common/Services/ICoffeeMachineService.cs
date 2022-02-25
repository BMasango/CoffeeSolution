using CoffeeSolution.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSolution.Common.Services
{
    public interface ICoffeeMachineService
    {
        int BeansQuantity { get; }
        int MilkQuantity { get; }

        bool PrepareDrink(IDrink drink);
    }
}
