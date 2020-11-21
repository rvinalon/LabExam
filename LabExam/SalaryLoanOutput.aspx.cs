using DataHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabExam
{
    public partial class SalaryLoanOutput : System.Web.UI.Page
    {
        private decimal BasicSalary;
        private int NumberOfMonthsToPay;
        private LoanApplication LoanApplication;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["BasicSalary"] == null || Session["NumberOfMonths"] == null)
            {
                divNoLoanDatExist.Visible = true;
                divLoanOutput.Visible = false;
            }
            else
            {
                BasicSalary = Convert.ToDecimal(Session["BasicSalary"]);
                NumberOfMonthsToPay = (int)Session["NumberOfMonths"];
                CalculateLoan();
                DisplayLoanOutput();
            }

        }

        private void CalculateLoan()
        {
            var calculator = new LoanCalculator();
            var loanApplication = new LoanApplication();

            loanApplication.EmailAdd = (string)Session["Username"];
            var loanAmount = calculator.GetLoanAmount(BasicSalary);
            loanApplication.LoanAmount = loanAmount;
            loanApplication.InterestRate = calculator.GetInterestRate(NumberOfMonthsToPay);
            loanApplication.Interest = calculator.GetInterest(loanAmount, NumberOfMonthsToPay);
            loanApplication.MonthlyAmortization = calculator.GetMonthlyAmortization(loanAmount, NumberOfMonthsToPay);
            loanApplication.ServiceCharge = calculator.GetServiceCharge(loanAmount);
            loanApplication.TakeHomeLoan = calculator.GetTakeHomeLoan(loanAmount, loanApplication.Interest);
            LoanApplication = loanApplication;
        }

        private void DisplayLoanOutput()
        {
            lblLoanAmount.Text =  LoanApplication.LoanAmount.ToString("F2"); 
            lblInterest.Text = LoanApplication.Interest.ToString("F2");
            lblServiceCharge.Text = LoanApplication.ServiceCharge.ToString("F2");
            lblTakeHomeLoan.Text = LoanApplication.TakeHomeLoan.ToString("F2");
            lblMonthlyAmortization.Text = LoanApplication.MonthlyAmortization.ToString("F2");
        }

        protected void EnterDetailsBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void saveLoanBtn_Click(object sender, EventArgs e)
        {
            if (LoanApplication != null)
            {
                var dataAccess = new DataAccess();
                dataAccess.SaveLoanApplication(LoanApplication);
                lblApplicationSaved.Visible = true;
            }
        }
    }
}