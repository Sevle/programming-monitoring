<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmLogin.aspx.cs" Inherits="SiteSeguro.FrmLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="css/style.css" rel="stylesheet" />
</head>
<body>

    <h1>Identifique-se</h1>
    <form id="form1" runat="server">
        <div class="div-form div-40p">
                <label>Login:</label>
                <asp:TextBox runat="server" ID="txtLogin" />

                <label>Senha:</label>
                <asp:TextBox runat="server" ID="txtSenha" TextMode="Password" />
                <asp:Button Text="Entrar" runat="server" ID="btnLogin" OnClick="btnLogin_Click" />
        </div>
    </form>
</body>
</html>
