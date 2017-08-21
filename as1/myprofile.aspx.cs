using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class myprofile : System.Web.UI.Page
{

    private EmployeeComDataContext dataContext = new EmployeeComDataContext();
   

    protected void Page_Load(object sender, EventArgs e)
    {


        UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;

        int user_idQuery = int.MaxValue;
        string currentuser = Session["username"].ToString();
        session.Text = currentuser;
        if (!IsPostBack)
        {
            //RETRIEVE DATA OF THE CURRENT PROFILE
            var queryProfile = from profile in dataContext.profiles where profile.UserName == currentuser select profile;

            foreach (profile values in queryProfile)
            {
                password.Text = values.password;
                username.Text = values.UserName;
                user_idQuery = values.user_id;
            }

            //RETRIEVE PERSONAL INFORMATION
            var queryPersonal = from usertbl in dataContext.usertbls where usertbl.Id == user_idQuery select usertbl;
            foreach (usertbl values in queryPersonal)
            {
                fName.Text = values.firstName;
                lName.Text = values.lastName;
                genderBox.Text = values.gender.ToString().Trim();
                birthDate.Text = values.date_birth;
            }

            //RETRIEVE LOCATION OF THE USER
            var queryLocation = from user_location in dataContext.user_locations where user_location.user_id == user_idQuery select user_location;
            foreach (user_location values in queryLocation)
            {
                address.Text = values.street_addr;
                city.Text = values.city;
                provinceOrstate.Text = values.province_state;
                zipPostal.Text = values.postal_zipCode;
                country.Text = values.country;
            }
        }
    }

    protected void logoutSession(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("index.aspx");
    }


    protected void Button1_Click(object sender, EventArgs e)
    {

        //WHEN CLICKING THE BUTTON IT TAKES ALL THE VALUES IN THE TEXTBOXES AND UPDATE DB ONE SHOT
        int user_idQuery = int.MaxValue;
        var profiletbl = from profile in dataContext.profiles where profile.UserName == Session["username"].ToString() select profile;
        foreach (profile value in profiletbl)
        {
            value.password = password.Text;
            user_idQuery = value.user_id;
        }
        dataContext.SubmitChanges();


        var usertable = from usertbl in dataContext.usertbls where usertbl.Id == user_idQuery select usertbl;
        foreach (usertbl value in usertable)
        {
            value.firstName = fName.Text;
            value.lastName = lName.Text;
            value.gender = genderBox.Text;
            value.date_birth = birthDate.Text;
        }
        dataContext.SubmitChanges();

        var locationtbl = from user_location in dataContext.user_locations where user_location.user_id == user_idQuery select user_location;
        foreach (user_location value in locationtbl)
        {
            value.street_addr = address.Text;
            value.city = city.Text;
            value.country = country.Text;
            value.postal_zipCode = zipPostal.Text;
            value.province_state = provinceOrstate.Text;
        }
        dataContext.SubmitChanges();
        Response.Redirect("main.aspx");
    }

    protected void genderValidation(object sender, ServerValidateEventArgs e)
    {
        if (!"male".Equals(e.Value.ToString().ToLower()) || !"female".Equals(e.Value.ToString().ToLower()))
        {
            e.IsValid = false;
        }
    }

}