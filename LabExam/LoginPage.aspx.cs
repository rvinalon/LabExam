using DataHelper;
using System;
using System.Diagnostics;
using System.Web.UI;

namespace LabExam
{
    public partial class LoginPage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Clear();
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            var dataAccess = new DataAccess();
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            LoginRecord record = dataAccess.GetRecord(userName, password);
            
            if (record != null && record.EmailAdd == userName && record.Password == password)
            {
                Session["Username"] = record.EmailAdd;
                Session["Password"] = record.Password;
                Session["IsLoggedIn"] = true;
                Response.Redirect("Default.aspx");
            }
            else
            {
                lblIncorrectLogin.Visible = true;
            }
        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }
    }
}