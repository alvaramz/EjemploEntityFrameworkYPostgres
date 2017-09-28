<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Prueba PostgreSQL con Entity Framework</title>
</head>
<body style="height: 341px">
    <form id="form1" runat="server">
    <div>
            <h1>Prueba PostgresSQL y Entity Framework</h1>

    </div>
        
        <asp:TextBox ID="TextBox1" runat="server" Width="557px"></asp:TextBox>
        
        <p>
            <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
        </p>
        <asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Valor:"></asp:Label>
        </p>
        <asp:TextBox ID="TxtValor" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="BtnGuardar" runat="server" OnClick="BtnGuardar_Click" Text="Guardar" />
        </p>
        <asp:Label ID="LblMensajes" runat="server"></asp:Label>
        
    </form>
</body>
</html>
