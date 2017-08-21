using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.SessionState;

public partial class main : System.Web.UI.Page, IRequiresSessionState
{
    EmployeeComDataContext dataContext = new EmployeeComDataContext();
    TextBox txt = new TextBox();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        int id = 0;
        session.Text =  Session["username"].ToString();
        

        var query = from profile in dataContext.profiles select profile;
 
        foreach (profile value in query)
        {

            //if the profile is the same as the one logged in just continue
            if (value.UserName.Equals(session.Text.ToString()))
            {
                continue;
            }
            else
            {
                //LOAD THE PROFILE CONTROL
                profilesControl profCon = (profilesControl)LoadControl("~/profilesControl.ascx");

                //FIND THE IMAGE CONTROL TO SET UP A PICTURE
                Image img = (Image)profCon.FindControl("profileImg");
                HyperLink hp = (HyperLink)profCon.FindControl("usernameProfile");

                //RETRIEVE THE GENDER BY MATCHING THE ID'S IN USERTBL AND PROFILE TABLES
                 id = value.user_id;
                var inner_query = from usertbl in dataContext.usertbls
                                  where usertbl.Id == id
                                  select usertbl;

                //Set the image gender
                foreach (usertbl squery in inner_query)
                {
                    string genderQ = squery.gender;
                    string male = "male";

                    if (genderQ.Trim().Equals(male))
                    {
                        img.ImageUrl = "~/assets/images/boy.png";
                    }
                    else
                    {
                        img.ImageUrl = "~/assets/images/girl.png";
                    }
                }

                //set the hyperlink 
                profCon.UserName = value.UserName;
                hp.NavigateUrl = "user.aspx?profile=" + value.UserName;
                profiles.Controls.Add(profCon);
            }
        }

        //checking if any message has been sent
        var queryUser = from profile in dataContext.profiles where profile.UserName == Session["username"].ToString() select profile.Id;
        var queryMessages = from message in dataContext.messages where message.receiver_ID == queryUser.First() select message;
        foreach (message value in queryMessages)
        {
            //if the message hasn't yet been seen then display
            if (value.seen == null)
            {
                MessagesControl msgControl = (MessagesControl)LoadControl("~/MessagesControl.ascx");

                var querySec = from profile in dataContext.profiles where profile.Id == value.sender_ID select profile.UserName;

                msgControl.ID = value.Id;
                msgControl.Message = value.messageText;
                msgControl.TimeStamp = value.time;
                msgControl.Username = querySec.First();
                msgControl.replyEvent += replyEventHandler;

                PlaceHolderMessage.Controls.Add(msgControl);
            }
        }
    }

    protected void logoutSession(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("index.aspx");
    }


    protected void replyEventHandler(object sender, EventArgs e)
    {
        //first get the button and then the parent control to finally retrieve the current textbox 
        Button submitBtn = (Button)sender;
        Control ctrl = submitBtn.Parent;
        TextBox txt = (TextBox)ctrl.FindControl("reply");

        if (!string.IsNullOrEmpty(txt.Text.ToString()))
        {

            int ID = int.Parse(((Button)sender).CommandArgument);
            int id_newReceiver = 0;

            var seenMode = from message in dataContext.messages where message.Id == ID select message;
            foreach (message valueHere in seenMode)
            {
                valueHere.seen = 1;
                id_newReceiver = valueHere.sender_ID;
                dataContext.SubmitChanges();
            }

            //create the reply
            message msg = new message();
            msg.messageText = txt.Text;
            msg.time = DateTime.Now;
            var querySender = from profile in dataContext.profiles where profile.UserName == Session["username"].ToString() select profile.Id;
            msg.sender_ID = querySender.First();
            msg.receiver_ID = id_newReceiver;
            dataContext.messages.InsertOnSubmit(msg);
            dataContext.SubmitChanges();

            Response.Redirect(Request.RawUrl);
        }
    }
}