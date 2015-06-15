<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registreer.aspx.cs" Inherits="oim.registreer" %>

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
                <p>
                
                    
                </p>
            </article>
        </section>
        <aside>
        <section class="popular-recipes">   
               <asp:Label ID="lblvoornaam" runat="server" Text="voornaam:"></asp:Label><br>                
                <asp:TextBox ID="Tbvoornaam" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator runat=server 
                    controltovalidate=Tbvoornaam
                    errormessage="voornaam is required.">*voornaam is required
                    </asp:RequiredFieldValidator><br>                
                <asp:Label ID="lblachternaam" runat="server" Text="achternaam:"></asp:Label><br>
                <asp:TextBox ID="Tbachternaam" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator runat=server 
                    controltovalidate=Tbachternaam
                    errormessage="achternaam is required.">*achternaam is required
                    </asp:RequiredFieldValidator><br>
                <asp:Label ID="lblgeboortedatum" runat="server" Text="geboortedatum:"></asp:Label><br>
                <asp:TextBox ID="Tbgeboortedatum" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator runat=server 
                    controltovalidate=Tbgeboortedatum
                    errormessage="geboortedatum is required.">*geboortedatum is required
                    </asp:RequiredFieldValidator><br>
                <asp:Label ID="lblgeslacht" runat="server" Text="geslacht:"></asp:Label><br>
                <asp:TextBox ID="Tbgeslacht" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator runat=server 
                    controltovalidate=Tbgeslacht
                    errormessage="geslacht is required.">*geslacht is required
                    </asp:RequiredFieldValidator><br>
                <asp:Label ID="lblemail" runat="server" Text="email:"></asp:Label><br> 
                <asp:TextBox ID="Tbemail" runat="server"></asp:TextBox>
                 <asp:RequiredFieldValidator runat=server 
                    controltovalidate=Tbemail
                    errormessage="email is required.">*email is required
                    </asp:RequiredFieldValidator><br> 
                <asp:Label ID="lblww" runat="server" Text="wachtwoord:"></asp:Label><br> 
                <asp:TextBox ID="Tbww" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator runat=server 
                    controltovalidate=Tbww
                    errormessage="wachtwoord is required.">*wachtwoord is required
                    </asp:RequiredFieldValidator><br> 
                <br>  
                <br>  
                <asp:Button ID="btnconfirm" runat="server" Text="registreer" OnClick="btnconfirm_Click"/> 
                
            
            
            
            
            
    </div><!-- .wrapper -->
    </form>
</body>
</html>
