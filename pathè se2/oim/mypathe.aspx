<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mypathe.aspx.cs" Inherits="oim.mypathe" %>

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
 </ul>
 </nav>
 </header>
 <section class="courses">
  <article>
    
      Inloggen:
&nbsp;<p>
       
       <asp:Label ID="Label1" runat="server" Text="email:"></asp:Label><br>
       <asp:TextBox ID="Tbmail" runat="server"></asp:TextBox><br>
       <asp:Label ID="Label2" runat="server" Text="wachtwoord:"></asp:Label><br>     
       <asp:TextBox ID="Tbww" runat="server"></asp:TextBox><br><br><br>
       <asp:Button ID="Btnlogin" runat="server" Text="log in" OnClick="Btnlogin_Click" />
      </p>
 </article> 
 </section>
 <aside>
 <section class="popular-recipes"> 
 <a href="/registreer.aspx">heb je nog geen account? registreer je hier</a> 
 </section>
 
 </aside>
 <footer>
 &copy; 2015 Mark Claessens
 </footer>
 </div><!-- .wrapper -->
    </form>
</body>
</html>
