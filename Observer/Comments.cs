//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Observer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comments
    {
        public int Id { get; set; }
        public Nullable<int> Message_id { get; set; }
        public string Body { get; set; }
        public Nullable<int> User_id { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> Like { get; set; }
        public Nullable<int> Dislaid { get; set; }
        public string User_name { get; set; }
    }
}