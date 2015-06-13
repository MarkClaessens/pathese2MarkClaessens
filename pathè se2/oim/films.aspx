<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="films.aspx.cs" Inherits="oim.films" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01//EN">
<html>
<head>
  <title>Media design</title>
  <link rel="stylesheet" href="mystyle.css">
</head>
<body>
 <img src="pathe.png" height="100" width="200">
 <div class="wrapper">
 <header>
 	

 	 <h1>films</h1>
 <nav>
 <ul>               
                    <li><a runat="server"  href="~/oke.aspx">Home</a></li>
                    <li>films</li>                    
                    <li><a runat="server"  href="~/bioscopen.aspx">bioscopen</a></li>
                    <li><a runat="server"  href="~/trailers.aspx">trailers</a></li>
                    <li><a runat="server"  href="~/mypathe.aspx">mijn pathe</a></li>
 </ul>
 </nav>
 </header>
 <section class="courses">
  <article>
  <hgroup>
 <h2>about</h2>
 <h3>Deze website is gemaakt door een leerling van de opleiding hbo ICT,
<br>die in zijn eerste periode voor het vak media design als opdracht had
<br>om een website te maken.
<br>de opdracht was om een site voor de open dag te maken om media design
<br>te promoten.</h3>
 </hgroup>
 <p></p>
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
</body>
</html>