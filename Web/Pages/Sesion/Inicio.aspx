<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Web.Pages.Sesion.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Sistema de Colegios</title>
    <link href="../../Styles/Estilos/main.css" rel="stylesheet" />
    <link href="../../Styles/Estilos/BootstrapOk/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <div class="box-login">
        <form id="form1" runat="server" class="form-group">
        
                <div class="form-group col-md-9">
                    <asp:Label runat="server" ID="lblUsuario" AssociatedControlID="txtUsuario">Usuario</asp:Label>
                    <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control" placeholder="Usuario"></asp:TextBox>
                </div>
                <div class="form-group col-md-9">
                    <asp:Label runat="server" ID="lblPassword" AssociatedControlID="txtPassword">Password</asp:Label>
                    <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control"  placeholder="Password"></asp:TextBox>
                </div>

                <asp:Label ID="lblRespuesta" runat="server" AssociatedControlID="txtPassword" style="display:none; margin-top: 10px"></asp:Label>
                
                <asp:Button ID="btnLogin" runat="server" Text="Iniciar Sesión" CssClass="btn btn-primary" OnClick="btnLogin_Click" />                

                <asp:Button ID="btnRegistrar" runat="server" Text="Registrarme" CssClass="btn btn-secondary" OnClick="btnRegistrar_Click" />
   
        </form>
    </div>
</body>
</html>
