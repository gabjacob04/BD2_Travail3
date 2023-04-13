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
            setDataSourceComboBox();
            dgvPieces.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void setDataSourceComboBox()
        {
            try
            {
                cmbListeProjets.DataSource = managerProjet.TouteLesProjet();
                cmbListeProjets.ValueMember = "no_Projet";
                cmbListeProjets.DisplayMember = "nom_projet";
            }
            catch (Exception)
            {
                throw;
            }       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                managerProjetPiece.SupprimerUnProjet((int)cmbListeProjets.SelectedValue);
                setDataSourceComboBox();
                dgvPieces.DataSource = null;
                for (int i = 0; i < dgvPieces.Rows.Count; i++)
                {
                    dgvPieces[0, dgvPieces.CurrentRow.Index].Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbListeProjets_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                assignerDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void assignerDGV()
        {
            try
            {
                dgvPieces.DataSource = managerProjetPiece.ListerQuantiteAccepteePourProjet((int)cmbListeProjets.SelectedValue, ref context);
                dgvPieces.Columns["no_Projet"].Visible = false;
                dgvPieces.Columns["no_Piece"].ReadOnly = true;
                dgvPieces.Columns["description_Piece"].ReadOnly = true;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        private void casErreurRemettreDGVBonEtat()
        {
            try
            {
                int positionRowIndex = dgvPieces.CurrentRow.Index;
                int positionCellIndex = dgvPieces.CurrentCell.ColumnIndex;

                context = new AL_GJ_TravailEntities();
                dgvPieces.DataSource = null;
                for (int i = 0; i < dgvPieces.Rows.Count; i++)
                {
                    dgvPieces[0, dgvPieces.CurrentRow.Index].Dispose();
                }
                assignerDGV();
                dgvPieces.CurrentCell = dgvPieces.Rows[positionRowIndex].Cells[positionCellIndex];
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
                    throw new Exception("Erreur, aucun changement effectué");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                casErreurRemettreDGVBonEtat();
            }
        }

        private void dgvPieces_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            enregister();
        }
    }
}
