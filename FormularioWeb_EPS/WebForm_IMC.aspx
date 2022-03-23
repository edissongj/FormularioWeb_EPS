<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm_IMC.aspx.cs" Inherits="FormularioWeb_EPS.WebForm_IMC" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 201px;
        }
        .auto-style2 {
            width: 201px;
            height: 26px;
        }
        .auto-style3 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="ldDocIdentidad" runat="server" Text="Documento de identidad"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtDocIdentidad" runat="server"></asp:TextBox>
                        <asp:Label ID="lbError" runat="server" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
                    </td>                    
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lbSexo" runat="server" Text="Sexo"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="cmbSexo" runat="server">
                            <asp:ListItem> Seleccione</asp:ListItem>
                            <asp:ListItem>F</asp:ListItem>
                            <asp:ListItem>M</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lbPeso" runat="server" Text="Peso (kg)"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPeso" runat="server"></asp:TextBox>
                    </td>
                    
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lbEstatura" runat="server" Text="Estatura (mt)"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEstatura" runat="server"></asp:TextBox>
                    </td>
                    
                </tr><tr>
                    <td class="auto-style1">
                        
                        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
                        
                    </td>
                    <td>
                        
                        <asp:Button ID="btnMostrarResultados" runat="server" Text="Mostrar resultados" OnClick="btnMostrarResultados_Click" UseSubmitBehavior="False" />
                        
                    </td>
                    
                </tr>
                <tr>
                    <td class="auto-style1">
                        
                        <asp:Label ID="lbResultados" runat="server" Text="Resultados"></asp:Label>
                        
                    </td>
                    <td>
                        
                        <asp:TextBox ID="txtResultados" runat="server" Height="100px" TextMode="MultiLine"></asp:TextBox>
                        
                    </td>
                    
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
