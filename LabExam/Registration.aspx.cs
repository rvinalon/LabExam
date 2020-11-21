using DataHelper;
using System;
using System.Web.UI;
namespace LabExam
{
    public partial class Registration : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            DataAccess myData = new DataAccess();
            myData.SaveRecords(txtFName.Text, txtLName.Text, txtEmail.Text, txtPassWord.Text);
            Response.Redirect("LoginPage.aspx");
        }
    }
}