using System;
using System.Collections.Generic;
using System.Text;

namespace TipCalculator.Core.Services
{
    public class CalculatorService : ICalculatorService
    {
        public decimal TipAmount(decimal subtotal, double generosity)
        {
            return subtotal * (decimal)(generosity / 100);
        }
    }
}
