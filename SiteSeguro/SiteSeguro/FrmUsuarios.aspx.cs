using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiteSeguro
{
    public partial class FrmUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                AtualizarDDLPerfis();
        }

        private void AtualizarDDLPerfis()
        {
            List<Perfil> perfis = PerfilDAO.ListarPerfis();
            ddlPerfis.DataSource = perfis;
            ddlPerfis.DataTextField = "Descricao";
            ddlPerfis.DataValueField = "IdPerfil";
            ddlPerfis.DataBind();
            ddlPerfis.Items.Insert(0, "Selecione..");
        }

        [Obsolete]
        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (ddlPerfis.SelectedIndex > 0)
            {
                var user = new Usuario();

                user.Nome = txtNome.Text;
                user.Login = txtLogin.Text;
                
                var senhaNormal = txtSenha.Text;
                string senhaCriptografada = FormsAuthentication.HashPasswordForStoringInConfigFile(senhaNormal, "SHA1");

                user.Senha = senhaCriptografada;

                user.DataNasc = Convert.ToDateTime(txtDataNasc.Text);
                user.PerfilId = Convert.ToInt32(ddlPerfis.SelectedValue);

                string mensagem = UsuarioDAO.Cadastrar(user);
                lblMensagem.InnerText = mensagem;

                LimparCampos();
            }
        }

        private void LimparCampos()
        {
            txtDataNasc.Text = "";
            txtLogin.Text = "";
            txtNome.Text = "";
            txtSenha.Text = "";
            ddlPerfis.SelectedIndex = 0;
        }
    }
}