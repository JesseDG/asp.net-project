using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MessagesControl : System.Web.UI.UserControl
{

    private string message;
    private string username;
    private DateTime dateTime;
    public event EventHandler replyEvent = null;
    private int id;

    public String Message
    {
        get { return message; }
        set { message = value; }
    }

    public String Username
    {
        get { return username; }
        set { username = value; }
    }
    public DateTime TimeStamp
    {
        get { return dateTime; }
        set { dateTime = value; }
    }
    public int ID
    {
        get { return id; }
        set { id = value; }
    }


    protected void Page_Load(object sender, EventArgs e)
    {
        buttonAnswer.CommandArgument = id.ToString();
    }

    protected void btnReply_Click(object sender, EventArgs e)
    {
        if (replyEvent != null)
        {
            replyEvent(sender, e);
        }
    }
}