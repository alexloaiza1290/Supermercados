<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="frmAccesoCliente.aspx.cs" Inherits="CapaPresentacion.frmAccesoCliente" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">      
    </asp:UpdatePanel>

     <div class="container">
          <div class="row">
                <div class="col-md-6"><br /><br /><br />
                    <img src="imagenes/carro-01.png" /></div>
               <div class="col-md-6">
                   <div>
                       <div class="fondo_login">
                           <div class="titulo_auti">Autentificación Cliente</div>
                           <div class="titulo_usu"><br />Usuario: </div>
                           <div class="inpuxt_name"> <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control"></asp:TextBox>
                               <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUsuario" ErrorMessage="Ingresar Usuario" style="color: #FF0000" ValidationGroup="ingresar"></asp:RequiredFieldValidator>
                               <br /><br /></div>
                           <div class="titulo_usu">Password: </div>
                           <div class="inpuxt_name"><asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password" AutoComplete="off"></asp:TextBox>
                               <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="Ingresar Password" style="color: #FF0000" ValidationGroup="ingresar"></asp:RequiredFieldValidator>
                               <br /><br /></div>
                           <div class="boton"> <asp:Button ID="btnIngresar" CssClass="btn btn-warning" Width="260px" runat ="server" Text="Ingresar" OnClick="btnIngresar_Click" ValidationGroup="ingresar"/>
                               <div class="titulo_usu">
                                   <br />
                                  Agregar Nuevo Cliente:           
                               <asp:ImageButton ID="ImageButton1" runat="server" Height="44px" ImageUrl="~/imagenes/images.png" OnClick="ImageButton1_Click" Width="51px" /></div>
                           </div>
                           <br />
                       </div>
                       <br /><br />
                   </div>
               </div>
          </div>
     </div>
      
</asp:Content>
