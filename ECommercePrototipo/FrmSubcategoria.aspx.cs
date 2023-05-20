using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ECommercePrototipo
{
    public partial class FrmSubcategoria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                AtualizarListView();
            }
        }

        private void AtualizarListView()
        {
            List<Subcategoria> subcategorias = SubcategoriaDAO.ListarSubcategorias();
            AtualizarLvSubcategorias(subcategorias);
        }

        private void AtualizarLvSubcategorias(List<Subcategoria> subcategorias)
        {
            lvSubcategorias.DataSource = subcategorias;
            lvSubcategorias.DataBind();
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            string NomeSubcategoria = txtNome.Value;

            if (NomeSubcategoria != "") {

                Subcategoria sub = new Subcategoria();
                sub.Descricao = NomeSubcategoria;

                string mensagem = SubcategoriaDAO.Cadastrar(sub);

                txtNome.Value = "";
                lblMensagem.InnerText = mensagem;
                AtualizarListView();
            }
            else
            {
                lblMensagem.InnerText = "O campo 'Nome da Subcategoria' é obrigatório";
            }
        }

        protected void lvSubcategorias_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            
            if(e.CommandName == "Delete")
            {
                //Excluir um elemento
                int id = Convert.ToInt32(e.CommandArgument);
                Subcategoria sub = SubcategoriaDAO.Excluir(id);
                AtualizarListView();

                if (sub != null)
                {
                    lblMensagem.InnerText = "Subcategoria " + sub.Descricao +
                        " excluída com sucesso!";
                }
            }
        }

        protected void lvSubcategorias_ItemDeleting(object sender, ListViewDeleteEventArgs e)
        {

        }
    }
}