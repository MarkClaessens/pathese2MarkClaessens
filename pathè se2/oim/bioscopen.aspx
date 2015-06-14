<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bioscopen.aspx.cs" Inherits="oim.bioscopen" %>

<!DOCTYPE HTML>
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
            

            <h1>taken</h1>
            <nav>
                <ul>
                    <li><a runat="server"  href="~/oke.aspx">home</a></li>
                    <li><a runat="server"  href="~/films.aspx">films</a></li>
                    <li><a runat="server">bioscopen</a></li>
                    <li><a runat="server"  href="~/trailers.aspx">trailers</a></li>
                    <li><a runat="server"  href="~/mypathe.aspx">mijn pathe</a></li>
                </ul>
            </nav>
        </header>
        <section class="courses">
            <article>
                <hgroup>
                    <h1>home
                    </h1>
                    </hgroup>
                    
                    <hgroup>
                </hgroup>
                <asp:Button ID="Buttoneindhoven" runat="server" Text="Eindhoven" Height="100px" width="100px" OnClick="Buttoneindhoven_Click"/>
                    <asp:Button ID="ButtonArena" runat="server" Text="Arena" Height="100px" width="100px" OnClick="ButtonArena_Click"/>                    
                    <asp:Button ID="Buttonhelmond" runat="server" Text="Helmond" Height="100px" width="100px" OnClick="Buttonhelmond_Click"/>
                    <asp:Button ID="Buttonhaarlem" runat="server" Text="Haarlem" Height="100px" width="100px" OnClick="Buttonhaarlem_Click"/>
                    <asp:Button ID="Buttontilburg" runat="server" Text="Tilburg" Height="100px" width="100px" OnClick="Buttontilburg_Click"/>
                   
                <hgroup>
              
                </hgroup>
                <hgroup>
                
                </hgroup>
                <p>
                    
                    
                    
                </p>
            </article>
        </section>
        <aside>
            <section class="popular-recipes"></section>
            </aside>   
                
                 
                
    </div><!-- .wrapper -->
    </form>
</body>
</html>
