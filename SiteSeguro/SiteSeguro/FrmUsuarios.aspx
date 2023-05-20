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
            <p>
                <label>Nome:</label>
                <asp:TextBox runat="server"
                    ID="txtNome" />
            </p>

            <p>
                <label>Data  Nascimento:</label>
                <asp:TextBox ID="txtDataNasc"
                    runat="server"
                    TextMode="Date" />
            </p>

            <p>
                <label>Usuário:</label>
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
                <label>Perfil:</label>
                <asp:DropDownList runat="server" ID="ddlPerfis">
                </asp:DropDownList>
            </p>

            <p>
                <asp:Button Text="Confirmar" runat="server"
                    ID="btnConfirmar"
                    OnClick="btnConfirmar_Click" />
            </p>

            <p>
                <label id="lblMensagem" runat="server"></label>
            </p>
        </div>

    </form>
</body>
</html>
