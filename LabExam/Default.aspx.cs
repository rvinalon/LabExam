using System;

namespace LabExam
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool isLoggedIn = Session["IsLoggedIn"] != null && (bool)Session["IsLoggedIn"];
            if (!isLoggedIn)
            {
                Response.Redirect("LoginPage.aspx");
            }
        }

        protected void CalculateBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBasicSalary.Text) && !string.IsNullOrEmpty(txtNumberOfMonths.Text))
            {
                decimal basicSalary = Convert.ToDecimal(txtBasicSalary.Text);
                Session["BasicSalary"] = basicSalary;

                int numberOfMonthsToPay = Convert.ToInt32(txtNumberOfMonths.Text);
                Session["NumberOfMonths"] = numberOfMonthsToPay;

                Response.Redirect("SalaryLoanOutput.aspx");
            }
        }
    }
}