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
    
    public partial class Connection
    {
        public Connection()
        {
            this.Server = new HashSet<Server>();
            this.Device = new HashSet<Device>();
            this.Queue = new HashSet<Queue>();
            this.Computer = new HashSet<Computer>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string D1 { get; set; }
        public string D2 { get; set; }
        public int ModelId { get; set; }
        public int RouterId { get; set; }
    
        public virtual Model Model { get; set; }
        public virtual Router Router { get; set; }
        public virtual ICollection<Server> Server { get; set; }
        public virtual ICollection<Device> Device { get; set; }
        public virtual ICollection<Queue> Queue { get; set; }
        public virtual ICollection<Computer> Computer { get; set; }
    }
}