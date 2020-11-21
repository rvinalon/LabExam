using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHelper
{
    public class LoanCalculator
    {
        public decimal GetLoanAmount(decimal basicSalary)
        {
            return basicSalary * 2.5M;
        }

        public decimal GetInterest(decimal loanAmount, int numberOfMonthsToPay)
        {
            var interestRate = GetInterestRate(numberOfMonthsToPay);
            return loanAmount * numberOfMonthsToPay * interestRate;
        }

        public decimal GetTakeHomeLoan(decimal loanAmount, decimal interest)
        {
            decimal deduction = interest + (loanAmount * 0.02M);
            return loanAmount - deduction;
        }

        public decimal GetMonthlyAmortization(decimal loanAmount, int numberOfMonthsToPay)
        {
            return loanAmount / numberOfMonthsToPay;
        }

        public decimal GetServiceCharge(decimal loanAmount)
        {
            return loanAmount * 0.02M;
        }

        public decimal GetInterestRate(int numberOfMonthsToPay)
        {

            if (numberOfMonthsToPay > 0 && numberOfMonthsToPay <= 5)
            {
                return 0.0062M;
            }

            if (numberOfMonthsToPay > 5 && numberOfMonthsToPay <= 10)
            {
                return 0.0065M;
            }

            if (numberOfMonthsToPay > 10 && numberOfMonthsToPay <= 15)
            {
                return 0.0068M;
            }

            if (numberOfMonthsToPay > 15 && numberOfMonthsToPay <= 20)
            {
                return 0.0075M;
            }

            if (numberOfMonthsToPay > 20)
            {
                return 0.0080M;
            }

            return 0.00M;
        }
    }
}
