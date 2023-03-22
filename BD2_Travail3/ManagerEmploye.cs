using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD2_Travail3
{
    internal class ManagerEmploye
    {
        public List<selectionnerTouteLesEmployes_Result> ListerEmploye()
        {
            try
            {
                using (var context = new AL_GJ_TravailEntities1())
                {
                    return context.selectionnerTouteLesEmployes().ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        public List<selectionnerEmployeSelonRecherche_Result> ListerEmployeQuiMatchLettresDonnees(string lettres)
        {
            try
            {
                using (var context = new AL_GJ_TravailEntities1())
                {
                    return context.selectionnerEmployeSelonRecherche(lettres).ToList();
                    //return context.tbl_Employe.Where(c => c.Nom.Contains(lettres) || c.Prénom.Contains(lettres)).OrderBy(c=> c.Nom).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public tbl_Employe GetInfoEmploye(int no_Employe)
        {
            try
            {
                using (var context = new AL_GJ_TravailEntities1())
                {
                    return context.tbl_Employe.Find(no_Employe);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int ModifierEmploye(tbl_Employe employeAModifier)
        {
            try
            {   
                int nombreLigneModifier = 0;
                using (var context = new AL_GJ_TravailEntities1())
                {
                    tbl_Employe employe = context.tbl_Employe.Find(employeAModifier.no_Employe);
                    employe.no_Employe = employeAModifier.no_Employe;
                    employe.Nom = employeAModifier.Nom;
                    employe.Prénom = employeAModifier.Prénom;
                    employe.Courriel = employeAModifier.Courriel;

                    //string etat2 = context.Entry(employeAModifier).State.ToString();
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
