<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmUsuarios.aspx.cs" Inherits="SiteSeguro.FrmUsuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Cadastro de usuário</title>
    <link href="css/style.css" rel="stylesheet" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
</head>
<body>
    <h1>Gerenciamento de usuários</h1>
    <form id="form1" runat="server">
        <div class="div-form">
                <label>Nome:</label>
                <asp:TextBox runat="server" ID="txtNome" />

                <label>Data  Nascimento:</label>
                <asp:TextBox ID="txtDataNasc" runat="server" TextMode="Date" />

                <label>Usuário:</label>
                <asp:TextBox runat="server" ID="txtLogin" />

                <label>Senha:</label>
                <asp:TextBox runat="server" ID="txtSenha" TextMode="Password" />

                <label>Perfil:</label>
                <asp:DropDownList runat="server" ID="ddlPerfis">
                </asp:DropDownList>

                <asp:Button Text="Confirmar" runat="server" ID="btnConfirmar" OnClick="btnConfirmar_Click" />
                <label id="lblMensagem" runat="server"></label>
        </div>
    </form>
</body>
</html>
