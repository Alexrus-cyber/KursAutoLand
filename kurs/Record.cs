//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace kurs
{
    using System;
    using System.Collections.Generic;
    
    public partial class Record
    {
        public int Id_record { get; set; }
        public int Id_client { get; set; }
        public string Location { get; set; }
        public string Service { get; set; }
    
        public virtual Client Client { get; set; }
    }
}
