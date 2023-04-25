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
        DbPropertyValues valeurDatabase;
        DbEntityEntry valeurUser;
        AL_GJ_TravailEntities context;

        public GererErreurDeConcurrence(DbEntityEntry valeurUser, DbPropertyValues valeurDatabase, ref AL_GJ_TravailEntities context)
        {
            InitializeComponent();
            this.valeurUser = valeurUser;
            this.valeurDatabase = valeurDatabase;
            this.context = context;
        }

        private void GererErreurDeConcurrence_Load(object sender, EventArgs e)
        {
            try
            {
                if (valeurUser is null || valeurDatabase is null)
                {
                    throw new Exception("Impossible de récupérer les valeurs");
                }
                txtUserDescription.Text = valeurUser.CurrentValues.GetValue<string>("description_projet");
                txtUserNomProjet.Text = valeurUser.CurrentValues.GetValue<string>("nom_projet");

                txtDatabaseDescription.Text = valeurDatabase.GetValue<string>("description_projet");
                txtDatabaseNomProjet.Text = valeurDatabase.GetValue<string>("nom_projet");

                txtOriginalDescription.Text = valeurUser.OriginalValues.GetValue<string>("description_projet");
                txtOriginalNomProjet.Text = valeurUser.OriginalValues.GetValue<string>("nom_projet");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_prendre_valeur_proposé_Click(object sender, EventArgs e)
        {
            try
            {
                var currentUserValues = valeurUser.CurrentValues;
                valeurUser.OriginalValues.SetValues(valeurDatabase);
                valeurDatabase.SetValues(currentUserValues);
                context.SaveChanges();

                MessageBox.Show("Modification effectué avec succès");
                this.Hide();
                this.Closed += (s, args) => this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_prendre_valeur_bd_Click(object sender, EventArgs e)
        {
            try
            {
                valeurUser.Reload();
                valeurUser.OriginalValues.SetValues(valeurDatabase);
                context.SaveChanges();

                MessageBox.Show("Vos valeurs ont été annulée et vous avez été mis à jour avec la bd");
                this.Hide();
                this.Closed += (s, args) => this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
