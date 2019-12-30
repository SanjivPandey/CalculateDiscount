using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CalculateDiscount
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICustomer customer = FactoryCustomer.CreateCustomer("Gold");
            double disAmount  = customer.Calculate(250);
            Console.WriteLine("Discount Amount is : ", disAmount);
            Console.ReadLine();
            
        }

      
    }
}
