using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW17
{
    public class Calculator
    {
        public static void CalculateInterest(ICalculatedAccount account)
        {
            account.CalculateInterest();
        }
    }
}
