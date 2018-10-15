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
                         <div class="col-md-4">
                            <asp:Label runat="server" ID="lblCodigo" Text="Codigo de la tarea"></asp:Label>
                            <asp:TextBox runat="server" ID="txtCodigo" CssClass="form-control"></asp:TextBox>
                            <ajaxToolkit:TextBoxWatermarkExtender ID="twmtCodigo" runat="server"
                                TargetControlID="txtCodigo"
                                WatermarkText="Codigo Tarea" />
                        </div>
                        <div class="col-md-4">
                            <asp:Label runat="server" ID="lblTitularTarea" Text="Titular de la tarea"></asp:Label>
                            <asp:TextBox runat="server" ID="txtTitular" CssClass="form-control"></asp:TextBox>
                            <ajaxToolkit:TextBoxWatermarkExtender ID="tbxTitularTarea" runat="server"
                                TargetControlID="txtTitular"
                                WatermarkText="Introduzca el titular de la tarea"
                                WatermarkCssClass="watermarked" />
                        </div>
                        <div class="col-md-4">
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
                            <asp:Label runat="server" ID="lblCuenta" Text="Cuenta"></asp:Label>
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

                    
                <div class="form-group">
                    <div class="form-row">
                        <div class="col-sm-12">
                            <asp:Button  runat="server" id="btnGuardar" Text="Guardar" CssClass="btn btn-primary" OnClick="btnGuardar_Click" />
                            <asp:Button  runat="server" id="btnCancelar" Text="Cancelar" CssClass="btn btn-primary" OnClick="btnCancelar_Click" />
                        </div> 
                    </div>
                </div>  
                <%--Fila 8--%>
                <div class="form-group">
                    <div class="form-row">
                        <div class="col-sm-12">
                            <h3><b>Resultado</b></h3>
                            <asp:Label runat="server" ID="lblSubtitulo" Text="Resultado" />
                        </div> 
                    </div>
                </div>
                <div class="form-group">
                    <div class="form-row">
                        <div class="col-sm-12" style="overflow:auto">
                            <asp:gridVIew runat="server" Id="gvwDatos" 
                                width="100%" 
                                AutoGenerateColumns="False" 
                                EmptyDataText="No se encontraron registros" 
                                CellPadding="3" 
                                BorderStyle="None"
                                ForeColor="#333333" 
                                GridLines="Vertical"
                                OnRowCommand="gvwDatos_RowCommand"
                                >
                                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                <Columns>
                                    <%--Representacion de datos en controles wevb--%>
                                    <asp:TemplateField visible="false">
                                        <itemTemplate>
                                            <asp:Label runat="server" ID="lbCodigo" Text='<%#Bind("inCodigo")%>'></asp:Label>
                                            <asp:Label runat="server" ID="lbCodigoEstado" Text='<%#Bind("oClsEstado.inEstaCodigo")%>'></asp:Label>
                                            <asp:Label runat="server" ID="lbCodigoPrioridad" Text='<%#Bind("oClsPrioridad.inCodigo")%>'></asp:Label>
                                        </itemTemplate>
                                    </asp:TemplateField>
                                    <%--Representacion de datos en celdas
                                    <asp:BoundField HeaderText="Identificacion" DataField="clieIdentificacion" />--%>
                                    <asp:BoundField HeaderText="Titular" DataField="stTitular" />
                                    <asp:BoundField HeaderText="Asunto" DataField="stAsunto" />
                                    <asp:BoundField HeaderText="Fecha Vencimiento" DataField="stFechaVencimiento" />
                                    <asp:BoundField HeaderText="Contacto" DataField="stContacto" />
                                    <asp:BoundField HeaderText="Cuenta" DataField="stCuenta" />
                                    <asp:BoundField HeaderText="Estado" DataField="oClsEstado.stDescripcion" />
                                    <asp:BoundField HeaderText="Prioridad" DataField="oClsPrioridad.stDescripcion" />
                                    <asp:BoundField HeaderText="Enviar mensaje" DataField="stEnviarMensaje" />
                                    <asp:BoundField HeaderText="Repetir" DataField="stRepetir" />
                                    <asp:BoundField HeaderText="Descripcion" DataField="stDescripcion" />
                                    <asp:TemplateField HeaderText="Editar">
                                        <itemTemplate>                                    
                                            <asp:ImageButton runat="server" ID="ibEditar" CommandName="Editar" ImageUrl="~/Resources/Images/icons8-editar-26.png" CommandArgument='<%#((GridViewRow) Container).RowIndex%>'></asp:ImageButton>
                                        </itemTemplate>
                                        <ItemStyle HorizontalAlign="Center" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Eliminar">
                                        <itemTemplate>                                    
                                            <asp:ImageButton runat="server" ID="ibEliminar" CommandName="Eliminar" ImageUrl="~/Resources/Images/icons8-eliminar-26.png" CommandArgument='<%#((GridViewRow) Container).RowIndex%>'></asp:ImageButton>
                                        </itemTemplate>
                                        <ItemStyle HorizontalAlign="Center" />
                                    </asp:TemplateField>
                                </Columns>

                                <EditRowStyle BackColor="#999999" />
                                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />

                            </asp:gridVIew>
                        </div> 
                    </div>
                </div>    



            </div>
        </div>    
    </div>
</asp:Content>
