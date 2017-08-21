using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class profilesControl : System.Web.UI.UserControl
{
    private string userName;

    public string UserName
    {
        get { return userName; }
        set { userName = value; }
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }
}