<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmMantenimientoClientes.aspx.cs" Inherits="CapaPresentacion.frmMantenimientoClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style7 {
            font-family: 'Century Gothic';
            font-size: x-large;
            color: #FF4600;
            font-weight: bold;
            padding-top: 20px;
            padding-left: 120px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <br /><br />
          <div  style="font-weight: 700; background-color: #FFFFFF;" class="text-center">
              <span  class="auto-style7">MANTENIMIENTO DE CLIENTES</span>
          </div>
            <br /><br />
            <div style ="padding-left:5%;padding-right:5%">

                <table class="nav-justified" style="width:100%;">
                    <tr>
                        <td>
                            <asp:Label ID="Label6" runat="server" Text="IdCliente:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtIdCliente" runat="server" Width="99px" CssClass="form-control" Height="30px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtIdCliente" ErrorMessage="Ingresar codigo del Cliente" style="color: #FF0000" ValidationGroup="Identificar"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <asp:Label ID="Label7" runat="server" Text="Nombre:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtNombre" runat="server" Width="260px" CssClass="form-control" Height="30px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtNombre" ErrorMessage="Ingresar Nombre" style="color: #FF0000" ValidationGroup="insertar"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr style="height:50px;">
                        <td>
                            <asp:Label ID="Label8" runat="server" Text="Apellidos:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtApellido" runat="server" Width="260px" CssClass="form-control" Height="30px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtApellido" ErrorMessage="Ingresar Apellido" style="color: #FF0000" ValidationGroup="insertar"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <asp:Label ID="Label12" runat="server" Text="Dirección:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtDireccion" runat="server" Width="260px" CssClass="form-control" Height="30px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtDireccion" ErrorMessage="Ingresar direccion" style="color: #FF0000" ValidationGroup="insertar"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label9" runat="server" Text="Telefono:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" Height="30px" Width="260px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtTelefono" ErrorMessage="Ingresar Telefono" style="color: #FF0000" ValidationGroup="insertar"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <asp:Label ID="Label13" runat="server" Text="DNI:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtDNI" runat="server" Width="260px" CssClass="form-control" Height="29px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Ingresar DNI" style="color: #FF0000" ValidationGroup="insertar" ControlToValidate="txtDNI"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr style="height:50px;">
                        <td>
                            <asp:Label ID="Label10" runat="server" Text="Email:"></asp:Label>
                        </td>
                        <td colspan="3">
                            <asp:TextBox ID="txtEmail" runat="server" Width="260px" CssClass="form-control" Height="30px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtEmail" ErrorMessage="Ingresar Email" style="color: #FF0000" ValidationGroup="insertar"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label11" runat="server" Text="Usuario:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtUsuario" runat="server" Width="260px" CssClass="form-control" Height="30px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtUsuario" ErrorMessage="Ingresar Usuario" style="color: #FF0000" ValidationGroup="insertar"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <asp:Label ID="Label14" runat="server" Text="Clave:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtClave" runat="server" Width="260px" CssClass="form-control" Height="30px" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtClave" ErrorMessage="Ingresar Clave" style="color: #FF0000" ValidationGroup="insertar"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                   
                  
                </table>

            </div>
            <br />
            <div style="padding-left:30%;padding-right:30%">
                            <table class="nav-justified">
                                <tr>
                                    <td>
                                        <asp:Button ID="btnNuevo" runat="server" CssClass="btn btn-warning" Text="Nuevo"  OnClick="btnNuevo_Click" />
                                    </td>
                                    <td>
                                        <asp:Button ID="btnGuardar" runat="server" CssClass="btn btn-warning" Text="Guardar"  OnClick="btnGuardar_Click" ValidationGroup="insertar" />
                                    </td>
                                    <td>
                                        <asp:Button ID="btnBuscar" runat="server" CssClass="btn btn-primary" Text="Buscar"  OnClick="btnBuscar_Click" ValidationGroup="Identificar" />
                                    </td>
                                    <td>
                                        <asp:Button ID="btnEliminar" runat="server" CssClass="btn btn-danger" Text="Eliminar"  OnClick="btnEliminar_Click" ValidationGroup="Identificar" />  
                                    </td>
                                </tr>
                 </table>
            </div>
            <br />
            <div class="letrasCa"; style="text-align: center; font-weight: 700; font-size: large">                
                LISTAR CLIENTES
            </div>
            <br />
            <div style="padding-left:5%;padding-right:5%">
                <asp:GridView ID="grvDatos" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" CssClass="mGrid">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="id_cliente" HeaderText="Codigo" >
                        <HeaderStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="nombres" HeaderText="Nombres" />
                        <asp:BoundField DataField="apellidos" HeaderText="Apellidos" />
                        <asp:BoundField DataField="direccion" HeaderText="Dirección" />
                        <asp:BoundField DataField="telefono" HeaderText="Telefono" />
                        <asp:BoundField DataField="dni" HeaderText="DNI" />
                        <asp:BoundField DataField="email" HeaderText="Email" />
                        <asp:BoundField DataField="usuario" HeaderText="Usuario" />
                        <asp:BoundField DataField="clave" HeaderText="Clave" />
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
                <br /><br />
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
