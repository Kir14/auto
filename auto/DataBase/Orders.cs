//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace auto
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders
    {
        public int idOrder { get; set; }
        public Nullable<int> idAuto { get; set; }
        public Nullable<int> idUser { get; set; }
        public Nullable<System.DateTime> dateOrder { get; set; }
        public Nullable<System.DateTime> dateStart { get; set; }
        public Nullable<System.DateTime> dateFinish { get; set; }
        public Nullable<decimal> cost { get; set; }
    
        public virtual Automobiles Automobiles { get; set; }
        public virtual Users Users { get; set; }
    }
}
