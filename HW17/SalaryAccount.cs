using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW17
{
    public class SalaryAccount : ICalculatedAccount
    { 
        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        public void CalculateInterest()
        {
            Interest = Balance * 0.5;
        }
    }
}
