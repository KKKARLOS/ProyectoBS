<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Proyecto.Web.Views.Register.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<meta charset="utf-8"/>
<meta http-equiv="X-UA-Compatible" content="IE=edge"/>
<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
<meta name="description" content=""/>
<meta name="author" content=""/>

<title>Registrar</title>

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
<form id="form2" runat="server">
    <div class="container">    
    <div class="card card-register mx-auto mt-5">
        <div class="card-header">Register an Account</div>
        <div class="card-body">
            <div class="form-group">
              <div class="form-row">
                <div class="col-md-6">
                  <div class="form-label-group">
                    <input runat="server" type="text" id="firstName" class="form-control" placeholder="First name" required="required" autofocus="autofocus"/>
                    <label for="firstName">First name</label>
                  </div>
                </div>
                <div class="col-md-6">
                  <div class="form-label-group">
                    <input runat="server" type="text" id="lastName" class="form-control" placeholder="Last name" required="required"/>
                    <label for="lastName">Last name</label>
                  </div>
                </div>
              </div>
            </div>
            <div class="form-group">
              <div class="form-label-group">
                <input runat="server" type="email" id="inputEmail" class="form-control" placeholder="Email address" required="required"/>
                <label for="inputEmail">Email address</label>
              </div>
            </div>
            <div class="form-group">
              <div class="form-row">
                <div class="col-md-6">
                  <div class="form-label-group">
                    <input runat="server" type="password" id="inputPassword" class="form-control" placeholder="Password" required="required"/>
                    <label for="inputPassword">Password</label>
                  </div>
                </div>
                <div class="col-md-6">
                  <div class="form-label-group">
                    <input runat="server" type="password" id="confirmPassword" class="form-control" placeholder="Confirm password" required="required"/>
                    <label for="confirmPassword">Confirm password</label>
                  </div>
                </div>
              </div>
            </div>
            <a class="btn btn-primary btn-block" href="login.html">Register</a>
          <div class="text-center">
            <a class="d-block small mt-3" href="../Login/login.aspx">Login Page</a>
            <a class="d-block small" href="forgot-password.html">Forgot Password?</a>
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
