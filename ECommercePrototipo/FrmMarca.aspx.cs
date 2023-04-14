using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ECommercePrototipo
{
    public partial class FrmMarca : System.Web.UI.Page
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
            List<Marca> marcas = MarcaDAO.ListarMarcas();
            AtualizarLvMarcas(marcas);
        }

        private void AtualizarLvMarcas(List<Marca> marcas)
        {
            lvMarcas.DataSource = marcas;
            lvMarcas.DataBind();
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            string NomeMarca = txtNome.Value;

            string textoBotao = btnConfirmar.Text;

            bool cadastrando = !(textoBotao.ToUpper() == "ALTERAR");

            if (NomeMarca != "")
            {
                Marca marca = null;

                if (cadastrando)
                {
                    marca = new Marca();
                }
                else
                {
                    //Alterando
                    int id = 0;
                    string idHF = hfId.Value;
                    if (idHF != null)
                    {
                        id = Convert.ToInt32(idHF);
                        marca = MarcaDAO.Selecionar(id);
                    }

                }

                marca.Descricao = NomeMarca;

                string mensagem = "";

                if (cadastrando)
                {
                    mensagem = MarcaDAO.Cadastrar(marca);
                }
                else
                {
                    mensagem = MarcaDAO.Alterar(marca);
                    btnConfirmar.Text = "Cadastrar";
                    leg.InnerText = "CADASTRO";
                }

                txtNome.Value = "";
                lblMensagem.InnerText = mensagem;
                AtualizarListView();
            }
            else
            {
                lblMensagem.InnerText = "O campo 'Nome da Subcategoria' é obrigatório";
            }
        }

        protected void lvMarcas_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "Delete")
            {
                //Excluir um elemento
                Marca marca = MarcaDAO.Excluir(id);
                AtualizarListView();

                if (marca != null)
                {
                    lblMensagem.InnerText = "Marca " + marca.Descricao +
                        " excluída com sucesso!";
                }
            }
            else if (e.CommandName == "Alterar")
            {
                Marca marca = MarcaDAO.Selecionar(id);
                txtNome.Value = marca.Descricao;
                hfId.Value = marca.IdMarca.ToString();
                btnConfirmar.Text = "Alterar";
                leg.InnerText = "ALTERAR";
            }
        }

        protected void lvMarcas_ItemDeleting(object sender, ListViewDeleteEventArgs e)
        {

        }
    }
}