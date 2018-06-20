<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaCarritoCompras.Master" AutoEventWireup="true" CodeBehind="frmCarrito.aspx.cs" Inherits="CapaPresentacion.frmCarrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            font-family: 'Century Gothic';
            font-size: large;
            color: #0000FF;
            font-weight: bold;
            padding-top: 20px;
            padding-left: 5px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        
    </asp:UpdatePanel>
    <div class="tituloCarrito">
        Detalle de Pedido: Contenido de canje de puntos
    </div>
    <br />
    <div>
        <asp:GridView ID="grvPedido" runat="server" AutoGenerateColumns="False" Width="100%" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDeleting="grvPedido_RowDeleting" CssClass="mGrid">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="codigo" HeaderText="Codigo" >
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="descripcion" HeaderText="Descripción" />
                <asp:BoundField DataField="puntos" HeaderText="Puntos" >
                <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:TemplateField HeaderText="Cantidad">
                    <ItemTemplate>
                        <asp:TextBox ID="txtCantidad" runat="server"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="total" HeaderText="Total" >
                 <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                 <asp:TemplateField HeaderText="Operación">
                    <ItemTemplate>
                       <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="false" CommandName="Delete">Quitar</asp:LinkButton>
                    </ItemTemplate>
                     <EditItemTemplate>
                          
                     </EditItemTemplate>
                     <HeaderStyle HorizontalAlign="Center" />
                </asp:TemplateField>
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
        <br />
        <asp:Button ID="btnCalcular" runat="server" Text="Calcular Sub Total" OnClick="btnCalcular_Click"  CssClass="btn btn-warning"/> <span class="SubtituloCarrito"> cantidad de puntos: </span><span class="SubtituloCarritoMonto">
            <asp:Label ID="lblTotal" runat="server" ></asp:Label></span>
        <br />
    </div>
    <div>
        <br />
        <asp:Label ID="lblLetras" runat="server" CssClass="auto-style1"></asp:Label>
        <br />
        <asp:ImageButton ID="ImageButton1" runat="server" Height="58px" ImageUrl="~/imagenes/boton-compra.png" Width="232px" OnClick="ImageButton1_Click" />
        <asp:Label ID="lblcompraSatisfactoria" runat="server"  class="SubtituloCarritoMonto"></asp:Label>
    </div>
    <div>
        <asp:GridView ID="grvPrueba" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" CssClass="mGrid">
            <AlternatingRowStyle BackColor="White" />
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

</asp:Content>
