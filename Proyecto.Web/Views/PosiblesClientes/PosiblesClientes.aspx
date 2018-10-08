<%@ Page Title="" Language="C#" MasterPageFile="~/Resources/Templates/Template.Master" AutoEventWireup="true" CodeBehind="PosiblesClientes.aspx.cs" Inherits="Proyecto.Web.Views.PosiblesClientes.PosiblesClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenedor" runat="server">
    <div class="mx-auto mt-5"> 
<%--primera sección--%>
        <div class="form-group">
            <div class="form-row">
                <div class="col-xs-12">
                    <h1><b>Posibles Clientes</b></h1>
                    <asp:Label runat="server" ID="lblOpcion" style="visibility:hidden"/>
                </div> 
            </div>
        </div>
        <div class="form-group">
            <div class="form-row">
                <div class="col-sm-3">
                    <div class="col-xs-12">
                        <asp:Label runat="server" ID="lblIdentificacion" Text="Identificacion" />
                    </div>
                    <div class="col-xs-12">
                        <asp:TextBox runat="server" ID="txtIdentificacion" CssClass="form-group" />
                    </div>
                </div>
                <div class="col-sm-3">
                    <div class="col-xs-12">
                        <asp:Label runat="server" ID="lblEmpresa" Text="Empresa" />
                    </div>
                    <div class="col-xs-12">
                        <asp:TextBox runat="server" ID="txtEmpresa" CssClass="form-group" />
                    </div>
                </div>
                <div class="col-sm-3">
                    <asp:Label runat="server" ID="lblPrimerNombre" Text="Primer Nombre" />
                    <asp:TextBox runat="server" ID="txtPrimerNombre" CssClass="form-group" />
                </div>
                <div class="col-sm-3">
                    <asp:Label runat="server" ID="lblSegundoNombre" Text="Segundo Nombre" />
                    <asp:TextBox runat="server" ID="txtSegundoNombre" CssClass="form-group" />
                </div>
            </div>
        </div>     
    <%--        Segunda sección--%>
        <div class="form-group">
            <div class="form-row">
                <div class="col-sm-3">
                    <asp:Label runat="server" ID="lblPrimerApellido" Text="Primer Apellido" />
                    <asp:TextBox runat="server" ID="txtPrimerApellido" CssClass="form-group" />
                </div>
                <div class="col-sm-3">
                    <asp:Label runat="server" ID="lblSegundoApellido" Text="Segundo Apellido" />
                    <asp:TextBox runat="server" ID="txtSegundoApellido" CssClass="form-group" />
                </div>
                <div class="col-sm-3">
                    <asp:Label runat="server" ID="lblDireccion" Text="Dirección" />
                    <asp:TextBox runat="server" ID="txtDireccion" CssClass="form-group" />
                </div>
                <div class="col-sm-3">
                    <div class="col-xs-12">
                        <asp:Label runat="server" ID="lblTelefono" Text="Telefono" />
                    </div>
                    <div class="col-xs-12">
                        <asp:TextBox runat="server" ID="txtTelefono" CssClass="form-group" />
                    </div>
                </div>
            </div>
        </div> 
        <%--        Tercera sección--%>
        <div class="form-group">
            <div class="form-row">
                <div class="col-sm-12">
                    <div class="col-xs-12">
                        <asp:Label runat="server" ID="lblCorreo" Text="Correo" />
                    </div>
                    <div class="col-xs-12">
                        <asp:TextBox runat="server" ID="txtCorreo" CssClass="form-group" />
                    </div>
                </div> 
                <div class="col-sm-12">
                </div> 
            </div>
        </div>  
   <%--        Cuarta sección--%>
        <div class="form-group">
            <div class="form-row">
                <div class="col-sm-12">
                    <asp:Button  runat="server" id="btnGuardar" Text="Guardar" CssClass="btn btn-primary" OnClick="btnGuardar_Click" />
                    <asp:Button  runat="server" id="btnCancelar" Text="Cancelar" CssClass="btn btn-primary" OnClick="btnCancelar_Click" />
                </div> 
            </div>
        </div>  
   <%--        Cuarta sección--%>
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
                            <asp:TemplateField HeaderText="Identificacion">
                                <itemTemplate>
                                    <asp:Label runat="server" ID="lbIdentificacion" Text='<%#Bind("clieIdentificacion")%>'></asp:Label>
                                </itemTemplate>
                            </asp:TemplateField>
                            <%--Representacion de datos en celdas
                            <asp:BoundField HeaderText="Identificacion" DataField="clieIdentificacion" />--%>
                            <asp:BoundField HeaderText="Empresa" DataField="clieEmpresa" />
                            <asp:BoundField HeaderText="Primer Nombre" DataField="cliePrimerNombre" />
                            <asp:BoundField HeaderText="Segundo Nombre" DataField="clieSegundoNombre" />
                            <asp:BoundField HeaderText="Primer Apellido" DataField="cliePrimerApellido" />
                            <asp:BoundField HeaderText="Segundo Apellido" DataField="clieSegundoApellido" />
                            <asp:BoundField HeaderText="Dirección" DataField="clieDireccion" />
                            <asp:BoundField HeaderText="Teléfono" DataField="clieTelefono" />
                            <asp:BoundField HeaderText="Correo" DataField="clieCorreo" />
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
</asp:Content>
