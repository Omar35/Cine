//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cinev2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class proyeccion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public proyeccion()
        {
            this.funcion = new HashSet<funcion>();
            this.funcion1 = new HashSet<funcion>();
            this.reserva = new HashSet<reserva>();
            this.reserva1 = new HashSet<reserva>();
        }
    
        public decimal pro_idProyeccion { get; set; }
        public string pro_horaInicio { get; set; }
        public string pro_horaFin { get; set; }
        public Nullable<decimal> pel_idPeli { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<funcion> funcion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<funcion> funcion1 { get; set; }
        public virtual pelicula pelicula { get; set; }
        public virtual pelicula pelicula1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reserva> reserva { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reserva> reserva1 { get; set; }
    }
}
