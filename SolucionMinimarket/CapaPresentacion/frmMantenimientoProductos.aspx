<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmMantenimientoProductos.aspx.cs" Inherits="CapaPresentacion.frmMantenimientoProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">    
  
  <style type="text/css">
        .auto-style6 {
        font-size: large;
    }
      .auto-style8 {
          display: block;
          font-size: 14px;
          line-height: 1.42857143;
          color: #555;
          vertical-align: middle;
          border-radius: 4px;
          -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, .075);
          box-shadow: inset 0 1px 1px rgba(0, 0, 0, .075);
          -webkit-transition: border-color ease-in-out .15s, -webkit-box-shadow ease-in-out .15s;
          transition: border-color ease-in-out .15s, box-shadow ease-in-out .15s;
          -o-transition: border-color ease-in-out .15s, box-shadow ease-in-out .15s;
          border: 1px solid #ccc;
          padding: 6px 12px;
          background-color: #fff;
          background-image: none;
      }
      .auto-style10 {
          width: 304px;
      }
      .auto-style11 {
          width: 326px;
      }
      .auto-style12 {
          text-align: left;
      }
      .auto-style13 {
          font-family: 'Century Gothic';
          font-size: 18px;
          color: #FF4600;
          font-weight: bold;
          padding-top: 20px;
          padding-left: 120px;
          text-align: center;
      }
      .auto-style14 {
          width: 89%;
      }
      .auto-style15 {
          display: block;
          font-size: 14px;
          line-height: 1.42857143;
          color: #555;
          vertical-align: middle;
          border-radius: 4px;
          -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, .075);
          box-shadow: inset 0 1px 1px rgba(0, 0, 0, .075);
          -webkit-transition: border-color ease-in-out .15s, -webkit-box-shadow ease-in-out .15s;
          transition: border-color ease-in-out .15s, box-shadow ease-in-out .15s;
          -o-transition: border-color ease-in-out .15s, box-shadow ease-in-out .15s;
          border: 1px solid #ccc;
          padding: 6px 12px;
          background-color: #fff;
          background-image: none;
          margin-left: 0;
      }
      .auto-style16 {
          width: 294px;
      }
    </style>  
   
  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager runat="server"></asp:ScriptManager>
   
        
            <div style="padding:3px;padding-left:10%;padding-right:10%">
                <br /><br />
                 <div class="letrasCa" style="font-weight: 700; background-color: #FFFFFF; text-align: center;" class="text-center">
              <span class="auto-style6">MANTENIMIENTO DE PRODUCTOS</span>
          </div>
                <br /><br />
            <table class="auto-style14">
                <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Producto:"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="txtIdProducto" runat="server" CssClass="form-control" Width="300px" ValidationGroup="buscar"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtIdProducto" ErrorMessage="Ingresar Codigo Producto" style="color: #FF0000" ValidationGroup="buscar"></asp:RequiredFieldValidator>
                        &nbsp;</td>
                    <td class="auto-style11">
                        <asp:Label ID="Label11" runat="server" Text="Categoría:"></asp:Label>
                    </td>
                    <td class="auto-style16">
                        <asp:DropDownList ID="ddlCategoria" runat="server" style="margin-left: 0px" AutoPostBack="True" Height="30px" Width="300px" CssClass="form-control" OnSelectedIndexChanged="ddlCategoria_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                    <td rowspan="3">
                        <asp:Image ID="imgProducto" runat="server" Height="133px" Width="194px"  CssClass="img-thumbnail"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text="Nombre:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtNombre" runat="server" Width="300px" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNombre" ErrorMessage="Ingresar Nombre Producto" style="color: #FF0000" ValidationGroup="insertar"></asp:RequiredFieldValidator>
                    </td>
                    <td></td>
                    <td class="auto-style12">Foto:</td>
                    <td class="auto-style16">
                        <asp:TextBox ID="txtFoto" runat="server" Height="30px" Width="178px" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtFoto" ErrorMessage="Seleccionar Foto" style="color: #FF0000" ValidationGroup="insertar"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label8" runat="server" Text="Descripción:"></asp:Label>
                    </td>
                    <td colspan="3">
                        <asp:TextBox ID="txtDescripcion" runat="server" Width="300px" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtDescripcion" ErrorMessage="Ingresar Descripcion " style="color: #FF0000" ValidationGroup="insertar"></asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style16">
                        <asp:Button ID="btnMostrarFoto" runat="server" Text="Mostrar Foto" OnClick="btnMostrarFoto_Click"  CssClass="btn  btn-info" Height="36px" />                     
                        <br />
                    </td>
                </tr>
                <tr style="height:50px;">
                    <td>
                        <asp:Label ID="Label9" runat="server" Text="Puntos:"></asp:Label>
                    </td>
                    <td class="auto-style10">
                        <asp:TextBox ID="txtPrecio" runat="server" CssClass="auto-style8" Width="126px"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtPrecio" ErrorMessage="Solo Números" style="color: #FF0000" ValidationExpression="\d*\.?\d*" ValidationGroup="insertar"></asp:RegularExpressionValidator>
                        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtPrecio" ErrorMessage="Ingresar Precio" style="color: #FF0000" ValidationGroup="insertar"></asp:RequiredFieldValidator>
                    </td>
                    <td colspan="2">
                        <asp:Label ID="Label10" runat="server" Text="Stock:"></asp:Label>
                    </td>
                    <td class="auto-style16">
                        <asp:TextBox ID="txtStock" runat="server" Height="30px" Width="73px" CssClass="form-control"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtStock" ErrorMessage="Solo Números" style="color: #FF0000" ValidationExpression="\d*\.?\d*" ValidationGroup="insertar"></asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtStock" ErrorMessage="Ingresar Stock" style="color: #FF0000" ValidationGroup="insertar"></asp:RequiredFieldValidator>
                    </td>
                    <td>
                        <asp:FileUpload BorderStyle="None" ID="FileUpload1" runat="server" CssClass="auto-style15" Width="327px" />
                    </td>
                    <td></td>
                </tr>
                     
            </table>
            </div>
    <div>
        <div class="col-lg-3">

        </div>
        <div class="col-lg-6">
             <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" Width="100px" OnClick="btnNuevo_Click" CssClass="btn btn-warning"  Height="36px" />
                 &nbsp;  &nbsp; &nbsp; &nbsp;
              <asp:Button ID="btnGrabar" runat="server" Text="Grabar" Width="100px" OnClick="btnGrabar_Click" CssClass="btn btn-warning"  Height="36px" ValidationGroup="insertar" />
                 &nbsp;  &nbsp; &nbsp; &nbsp;
              <asp:Button ID="btnBuscar" runat="server" Text="Buscar" Width="100px" OnClick="btnBuscar_Click" CssClass="btn btn-primary"  Height="36px" ValidationGroup="buscar" />

        </div>
        <div class="col-lg-3">

        </div>
     
    </div>
            <br /><br />
            <div class="auto-style13"; style="align-content:center;align-items:center">
               
                <asp:Label ID="Label1" runat="server" Text="LISTADO DE PRODUCTOS" style="font-weight: 700; font-size: large; text-align: center"></asp:Label>
            </div>
            <br />
            <div style="text-align: center;padding-left:5%;padding-right:5%" >
                <asp:GridView ID="grvDatos" runat="server" Width="100%" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" CssClass="mGrid">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="id_producto" HeaderText="Código" >
                        <HeaderStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                        <asp:BoundField DataField="descripcion" HeaderText="Descripción" />
                        <asp:BoundField DataField="puntos" HeaderText="Precio" />
                        <asp:BoundField DataField="stock" HeaderText="Stock" />
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
       
        
   
</asp:Content>
