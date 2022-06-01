<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frm_alumnos.aspx.vb" Inherits="ProyectoWeb.frm_alumnos" %>

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
            width: 363px;
        }
        .auto-style5 {
            width: 363px;
        }
        .auto-style6 {
            height: 25px;
            width: 363px;
        }
        .auto-style7 {
            height: 25px;
        }
        .auto-style8 {
            width: 363px;
            height: 29px;
        }
        .auto-style9 {
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2" colspan="2">Mantenimiento de Alumnos</td>
                </tr>
                <tr>
                    <td class="auto-style6">Código alumno</td>
                    <td class="auto-style7">
                        <asp:Label ID="lbl_codigo" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">DNI</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txt_dni" runat="server" Width="361px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">Nombres</td>
                    <td class="auto-style9">
                        <asp:TextBox ID="txt_nombres" runat="server" Width="359px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Apellido Paterno</td>
                    <td>
                        <asp:TextBox ID="txt_paterno" runat="server" Width="358px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Apellido Materno</td>
                    <td>
                        <asp:TextBox ID="txt_materno" runat="server" Width="354px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Sexo</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txt_sexo" runat="server" Width="34px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Fecha Nacimiento</td>
                    <td>
                        <asp:Calendar ID="cal_fecha" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="16px" Width="209px">
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
                    <td class="auto-style5">Semestre Ingreso</td>
                    <td>
                        <asp:DropDownList ID="cbo_semestre" runat="server" Width="554px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Escuela</td>
                    <td>
                        <asp:DropDownList ID="cbo_escuela" runat="server" Width="551px" Height="28px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btn_nuevo" runat="server" Text="Nuevo" />
                        <asp:Button ID="btn_grabar" runat="server" Text="Grabar" />
                        <asp:Button ID="btn_modificar" runat="server" Text="Modificar" />
                        <asp:Button ID="btn_eliminar" runat="server" Text="Eliminar" />
                    </td>
                </tr>
            </table>
            <asp:GridView ID="dgv_alumnos" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
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
