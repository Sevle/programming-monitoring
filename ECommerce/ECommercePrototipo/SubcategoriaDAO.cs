using System;
using System.Collections.Generic;
using System.Linq;

namespace ECommercePrototipo
{
    public class SubcategoriaDAO
    {
        public static string Cadastrar(Subcategoria sub)
        {
            string mensagem = "";
            try
            {
                using (var ctx = new EcommerceDBEntities())
                {
                    ctx.Subcategorias.Add(sub);
                    ctx.SaveChanges();
                }
                mensagem = "Subcategoria cadastrada com sucesso!";
            }
            catch (Exception ex)
            {
                mensagem = "Erro: " + ex.Message;
            }
            return mensagem;
        }

        public static List<Subcategoria> ListarSubcategorias()
        {
            List<Subcategoria> lista = null;

            using (var ctx = new EcommerceDBEntities())
            {
                lista = ctx.Subcategorias.
                    OrderBy(x => x.Descricao).ToList();
                //Expressão Lambda -- Linq
            }
            return lista;
        }

        public static Subcategoria Excluir(int id)
        {
            Subcategoria sub = null;
            using (var ctx = new EcommerceDBEntities())
            {
                sub = ctx.Subcategorias.FirstOrDefault(
                        s => s.IdSubCategoria == id
                    );
                ctx.Subcategorias.Remove(sub);
                ctx.SaveChanges();
            }

            return sub;
        }
    }
}