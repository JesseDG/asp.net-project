<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

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

    <section class="container">
			<section class="login-form">
				<form method="post" action="" role="login" runat="server">

					<img src="assets/images/logo.png" class="img-responsive" alt=""  width="120"/>
					<input type="text" name="username" placeholder="User name" required class="form-control input-lg" autocomplete="off"/>
					<input type="password" name="password" placeholder="Password" required class="form-control input-lg" />

                    <div style="margin-left: auto; margin-right: auto; text-align: center;">
                        <asp:Label ID="Error" runat="server" ForeColor="Red"></asp:Label>
                    </div>

					<button type="submit" name="go" class="btn btn-lg btn-primary btn-block">Sign in</button>
					<div>
						<a href="register.aspx">Create account</a>
					</div>
				</form>
			</section>
	</section>
	
	<script src="http://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js"></script>
	<script src="assets/bootstrap/js/bootstrap.min.js"></script>
</body>
</html>
