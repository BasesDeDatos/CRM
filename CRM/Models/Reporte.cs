//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRM.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reporte
    {
        public int reporte_id { get; set; }
        public string estado { get; set; }
        public string descripcion { get; set; }
    
        public virtual Producto Producto { get; set; }
        public virtual User User { get; set; }
    }
}
