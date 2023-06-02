using System;

namespace SiteSeguro
{
    internal class LogAcessoDAO
    {
        internal static void Cadastrar(Usuario user)
        {
            LogAcesso log = new LogAcesso();
            log.UsuarioId = user.IdUsuario;
            log.UltimoAcesso = DateTime.Now;

            using (var ctx = new SecureDBEntities())
            {
                ctx.LogAcessos.Add(log);
                ctx.SaveChanges();
            }
        }
    }
}