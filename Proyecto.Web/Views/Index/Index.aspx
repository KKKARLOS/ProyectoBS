<%@ Page Title="" Language="C#" MasterPageFile="~/Resources/Templates/Template.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Proyecto.Web.Views.Index.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenedor" runat="server">
        <div class="container">        
        <div class="card card-login mx-auto mt-5">
            <div class="card-header text-center">
                <h2>Bienvenido</h2>
            </div>
            <div class="card-body">
                <div class="form-group">
                    <div class="form-row">
                        <div class="col-xl-12 text-center">
                            <asp:Image runat="server" ID="imgCuenta" Width="200px" Height="200px" />
                        </div>
                    </div>                    
                </div>
            </div>
        </div>
    </div> 
</asp:Content>
