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
    
    public partial class tbl_Impute
    {
        public int no_Piece { get; set; }
        public int no_Projet { get; set; }
        public int no_Employe { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<int> quantite_Retire { get; set; }
    
        public virtual tbl_Employe tbl_Employe { get; set; }
        public virtual tbl_Inventaire tbl_Inventaire { get; set; }
        public virtual tbl_Projet tbl_Projet { get; set; }
    }
}
