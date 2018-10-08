<%@ Page Title="" Language="C#" MasterPageFile="~/Resources/Templates/Template.Master" AutoEventWireup="true" CodeBehind="Login2.aspx.cs" Inherits="Proyecto.Web.Views.Login.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenedor" runat="server">
    <div class="card card-login mx-auto mt-5">
        <div class="card-header">Login</div>
        <div class="card-body">
            <div class="form-group">
                <input runat="server" type="email" id="txtEmail" class="form-control" placeholder="Email address" required="required" autofocus="autofocus" value="Dirección email"/>
            </div>
            <div class="form-group">
                <input runat="server" type="password" id="txtPassword" class="form-control" placeholder="Contraseña"  value="Contraseña" required="required"/>
            </div>
            <div class="form-group">
              <div class="checkbox">
                <label>
                  <input runat="server" type="checkbox" value="remember-me"/>
                  Recordar contraseña
                </label>
              </div>
            </div>
            <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn btn-primary btn-block" OnClick="btnLogin_Click" />

          <div class="text-center">
            <a class="d-block small mt-3" href="../Register/Register.aspx">Register an Account
              </a>
            &nbsp;<a class="d-block small" href="forgot-password.html">Forgot Password?</a>
          </div>
        </div>
      </div>
</asp:Content>
