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
    public partial class RechercherMoficationEmploye : Form
    {
        ManagerEmploye managerEmploye;

        public RechercherMoficationEmploye()
        {
            InitializeComponent();
            managerEmploye = new ManagerEmploye();  
            cmbRechercheEmploye.DropDownStyle = ComboBoxStyle.DropDownList; 
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                cmbRechercheEmploye.Text = "";
                if (txtNomPrenom.Text is "")
                {
                    cmbRechercheEmploye.DataSource = managerEmploye.ListerEmploye();
                }
                else
                {
                    string recherche = txtNomPrenom.Text;
                    cmbRechercheEmploye.DataSource = managerEmploye.ListerEmployeQuiMatchLettresDonnees(recherche);
                }
                cmbRechercheEmploye.ValueMember = "no_Employe";
                cmbRechercheEmploye.DisplayMember = "Prénom";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbRechercheEmploye_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                tbl_Employe employe = managerEmploye.GetInfoEmploye((int)cmbRechercheEmploye.SelectedValue);
                txtCourriel.Text = employe.Courriel;
                txtNom.Text = employe.Nom;
                txtPrenom.Text = employe.Prénom;
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
                tbl_Employe employeAModifier = new tbl_Employe();
                employeAModifier.no_Employe = (int)cmbRechercheEmploye.SelectedValue;
                employeAModifier.Nom = txtNom.Text;
                employeAModifier.Prénom = txtPrenom.Text;
                employeAModifier.Courriel = txtCourriel.Text;
                int nbreLigneAffectee = managerEmploye.ModifierEmploye(employeAModifier);
                if (nbreLigneAffectee > 0)
                {
                    MessageBox.Show(nbreLigneAffectee + " de ligne(s) affectée");
                    //cmbRechercheEmploye.Invalidate();
                    return;
                }
                MessageBox.Show("erreur, aucune ligne affectée");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
