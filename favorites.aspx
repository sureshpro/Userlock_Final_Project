<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Favorites.aspx.cs" Inherits="Userlock_210323.Favorites" %>

<!--
  Company Name : Allyhealth Business Process Solutions
  Title : Userlock Status Project
  Author Name : Suresh Mohan
  File Name : Favorites.aspx
-->

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">  <!-- Head Tag Opened -->

    <title>Allyhealth</title>

    <!-- This is a link to an external CSS file that contains styles for the page -->
    <link rel="stylesheet" href="style.css" />

    <!-- This is a link to an external CSS file for the Bootstrap CSS framework -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" />

    <!-- This is a link to the website's favicon -->
    <link rel="icon" type="image/png" href="image/AH-fav-icon1.png" />

    <!-- This code is for the jQuery UI library for autocomplete functionality -->
    <script src="https://ajax.aspnetcdn.com/ajax/jquery/jquery-1.8.0.js"></script>
    <script src="https://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.22/jquery-ui.js"></script>
    <link rel="Stylesheet" href="https://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.10/themes/redmond/jquery-ui.css" />

</head> <!-- Head Tag Closed -->

<body> <!-- Body Tag Opened -->

    <!-- This section contains the navigation bar, including the company logo and user icon -->
    <form method="post" runat="server">        
    <div class="nav-container"> 
        
    <!-- This is the open of the navigation section -->
   <nav class="navbar">
  
    <asp:Image ID="Image1" Class="vertical-line" ImageUrl="image/Allyhealthsolutions_LOGO.png" title="Allyhealth Solutions" runat="server" />  
    <ul class="menu">          
    <li><a href="index.aspx">Home</a></li>
    </ul>
    <div class="row">
    <div class="user-info">
        <% if (HttpContext.Current.User.Identity.IsAuthenticated) { %>
          <span class="col-lg-6"><%= User.Identity.Name.Split('\\')[1] %>@allyhealthsolutions.com</span>  
        <% } else { %>
          <span>Error</span>
        <% } %>
    </div>  
    </div>
    <asp:ImageButton ID="Image2" runat="server" ImageUrl="image/user-icon-right.png" title="Icon" />  
    </nav>        
    </div>

    <!-- This section contains the main content of the page -->                 
    <div class="container">
    <div class="row">
    <!-- This section contains the search area, including the search box and search button --> 
    <div class="col-sm-12 col-lg-7 col-md-12 table-area">
    <div class="m-12">
    <p class="search-area"></p>   <br />                                           
    <div class="d-flex">  
    <h3>My Team</h3>
    </div>
    </div>
    <br />   
                  
    <!-- This section contains the gridview to display the data in the page -->
    <asp:GridView ID="Grid2"  CssClass="table-bordered text-center border rounded" runat="server">
    <FooterStyle CssClass="table" />
    <HeaderStyle BackColor="#5d2e82"  ForeColor="White"  />
    <AlternatingRowStyle BorderStyle="Solid" />
    <RowStyle BackColor="white"  />
    <Columns>
    <asp:TemplateField>
    <ItemTemplate>
    <asp:LinkButton ID="LinkBtn_Delete" runat="server" OnClick="LinkBtn_Delete_Click1">Delete</asp:LinkButton> 
    </ItemTemplate>
    </asp:TemplateField>
    </Columns>
    </asp:GridView> <br />
    <!--  <asp:Button ID="Btn_Refresh" runat="server" Class="btn btn-primary" Text="Refresh" OnClick="Btn_Refresh_Click"  /> <br /> <br />  -->
    </div>     
    </div>
    </div>
    </form>
    

    <!-- This section links to an external JavaScript file -->
    <script src="script.js"></script>

</body> <!-- Body Tag Closed -->
</html>
