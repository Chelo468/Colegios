<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registrar.aspx.cs" Inherits="Web.Pages.Usuarios.registrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Sistema de Colegios</title>
    <link href="../../Content/Estilos/main.css" rel="stylesheet" />
    <link href="../../Content/Estilos/BootstrapOk/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <div class="box-login">
        <form id="form1" runat="server" class="form-group">
            <asp:HiddenField ID="hdfError" runat="server" />
            <h2>Registro de Usuario</h2>
            <div class="form-group col-md-12">
                <asp:Label ID="lblNombre" runat="server" AssociatedControlID="txtNombre">Nombre</asp:Label>
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" placeholder="Nombre" />
            </div>
            <div class="clearfix"></div>
            <div class="form-group col-md-12">
                <asp:Label ID="lblApellido" runat="server" AssociatedControlID="txtNombre">Apellido</asp:Label>
                <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control" placeholder="Apellido" />
            </div>
            <div class="clearfix"></div>
            <div class="form-group col-md-12">
                <asp:Label ID="lblUsuario" runat="server" AssociatedControlID="txtUsuario">Usuario</asp:Label>
                <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control" placeholder="Usuario" />
            </div>
            <div class="clearfix"></div>
            <div class="form-group col-md-12">
                <asp:Label ID="lblPassword" runat="server" AssociatedControlID="txtNombre">Password</asp:Label>
                <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" placeholder="Password" />
            </div>
            <div class="clearfix"></div>
            <div class="form-group col-md-12">
                <asp:Label ID="lblEmail" runat="server" AssociatedControlID="txtNombre">Email</asp:Label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="Email" />
            </div>
            <div class="clearfix"></div>
            <div class="form-group col-md-12">
                <asp:Label ID="lblCelular" runat="server" AssociatedControlID="txtNombre">Celular</asp:Label>
                <asp:TextBox ID="txtCelular" runat="server" CssClass="form-control" placeholder="Celular" />
            </div>
            <div class="clearfix"></div>
            <div class="form-group col-md-12">
                <asp:Label ID="lblPais" runat="server" AssociatedControlID="txtNombre">Pais</asp:Label>
                <asp:DropDownList ID="cboPais" runat="server" CssClass="form-control" />        
            </div>
            <div class="clearfix"></div>
            <div class="form-group col-md-12">
                <asp:Label ID="lblProvincia" runat="server" AssociatedControlID="txtNombre">Provincia</asp:Label>
                <asp:DropDownList ID="cboProvincia" runat="server" CssClass="form-control" />        
            </div>
            <div class="clearfix"></div>
            <div class="form-group col-md-12">
                <asp:Label ID="lblLocalidad" runat="server" AssociatedControlID="txtNombre">Localidad</asp:Label>
                <asp:DropDownList ID="cboLocalidad" runat="server" CssClass="form-control" />        
            </div>
            <div class="clearfix"></div>
            <div class="form-group col-md-12">
                <asp:Label ID="lblBarrio" runat="server" AssociatedControlID="txtNombre">Barrio</asp:Label>
                <asp:DropDownList ID="cboBarrio" runat="server" CssClass="form-control" />        
            </div>
            <div class="clearfix"></div>
            <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" CssClass="btn btn-primary" OnClick="btnRegistrar_Click" />
            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-default" OnClick="btnCancelar_Click" />
        </form>
    </div>
    

</body>
</html>

