<%@ Page Language="C#" AutoEventWireup="true" CodeFile="user.aspx.cs" Inherits="user" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link href="http://fonts.googleapis.com/css?family=Lato:100italic,100,300italic,300,400italic,400,700italic,700,900italic,900" rel="stylesheet" type="text/css"/>
	<link rel="stylesheet" type="text/css" href="assets/bootstrap/css/bootstrap.min.css" />
	<link rel="stylesheet" type="text/css" href="assets/css/styles.css" />
</head>
<body>
    <form id="form1" runat="server" style="width:75%;background-color:transparent;margin:auto;">
              
              <asp:Label ID="header" Text="The profile of " runat="server" Width="80%" Height="5%" Font-Size="X-Large" BackColor="#0000ff" ForeColor="cyan" ></asp:Label>
               <style>#header{padding-top:1%; padding-bottom:1%; padding-left:4%; padding-right:4%;margin-bottom:2%;}</style>
              <div style=" padding-top:2%; ">

                <div style="display:block;border:inset white;margin-bottom:5%;width:45%;">
                    <label class="uniqueWidth" style="color:white">First Name: </label><asp:Textbox  id="fName" ReadOnly="true" CssClass="input-lg" AutoPostBack="true" runat="server" />
                    <br />
                    <label class="uniqueWidth" style="color:white">Last Name: </label><asp:Textbox    id="lName" ReadOnly="true"  CssClass="input-lg"  runat="server"/>
                    <br />
                    <label class="uniqueWidth" style="color:white;">Gender: </label><asp:Textbox    id="gender" ReadOnly="true"  CssClass="input-lg" runat="server"/>
                    <br />
                    <label class="uniqueWidth" style="color:white;">Birth date: </label><asp:Textbox   id="birthDate"  ReadOnly="true" CssClass="input-lg" runat="server"/>
                    <br />
                </div>
   
                <div style="display:block;border:inset white;width:45%;float:left;clear:right; margin-bottom:5%;">
                    <label class="uniqueWidth" style="color:white">Street Address: </label><asp:Textbox  id="address" ReadOnly="true" CssClass="input-lg"  runat="server" />
                    <br />
                    <label class="uniqueWidth" style="color:white">City: </label><asp:Textbox   id="city" CssClass="input-lg" ReadOnly="true" runat="server"/>
                    <br />
                    <label class="uniqueWidth" style="color:white">Province or State: </label><asp:Textbox  id="provinceOrstate"  ReadOnly="true" CssClass="input-lg" runat="server"/>
                    <br />
                    <label class="uniqueWidth" style="color:white">Country: </label><asp:Textbox  id="country"   CssClass="input-lg" ReadOnly="true" runat="server"/>
                    <br />
                    <label class="uniqueWidth" style="color:white">Zip or postal code: </label><asp:Textbox  id="zipPostal" ReadOnly="true"  CssClass="input-lg" runat="server"/>
                    <br />
                </div>
                  <br />
                <div style="display:block;margin-bottom:5%;width:45%;">
                    
                    <asp:TextBox ID="emailTextBox" runat="server" TextMode="multiline" Columns="63" Rows="10"></asp:TextBox>
                    <br />
                    <asp:Button ID="sendEmail" runat="server" Text="Send Message"  />
                    
                </div>
            </div>
             <style>
                .uniqueWidth{
                    width:140px;
                    margin-left:2%;
                }
            </style>
            
    </form>
</body>
</html>
