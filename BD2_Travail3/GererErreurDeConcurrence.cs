using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD2_Travail3
{
    public partial class GererErreurDeConcurrence : Form
    {
        public GererErreurDeConcurrence()
        {
            InitializeComponent();
        }

        private void txt_valeur_changee_de_bd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_valeur_proposé_TextChanged(object sender, EventArgs e)
        {

        }

        private void GererErreurDeConcurrence_Load(object sender, EventArgs e)
        {

        }

        private void btn_prendre_valeur_bd_Click(object sender, EventArgs e)
        {
            
          /*  DbUpdateConcurrencyException dex;
            if (nom_projet is changed)
            {
                var valeurNomCoursOG = dex.Entries.Single().GetDatabaseValues().GetValue<string>("nom_projet");
                txt_valeur_changee_de_bd.Text = valeurNomCoursOG;
            }
            else
            {
                var valeurPondOG = dex.Entries.Single().GetDatabaseValues().GetValue<string>("description_projet");
                txt_valeur_changee_de_bd.Text = valeurPondOG;
            }
                    var value = dex.Entries.Single().GetDatabaseValues();
                    dex.Entries.Single().OriginalValues.SetValues(value);
                    context.SaveChanges();
                    MessageBox.Show("Le cour est toute décalisser fak on a le cours d'origine normal.");
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }*/
        }
    }
}
