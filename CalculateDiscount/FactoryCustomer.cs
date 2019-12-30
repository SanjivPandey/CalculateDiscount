using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateDiscount
{
    public static class FactoryCustomer
    {
        public static ICustomer CreateCustomer( string cust)
        {
            if (cust == "Gold")
                return new GoldCustomer();
            else if (cust == "Diam")
                return new DiamondCustomer();
            else
                return new NormalCustomer();
        }
    }
}
