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
    
    public partial class Tag_Item_li
    {
        public Tag_Item_li()
        {
            this.Tag_HTML = new HashSet<Tag_HTML>();
        }
    
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Nivel { get; set; }
        public string Categoria { get; set; }
        public string Espaco { get; set; }
    
        public virtual ICollection<Tag_HTML> Tag_HTML { get; set; }
    }
}