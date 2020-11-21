using DataHelper;
using System;
using System.Web.UI;

namespace LabExam
{
    public partial class ViewRecords : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataAccess myData = new DataAccess();
            var service = myData.DisplayLoanApplications();
            gridService.DataSource = service;
            gridService.DataBind();
        }
    }
}