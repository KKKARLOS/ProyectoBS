<%@ Page Title="" Language="C#" MasterPageFile="~/Resources/Templates/Template.Master" AutoEventWireup="true" CodeBehind="Register2.aspx.cs" Inherits="Proyecto.Web.Views.Register.Register1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenedor" runat="server">
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

</asp:Content>
