//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFCursos.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Curso
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public Nullable<System.DateTime> inicio { get; set; }
        public Nullable<System.DateTime> fin { get; set; }
        public string duracion { get; set; }
    }
}