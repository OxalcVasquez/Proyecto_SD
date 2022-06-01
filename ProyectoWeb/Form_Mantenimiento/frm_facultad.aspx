<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frm_facultad.aspx.vb" Inherits="ProyectoWeb.frm_facultad" %>

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
            width: 267px;
        }
        .auto-style4 {
            height: 26px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1" border="1">
                <tr>
                    <td class="auto-style4" colspan="2">Mantenimiento de Facultad</td>
                </tr>
                <tr>
                    <td class="auto-style2">Codigo Facultad</td>
                    <td>
                        <asp:Label ID="lbl_codigo_facultad" runat="server" Text="Codigo"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Nombre Facultad</td>
                    <td>
                        <asp:TextBox ID="txt_nombre_facultad" runat="server" Width="517px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btn_nuevo" runat="server" Text="Nuevo" />
                        <asp:Button ID="btn_grabar" runat="server" Text="Grabar" />
                        <asp:Button ID="btn_modificar" runat="server" Text="Modificar" />
                        <asp:Button ID="btn_eliminar" runat="server" Text="Eliminar" />
                        <asp:GridView ID="dgv_facultad" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
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
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
