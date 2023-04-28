<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Userlock_210323.index" %>

<!-- 
     Company Name  : Allyhealth Business Process Solutions
     Title         : Userlock Status Project
     Author Name   : Suresh Mohan 
     File Name     : index.aspx 
-->

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">  <!-- Head Tag Opened -->

    <title>Allyhealth Solutions</title>

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
          <li><a href="Favorites.aspx">Favorites  </a></li>
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
    <p class="search-area">Search</p>                                              
    <div class="d-flex">  
    <asp:TextBox ID="TextBox1" placeholder="Enter Users Username or Email Id" runat="server" class="form-control"></asp:TextBox>
    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="image/white_search_icon.png"  title="Click Now!" OnClick="ImageButton1_Click" />
    </div>
    </div>
    <br />  
                    
    <!-- This section contains the gridview to display the data in the page -->
    <asp:GridView ID="Grid1"  CssClass="table-bordered text-center border rounded" runat="server">
    <FooterStyle CssClass="table" />
    <HeaderStyle BackColor="#5d2e82"  ForeColor="White"  />
    <AlternatingRowStyle BorderStyle="Solid" />
    <RowStyle BackColor="white"  />
    </asp:GridView> <br /> 
        <asp:Button ID="Btn_AddFavorites" runat="server" Class="btn btn-primary" Text="Add Favorites" OnClick="Button1_Click" /> <br /> 
         <asp:Label ID="Click" Class="Record" runat="server" Text=""></asp:Label> 
    </div>

    <!-- This section contains the circle buttons to show the status -->
   
    
         <div class="col-sm-7 col-lg-3 col-md-6 m-2 ml-5">    
    <h1 class="status-area">STATUS</h1>                      
    <asp:Button ID="Btn_green" runat="server" Text="" CssClass="lights" />                   
    <asp:Button ID="Btn_yellow" runat="server" Text="" CssClass="lights"/>  
    <asp:Button ID="Btn_red" runat="server" Text="" CssClass="lights"/>    
    </div>
        </div>
     </div>
    </form>
    

    <!-- This section links to an external JavaScript file -->
    <script src="script.js"></script>

</body> <!-- Body Tag Closed -->
</html>
