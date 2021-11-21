using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeWarsSolutions;

namespace CodeWarsSolutions.Interfaces
{
    public interface IRentalCalculator
    {
        public int TotalPriceNoDiscountApplied(int days);
        public int DiscountOffTotalPrice(int days);
        public int TotalPriceAfterDiscount(int days);
    }
}