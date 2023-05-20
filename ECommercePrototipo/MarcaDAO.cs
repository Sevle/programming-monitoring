using System;
using System.Collections.Generic;
using System.Linq;

namespace ECommercePrototipo
{
    public class MarcaDAO
    {
        public static string Cadastrar(Marca marca)
        {
            string mensagem = "";
            try
            {
                using (var ctx = new EcommerceDBEntities())
                {
                    ctx.Marcas.Add(marca);
                    ctx.SaveChanges();
                }
                mensagem = "Marca cadastrada com sucesso!";
            }
            catch (Exception ex)
            {
                mensagem = "Erro: " + ex.Message;
            }
            return mensagem;
        }

        public static List<Marca> ListarMarcas()
        {
            List<Marca> lista = null;

            using (var ctx = new EcommerceDBEntities())
            {
                lista = ctx.Marcas.
                    OrderBy(x => x.Descricao).ToList();
                //Expressão Lambda -- Linq
            }
            return lista;
        }

        public static Marca Excluir(int id)
        {
            Marca marca = null;
            using (var ctx = new EcommerceDBEntities())
            {
                marca = ctx.Marcas.FirstOrDefault(
                        s => s.IdMarca == id
                    );
                if (marca != null)
                {
                    ctx.Marcas.Remove(marca);
                    ctx.SaveChanges();
                }
            }

            return marca;
        }

        public  static Marca Selecionar(int id)
        {
            Marca marca = null;

            using (var ctx = new EcommerceDBEntities())
            {
                marca = ctx.Marcas.FirstOrDefault(
                        m => m.IdMarca == id
                    );
            }

            return marca;
        }

        public static string Alterar(Marca marca)
        {
            string mensagem = "";

            try
            {
                using (var ctx = new EcommerceDBEntities())
                {
                    Marca marcaAntiga = ctx.Marcas.FirstOrDefault(
                            m => m.IdMarca == marca.IdMarca
                        );
                    marcaAntiga.Descricao = marca.Descricao;
                    ctx.SaveChanges();

                    mensagem = "Marca " + marca.Descricao + " alterada com sucesso!";

                }

            }
            catch (Exception ex)
            {
                mensagem = ex.Message;
            }

            return mensagem;

        }
    }
}