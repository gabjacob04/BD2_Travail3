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
            try
            {
                using (var context = new AL_GJ_TravailEntities()) 
                {
                   return context.tbl_Projet.OrderBy(p=>p.nom_projet).ToList();;
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public List<tbl_Projet> TousLesProjetsParReferenceContext(ref AL_GJ_TravailEntities context)
        {
            try
            {
                return context.tbl_Projet.OrderBy(p => p.nom_projet).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public tbl_Projet GetProjetById(int id)
        {
            try
            {
                using (var context = new AL_GJ_TravailEntities())
                {
                    tbl_Projet projetARetourner = context.tbl_Projet.Find(id);
                    return projetARetourner;
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        
        public int ModifierProjet(ref AL_GJ_TravailEntities context, tbl_Projet projetAModifier)
        {
            try
            {
                tbl_Projet projet = context.tbl_Projet.Find(projetAModifier.no_Projet);

                projet.description_projet = projetAModifier.description_projet;
                projet.nom_projet = projetAModifier.nom_projet;

                int nombreLigneAffectee = 0;
                if (context.ChangeTracker.HasChanges())
                {
                    nombreLigneAffectee = context.SaveChanges();
                }
                return nombreLigneAffectee;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
