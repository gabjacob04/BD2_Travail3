using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD2_Travail3
{
    internal class ManagerProjetPiece
    {
        public List<vueListerQuantiteAccepteePourProjet> ListerQuantiteAccepteePourProjet(int no_Projet, ref AL_GJ_TravailEntities context)
        {
            try
            {
                return context.vueListerQuantiteAccepteePourProjet.Where(v => v.no_Projet == no_Projet).ToList();
            }
            catch (Exception)
            {

                throw;
            }          
        }

        public int enregisterQuantiteeAcceptee(ref AL_GJ_TravailEntities context)
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
                if (LeMessage.Contains("C_quantiteeAcceptee"))
                    throw new Exception("La quantitée ne peut être plus petite que 0");
                else
                    throw new Exception(LeMessage.ToString());

            }
            catch (Exception)
            {
                throw;
            }
            return nombreLigneAffectees;
        }

        public void SupprimerUnProjet(int no_projet)
        {
            try
            {
                using (var context = new AL_GJ_TravailEntities())
                {
                    context.SupprimerUnProjet(no_projet);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
