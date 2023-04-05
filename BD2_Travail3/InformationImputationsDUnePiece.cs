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
    public partial class InformationImputationsDUnePiece : Form
    {
        ManagerInventaire managerInventaire;
        ManagerImputation managerImputation;
        public InformationImputationsDUnePiece()
        {
            InitializeComponent();
            managerInventaire = new ManagerInventaire();
            managerImputation = new ManagerImputation();    
        }

        private void InformationImputationsDUnePiece_Load(object sender, EventArgs e) 
        {
            dgvAfficherPiece.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvImputationDUnePiece.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                dgvAfficherPiece.DataSource = managerInventaire.listerInventaire(txtRechercheNumeroPiece.Text);
                dgvImputationDUnePiece.DataSource = null;
                for (int i = 0; i < dgvImputationDUnePiece.Rows.Count; i++)
                {
                    dgvImputationDUnePiece[0, dgvImputationDUnePiece.CurrentRow.Index].Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAfficherInformations_Click(object sender, EventArgs e)
        {
            try
            {
                string annee = nudAnnee.Value.ToString();
                string mois = nudMois.Value.ToString();
                string formatDate = annee + "-" + mois + "-01";
                if (dgvAfficherPiece.CurrentRow is null)
                {
                    throw new Exception("Vous n'avez aucune pièce de sélectionner");
                }
                string no_Piece_Entreprise = (string)dgvAfficherPiece[0, dgvAfficherPiece.CurrentRow.Index].Value;
                dgvImputationDUnePiece.DataSource = managerImputation.getListImputationEnFonctionDUneRechercher(no_Piece_Entreprise, formatDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
