<%@ Page Title="Administracion" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Web.Pages.Administracion.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-3">
            <asp:Button ID="btnPais" runat="server" Text="Pais" CssClass="btn btn-primario" style="padding: 25px" Width="100%" OnClick="btnPais_Click" />
        </div>
        <div class="col-md-3">
            <asp:Button ID="btnProvincia" runat="server" Text="Provincia" CssClass="btn btn-primario" style="padding: 25px" Width="100%" OnClick="btnProvincia_Click"  />
        </div>
        <div class="col-md-3">
            <asp:Button ID="btnLocalidad" runat="server" Text="Localidad" CssClass="btn btn-primario" style="padding: 25px"  Width="100%" OnClick="btnLocalidad_Click"  />
        </div>
        <div class="col-md-3">
            <asp:Button ID="btnBarrio" runat="server" Text="Barrio" CssClass="btn btn-primario" style="padding: 25px" Width="100%" OnClick="btnBarrio_Click"  />
        </div>
    </div>

    <div id="divTitulo" runat="server" visible="false" style="padding:30px;text-align: center; background: #37474f; color: white">
        <asp:Label ID="lblTitulo" runat="server"></asp:Label>
    </div>

    <div class="container">
            <asp:GridView ID="grilla" runat="server" CssClass="table table-hovered" EmptyDataText="No hay datos cargados" EmptyDataRowStyle-HorizontalAlign="Center">
                
            </asp:GridView>
    </div>

    <div style="z-index: 100; position: fixed; bottom: 2em; right: 2em">
    <a href="/Producto/crear" id="btnCrear" class="btn btn-success" style="border-radius: 50%">+</a>
</div>

</asp:Content>
