<%@ Page Language="C#" AutoEventWireup="true" CodeFile="main.aspx.cs" Inherits="main" %>
<%@ Reference Control="~/profilesControl.ascx" %>
<%@ Reference Control="~/MessagesControl.ascx" %>
<!DOCTYPE html>
<html lang="en">
<head>
  <title>Bootstrap Example</title>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
  <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
  <link href="https://fonts.googleapis.com/css?family=Raleway:700" rel="stylesheet">
  <style>
    /* Remove the navbar's default margin-bottom and rounded borders */
    .navbar {
      margin-bottom: 0;
      border-radius: 0;
    }
    
    /* Set height of the grid so .sidenav can be 100% (adjust as needed) */
    .row.content {height: 450px}
    
    /* Set gray background color and 100% height */
    .sidenav {
      padding-top: 20px;
      background-color: #f1f1f1;
      height: 100%;
    }
        
    /* On small screens, set height to 'auto' for sidenav and grid */
    @media screen and (max-width: 767px) {
      .sidenav {
        height: auto;
        padding: 15px;
      }
      .row.content {height:auto;}
    }
    .navbar-inverse{
        background-color:#000222;
        margin-top:1.5%;
    }
    .sidenav, .well{
        background-color:#eee;
    }
  </style>
</head>
<body style="background-image:url(../assets/images/bg.jpg);height:100%;display:block;position:absolute;width:100%;background-size:100%;">


    <form id="form1" runat="server">

        <nav class="navbar navbar-inverse" style="background-color:#003">
          <div class="container-fluid">

              <asp:ImageButton ImageUrl="~/assets/images/Capture.png" ID="LogoutDiv" runat="server" OnClick="logoutSession"/>

              <img src="assets/images/currentUser.png" id="currentProfile" height="80"/>
              <asp:Label ID="session" runat="server" ForeColor="White"></asp:Label>
              <asp:HyperLink ID="currentprofile_link" runat="server" NavigateUrl="~/myprofile.aspx?edit=1">My profile</asp:HyperLink>
              <style>
                  #currentProfile{
                      margin:0 auto;
                      display:block;
                      position:relative;
                      clear:both;
                  }
                  .navbar{
                      padding-bottom:1%;
                  }
                  #session{
                      text-align:center;
                      margin:0 auto;
                      display:block; 
                      font-size:25px;
                  }
                  #currentprofile_link{
                      text-align:center;
                      margin:0 auto;
                      display:block;
                      font-size:20px;
                  }
                  #LogoutDiv{
                      display:block;
                      margin:0 auto; 
                      float:right;
                      padding-right:5px;
                      padding-top:5px;
                  }
              </style>
          </div>
        </nav>
        <label style="text-align:center;margin:0 auto;display:block;color:white;font-size:x-large;border-bottom:inset white;font-family: 'Raleway', sans-serif;">List of profiles</label>
        <div id="allProfiles" class="col-lg-6" style="">
            <asp:PlaceHolder ID="profiles" runat="server"/>
        </div>

       
        <div id="messagesBox" style="width:100%;height:100%; margin-top:20%;border-top:inset white" class="col-lg-6">
           <asp:PlaceHolder ID="PlaceHolderMessage" runat="server"/>
        </div>
		
    </form>
</body>
</html>

