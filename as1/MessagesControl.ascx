<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MessagesControl.ascx.cs" Inherits="MessagesControl" %>
<link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">

<div class="col-sm-3" style="margin-top:20px;">
    <div class="well">
        <asp:Label Width="100%" ID="headerLabel" runat="server" >Message from <%=this.Username %> at <%= this.TimeStamp %>: </asp:Label>
        <br />
        <asp:Label Width="100%" ID="messageLabel" runat="server"><%= this.Message %></asp:Label>
        <asp:TextBox TextMode="MultiLine" ID="reply" runat="server" Columns="40" Rows="5"/>
        <br />
        <asp:Button ID="buttonAnswer" runat="server" width="75%" Height="5%" Text="Reply to message" OnClick="btnReply_Click"/>
    </div>
</div>

<style>
    #messageLabel{
        display:inline-block;
        position:relative;
        width:6em;
        top:-3px;
    } 
    #reply{
        display:inline-block;
        position:relative;
        width:6em;
        top:-3em;
    }
    #buttonAnswer{
        display:inline-block;
        position:relative;
        width:6em;
        top:-3em;
    }

</style>