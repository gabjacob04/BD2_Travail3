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
        public InformationImputationsDUnePiece()
        {
            InitializeComponent();
            managerInventaire = new ManagerInventaire();
        }

        private void InformationImputationsDUnePiece_Load(object sender, EventArgs e) {

        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                dgvAfficherPiece.DataSource = managerInventaire.listerInventaire(txtRechercheNumeroPiece.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
