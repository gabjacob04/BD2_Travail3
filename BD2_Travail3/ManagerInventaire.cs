using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD2_Travail3 {
    public class ManagerInventaire {

        public List<tbl_Inventaire> listerInventaire() {
            try {
                using (var context = new AL_GJ_TravailEntitiesGabrielMaison()) {
                    return context.RecherchePieceParNoPiece(noPieceDemandé).tolist();
                }
            }
            catch (Exception) {
                throw;
            }
        }
    }
}
