<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="films.aspx.cs" Inherits="oim.films" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01//EN">
<html>
<head>
  <title>Pathè.nl</title>
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
                    <li><a runat="server">films</a></li>                    
                    <li><a runat="server"  href="~/bioscopen.aspx">bioscopen</a></li>
                    <li><a runat="server"  href="~/trailers.aspx">trailers</a></li>
                    <li><a runat="server"  href="~/mypathe.aspx">mijn pathe</a></li>
 </ul>
 </nav>
 </header>
 <section class="courses">
     
     <asp:ImageButton ID="ImageButton2" runat="server" Height="200px" ImageUrl="~/Images/jworld.jpg" OnClick="ImageButton2_Click" Width="200px" />
     <asp:ImageButton ID="ImageButton3" runat="server" Height="200px" ImageUrl="~/Images/spy.jpg" OnClick="ImageButton3_Click" Width="200px" />
     <asp:ImageButton ID="ImageButton1" runat="server" Height="200px" ImageUrl="~/Images/minions.jpg" OnClick="ImageButton1_Click" Width="200px" />
     <asp:ImageButton ID="ImageButton4" runat="server" Height="200px" ImageUrl="~/Images/divergent.jpg" OnClick="ImageButton4_Click" Width="200px" />
     <asp:ImageButton ID="ImageButton5" runat="server" Height="200px" ImageUrl="~/Images/kingsman.jpg" OnClick="ImageButton5_Click" Width="200px" />
     <asp:ImageButton ID="ImageButton6" runat="server" Height="200px" ImageUrl="~/Images/shaun.jpg" OnClick="ImageButton6_Click" Width="200px" />
     <asp:ImageButton ID="ImageButton7" runat="server" Height="200px" ImageUrl="~/Images/rambo.jpg" OnClick="ImageButton7_Click" Width="200px" />
     <asp:ImageButton ID="ImageButton8" runat="server" Height="200px" ImageUrl="~/Images/harry.jpg" OnClick="ImageButton8_Click" Width="200px" />
 </section>
 <aside>
 <section class="popular-recipes">
 
 </section>
     
 </aside>
 <footer>
 &copy; 2014 Mark Claessens
 </footer>
 </div><!-- .wrapper -->
    </form>
</body>
</html>