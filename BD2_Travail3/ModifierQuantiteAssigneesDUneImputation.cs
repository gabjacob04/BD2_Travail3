using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD2_Travail3
{
    public partial class ModifierQuantiteAssigneesDUneImputation : Form
    {
        ManagerProjet managerProjet;
        ManagerImputation ManagerImputation;
        public ModifierQuantiteAssigneesDUneImputation()
        {
            InitializeComponent();
            managerProjet = new ManagerProjet();
            ManagerImputation = new ManagerImputation();
        }

        private void ModifierQuantiteAssigneesDUneImputation_Load(object sender, EventArgs e)
        {
            cmbListeProjets.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbListeProjets.DataSource = managerProjet.TouteLesProjet();
            cmbListeProjets.ValueMember = "no_Projet";
            cmbListeProjets.DisplayMember = "nom_projet";
            cmbListeProjets.ValueMember = "";
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cmbListeProjets_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string no_projet = (string)cmbListeProjets.SelectedValue;
            //dgvPieces.DataSource = ManagerProjet.

            //dgvPieces.Columns["nom"].ReadOnly = true;
            // dgvPieces.Columns["session"].Visible = false;
            dgvPieces.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void enregister()
        {
            try
            {
                int nombreLigneAffectees = 0; // = ManagerImputation.enregisterNote(ref context);
                if (nombreLigneAffectees > 0)
                {
                    MessageBox.Show("Enregistrement effectué avec succès");
                    return;
                }
                else
                {
                    throw new Exception("Erreur,aucun changement effectué");
                }

            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception babaje)
            {
                MessageBox.Show(babaje.Message);

            }
            /* catch (Exception ex)
             {

                 MessageBox.Show(ex.Message);
             }*/
        }

        private void dgvPieces_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            enregister();
        }
    }
}
