//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestaoPatrimonio.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Centro
    {
        public Centro()
        {
            this.Patrimonio = new HashSet<Patrimonio>();
        }
    
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Resumo { get; set; }
    
        public virtual ICollection<Patrimonio> Patrimonio { get; set; }
    }
}
