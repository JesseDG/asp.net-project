<%@ Page Language="C#" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="register" %>

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

      <h1 style="color:white;text-align:center;">Register</h1>
		<form method="post" action="register.aspx" role="login" runat="server" style="width:75%;background-color:transparent;margin:auto;">
          

            <div style="display:block;float:left;border-right:inset white;padding-right:5%;height:390px;">
                <input type="text" name="fname" placeholder="First name" required class="input-lg" />
                <br />
                <input type="text" name="lname" placeholder="Last name" required class="input-lg" />
                <br />

                <select name="gender" class="form-control" style="height:40px;margin-top:18px">
                    <option value="male">Male</option>
                    <option value="Female">Female</option>
                </select>
                <br />

                <h4 class="form-sub-label" style="color:white;margin:7px 0 -13px 0;text-align:left;" >Birth date</h4>

                <div class="form-input jf-required" style="padding-top:18px;">
                      <span class="form-sub-label-container" style="vertical-align: top;float:left;">
                        <select class="form-control" name="month" style="width:110px;padding-left:0;padding-right:2px">
                          <option>  </option>
                          <option value="January"> January </option>
                          <option value="February"> February </option>
                          <option value="March"> March </option>
                          <option value="April"> April </option>
                          <option value="May"> May </option>
                          <option value="June"> June </option>
                          <option value="July"> July </option>
                          <option value="August"> August </option>
                          <option value="September"> September </option>
                          <option value="October"> October </option>
                          <option value="November"> November </option>
                          <option value="December"> December </option>
                        </select>
                        <label class="form-sub-label" for="input_6_month" id="sublabel_month" style="min-height: 13px;color:white;"> Month </label>
                      </span>
                      <span class="form-sub-label-container" style="vertical-align: top;float:left;">
                        <select class="form-control" name="day" style="width:65px;">
                          <option>  </option>
                          <option value="1"> 1 </option>
                          <option value="2"> 2 </option>
                          <option value="3"> 3 </option>
                          <option value="4"> 4 </option>
                          <option value="5"> 5 </option>
                          <option value="6"> 6 </option>
                          <option value="7"> 7 </option>
                          <option value="8"> 8 </option>
                          <option value="9"> 9 </option>
                          <option value="10"> 10 </option>
                          <option value="11"> 11 </option>
                          <option value="12"> 12 </option>
                          <option value="13"> 13 </option>
                          <option value="14"> 14 </option>
                          <option value="15"> 15 </option>
                          <option value="16"> 16 </option>
                          <option value="17"> 17 </option>
                          <option value="18"> 18 </option>
                          <option value="19"> 19 </option>
                          <option value="20"> 20 </option>
                          <option value="21"> 21 </option>
                          <option value="22"> 22 </option>
                          <option value="23"> 23 </option>
                          <option value="24"> 24 </option>
                          <option value="25"> 25 </option>
                          <option value="26"> 26 </option>
                          <option value="27"> 27 </option>
                          <option value="28"> 28 </option>
                          <option value="29"> 29 </option>
                          <option value="30"> 30 </option>
                          <option value="31"> 31 </option>
                        </select>
                        <label class="form-sub-label" for="input_6_day" id="sublabel_day" style="min-height: 13px;color:white;"> Day </label>
                      </span>
                      <span class="form-sub-label-container" style="vertical-align: top">
                        <select class="form-control" name="year" style="width:80px;">
                          <option>  </option>
                          <option value="2016"> 2016 </option>
                          <option value="2015"> 2015 </option>
                          <option value="2014"> 2014 </option>
                          <option value="2013"> 2013 </option>
                          <option value="2012"> 2012 </option>
                          <option value="2011"> 2011 </option>
                          <option value="2010"> 2010 </option>
                          <option value="2009"> 2009 </option>
                          <option value="2008"> 2008 </option>
                          <option value="2007"> 2007 </option>
                          <option value="2006"> 2006 </option>
                          <option value="2005"> 2005 </option>
                          <option value="2004"> 2004 </option>
                          <option value="2003"> 2003 </option>
                          <option value="2002"> 2002 </option>
                          <option value="2001"> 2001 </option>
                          <option value="2000"> 2000 </option>
                          <option value="1999"> 1999 </option>
                          <option value="1998"> 1998 </option>
                          <option value="1997"> 1997 </option>
                          <option value="1996"> 1996 </option>
                          <option value="1995"> 1995 </option>
                          <option value="1994"> 1994 </option>
                          <option value="1993"> 1993 </option>
                          <option value="1992"> 1992 </option>
                          <option value="1991"> 1991 </option>
                          <option value="1990"> 1990 </option>
                          <option value="1989"> 1989 </option>
                          <option value="1988"> 1988 </option>
                          <option value="1987"> 1987 </option>
                          <option value="1986"> 1986 </option>
                          <option value="1985"> 1985 </option>
                          <option value="1984"> 1984 </option>
                          <option value="1983"> 1983 </option>
                          <option value="1982"> 1982 </option>
                          <option value="1981"> 1981 </option>
                          <option value="1980"> 1980 </option>
                          <option value="1979"> 1979 </option>
                          <option value="1978"> 1978 </option>
                          <option value="1977"> 1977 </option>
                          <option value="1976"> 1976 </option>
                          <option value="1975"> 1975 </option>
                          <option value="1974"> 1974 </option>
                          <option value="1973"> 1973 </option>
                          <option value="1972"> 1972 </option>
                          <option value="1971"> 1971 </option>
                          <option value="1970"> 1970 </option>
                          <option value="1969"> 1969 </option>
                          <option value="1968"> 1968 </option>
                          <option value="1967"> 1967 </option>
                          <option value="1966"> 1966 </option>
                          <option value="1965"> 1965 </option>
                          <option value="1964"> 1964 </option>
                          <option value="1963"> 1963 </option>
                          <option value="1962"> 1962 </option>
                          <option value="1961"> 1961 </option>
                          <option value="1960"> 1960 </option>
                          <option value="1959"> 1959 </option>
                          <option value="1958"> 1958 </option>
                          <option value="1957"> 1957 </option>
                          <option value="1956"> 1956 </option>
                          <option value="1955"> 1955 </option>
                          <option value="1954"> 1954 </option>
                          <option value="1953"> 1953 </option>
                          <option value="1952"> 1952 </option>
                          <option value="1951"> 1951 </option>
                          <option value="1950"> 1950 </option>
                          <option value="1949"> 1949 </option>
                          <option value="1948"> 1948 </option>
                          <option value="1947"> 1947 </option>
                          <option value="1946"> 1946 </option>
                          <option value="1945"> 1945 </option>
                          <option value="1944"> 1944 </option>
                          <option value="1943"> 1943 </option>
                          <option value="1942"> 1942 </option>
                          <option value="1941"> 1941 </option>
                          <option value="1940"> 1940 </option>
                          <option value="1939"> 1939 </option>
                          <option value="1938"> 1938 </option>
                          <option value="1937"> 1937 </option>
                          <option value="1936"> 1936 </option>
                          <option value="1935"> 1935 </option>
                          <option value="1934"> 1934 </option>
                          <option value="1933"> 1933 </option>
                          <option value="1932"> 1932 </option>
                          <option value="1931"> 1931 </option>
                          <option value="1930"> 1930 </option>
                          <option value="1929"> 1929 </option>
                          <option value="1928"> 1928 </option>
                          <option value="1927"> 1927 </option>
                          <option value="1926"> 1926 </option>
                          <option value="1925"> 1925 </option>
                          <option value="1924"> 1924 </option>
                          <option value="1923"> 1923 </option>
                          <option value="1922"> 1922 </option>
                          <option value="1921"> 1921 </option>
                          <option value="1920"> 1920 </option>
                        </select>
                        <label class="form-sub-label" for="input_6_year" id="sublabel_year" style="min-height: 13px;color:white;"> Year </label>
                      </span>
                    </div>
            </div>
 

            <div  style="float:right;">
                <asp:TextBox ID="username"  placeholder="User Name" CssClass="input-lg" Width="255px" runat="server"></asp:TextBox>
                <!--input type="text" name="userName" placeholder="User name" required class="input-lg" /-->
                <br />
                <asp:RequiredFieldValidator ID="userRequired" ControlToValidate="username" runat="server"  ErrorMessage="Enter a value within the field!" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                <br />
                <asp:RegularExpressionValidator Display = "Dynamic" ControlToValidate = "username" ID="UserNameRegularExpression" ValidationExpression = "^[0-9a-zA-Z]{7,20}$" runat="server" ErrorMessage="UserName must consist of 7 to 20 characters without any blank space"></asp:RegularExpressionValidator>
                <br />
                <asp:TextBox ID="password"  placeholder="Password" CssClass="input-lg" Width="255px" runat="server" ></asp:TextBox>
                <!--input type="password" name="password" placeholder="Password" required class="input-lg" /-->
                <br />
                <asp:RequiredFieldValidator ID="passwordRequired" ControlToValidate="password" runat="server" ErrorMessage="Enter a value within the field!" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                <br />
                <asp:RegularExpressionValidator Display = "Dynamic" ControlToValidate = "password" ID="RegularExpressionValidator1" ValidationExpression = "^[0-9a-zA-Z]{7,20}$" runat="server" ErrorMessage="Password must consist of 7 to 20 characters without any blank space"></asp:RegularExpressionValidator>
                <br />
                <asp:TextBox ID="passwordSecond" placeholder="Password" CssClass="input-lg" Width="255px" runat="server"></asp:TextBox>
                <br />
                <asp:CompareValidator id="comparePasswords" runat="server" ControlToCompare="password" ControlToValidate="passwordSecond" ErrorMessage="Your passwords do not match up!" Display="Dynamic" ForeColor="Red" />
                <br />
                <asp:RequiredFieldValidator ID="PasswordSecondRequired" ControlToValidate="passwordSecond" runat="server" ErrorMessage="Enter a value within the field!"  ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                <!--input type="password" name="passwordSecond" placeholder="Confirm Password" required class="input-lg" /-->
                
            </div>

   
            <div style="margin:0 auto;width:40%;border-right: inset white;">
                <input type="text" name="address" placeholder="Street Address" required class="input-lg" />
                <br />
                <input type="text" name="city" placeholder="City" required class="input-lg" />
                <br />
                <input type="text" name="provinceOrstate" placeholder="Province/State" required class="input-lg" />
                <br />
                <asp:DropDownList ID="countryList" CssClass="input-lg" Width="255px" runat="server" />
                <style>
                    #countryList{
                        margin-top:16px;
                        margin-bottom: 16px;
                    }
                </style>
                <br />
                <asp:TextBox id="zipCode" name="zipCode" CssClass="input-lg" runat="server" placeholder="Postal/Zip code"/>
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldZipCode" runat="server" ControlToValidate="zipCode" Display="Dynamic" Text="Enter a zip/postal code" ForeColor="White"></asp:RequiredFieldValidator>
            </div>



                <label style="color:white;display:block;text-align:center;"><asp:CheckBox ID="approved" runat="server" Checked="false"/>I agree to the terms of condition</label>

                <br />
                <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" Text="Submit information"/>
            <asp:Label ID="errorCheck" runat="server" Text="Testing will begin!" ForeColor="white"/>
		</form>
	
	<script src="http://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js"></script>
	<script src="assets/bootstrap/js/bootstrap.min.js"></script>	

</body>
</html>
