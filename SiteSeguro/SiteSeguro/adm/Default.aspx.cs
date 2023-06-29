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
            if (user == null || !user.GetPerfil.Descricao.Contains("Administrador"))
                Response.Redirect("~/");
        }

        protected void btn_confirmar(object sender, EventArgs e)
        {
            try
            {
                if (FU_image.HasFile)
                {
                    var arquivo = FU_image.PostedFile;
                    var tipo = arquivo.ContentType;
                    
                    if(tipo.Contains("image/"))
                    {
                        var extensao = tipo.Replace("image/", "");
                        int id = 212;
                        var nome_arquivo = id + "." + extensao;
                        var caminho = MapPath("~/Upload");
                        arquivo.SaveAs(caminho + "\\" + nome_arquivo);

                        img_perfil.Src = "upload/" + nome_arquivo;
                    }
                    else
                        lbl_mensagem.InnerText = "Pode parar d atrapalhar? seu comedia";
                }
            }
            catch 
            { }
        }
    }
}