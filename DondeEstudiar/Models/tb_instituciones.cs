//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DondeEstudiar.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_instituciones
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_instituciones()
        {
            this.tb_sedes = new HashSet<tb_sedes>();
        }
    
        public int id_institucion { get; set; }
        public string ruc { get; set; }
        public string nom_institucion { get; set; }
        public string tipo_institucion { get; set; }
        public string tipo_gestion { get; set; }
        public string telf_institucion { get; set; }
        public string dir_web { get; set; }
        public short reputacion { get; set; }
        public Nullable<bool> residencial { get; set; }
        public string logo { get; set; }
        public Nullable<bool> estado { get; set; }
        public System.DateTime fec_reg { get; set; }
        public byte admisiones_anual { get; set; }
    
        public virtual tb_generales tb_generales { get; set; }
        public virtual tb_generales tb_generales1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_sedes> tb_sedes { get; set; }
    }
}