using System;
using System.Linq;

namespace SiteSeguro
{
    internal class UsuarioDAO
    {
        internal static string Cadastrar(Usuario user)
        {
            string mensagem = "";

            try
            {
                using (var ctx = new SecureDBEntities())
                {
                    ctx.Usuarios.Add(user);
                    ctx.SaveChanges();
                    mensagem = "Usuário " + user.Nome +
                        " cadastrado com sucesso!";
                }
            }
            catch (Exception ex)
            {
                mensagem = "Ocorreu um erro: " + ex.Message;
            }
            return mensagem;
        }

        internal static Usuario SelecionarUsuario(string login)
        {

            Usuario user = null;
            try
            {
                using (var ctx = new SecureDBEntities())
                {
                    user = ctx.Usuarios.FirstOrDefault(
                        x => x.Login == login);
                }
            }
            catch (Exception ex)
            {

            }

            return user;
        }
    }
}