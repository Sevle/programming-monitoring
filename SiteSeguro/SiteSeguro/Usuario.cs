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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            this.LogAcessos = new HashSet<LogAcesso>();
        }
    
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public Nullable<System.DateTime> DataNasc { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public int PerfilId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LogAcesso> LogAcessos { get; set; }
        public virtual Perfil Perfil { get; set; }
    }
}
