﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SiteSeguro
{
    internal class PerfilDAO
    {
        internal static List<Perfil> ListarPerfis()
        {
            List<Perfil> perfis = null;
            try
            {
                using (var ctx = new SecureDBEntities())
                    perfis = ctx.Perfils.OrderBy(x => x.Descricao).ToList();
            }
            catch (Exception ex)
            { }
            return perfis;
        }

        internal static Perfil SelecionarPerfil(int perfilId)
        {
            Perfil perfil = null;
            try
            {
                using (var ctx = new SecureDBEntities())
                    perfil = ctx.Perfils.FirstOrDefault(x => x.IdPerfil == perfilId);
            }
            catch (Exception ex)
            { }
            return perfil;
        }
    }
}