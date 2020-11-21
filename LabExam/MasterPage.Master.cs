using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabExam
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool isLoggedIn = Session["IsLoggedIn"] != null && (bool)Session["IsLoggedIn"];
            if (isLoggedIn)
            {
                var email = (string)Session["Username"];
                txtUser.InnerText = email;
                linkLogin.InnerText = "Logout";
                linkViewRecords.Visible = true;
            }
        }
    }
}