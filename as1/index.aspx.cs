using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Specialized;
/**
Daniel Diego-Garcia
Walid Ennaceur
**/
public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;

        EmployeeComDataContext dataContext = new EmployeeComDataContext();

        NameValueCollection POST = Request.Form;
        string userName = "";
        if (!string.IsNullOrEmpty(POST["username"]) || !string.IsNullOrEmpty(POST["password"]))
        {
            userName = POST["username"];
            string pass = POST["password"];
            var results = from profile in dataContext.profiles where profile.UserName == userName && profile.password == pass select profile;
            if (results.Count() == 0)
            {
                Error.Text = "Username or Password is not valid";
            }
            else
            {
                Session["username"] = userName;
                Response.Redirect("main.aspx");
            }
        }
    }
}