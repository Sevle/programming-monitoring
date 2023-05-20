using System;

namespace SiteSeguro
{
    internal class LoginDAO
    {
        internal static bool AutenticarUsuario(string login, string senhaCriptografada)
        {
            try
            {
                Usuario user = UsuarioDAO.SelecionarUsuario(login);
                if (user != null)
                {
                    if (user.Senha == senhaCriptografada)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            return false;
        }
    }
}