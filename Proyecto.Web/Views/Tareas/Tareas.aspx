<%@ Page Title="" Language="C#" MasterPageFile="~/Resources/Templates/Template.Master" AutoEventWireup="true" CodeBehind="Tareas.aspx.cs" Inherits="Proyecto.Web.Views.Tareas.Tareas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenedor" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="container">        
        <div class="card mx-auto mt-1">
            <div class="card-header"Crear>Tareas</div>
            <div class="card-body">
                 <%--Fila 1--%>
                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-12">
                            <h2>
                                <b>Titular de la tarea</b>
                                <asp:Label runat="server" ID="lblOpcion" Visible="false" ></asp:Label>
                            </h2>
                        </div>
                    </div>
                </div>
                 <%--Fila 2--%>
                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lblTitularTarea" Text="Titular de la tarea"></asp:Label>
                            <asp:TextBox runat="server" ID="txtTitularTarea" CssClass="form-control"></asp:TextBox>
                            <ajaxToolkit:TextBoxWatermarkExtender ID="tbxTitularTarea" runat="server"
                                TargetControlID="txtTitularTarea"
                                WatermarkText="Introduzca el titular de la tarea"
                                WatermarkCssClass="watermarked" />
                        </div>
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lblAsunto" Text="Asunto"></asp:Label>
                            <asp:TextBox runat="server" ID="txtAsunto" CssClass="form-control"></asp:TextBox>
                            <ajaxToolkit:TextBoxWatermarkExtender ID="tbxAsunto" runat="server"
                                TargetControlID="txtAsunto"
                                WatermarkText="Introduzca el asunto"
                                WatermarkCssClass="watermarked" />
                        </div>
                    </div>
                </div>
                 <%--Fila 3--%>
                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lblFechaVencimiento" Text="Fecha de vencimiento"></asp:Label>
                            <asp:TextBox runat="server" ID="txtFechaVencimiento" CssClass="form-control"></asp:TextBox>
                            <ajaxToolkit:TextBoxWatermarkExtender  ID="tbxFechaVencimiento"  runat="server"
                                TargetControlID="txtFechaVencimiento"
                                WatermarkText="Introduzca fecha de vencimiento"
                                WatermarkCssClass="watermarked" />
                            <ajaxToolkit:CalendarExtender runat="server"
                                    Format="dd-MM-yyyy"                                   
                                    TargetControlID="txtFechaVencimiento" />
                        </div>
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lblContacto" Text="Contacto"></asp:Label>
                            <asp:TextBox runat="server" ID="txtContacto" CssClass="form-control"></asp:TextBox>
                            <ajaxToolkit:TextBoxWatermarkExtender ID="tbxContacto" runat="server"
                                TargetControlID="txtContacto"
                                WatermarkText="Introduzca Contacto"
                                WatermarkCssClass="watermarked" />
                        </div>
                    </div>
                </div>                   
                 <%--Fila 4--%>
                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lblCuenta" Text="Fecha de vencimiento"></asp:Label>
                            <asp:TextBox runat="server" ID="txtCuenta" CssClass="form-control"></asp:TextBox>
                            <ajaxToolkit:TextBoxWatermarkExtender  ID="tbxCuenta"  runat="server"
                                TargetControlID="txtCuenta"
                                WatermarkText="Introduzca la cuenta"
                                WatermarkCssClass="watermarked" />
                        </div>
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lblEstado" Text="Estado"></asp:Label>
                            <asp:DropDownList runat="server" ID="ddlEstado" CssClass="form-control"></asp:DropDownList>
                        </div>
                    </div>
                </div>                
                <%--Fila 5--%>
                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lblPrioridad" Text="Prioridad"></asp:Label>
                            <asp:DropDownList runat="server" ID="ddlPrioridad" CssClass="form-control"></asp:DropDownList>
                        </div>
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lblEnviarMensaje" Text="Enviar mensaje">
                                <asp:Checkbox runat="server" ID="chkEnviarMensaje" CssClass="form-control"></asp:Checkbox>                        
                            </asp:Label>
                        </div>
                    </div>
                </div>                
                <%--Fila 6--%>
                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lblRepetir" Text="Repetir">
                                <asp:Checkbox runat="server" ID="chkRepetir" CssClass="form-control"></asp:Checkbox>                        
                            </asp:Label>
                        </div>
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lblDescripcion" Text="Descripción"></asp:Label>
                            <asp:TextBox runat="server" ID="txtDescripcion" CssClass="form-control" TextMode="MultiLine" ></asp:TextBox>
                            <ajaxToolkit:TextBoxWatermarkExtender  ID="tbxDescripcion"  runat="server"
                                TargetControlID="txtDescripcion"
                                WatermarkText="Introduzca la descripción"
                                WatermarkCssClass="watermarked" />
                        </div>
                    </div>
                </div>                    
            </div>
        </div>    
    </div>
</asp:Content>
