//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AspNetMvcWithSQLserver
{
    using System;
    using System.Collections.Generic;
    
    public partial class MEDICO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MEDICO()
        {
            this.CONSULTA = new HashSet<CONSULTA>();
        }
    
        public int ID { get; set; }
        public string NOME { get; set; }
        public string SEXO { get; set; }
        public string ESPECIALIDADE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONSULTA> CONSULTA { get; set; }
    }
}
