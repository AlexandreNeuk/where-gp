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
    
    public partial class Setor
    {
        public Setor()
        {
            this.RadioBase = new HashSet<RadioBase>();
            this.Tag_Div = new HashSet<Tag_Div>();
        }
    
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Resumo { get; set; }
        public int Id_UnidadeNegocio { get; set; }
    
        public virtual ICollection<RadioBase> RadioBase { get; set; }
        public virtual ICollection<Tag_Div> Tag_Div { get; set; }
        public virtual UnidadeNegocio UnidadeNegocio { get; set; }
    }
}
