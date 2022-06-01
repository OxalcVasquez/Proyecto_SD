<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frm_evento.aspx.vb" Inherits="ProyectoWeb.frm_evento" %>

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
            text-align: center;
        }
        .auto-style3 {
            height: 26px;
        }
        .auto-style4 {
            height: 26px;
            width: 297px;
        }
        .auto-style5 {
            width: 297px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2" colspan="2">Mantenimiento Evento</td>
                </tr>
                <tr>
                    <td class="auto-style4">Código Evento</td>
                    <td class="auto-style3">
                        <asp:Label ID="lbl_codigo" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Evento</td>
                    <td>
                        <asp:TextBox ID="txt_evento" runat="server" Width="487px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Tipo Evento</td>
                    <td>
                        <asp:TextBox ID="txt_tipo" runat="server" Width="169px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Semestre</td>
                    <td>
                        <asp:DropDownList ID="cbo_semestre" runat="server" Width="494px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Fecha Inicio</td>
                    <td>
                        <asp:Calendar ID="cal_inicio" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
                            <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                            <NextPrevStyle VerticalAlign="Bottom" />
                            <OtherMonthDayStyle ForeColor="#808080" />
                            <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                            <SelectorStyle BackColor="#CCCCCC" />
                            <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                            <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                            <WeekendDayStyle BackColor="#FFFFCC" />
                        </asp:Calendar>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Fecha Fin</td>
                    <td>
                        <asp:Calendar ID="cal_fin" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
                            <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                            <NextPrevStyle VerticalAlign="Bottom" />
                            <OtherMonthDayStyle ForeColor="#808080" />
                            <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                            <SelectorStyle BackColor="#CCCCCC" />
                            <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                            <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                            <WeekendDayStyle BackColor="#FFFFCC" />
                        </asp:Calendar>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btn_nuevo" runat="server" Text="Nuevo" style="width: 67px" />
                        <asp:Button ID="btn_grabar" runat="server" Text="Grabar" />
                        <asp:Button ID="btn_modificar" runat="server" Text="Modificar" />
                        <asp:Button ID="btn_eliminar" runat="server" Text="Eliminar" />
                    </td>
                </tr>
            </table>
            <asp:GridView ID="dgv_eventos" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
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
        </div>
    </form>
</body>
</html>
