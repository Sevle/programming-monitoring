//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SiteSeguro
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public Nullable<System.DateTime> DataNasc { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public Nullable<System.DateTime> UltimoAcesso { get; set; }
        public int PerfilId { get; set; }
    
        public virtual Perfil Perfil { get; set; }
    }
}