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
    public partial class ModifierQuantiteAssigneesDUnProjet : Form
    {
        ManagerProjet managerProjet;
        ManagerProjetPiece managerProjetPiece;
        AL_GJ_TravailEntities context;
        public ModifierQuantiteAssigneesDUnProjet()
        {
            InitializeComponent();
            managerProjet = new ManagerProjet();
            managerProjetPiece = new ManagerProjetPiece();
            context = new AL_GJ_TravailEntities();
        }

        private void ModifierQuantiteAssigneesDUneImputation_Load(object sender, EventArgs e)
        {
            cmbListeProjets.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbListeProjets.DataSource = managerProjet.TouteLesProjet();
            cmbListeProjets.ValueMember = "no_Projet";
            cmbListeProjets.DisplayMember = "nom_projet";
            dgvPieces.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cmbListeProjets_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                dgvPieces.DataSource = managerProjetPiece.ListerQuantiteAccepteePourProjet((int)cmbListeProjets.SelectedValue, ref context);
                dgvPieces.Columns["no_Projet"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void enregister()
        {
            try
            {
                int nombreLigneAffectees = managerProjetPiece.enregisterQuantiteeAcceptee(ref context);
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
                context = new AL_GJ_TravailEntities();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPieces_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            enregister();
        }
    }
}
