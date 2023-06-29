using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiteSeguro
{
    public partial class Usuario
    {
        public Perfil GetPerfil 
        {
            get
            {
                Perfil perfil =PerfilDAO.SelecionarPerfil(this.PerfilId);
                return perfil;
            }
        }
    }
}