using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeWarsSolutions;
using CodeWarsSolutions.Interfaces;

namespace CodeWarsSolutions.Objects
{
    public class RentalCalculator : IRentalCalculator
    {
        public int _discountToApply;
        public int _TotalBeforeDiscount;

        public int TotalPriceAfterDiscount(int days)
        {
            _discountToApply = DiscountOffTotalPrice(days);
            _TotalBeforeDiscount = TotalPriceNoDiscountApplied(days);
            return (_TotalBeforeDiscount - _discountToApply);
        }

        public int DiscountOffTotalPrice(int days)
        {
            if (days >= 3 && days < 7)
            {
                return 20;
            }
            else if (days >= 7)
            {
                return 50;
            }
            else return 0;
        }

        public int TotalPriceNoDiscountApplied(int days)
        {
            return days * 40;
        }
    }
}
