using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD2_Travail3 {
    public class ManagerInventaire {

        public List<RecherchePieceParNoPiece_Result> listerInventaire(string noPieceDemandé)
        {
            try
            {
                using (var context = new AL_GJ_TravailEntities())
                {
                    return context.RecherchePieceParNoPiece(noPieceDemandé).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
