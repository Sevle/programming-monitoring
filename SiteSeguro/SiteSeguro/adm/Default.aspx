<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SiteSeguro.adm.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../css/style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="status">
            <asp:LoginStatus runat="server" LoginText="Entrar" LogoutText="Sair" />
        </div>

        <div class="up_image">
            <p>Selecione a imagem</p>
            <asp:FileUpload ID="FU_image" runat="server" />
            <asp:Button OnClick="btn_confirmar" runat="server" Text="Enviar" />
            <label id="lbl_mensagem" runat="server" text="" />
        </div>

        <img src="#" alt="imagem_perfil" id="img_perfil" runat="server" />

        <div>
            <asp:LoginName FormatString="Bem-vindo, {0}!" runat="server" />
            <h1>Usuário autenticado</h1>
        </div>
    </form>
</body>
</html>
