<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmMantenimientoCategoria.aspx.cs" Inherits="CapaPresentacion.frmMantenimientoCategoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style type="text/css">
         .auto-style7 {
             font-family: 'Century Gothic';
             font-size: 18px;
             color: #FF4600;
             font-weight: bold;
             padding-top: 20px;
             padding-left: 120px;
             text-align: center;
         }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <br /><br />
            <div style="padding:3px;padding-left:10%;padding-right:20%">
                 <div  style="font-weight: 700; background-color: #FFFFFF;" class="text-center">
              <span  class="letrasCa">MANTENIMIENTO DE CATEGORIA</span>
          </div>
                <br /><br />
                <table border="0"  style="width:100%">
                    <tr >
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="Código: "></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control" Width="143px" ValidationGroup="buscar"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtCodigo" ErrorMessage="Ingresar Código" style="color: #FF0000" ValidationGroup="buscar"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr style="height:50px;">
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="Nombre: "></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" Width="350px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtNombre" ErrorMessage="Ingresar Nombre de la Categoria" style="color: #FF0000" ValidationGroup="insertar"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                        <tr>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text="Descripcion: "></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control" Width="350px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtDescripcion" ErrorMessage="Ingresar Descripción de la Categoria" style="color: #FF0000" ValidationGroup="insertar"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                </table>
                <br />
            </div>
            <div style="padding-left:30%;padding-right:40%">
                            <table class="nav-justified">
                                <tr>
                                    <td>
                                        <asp:Button ID="btnNuevo" runat="server" CssClass="btn btn-warning" Text="Nuevo" OnClick="btnNuevo_Click"  />
                                    </td>
                                    <td>
                                        <asp:Button ID="btnGuardar" runat="server" CssClass="btn btn-warning" Text="Guardar"  OnClick="btnGuardar_Click" ValidationGroup="insertar" />
                                    </td>
                                    <td>
                                        <asp:Button ID="btnBuscar" runat="server" CssClass="btn btn-primary" Text="Buscar"  OnClick="btnBuscar_Click" ValidationGroup="buscar" />
                                    </td>
                                    <td>
                                        <asp:Button ID="btnEliminar" runat="server" CssClass="btn btn-danger" Text="Eliminar" OnClick="btnEliminar_Click" ValidationGroup="eliminar" />
                                    </td>
                                 
                                </tr>
                 </table>
            </div>
             <div  class="auto-style7">
                <br />
                <asp:Label ID="Label4" runat="server" Text="LISTADO DE CATEGORIAS" ></asp:Label>
            </div>
            <div style="text-align: center;padding-left:10%;padding-right:20%">
                  <asp:GridView ID="grvDatos" runat="server" Width="100%" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" CssClass="mGrid">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="id_categoria" HeaderText="Código" >
                        <HeaderStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                        <asp:BoundField DataField="descripcion" HeaderText="Descripción" />
                       
                    </Columns>
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
            </div>
            <br /><br />
        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>
