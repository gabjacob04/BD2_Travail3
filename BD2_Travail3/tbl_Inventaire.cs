//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BD2_Travail3
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Inventaire
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Inventaire()
        {
            this.tbl_Impute = new HashSet<tbl_Impute>();
        }
    
        public int no_Piece { get; set; }
        public string nom_Piece { get; set; }
        public string description_Piece { get; set; }
        public int quantite { get; set; }
        public Nullable<int> quantite_Critique { get; set; }
        public Nullable<int> quantite_Minimum { get; set; }
        public int no_Marque { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Impute> tbl_Impute { get; set; }
        public virtual tbl_Marque tbl_Marque { get; set; }
    }
}
