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
    
    public partial class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public Nullable<int> City_id { get; set; }
        public string Email { get; set; }
        public string CityName { get; set; }
        public string Token { get; set; }
        public Nullable<bool> Anonymous { get; set; }
        public byte[] Photo { get; set; }
    }
}