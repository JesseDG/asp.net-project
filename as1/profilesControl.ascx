<%@ Control Language="C#" AutoEventWireup="true" CodeFile="profilesControl.ascx.cs" Inherits="profilesControl" %>
       
<link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">

<div class="col-sm-2 sidenav" style="margin-top:20px;">
    <div class="well">
        <asp:Image Width="60px" Height="60px" ID="profileImg" runat="server" />
        <asp:HyperLink ID="usernameProfile" runat="server"><%= this.UserName %></asp:HyperLink>
    </div>
</div>



<style>
    #allProfiles{
        display:block;
        position:absolute;
        margin:0 auto;
        width:100%;
        float:left;
    }
    .well{
        padding:0;
    }
    #usernameProfile{
        font-size:25px;
        color:black;
        padding-left:5px;
        cursor:pointer;
    }
    .sidenav{
        margin-right:1%;
        width:10%;
    }
</style>