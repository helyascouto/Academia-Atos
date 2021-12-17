<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="Aula_WebForms._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Aula Web Forms</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Aula WebForms</h1>


            <asp:Label ID="lbnNome" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="txbNome" runat="server"></asp:TextBox>
            <asp:Button ID="Click" runat="server" Text="Click" />


        </div>
        
    </form>
</body>
</html>
