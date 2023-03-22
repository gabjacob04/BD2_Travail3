﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class AL_GJ_TravailEntities1 : DbContext
    {
        public AL_GJ_TravailEntities1()
            : base("name=AL_GJ_TravailEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_Employe> tbl_Employe { get; set; }
        public virtual DbSet<tbl_Impute> tbl_Impute { get; set; }
        public virtual DbSet<tbl_Inventaire> tbl_Inventaire { get; set; }
        public virtual DbSet<tbl_Marque> tbl_Marque { get; set; }
        public virtual DbSet<tbl_Projet> tbl_Projet { get; set; }
    
        public virtual ObjectResult<selectionnerEmployeSelonRecherche_Result> selectionnerEmployeSelonRecherche(string searchTerm)
        {
            var searchTermParameter = searchTerm != null ?
                new ObjectParameter("searchTerm", searchTerm) :
                new ObjectParameter("searchTerm", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<selectionnerEmployeSelonRecherche_Result>("selectionnerEmployeSelonRecherche", searchTermParameter);
        }
    
        public virtual ObjectResult<selectionnerTouteLesEmployes_Result> selectionnerTouteLesEmployes()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<selectionnerTouteLesEmployes_Result>("selectionnerTouteLesEmployes");
        }
    
        public virtual ObjectResult<RecherchePieceParNoPiece_Result> RecherchePieceParNoPiece(string noPieceDemandé)
        {
            var noPieceDemandéParameter = noPieceDemandé != null ?
                new ObjectParameter("noPieceDemandé", noPieceDemandé) :
                new ObjectParameter("noPieceDemandé", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RecherchePieceParNoPiece_Result>("RecherchePieceParNoPiece", noPieceDemandéParameter);
        }
    
        public virtual int SuppressionDobjetDeLInventaire(Nullable<int> quantiteAEnlever, Nullable<int> no_Piece)
        {
            var quantiteAEnleverParameter = quantiteAEnlever.HasValue ?
                new ObjectParameter("QuantiteAEnlever", quantiteAEnlever) :
                new ObjectParameter("QuantiteAEnlever", typeof(int));
    
            var no_PieceParameter = no_Piece.HasValue ?
                new ObjectParameter("no_Piece", no_Piece) :
                new ObjectParameter("no_Piece", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SuppressionDobjetDeLInventaire", quantiteAEnleverParameter, no_PieceParameter);
        }
    }
}