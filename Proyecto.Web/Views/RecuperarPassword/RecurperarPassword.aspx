<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecurperarPassword.aspx.cs" Inherits="Proyecto.Web.Views.RecuperarPassword.RecurperarPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    <meta name="description" content=""/>
    <meta name="author" content=""/>

    <title>Recuperar contraseña</title>

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
            <div class="card-header">Login</div>
            <div class="card-body">
                <div class="text-center mx-4 mb-5">
                    <h4>Olvidó su password</h4>
                    <p>
                        Ingrese su dirección de correo electrónico y nosotros enviaremos las instrucciones para la recuperación de su password.
                    </p>
                </div>
                <div class="form-group">
                    <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control"></asp:TextBox>
                </div>
                <asp:Button ID="btnAceptar" runat="server" Text="Recuperar password" CssClass="btn btn-primary btn-block" OnClick="btnAceptar_Click" />
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
