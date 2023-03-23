using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD2_Travail3 {
    public class ManagerProjet {
        public List<tbl_Projet> TouteLesProjet() 
        {
            using(var context = new AL_GJ_TravailEntities()) 
            {
               return context.tbl_Projet.OrderBy(p=>p.nom_projet).ToList();;
            }
        }
    }
}
