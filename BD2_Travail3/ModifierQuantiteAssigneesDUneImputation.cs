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
        public ModifierQuantiteAssigneesDUneImputation()
        {
            InitializeComponent();
        }

        private void ModifierQuantiteAssigneesDUneImputation_Load(object sender, EventArgs e)
        {
            cmbListeProjets.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbListeProjets.DataSource = managerProjet.TouteLesProjet();
            cmbListeProjets.SelectedItem = "";
            cmbListeProjets.ValueMember = "no_Projet";
            cmbListeProjets.DisplayMember = "nom_projet";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
