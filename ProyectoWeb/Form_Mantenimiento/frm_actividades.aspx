<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frm_actividades.aspx.vb" Inherits="ProyectoWeb.frm_actividades" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            height: 24px;
        }
        .auto-style4 {
            height: 26px;
        }
        .auto-style6 {
            width: 243px;
        }
        .auto-style12 {
            height: 26px;
            width: 110px;
        }
        .auto-style14 {
            height: 26px;
            width: 159px;
        }
        .auto-style15 {
            height: 26px;
            width: 243px;
        }
        .auto-style16 {
            height: 26px;
            width: 185px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1" border="1">
                <tr>
                    <td class="auto-style3" colspan="5">Mantenimiento actividades</td>
                </tr>
                <tr>
                    <td class="auto-style6">Código</td>
                    <td colspan="4">
                        <asp:Label ID="lbl_codigo" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">Evento</td>
                    <td colspan="4">
                        <asp:DropDownList ID="cbo_evento" runat="server" Width="630px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style15">Tipo de Actividad</td>
                    <td class="auto-style4" colspan="4">
                        <asp:DropDownList ID="cbo_tipo" runat="server" Width="315px">
                            <asp:ListItem Value="C">Congreso de ISC</asp:ListItem>
                            <asp:ListItem Value="F">Conferencia</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">Nombre Actividad</td>
                    <td colspan="4">
                        <asp:TextBox ID="txt_actividad" runat="server" Width="624px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">Descripcion Actividad</td>
                    <td colspan="4">
                        <asp:TextBox ID="txt_descripcion" runat="server" Height="66px" TextMode="MultiLine" Width="616px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style15">Fecha y hora</td>
                    <td class="auto-style12">Fecha<br />
                        <asp:TextBox ID="cal_fecha" runat="server" TextMode="Date"></asp:TextBox>
                    </td>
                    <td class="auto-style16">Inicio<br />
                        <asp:TextBox ID="txt_hinicio" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style14">Fin<br />
                        <asp:TextBox ID="txt_hfin" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">Costo<br />
                        <asp:TextBox ID="txt_costo" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="5">
                        <asp:Button ID="btn_nuevo" runat="server" Text="Nuevo" />
&nbsp;<asp:Button ID="btn_grabar" runat="server" Text="Grabar" />
&nbsp;<asp:Button ID="btn_modificar" runat="server" Text="Modificar" />
&nbsp;<asp:Button ID="btn_eliminar" runat="server" Text="Eliminar" />
&nbsp;</td>
                </tr>
            </table>
            <asp:GridView ID="dgv_actividad" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" Width="810px">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
            <br />
        </div>
    </form>
</body>
</html>
