//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hotel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Position
    {
        public Position()
        {
            this.Employees = new HashSet<Employee>();
        }
    
        public int IdentifierPosition { get; set; }
        public string NamePosition { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
