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
    public partial class ModifierProjetConcurrence : Form
    {
        ManagerProjet managerProjet;
        AL_GJ_TravailEntities context;
        public ModifierProjetConcurrence()
        {
            InitializeComponent();
            managerProjet = new ManagerProjet();
            context = new AL_GJ_TravailEntities();
        }

        private void ModifierProjetConcurrence_Load(object sender, EventArgs e)
        {
            cmbListeProjets.DropDownStyle = ComboBoxStyle.DropDownList;
            AfficherProjetsComboBox();
            cmbListeProjets.SelectedItem = null;
            txtNoProjet.ReadOnly = true;
        }

        private void AfficherProjetsComboBox()
        {
            cmbListeProjets.DataSource = managerProjet.TousLesProjetsParReferenceContext(ref context);
            cmbListeProjets.DisplayMember = "nom_projet";
            cmbListeProjets.ValueMember = "no_projet";
        }

        private void cmbListeProjets_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            try
            {
                if (cmbListeProjets.SelectedItem is null)
                    throw new Exception("Aucun projet de sélectionner");

                tbl_Projet projet = managerProjet.GetProjetById((int)cmbListeProjets.SelectedValue);
                txtDescriptionProjet.Text = projet.description_projet;
                txtNomProjet.Text = projet.nom_projet;
                txtNoProjet.Text = projet.no_Projet.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_Projet projetAModifier = new tbl_Projet();
                projetAModifier.no_Projet = int.Parse(txtNoProjet.Text);
                projetAModifier.nom_projet = txtNomProjet.Text;
                projetAModifier.description_projet = txtDescriptionProjet.Text;
                int changement = managerProjet.ModifierProjet(ref context, projetAModifier);

                if (changement > 0)
                {
                    MessageBox.Show("Modification effectuée avec succès");
                    int selectedProjet = cmbListeProjets.SelectedIndex;
                    AfficherProjetsComboBox();
                    cmbListeProjets.SelectedIndex = selectedProjet;
                    return;
                }
                throw new Exception("Une erreur est survenue");
            }
            catch (DbUpdateConcurrencyException ex)
            {
                //Value du User
                var valeurModifierUser = ex.Entries.Single();
                //Valeur Database
                var valeurDataBase = ex.Entries.Single().GetDatabaseValues();

                GererErreurDeConcurrence gererErreurDeConcurrence = new GererErreurDeConcurrence(valeurModifierUser, valeurDataBase, ref context);
                gererErreurDeConcurrence.ShowDialog();

                int selectedProjet = cmbListeProjets.SelectedIndex;
                AfficherProjetsComboBox();
                cmbListeProjets.SelectedIndex = selectedProjet;
                cmbListeProjets_SelectionChangeCommitted_1(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
