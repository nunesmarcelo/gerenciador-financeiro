//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GerenciadorFinanceiro.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class imagemcontasaldo
    {
        public int id { get; set; }
        public string nome { get; set; }
        public bool principal { get; set; }
        public int contasaldo_id { get; set; }
    
        public virtual contasaldo contasaldo { get; set; }
    }
}
