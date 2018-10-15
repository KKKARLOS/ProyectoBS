<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrearCuenta.aspx.cs" Inherits="Proyecto.Web.Views.CrearCuenta.CrearCuenta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    <meta name="description" content=""/>
    <meta name="author" content=""/>

    <title>Crear Cuenta</title>

    <!-- Bootstrap core CSS-->
    <link href="../../vendor/bootstrap/css/bootstrap.css" rel="stylesheet"/>

    <!-- Custom fonts for this template-->
    <link href="../../vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css"/>

    <!-- Custom styles for this template-->
    <link href="../../css/sb-admin.css" rel="stylesheet"/>

   <!-- Sweet Alert -->
    <link href="../../css/sweetalert.css" rel="stylesheet" type="text/css"/>
  </head>
<body class="bg-dark">
  <form id="form1" runat="server">    
     <div class="container">        
        <div class="card card-login mx-auto mt-5">
            <div class="card-header">Crear cuenta nueva</div>
            <div class="card-body">

                    <div class="form-group">
                        <div class="form-row">
                            <div class="col-md-12">
                                <asp:Label runat="server" ID="lblLogin">Email</asp:Label>
                                <asp:TextBox runat="server" ID="txtLogin" TextMode="Email" CssClass="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfvLogin" runat="server" ErrorMessage="Campo obligatorio" ControlToValidate="txtLogin" ForeColor="Red" ValidationGroup="ValidarCuenta"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="form-row">
                            <div class="col-md-12">
                                <asp:Label runat="server" ID="lblPassword">Password</asp:Label>
                                <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" CssClass="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ErrorMessage="Campo obligatorio" ControlToValidate="txtPassword" ForeColor="Red" ValidationGroup="ValidarCuenta"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="form-row">
                            <div class="col-md-12">
                                <asp:Label runat="server" ID="lblConfirmarPassword">Confirmar Password</asp:Label>
                                <asp:TextBox runat="server" ID="txtConfirmarPassword" TextMode="Password" CssClass="form-control"></asp:TextBox>
                                <asp:CompareValidator ID="cvConfirmarPassword" runat="server" ErrorMessage="El password de confirmación es diferente" ControlToCompare="txtPassword" ControlToValidate="txtConfirmarPassword" style="float:left" ForeColor="Red"></asp:CompareValidator>
                                <asp:RequiredFieldValidator ID="rfvConfirmarPassword" runat="server" ErrorMessage="Campo obligatorio" ControlToValidate="txtConfirmarPassword" ForeColor="Red" ValidationGroup="ValidarCuenta" style="float:left"></asp:RequiredFieldValidator>                                
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="form-row">
                            <div class="col-md-12">
                                <asp:Label runat="server" ID="lblImagen">Foto</asp:Label>
                                <asp:FileUpLoad runat="server" ID="fuImagen" CssClass="form-control"></asp:FileUpLoad>
                                <asp:RequiredFieldValidator ID="rfvFuImagen" runat="server" ErrorMessage="Campo obligatorio" ControlToValidate="fuImagen" ForeColor="Red" ValidationGroup="ValidarCuenta"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                    </div>
                    <asp:Button ID="btnAceptar" runat="server" Text="Crear Cuenta" CssClass="btn btn-primary btn-block" ValidationGroup="ValidarCuenta" OnClick="btnAceptar_Click" />
                    <div class="text-center">
                            <a class="d-block small mt-3" href="../Login/Login.aspx">Login</a>
                    </div>  
              
            </div>
        </div>
    </div>
    <!-- Bootstrap core JavaScript-->
    <script src="../../vendor/jquery/jquery.min.js"></script>
    <script src="../../vendor/bootstrap/js/bootstrap.min.js"></script>

    <!-- Core plugin JavaScript-->
    <script src="../../vendor/jquery-easing/jquery.easing.min.js"></script>

    <!-- Custom scripts for all pages-->
    <script src="../../js/sb-admin.min.js"></script>

    <!-- Sweet Alert-->
    <script src="../../js/sweetalert.min.js"></script>
   </form>      
  </body>
</html>
