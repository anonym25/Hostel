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
    
    public partial class Employee
    {
        public Employee()
        {
            this.Answers = new HashSet<Answer>();
            this.Recalls = new HashSet<Recall>();
        }
    
        public int IndividualNumber { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public int IdentifierPositionFK { get; set; }
    
        public virtual ICollection<Answer> Answers { get; set; }
        public virtual Position Position { get; set; }
        public virtual ICollection<Recall> Recalls { get; set; }
    }
}