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
    public partial class ModifierProjetConcurrence : Form
    {
        ManagerProjet managerProjet;
        public ModifierProjetConcurrence()
        {
            InitializeComponent();
            managerProjet = new ManagerProjet();
        }

        private void cmbListeProjets_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                dgvInfoSurProjet.DataSource = managerProjet.ProjetParId((int)cmbListeProjets.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ModifierProjetConcurrence_Load(object sender, EventArgs e)
        {
            cmbListeProjets.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbListeProjets.DataSource = managerProjet.TouteLesProjet();
            cmbListeProjets.DisplayMember = "nom_projet";
            cmbListeProjets.ValueMember = "no_projet";
        }
    }
}
