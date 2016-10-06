//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PracticeWork
{
    using System;
    using System.Collections.Generic;
    
    public partial class Computer
    {
        public Computer()
        {
            this.Connection = new HashSet<Connection>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Processor { get; set; }
        public Nullable<int> RAM { get; set; }
        public int Memory { get; set; }
        public int ConnectionSpeed { get; set; }
        public int ModelId { get; set; }
    
        public virtual Model Model { get; set; }
        public virtual ICollection<Connection> Connection { get; set; }
    }
}
