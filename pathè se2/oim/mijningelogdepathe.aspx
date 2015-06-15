<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mijningelogdepathe.aspx.cs" Inherits="oim.mijningelogdepathe" %>

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
 	

 	 <h1>menu</h1>
 <nav>
 <ul>
 <li><a runat="server"  href="~/oke.aspx">home</a></li>
 <li><a runat="server"  href="~/films.aspx">films</a></li>
 <li><a runat="server"  href="~/bioscopen.aspx">bioscopen</a></li>
 <li><a runat="server"  href="~/trailers.aspx">trailers</a></li>
 <li>mijn pathe</li>
     <li>
         <asp:Button ID="btnuitlog" runat="server" OnClick="btnuitlog_Click" Text="uitloggen" />
     </li>
 </ul>
 </nav>
 </header>
 <section class="courses">
  <article>
       <asp:Label ID="Lblvoornaam" runat="server" Text="Label"></asp:Label><br>
       <asp:Label ID="Lblachternaam" runat="server" Text="Label"></asp:Label><br>
       <asp:Label ID="Lblemail" runat="server" Text="Label"></asp:Label><br>       
      <h2>Mijn tickets:
      </h2>
      <div id="contentdiv" runat="server">       
     </div>
   <p>
       
       
      </p>
 </article> 
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

