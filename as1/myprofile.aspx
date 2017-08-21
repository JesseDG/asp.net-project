<%@ Page Language="C#" AutoEventWireup="true" CodeFile="myprofile.aspx.cs" Inherits="myprofile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
	<meta name="viewport" content="width=1,initial-scale=1,user-scalable=1" />
	<title>Assignment 1</title>
	
	<link href="http://fonts.googleapis.com/css?family=Lato:100italic,100,300italic,300,400italic,400,700italic,700,900italic,900" rel="stylesheet" type="text/css"/>
	<link rel="stylesheet" type="text/css" href="assets/bootstrap/css/bootstrap.min.css" />
	<link rel="stylesheet" type="text/css" href="assets/css/styles.css" />
</head>
<body>
		<form role="login" runat="server" style="width:75%;background-color:transparent;margin:auto;">
          
                 <nav class="navbar navbar-inverse" style="background-color:#003">
                      <div class="container-fluid">

                          <asp:ImageButton ImageUrl="~/assets/images/Capture.png" ID="LogoutDiv" runat="server" OnClick="logoutSession"/>

                          <img src="assets/images/currentUser.png" id="currentProfile" height="80"/>
                          <asp:Label ID="session" runat="server" ForeColor="White"></asp:Label>
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

            <div style="display:block;border:inset white;margin-bottom:5%;">
                <label class="uniqueWidth" style="color:white">First Name: </label><asp:Textbox  id="fName" placeholder="First Name"  CssClass="input-lg" AutoPostBack="false" runat="server"/>
                <br />
                <label class="uniqueWidth" style="color:white">Last Name: </label><asp:Textbox  id="lName" placeholder="Last name"  CssClass="input-lg"  runat="server"/>
                <br />
                <label class="uniqueWidth" style="color:white;">Gender: </label><asp:Textbox  id="genderBox" placeholder="Gender"  CssClass="input-lg" runat="server" />
                <br />
                <asp:CustomValidator onservervalidate="genderValidation" ControlToValidate="genderBox" runat="server" ForeColor="White" ErrorMessage="Must be either male or female" Display="Dynamic" />
                <br />
                <label class="uniqueWidth" style="color:white;">Birth date: </label><asp:Textbox   id="birthDate" placeholder="Birth date"  CssClass="input-lg" runat="server"/>
                <br />
            </div>
 

            <div  style="display:block;border:inset white;margin-bottom:5%;">
                <label class="uniqueWidth" style="color:white">User Name: </label><asp:Textbox  id="username" CssClass="input-lg" runat="server" ReadOnly="true"/>
                <br />
                <label class="uniqueWidth" style="color:white">Password: </label><asp:Textbox   id="password" placeholder="password"  CssClass="input-lg"  runat="server" />
                <br /> 
                <asp:RegularExpressionValidator Display = "Dynamic" ControlToValidate = "password" ID="RegularExpressionValidator1" ValidationExpression = "^[0-9a-zA-Z]{7,20}$" runat="server" ErrorMessage="Password must consist of 7 to 20 characters without any blank space" ForeColor="White"></asp:RegularExpressionValidator>               
            </div>

   
            <div style="display:block;border:inset white;">
                <label class="uniqueWidth" style="color:white">Street Address: </label><asp:Textbox  id="address" placeholder="Street Address" CssClass="input-lg"  runat="server" />
                <br />
                <label class="uniqueWidth" style="color:white">City: </label><asp:Textbox   id="city" placeholder="City" CssClass="input-lg"  runat="server"/>
                <br />
                <label class="uniqueWidth" style="color:white">Province or State: </label><asp:Textbox  id="provinceOrstate"  CssClass="input-lg" runat="server"/>
                <br />
                <label class="uniqueWidth" style="color:white">Country: </label><asp:Textbox  id="country"   CssClass="input-lg"  runat="server"/>
                <br />
                <!--IN THIS PART HERE WE WEREN'T SURE WHETHER TO PUT A REGEX VALIDATOR SINCE WE ARE USING MULTIPLE COUNTRIES-->
                <label class="uniqueWidth" style="color:white">Zip or postal code: </label><asp:Textbox  id="zipPostal"  CssClass="input-lg" runat="server"/>
                <br />
              
            </div>
                <br />
                <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" Text="Submit information" OnClick="Button1_Click"/>

            <style>
                .uniqueWidth{
                    width:140px;
                }
            </style>

		</form>
	
	<script src="http://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js"></script>
	<script src="assets/bootstrap/js/bootstrap.min.js"></script>	

</body>
</html>
