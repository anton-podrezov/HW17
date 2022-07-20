using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW17
{
    public interface ICalculatedAccount
    {
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }
        public void CalculateInterest();
    }
}
