<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frm_inscripcion.aspx.vb" Inherits="ProyectoWeb.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 26px;
        }
        .auto-style7 {
            width: 137px;
        }
        .auto-style8 {
            height: 26px;
            width: 137px;
        }
        .auto-style9 {
            width: 485px;
        }
        .auto-style10 {
            text-align: right;
        }
        .auto-style12 {
            width: 247px;
            height: 29px;
        }
        .auto-style13 {
            height: 29px;
        }
        .auto-style14 {
            height: 29px;
            width: 152px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style9">
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style7">Inscripciones</td>
                                <td>
                                    <asp:Label ID="lbl_codigo" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style8">Evento</td>
                                <td class="auto-style2">
                                    <asp:DropDownList ID="cbo_eventos" runat="server" Width="216px" AutoPostBack="True">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style7">DNI Estudiante</td>
                                <td>
                                    <asp:TextBox ID="txt_dni" runat="server" Width="205px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style7">&nbsp;</td>
                                <td>
                                    <asp:Button ID="btn_buscar_estudiante" runat="server" Text="Buscar" />
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style7">&nbsp;</td>
                                <td>
                                    <asp:Label ID="lbl_estudiante" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style8">Tipo Pago</td>
                                <td class="auto-style2">
                                    <asp:DropDownList ID="cbo_tipo_pago" runat="server" Width="216px" AutoPostBack="True">
                                        <asp:ListItem Value="E">Efectivo</asp:ListItem>
                                        <asp:ListItem Value="D">Diferido</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style7">
                                    <asp:Label ID="lbl_nro_cuotas" runat="server" Text="Nro Cuotas"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="num_cuotas" runat="server" TextMode="Number" Width="206px"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td>
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style2">Actividades del evento</td>
                            </tr>
                            <tr>
                                <td class="auto-style2">
                                    <asp:GridView ID="dgv_actividades" runat="server" Height="139px" Width="598px">
                                        <Columns>
                                            <asp:TemplateField>
                                                <ItemTemplate>
                                                    <asp:CheckBox ID="chkActividad" runat="server"/>
                                                </ItemTemplate>

                                            </asp:TemplateField>
                                        </Columns>
                                    </asp:GridView>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style10">
                                    <asp:Button ID="btn_grabar" runat="server" Text="Grabar" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style12">DNI Estudiante</td>
                    <td class="auto-style14">
                        <asp:TextBox ID="txt_dni_consulta" runat="server" Width="213px"></asp:TextBox>
                        <asp:Button ID="btn_consulta" runat="server" Text="Consultar" Width="96px" />
                    </td>
                    <td class="auto-style13">Detalle Inscripción</td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:GridView ID="dgv_inscripciones" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="750px">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:CommandField ShowSelectButton="True" />
                            </Columns>
                            <EditRowStyle BackColor="#7C6F57" />
                            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#E3EAEB" />
                            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#F8FAFA" />
                            <SortedAscendingHeaderStyle BackColor="#246B61" />
                            <SortedDescendingCellStyle BackColor="#D4DFE1" />
                            <SortedDescendingHeaderStyle BackColor="#15524A" />
                        </asp:GridView>
                    </td>
                    <td>
                        <asp:GridView ID="dgv_detalle" runat="server">
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10" colspan="2">
                        <asp:Button ID="btn_eliminar" runat="server" Text="Eliminar" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
