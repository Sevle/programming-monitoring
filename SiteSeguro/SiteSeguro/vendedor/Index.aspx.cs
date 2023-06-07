using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiteSeguro.vendedor
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario user = (Usuario)Session["user"];
            VerificiarPerfilUsuario(user);
        }

        private void VerificiarPerfilUsuario(Usuario user)
        {
            if (user != null)
            {
                var perfil = user.GetPerfil.Descricao;
                if (!perfil.Contains("Administrador") &&
                    !perfil.Contains("Gerente") &&
                    !perfil.Contains("Vendedor"))
                {
                    Response.Redirect("~/");
                }
            }
            else
            {
                Response.Redirect("~/");
            }
        }
    }
}
