<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaCarritoCompras.Master" AutoEventWireup="true" CodeBehind="frmCatalogo.aspx.cs" Inherits="CapaPresentacion.frmCatalogo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style8 {
            text-align: center;
        }
        .auto-style9 {
            font-size: xx-large;
            color: #0000FF;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <asp:ScriptManager ID="ScriptManager1" runat="server"> </asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>     
                    <br  />             
                  <div style="background-color:orange;padding-left:3%;padding-right:3%">
                      <br />
                    <div class="auto-style8">
                        <span class="auto-style9">CÁTALOGO PRODUCTOS </span> <br />
                        <asp:Label ID="lblProductoAgregado" runat="server"  class="SubtituloCarritoMonto"></asp:Label>
                        <br />
                    </div>
                    <div style="padding-left:30px; text-align: right;">
                        <asp:Button  ID="btnCarrito" runat="server" Text="Ir a Carrito" CssClass="btn btn-warning" OnClick="btnCarrito_Click" />
                    </div>
                      <br />
                  </div>
                    <br />
                    <div style="padding-left:3%;padding-right:3%;height:100%">
            <asp:DataList runat="server" ID="DataList1" OnItemCommand="DataList_ItemCommand" RepeatColumns="4" RepeatDirection="Horizontal" BorderStyle="None">
                <ItemTemplate>
                    <table  border="0" style="border-radius:5px;  border:1px #222222 solid; margin-right:5px;" >
                        <tr style="border:none;height:280px;">
                            <td style="border:none">
                                <img alt="Producto" src="imagenes/<%# Eval("Foto")%>" width="150" class="img-responsive" />
                            </td>
                            <td style="border:none"><span class="letras_cuadro">Codigo:</span>
                                <span class="letras_cuadroSut"><asp:Label ID="lblIdProducto" runat="server"  Text='<%#Eval("id_producto") %>'></asp:Label></span>
                                <br />
                                <span class="letras_cuadro">Nombres:</span>
                                <asp:Label ID="lblNombre" runat="server" Text='<%#Eval("nombre") %>'></asp:Label>
                                <br />
                                <span class="letras_cuadro">Descripción:</span><br />
                                <asp:Label ID="lblDescripcion" runat="server" Text='<%#Eval("descripcion") %>'></asp:Label>
                                <br />
                                <span class="letras_cuadro">Puntos:</span>
                                <asp:Label ID="lblPuntos" runat="server" Text='<%#Eval("puntos") %>'></asp:Label>
                                <br />
                                <span class="letras_cuadro">Stock:</span>
                                <asp:Label ID="lblStock" runat="server" Text='<%#Eval("stock") %>'></asp:Label>
                                <br />
                                <span class="letras_cuadro">Foto:</span>
                                <asp:Label ID="lblFoto" runat="server" Text='<%#Eval("foto") %>'></asp:Label>
                                <br />
                               <!-- <span class="letras_cuadro">Categoría: </span>
                                <br />
                                <asp:Label ID="lblCategoria" runat="server" Text='<#Eval("categorias") %>'></asp:Label>-->
                            </td>
                        </tr >
                        <tr style="border:none">
                            <td colspan="2" style="text-align: center; border:none">
                                <asp:ImageButton ID="btnCarrito" runat="server" Height="49px" ImageUrl="~/imagenes/btnCarrito.png" Width="216px" CommandName="Agregar" />
                            </td>
                        </tr>
                    </table>
                    <br />
                </ItemTemplate>
            </asp:DataList>

                    </div>

                </ContentTemplate>
            </asp:UpdatePanel>
</asp:Content>
