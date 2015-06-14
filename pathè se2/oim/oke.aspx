<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="oke.aspx.cs" Inherits="oim.oke" %>

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
                    <li><a runat="server">Home</a></li>
                    <li><a runat="server"  href="~/films.aspx">films</a></li>
                    <li><a runat="server" href="~/bioscopen.aspx">bioscopen</a>                                     
                    </li>
                    <li><a runat="server"  href="~/trailers.aspx">trailers</a></li>
                    <li><a runat="server"  href="~/mypathe.aspx">mijn pathe</a></li>
                </ul>
                <br>
                <br>
            </nav>
        </header>
        <section class="courses">
            <article>
                <hgroup>
                    <h1>home
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </h1>
                    <h2>Snel een ticket kopen</h2>
                    <h3>
                        
                        <asp:Label ID="Label2" runat="server" Text="filmnaam:"></asp:Label>
                        <asp:TextBox ID="tbfilmnaam" runat="server"></asp:TextBox>
                        <asp:Button ID="Btnzoek" runat="server" Text="zoek film" OnClick="Btnzoek_Click" />
                        <asp:TextBox ID="Tbcheckedfilm" runat="server" ReadOnly="True"></asp:TextBox>
                        <asp:Button ID="Btnkoop" runat="server" Text="koop ticket" Enabled="False" OnClick="Btnkoop_Click" />
                        
                    </h3>
                    </hgroup>
                <hgroup>
              
                </hgroup>
                <hgroup>
                </hgroup>
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/jworld.jpg" OnClick="ImageButton1_Click" Height="200px" Width="200px" />          
                <asp:ImageButton ID="ImageButton2" runat="server" Height="200px" ImageUrl="~/Images/spy.jpg" Width="200px" OnClick="ImageButton2_Click" />
                <asp:ImageButton ID="ImageButton3" runat="server" Height="200px" ImageUrl="~/Images/minions.jpg" Width="200px" OnClick="ImageButton3_Click" />
                               
                <p>
                    
                    
                    
                </p>
            </article>
        </section>
        <aside>
            <section class="popular-recipes">   
                <h3>trailerss:</h3>
                 <object width="420" height="315"data="https://www.youtube.com/v/F-qBD17wwrQ"></object>
                <object width="420" height="315"data="https://www.youtube.com/v/KmYNkasYthg"></object>
                
    </div><!-- .wrapper -->
    </form>
</body>
</html>
