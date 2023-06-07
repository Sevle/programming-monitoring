using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiteSeguro
{
    public partial class FrmLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var login = txtLogin.Text;
            var senha = txtSenha.Text;

            var senhaCriptografada = FormsAuthentication.
                HashPasswordForStoringInConfigFile(senha, "SHA1");

            //Acessar o BD e comparar

            bool autenticado = LoginDAO.
                AutenticarUsuario(login, senhaCriptografada);

            if (autenticado)
            {
                //Usuario usuario = UsuarioDAO.SelecionarUsuario(login);

                Usuario usuario = UsuarioDAO.AtualizarLogUsuario(login);

                Session["user"] = usuario;
                FormsAuthentication.SetAuthCookie(usuario.Nome, true);
                var perfil = usuario.GetPerfil.Descricao;

                if (perfil == "Administrador")
                {
                    Page.Response.Redirect("~/adm/Default.aspx");
                }
                else if (perfil.Contains("Gerente"))
                {
                    Page.Response.Redirect("~/gerente/Index.aspx");
                }
                else if (perfil.Contains("Vendedor"))
                {
                    Page.Response.Redirect("~/vendedor/Index.aspx");
                }
                else
                {
                    Page.Response.Redirect("~/Default.aspx");
                }
            }

        }

    }
}
