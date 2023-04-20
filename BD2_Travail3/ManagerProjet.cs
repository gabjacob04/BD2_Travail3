using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD2_Travail3 {
    public class ManagerProjet 
    {
        public List<tbl_Projet> TouteLesProjet() 
        {
            using (var context = new AL_GJ_TravailEntities()) 
            {
               return context.tbl_Projet.OrderBy(p=>p.nom_projet).ToList();;
            }
        }

        public List<tbl_Projet> ProjetParId(int id)
        {
            using (var context = new AL_GJ_TravailEntities())
            {
                return context.tbl_Projet.Where(p => p.no_Projet == id).ToList();
            }
        }
        
        public int ModifierProjet(tbl_Projet projetAModifier)
        {
            try
            {
                int nombreLigneModifier = 0;
                using (var context = new AL_GJ_TravailEntities())
                {
                    tbl_Projet projet = context.tbl_Projet.Find(projetAModifier.no_Projet);
                    projet.no_Projet = projetAModifier.no_Projet;
                    projet.nom_projet = projetAModifier.nom_projet;
                    projet.description_projet = projetAModifier.description_projet;

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
