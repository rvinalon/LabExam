using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHelper
{
    public class LoanApplication
    {
        public string EmailAdd { get; set; }
        public decimal LoanAmount { get; set; }
        public decimal Interest { get; set; }
        public decimal InterestRate { get; set; }
        public decimal TakeHomeLoan { get; set; }
        public decimal ServiceCharge { get; set; }
        public decimal MonthlyAmortization { get; set; }
    }
}
