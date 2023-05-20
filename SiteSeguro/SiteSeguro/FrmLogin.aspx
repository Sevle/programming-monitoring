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
            <p>
                <label>Login:</label>
                <asp:TextBox runat="server"
                    ID="txtLogin" />
            </p>

            <p>
                <label>Senha:</label>
                <asp:TextBox runat="server"
                    ID="txtSenha"
                    TextMode="Password" />
            </p>
            <p>
                <asp:Button Text="Entrar" 
                    runat="server" 
                    id="btnLogin"
                    OnClick="btnLogin_Click"/>
            </p>
        </div>
    </form>
</body>
</html>
