using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD2_Travail3 {
    public partial class AjouterImputation : Form
    {
        ManagerImputation managerImputation;
        ManagerInventaire managerInventaire;
        ManagerProjet managerProjet;
        public AjouterImputation()
        {
            InitializeComponent();
            managerProjet = new ManagerProjet();
            managerImputation = new ManagerImputation();
            managerInventaire = new ManagerInventaire();
            cmbProjet.DataSource = managerProjet.TouteLesProjet();
            cmbProjet.ValueMember = "no_Projet";
            cmbProjet.DisplayMember = "nom_projet";
        }

        private void btnRechercher_Click(object sender, EventArgs e) {
            try
            {
                
                dgvAfficherPiece.DataSource = managerInventaire.listerInventaire(txtRechercheNumeroPiece.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbProjet_SelectionChangeCommitted(object sender, EventArgs e) {

        }

        private void btnChoisirEmploye_Click(object sender, EventArgs e) {

        }
    }
}
