﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Film.aspx.cs" Inherits="oim.Film" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01//EN">
<html>
<head>
  <title>pathé.nl</title>
  <link rel="stylesheet" href="mystyle.css">
</head>
<body>
    <form id="form1" runat="server">
 <img src="pathe.png" height="100" width="200">
 <div class="wrapper">
 <header>
 	

 	 <h1>films</h1>
 <nav>
 <ul>               
     <li><a runat="server"  href="~/oke.aspx">Home</a></li>
     <li><a runat="server"  href="~/films.aspx">Films</a></li>                  
     <li><a runat="server"  href="~/bioscopen.aspx">bioscopen</a></li>
     <li><a runat="server"  href="~/trailers.aspx">trailers</a></li>
     <li><a runat="server"  href="~/mypathe.aspx">mijn pathe</a><div style="margin-left: 496px">
     <asp:Label ID="Labelfilmaam" runat="server" Text="Label"></asp:Label>
     <br><asp:Label ID="Labelgenre" runat="server" Text="Label"></asp:Label>
     <br><asp:Label ID="Labelduur" runat="server" Text="Label"></asp:Label>
     <br><asp:Label ID="Labelregisseur" runat="server" Text="Label"></asp:Label>
     <br><asp:Label ID="Labeltaal" runat="server" Text="Label"></asp:Label>
     </div>
     </li>
                    
 </ul>
 </nav>
 </header>
 <section class="courses">
   
     <asp:Image ID="Imagefilm" runat="server" Height="300px" Width="300px" />
 </section>
 <aside>
 <section class="popular-recipes">
 
 </section>
     <asp:Label ID="Label1" runat="server" Text="Snel ticket kopen voor deze film"></asp:Label>
     <asp:Button ID="Button1" runat="server" Text="koop ticket" OnClick="Button1_Click"></asp:Button>
 </aside>
 <footer>
 &copy; 2015 Mark Claessens
 </footer>
 </div><!-- .wrapper -->
    </form>
</body>
</html>
