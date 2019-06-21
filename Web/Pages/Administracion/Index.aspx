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
            <asp:GridView ID="grilla" runat="server" CssClass="table table-hovered" AutoGenerateColumns="false" EmptyDataText="No hay datos cargados" EmptyDataRowStyle-HorizontalAlign="Center">
                <Columns>       
                    <asp:BoundField DataField="id" HeaderText="ID" HeaderStyle-CssClass="oculto" ItemStyle-CssClass="oculto" />             
                    <asp:BoundField DataField="descripcion" HeaderText="NOMBRE" />
                    <asp:TemplateField HeaderText="Acciones">
                        <ItemTemplate>
                            <asp:HyperLink ID="btnVerGrilla" runat="server" ><i class="fas fa-eye"></i></asp:HyperLink>
                            <asp:HyperLink ID="btnEditGrilla" runat="server" ><i class="fas fa-edit"></i></asp:HyperLink>
                            
                        </ItemTemplate>
                    </asp:TemplateField>
                    
                </Columns>
            </asp:GridView>
    </div>

    <div style="z-index: 100; position: fixed; bottom: 2em; right: 2em">
    <a runat="server" id="btnCrear" class="btn btn-success"  data-toggle="modal" style="border-radius: 50%" visible="false">+</a>
</div>


    <!-- Modal Pais-->
<div class="modal fade" id="modalPais" tabindex="-1" role="dialog" aria-labelledby="modalPaisLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="modalPaisLabel">Nuevo Pais</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
          <div class="row">
              <div class="col-md-12">
                  <asp:Label ID="lblPais" runat="server" AssociatedControlID="txtPais" style="float:left; margin-top: 5px">Pais</asp:Label>
                    <asp:TextBox ID="txtPais" runat="server" CssClass="form-control" style="float:left; margin-left: 10px" />
              </div>
          </div>
        
      </div>
      <div class="modal-footer">
          <asp:Button CssClass="btn btn-primary" ID="btnCrearPais" runat="server" OnClick="btnCrearPais_Click" Text="Crear"/>
          <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>        
      </div>
    </div>
  </div>
</div>
    <!--FIN MODAL PAIS-->


<!--MODAL PROVINCIA-->
<div class="modal fade" id="modalProvincia" tabindex="-1" role="dialog" aria-labelledby="modalProvinciaLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="modalProvinciaLabel">Nueva Provincia</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
                <div class="form-group col-md-12">
                    <asp:Label ID="lblPaisEnProvincia" runat="server"  CssClass="col-md-3" AssociatedControlID="cboPaisEnProvincia" style="float:left; margin-top: 5px">Pais</asp:Label>
                    <asp:DropDownList ID="cboPaisEnProvincia" runat="server" CssClass="form-control" style="float:left; margin-left: 10px" />
                </div>
             
              
                <div class="form-group col-md-12">
                    <asp:Label ID="lblProvincia" runat="server" CssClass="col-md-3" AssociatedControlID="txtProvincia" style="float:left; margin-top: 5px">Provincia</asp:Label>
                    <asp:TextBox ID="txtProvincia" runat="server" CssClass="form-control" style="float:left; margin-left: 10px" />
                </div>        
      </div>
      <div class="modal-footer">
          <asp:Button CssClass="btn btn-primary" ID="btnCrearProvincia" runat="server" OnClick="btnCrearProvincia_Click" Text="Crear"/>
          <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>        
      </div>
    </div>
  </div>
</div>
<!--FIN MODAL PROVINCIA-->


    
<!--MODAL LOCALIDAD-->
<div class="modal fade" id="modalLocalidad" tabindex="-1" role="dialog" aria-labelledby="modalLocalidadLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="modalLocalidadLabel">Nueva Localidad</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
                <div class="form-group col-md-12">
                    <asp:Label ID="lblCboPaisEnLocalidad" runat="server"  CssClass="col-md-3" AssociatedControlID="cboPaisEnLocalidad" style="float:left; margin-top: 5px">Pais</asp:Label>
                    <asp:DropDownList ID="cboPaisEnLocalidad" runat="server" CssClass="form-control" style="float:left; margin-left: 10px" />
                </div>
                <div class="form-group col-md-12">
                    <asp:Label ID="lblCboProvinciaEnLocalidad" runat="server"  CssClass="col-md-3" AssociatedControlID="cboProvinciaEnLocalidad" style="float:left; margin-top: 5px">Provincia</asp:Label>
                    <asp:DropDownList ID="cboProvinciaEnLocalidad" runat="server" CssClass="form-control" style="float:left; margin-left: 10px" />
                </div>
             
              
                <div class="form-group col-md-12">
                    <asp:Label ID="lblLocalidad" runat="server" CssClass="col-md-3" AssociatedControlID="txtLocalidad" style="float:left; margin-top: 5px">Localidad</asp:Label>
                    <asp:TextBox ID="txtLocalidad" runat="server" CssClass="form-control" style="float:left; margin-left: 10px" />
                </div>        
      </div>
      <div class="modal-footer">
          <asp:Button CssClass="btn btn-primary" ID="Button1" runat="server" OnClick="btnCrearProvincia_Click" Text="Crear"/>
          <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>        
      </div>
    </div>
  </div>
</div>
<!--FIN MODAL PROVINCIA-->


    
<!--MODAL PROVINCIA-->
<div class="modal fade" id="modalBarrio" tabindex="-1" role="dialog" aria-labelledby="modalBarrioLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="modalBarrioLabel">Nueva Provincia</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
                <div class="form-group col-md-12">
                    <asp:Label ID="Label1" runat="server"  CssClass="col-md-3" AssociatedControlID="cboPaisEnBarrio" style="float:left; margin-top: 5px">Pais</asp:Label>
                    <asp:DropDownList ID="cboPaisEnBarrio" runat="server" CssClass="form-control" style="float:left; margin-left: 10px" />
                </div>
                <div class="form-group col-md-12">
                    <asp:Label ID="Label2" runat="server"  CssClass="col-md-3" AssociatedControlID="cboProvinciaEnBarrio" style="float:left; margin-top: 5px">Provincia</asp:Label>
                    <asp:DropDownList ID="cboProvinciaEnBarrio" runat="server" CssClass="form-control" style="float:left; margin-left: 10px" />
                </div>
                <div class="form-group col-md-12">
                    <asp:Label ID="Label3" runat="server"  CssClass="col-md-3" AssociatedControlID="cboLocalidadEnBarrio" style="float:left; margin-top: 5px">Localidad</asp:Label>
                    <asp:DropDownList ID="cboLocalidadEnBarrio" runat="server" CssClass="form-control" style="float:left; margin-left: 10px" />
                </div>
             
              
                <div class="form-group col-md-12">
                    <asp:Label ID="Label4" runat="server" CssClass="col-md-3" AssociatedControlID="txtProvincia" style="float:left; margin-top: 5px">Provincia</asp:Label>
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" style="float:left; margin-left: 10px" />
                </div>        
      </div>
      <div class="modal-footer">
          <asp:Button CssClass="btn btn-primary" ID="Button2" runat="server" OnClick="btnCrearProvincia_Click" Text="Crear"/>
          <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>        
      </div>
    </div>
  </div>
</div>
<!--FIN MODAL PROVINCIA-->

</asp:Content>
