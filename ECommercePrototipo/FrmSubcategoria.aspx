<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmSubcategoria.aspx.cs" Inherits="ECommercePrototipo.FrmSubcategoria" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Gerenciar Subcategoria</title>
    <link href="css/Estilo.css" rel="stylesheet" />
</head>
<body>

    <h1>Gerenciar Subcategoria</h1>

    <div class="menu">
        <a href="Default.aspx">Início</a>
        <a href="FrmSubcategoria.aspx">Subcategorias</a>
        <a href="FrmMarca.aspx">Marcas</a>
    </div>

    <form id="form1" runat="server">
        <div class="formulario">
            <fieldset>
                <legend>CADASTRO</legend>

                <p>
                    <label>Nome da subcategoria:</label>
                    <input type="text"
                        id="txtNome"
                        runat="server"
                        required />
                </p>
                <p>
                    <asp:Button ID="btnConfirmar"
                        runat="server"
                        Text="Cadastrar"
                        OnClick="btnConfirmar_Click" />

                </p>

                <p>
                    <label id="lblMensagem" runat="server"></label>
                </p>
            </fieldset>
        </div>
        <div>
            <fieldset>
                <legend>Subcategorias cadastradas</legend>

                <table>
                    <%--Cabeçalho da tabela--%>
                    <tr>
                        <th>Código</th>
                        <th>Descrição</th>
                        <th colspan="2">Ação</th>
                    </tr>
                    <asp:ListView runat="server" 
                        ID="lvSubcategorias" 
                        OnItemCommand="lvSubcategorias_ItemCommand" OnItemDeleting="lvSubcategorias_ItemDeleting">
                        <ItemTemplate>
                            <%--Para cada item do listview--%>
                            <tr>
                                <td>
                                    <%# Eval("IdSubCategoria", "{0:0000}") %>
                                </td>
                                <td>                        
                                    <%# Eval("Descricao") %>
                                </td>
                                <td>
                                    <asp:ImageButton 
                                        ID="ibDelete" 
                                        runat="server"
                                        ImageUrl="~/img/delete.png"
                                        CssClass="image-icon"
                                        CommandName="Delete"
                                        CommandArgument='<%# Eval("IdSubCategoria") %>'
                                        />
                                </td>
                                <td>
                                    <asp:ImageButton 
                                        ID="idAlterar" 
                                        runat="server"
                                        ImageUrl="~/img/editar.png"
                                        CssClass="image-icon"
                                        CommandName="Delete"
                                        CommandArgument='<%# Eval("IdSubcategoria") %>'
                                        />
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:ListView>

                </table>



            </fieldset>
        </div>
    </form>
</body>
</html>
