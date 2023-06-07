using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiteSeguro.adm
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario user = (Usuario)Session["user"];
            VerificiarPerfilUsuario(user);
        }

        private void VerificiarPerfilUsuario(Usuario user)
        {
            if (user == null ||
                    !user.GetPerfil.Descricao.Contains("Administrador"))
            {
                Response.Redirect("~/");
            }
        }
    }
}