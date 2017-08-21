using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Specialized;

public partial class user : System.Web.UI.Page
{
    EmployeeComDataContext dataContext = new EmployeeComDataContext();
    String profileName = "";
    String loggedInProfile = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        
        NameValueCollection GET = Request.QueryString;
            if (GET["profile"] != null)
            {

                profileName = GET["profile"];
                if (!IsPostBack)
                {
                    header.Text += profileName;
                }
            }
            loggedInProfile = Session["username"].ToString();
        
        //Retrieving the info only
        int currentUser_ID = 0;
        var queryProfiletbl = from profile in dataContext.profiles where profile.UserName == profileName select profile;
        foreach (profile value in queryProfiletbl)
        {
            currentUser_ID = value.user_id;
        }

        var personInfo = from usertbl in dataContext.usertbls where usertbl.Id == currentUser_ID select usertbl;
        foreach (usertbl value in personInfo)
        {
            fName.Text = value.firstName;
            lName.Text = value.lastName;
            birthDate.Text = value.date_birth;
            gender.Text = value.gender;
        }

        var locationInfo = from user_location in dataContext.user_locations where user_location.user_id == currentUser_ID select user_location;
        foreach (user_location value in locationInfo)
        {
            country.Text = value.country;
            address.Text = value.street_addr;
            city.Text = value.city;
            zipPostal.Text = value.postal_zipCode;
            provinceOrstate.Text = value.province_state;
        }

        if (!string.IsNullOrEmpty(emailTextBox.Text))
        {
            int loggedinID = 0;
            var query = from profile in dataContext.profiles where profile.UserName == Session["username"].ToString() select profile;
            foreach (profile value in query)
            {
                loggedinID = value.Id;
            }


            //CREATE NEW MESSAGE
            message msg = new message();
            msg.messageText = emailTextBox.Text;
            msg.sender_ID = loggedinID;

            var gettingProfileID = from profile in dataContext.profiles where profile.user_id == currentUser_ID select profile.Id;
            msg.receiver_ID = gettingProfileID.First();
            msg.time = DateTime.Now;

            dataContext.messages.InsertOnSubmit(msg);
            dataContext.SubmitChanges();

            Response.Redirect(Request.RawUrl);
        }


    }
  
}