//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestDemoExam4.DatabaseConnection
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        public int IdUser { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public int IdRole { get; set; }
        public int pCost { get; set; }
        public string pImage { get; set; }
        public System.DateTime DeteOfBirth { get; set; }
    
        public virtual Roles Roles { get; set; }
    }
}
