<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frm_mantemiento_escuela.aspx.vb" Inherits="ProyectoWeb.frm_mantemiento_escuela" %>

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
            width: 252px;
        }
        .auto-style3 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <table class="auto-style1" border="1">
                <tr>
                    <td colspan="2" aria-checked="undefined" class="auto-style3">Mantenimiento de Escuela
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Codigo Escuela</td>
                    <td>
                        <asp:Label ID="lbl_codigo" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Nombre Escuela</td>
                    <td>
                        <asp:TextBox ID="txt_nombre" runat="server" Width="685px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Facultad</td>
                    <td>
                        <asp:DropDownList ID="cbo_facultad" runat="server" Width="690px">
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
            <asp:GridView ID="dgv_escuelas" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
                <Columns>
                    <asp:CommandField HeaderText="Seleccionar" ShowSelectButton="True" />
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
