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
    
    public partial class funcion
    {
        public decimal fun_idFuncion { get; set; }
        public Nullable<decimal> pro_idProyeccion { get; set; }
        public Nullable<decimal> sal_idSala { get; set; }
        public string fun_horario { get; set; }
    
        public virtual proyeccion proyeccion { get; set; }
        public virtual proyeccion proyeccion1 { get; set; }
        public virtual sala sala { get; set; }
        public virtual sala sala1 { get; set; }
        public virtual sala sala2 { get; set; }
    }
}
