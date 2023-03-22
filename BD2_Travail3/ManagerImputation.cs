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

        public int AjouterUneImputation(tbl_Impute imputeAAjouter)
        {
            try
            {
                int nombreLigneModifier = 0;
                using (var context = new AL_GJ_TravailEntities1())
                {
                    if (context.tbl_Impute.Find(imputeAAjouter.no_Piece, imputeAAjouter.no_Projet, imputeAAjouter.no_Employe) != null)
                    {
                        tbl_Impute imputeAModifier = context.tbl_Impute.Find(imputeAAjouter.no_Piece, imputeAAjouter.no_Projet, imputeAAjouter.no_Employe);
                        context.SuppressionDobjetDeLInventaire(imputeAAjouter.quantite_Retire, imputeAAjouter.no_Piece);
                        imputeAModifier.quantite_Retire = imputeAAjouter.quantite_Retire + imputeAModifier.quantite_Retire;
                    }
                    else
                    {
                        tbl_Impute impute = new tbl_Impute();
                        impute.no_Employe = imputeAAjouter.no_Employe;
                        impute.no_Piece = imputeAAjouter.no_Piece;
                        impute.no_Projet = imputeAAjouter.no_Projet;
                        impute.date = imputeAAjouter.date;
                        impute.quantite_Retire = imputeAAjouter.quantite_Retire;

                        context.SuppressionDobjetDeLInventaire(impute.quantite_Retire, impute.no_Piece);
                        context.tbl_Impute.Add(impute);
                        //string etat2 = context.Entry(employeAModifier).State.ToString();

                    }

                    if (context.ChangeTracker.HasChanges())
                    {
                        nombreLigneModifier = context.SaveChanges();
                    }
                }
                return nombreLigneModifier;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
