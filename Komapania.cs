//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Центр_занятости
{
    using System;
    using System.Collections.Generic;
    
    public partial class Komapania
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Komapania()
        {
            this.Vacansjas = new HashSet<Vacansja>();
        }
    
        public int NomerComapani { get; set; }
        public string NaimenovanieKratkoe { get; set; }
        public string NaimenovaniePolnoe { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public Nullable<int> Tip { get; set; }
    
        public virtual TipORganisacii TipORganisacii { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vacansja> Vacansjas { get; set; }
    }
}
