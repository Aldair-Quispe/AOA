//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TiendaAOA_CS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Compras
    {
        public long id { get; set; }
        public long productoId { get; set; }
        public long usuarioId { get; set; }
        public int cantidad { get; set; }
    
        public virtual Producto Producto { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
