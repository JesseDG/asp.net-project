using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
        generateDropDownList();
        if (IsPostBack)
        {
            Validate();
            if (IsValid)
            {
                NameValueCollection POST = Request.Form;
                if (approved.Checked == true && (!string.IsNullOrEmpty(POST["password"]) ||
                        !string.IsNullOrEmpty(POST["passwordSecond"])) && POST["password"] == POST["passwordSecond"])
                {
                    if (!string.IsNullOrEmpty(POST["fname"]) ||
                        !string.IsNullOrEmpty(POST["lname"]) ||
                        !string.IsNullOrEmpty(POST["gender"]) ||
                        !string.IsNullOrEmpty(POST["month"]) ||
                        !string.IsNullOrEmpty(POST["day"]) ||
                        !string.IsNullOrEmpty(POST["year"]) ||
                        !string.IsNullOrEmpty(POST["city"]) ||
                        !string.IsNullOrEmpty(POST["countryList"]) ||
                        !string.IsNullOrEmpty(POST["address"]) ||
                        !string.IsNullOrEmpty(POST["provinceOrstate"]) ||
                        !string.IsNullOrEmpty(POST["zipCode"]))
                    {
                        EmployeeComDataContext dataContext = new EmployeeComDataContext();
                        /**fill the usertbl table**/
                        usertbl newUser = new usertbl();

                        newUser.firstName = POST["fname"];
                        newUser.lastName = POST["lname"];
                        newUser.gender = POST["gender"];
                        newUser.date_birth = POST["month"] + "/" + POST["day"] + "/" + POST["year"];


                        dataContext.usertbls.InsertOnSubmit(newUser);
                        dataContext.SubmitChanges();

                        /**fill the profile table**/
                        profile newProfile = new profile();

                        var results = from usertbl in dataContext.usertbls
                                      where usertbl.firstName == POST["fname"]
                                          && usertbl.lastName == POST["lname"]
                                      select usertbl;
                        int id = int.MaxValue;
                        foreach (usertbl value in results)
                        {
                            id = value.Id;
                        }
                        newProfile.UserName = POST["username"];
                        newProfile.password = POST["password"];
                        newProfile.user_id = id;


                        dataContext.profiles.InsertOnSubmit(newProfile);
                        dataContext.SubmitChanges();

                        /**fill the user_location table**/
                        user_location newUserLocation = new user_location();

                        newUserLocation.city = POST["city"];
                        newUserLocation.country = POST["countryList"];
                        newUserLocation.street_addr = POST["address"];
                        newUserLocation.province_state = POST["provinceOrstate"];
                        newUserLocation.postal_zipCode = POST["zipCode"];
                        newUserLocation.user_id = id;
                        dataContext.user_locations.InsertOnSubmit(newUserLocation);
                        dataContext.SubmitChanges();

                        Response.Redirect("/index.aspx");
                        

                    }
                }

            }

        }
    }
    protected void generateDropDownList()
    {
        string[] countries = System.IO.File.ReadAllLines(@"E:\SEMESTER 5\Ecommerce\ASP.NET\ASSIGNMENT1\as1\countries.txt");

        foreach (String line in countries)
        {
            countryList.Items.Add(line);
        }
    }
}
