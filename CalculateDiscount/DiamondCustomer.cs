﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateDiscount
{
    public class DiamondCustomer:ICustomer
    {
        public double Calculate(double amount)
        {
            double calAmount = (amount * 20) / 100;
            return calAmount;
        }
    }
}
