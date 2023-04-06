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
        public int enregisterNote(ref AL_GJ_TravailEntities context)
        {
            int nombreLigneAffectees = 0;
            try
            {
                if (context.ChangeTracker.HasChanges())
                {
                    nombreLigneAffectees = context.SaveChanges();
                }

            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
            {
                var LeMessage = ex.InnerException.InnerException.Message;
                if (LeMessage.Contains("Verify_note"))
                    throw new Exception("La note ne peut être plus petite que 0 ou plus grande que 100");
                else
                    throw new Exception(LeMessage.ToString());

            }
            catch (Exception)
            {
                throw;
            }
            return nombreLigneAffectees;
        }
    }
}
