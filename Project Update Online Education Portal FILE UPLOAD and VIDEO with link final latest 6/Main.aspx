
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
    <title>Welcome To Online Education Portal </title>

    <link rel="stylesheet" href="men_web_home.css" type="text/css" />
</head>
<body>


    <form id="form1" runat="server">


    <div id="container">
        <header id="page_header">
            <img src="images/imgportal.jpg" alt="logo" width='232' height='100' class="logo" />
            <h1 class="head_text"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; WELCOME TO ONLINE EDUCATION PORTAL</h1>
        </header>
    </div>

    <div id="container">
        <div id="header">

        </div>
        <div id="menuBar">
            <div id='cssmenu'>
                <asp:Menu ID="Menu1" runat="server" Height="18px" Orientation="Horizontal" RenderingMode="Table" StaticSubMenuIndent="16px" Width="1100px">
                    <Items>
                        <asp:MenuItem Text="HOME" Value="HOME" NavigateUrl="~/Main.aspx"></asp:MenuItem>
                        <asp:MenuItem Text="ADMIN" Value="ADMIN">
                            <asp:MenuItem Text="LOGIN" Value="LOGIN" NavigateUrl="~/AdminLogin.aspx"></asp:MenuItem>
                        </asp:MenuItem>
                        <asp:MenuItem Text="STUDENT" Value="STUDENT">
                            <asp:MenuItem Text="REGISTER" Value="REGISTER" NavigateUrl="~/StudentReg.aspx"></asp:MenuItem>
                            <asp:MenuItem Text="LOGIN" Value="LOGIN" NavigateUrl="~/StudentLogin.aspx"></asp:MenuItem>
                        </asp:MenuItem>
                        <asp:MenuItem Text="FACULTY" Value="FACULTY">
                            <asp:MenuItem Text="LOGIN" Value="LOGIN" NavigateUrl="~/FacultyLogin.aspx"></asp:MenuItem>
                        </asp:MenuItem>
                        <asp:MenuItem Text="COMPETITIONS" Value="COMPETITIONS">
                            <asp:MenuItem Text="BLITZKREIG" Value="BLITZKREIG" NavigateUrl="~/AptiLogin.aspx"></asp:MenuItem>
                            <asp:MenuItem Text="PHOTO-FUNIA" Value="PHOTO-FUNIA" NavigateUrl="~/Gallery Login.aspx"></asp:MenuItem>
                        </asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/attendance/login.aspx" Text="ATTENDANCE" Value="ATTENDANCE"></asp:MenuItem>
                        <asp:MenuItem Text="ADMISSION" Value="ADMISSION">
                            <asp:MenuItem Text="DOWNLOAD FORM" Value="DOWNLOAD FORM" NavigateUrl="~/Download Form/download form.pdf"></asp:MenuItem>
                            <asp:MenuItem Text="PROCEDURE" Value="PROCEDURE" NavigateUrl="~/Download Form/proceedure.pdf"></asp:MenuItem>
                            <asp:MenuItem Text="FEE STRUCTURE" Value="FEE STRUCTURE" NavigateUrl="~/Download Form/fee structure.pdf"></asp:MenuItem>
                        </asp:MenuItem>
                        <asp:MenuItem Text="CONTACT US" Value="CONTACT US" NavigateUrl="~/Download Form/Contact Us.pdf"></asp:MenuItem>
                    </Items>
                </asp:Menu>
            </div>
        </div>
        <div>
            <div id="leftSideBar" style="color: blue">
                <marquee behavior="scroll" direction="up">

                    Designed and developed by :-<br>
                    SUBHAJIT GANGULY<br>
                    VIKASH SHINGH<br>
                    SUBHRANGSHU CHAUDHURI<br>
                    SUBHRO DUTTA<br></marquee>
            </div>

        </div>
        <div id="content" style="position: relative">
            
            <div>
                <h1 style="color: green"><asp:AdRotator ID="AdRotator1" runat="server" DataSourceID="XmlDataSource1" />
                    <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/Home.xml"></asp:XmlDataSource>
                </h1>
         <div>
			
			<h1 style="color: green"><marquee>WELCOME TO ONLINE EDUCATION PORTAL</marquee></h1>
		</div>
                
            </div>
        </div>
        
        
    <div id="footer">
        <p align="center">
            Online Education Portal<br />
            all copyrights are reserved&copy;
        </p>
    </div>

    </form>

</body>
</html>