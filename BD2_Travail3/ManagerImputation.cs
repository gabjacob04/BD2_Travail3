using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD2_Travail3 {
    public class ManagerImputation 
    {

        public int AjouterUneImputation(tbl_Impute imputeAAjouter, string no_Piece_Entreprise)
        {
            try
            {
                int nombreLigneModifier = 0;
                using (var context = new AL_GJ_TravailEntities())
                {
                    tbl_Impute impute = new tbl_Impute();
                    tbl_Inventaire recupererNoPiece = new tbl_Inventaire();
                    recupererNoPiece = context.tbl_Inventaire.FirstOrDefault(c => c.no_Piece_Entreprise == no_Piece_Entreprise);

                    if (recupererNoPiece.quantite - imputeAAjouter.quantite_Retire < 0)
                    {
                        throw new Exception("La quantité retirée est trop élevée pour la quantité restante de la pièce");
                    }

                    impute.no_Employe = imputeAAjouter.no_Employe;
                    impute.no_Piece = recupererNoPiece.no_Piece;
                    impute.no_Projet = imputeAAjouter.no_Projet;
                    impute.date = imputeAAjouter.date;
                    impute.quantite_Retire = imputeAAjouter.quantite_Retire;

                    context.SuppressionDobjetDeLInventaire(impute.quantite_Retire, impute.no_Piece);
                    context.tbl_Impute.Add(impute);

                    if (context.ChangeTracker.HasChanges())
                    {
                        nombreLigneModifier = context.SaveChanges();
                    }
                }
                return nombreLigneModifier;
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException exUpdate)
            {
                throw new Exception(exUpdate.InnerException.InnerException.Message);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<getImputeByYearAndMonth_Result> getListImputationEnFonctionDUneRechercher(string no_Piece_Entreprise, string date)
        {
            try
            {
                using (var context = new AL_GJ_TravailEntities())
                {
                    return context.getImputeByYearAndMonth(no_Piece_Entreprise, date).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
