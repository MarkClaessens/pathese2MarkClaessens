﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bioscoopje.aspx.cs" Inherits="oim.Bioscoopje" %>

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
     <li><a runat="server"  href="~/mypathe.aspx">mijn pathe</a></li>
                    
 </ul>
 </nav>
 </header>
 <section class="courses">
   
     <asp:Image ID="Imagebioscoop" runat="server" Height="300px" Width="300px" />
 </section>
     <asp:Label ID="Labelnaam" runat="server" Text="Label"></asp:Label><br>
     <asp:Label ID="Labeldesc" runat="server" Text="Label"></asp:Label>
 <aside>
 <section class="popular-recipes">
 
 </section>
 
 </aside>
 <footer>
 &copy; 2015 Mark Claessens
 </footer>
 </div><!-- .wrapper -->
    </form>
</body>
</html>
