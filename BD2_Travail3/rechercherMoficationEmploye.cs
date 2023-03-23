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
                mettreTextBoxValueARien();
                cmbRechercheEmploye.Text = "";
                cmbRechercheEmploye.DataSource = managerEmploye.ListerEmployeQuiMatchLettresDonnees(txtNomPrenom.Text);
                cmbRechercheEmploye_SelectionChangeCommitted(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mettreTextBoxValueARien()
        {
            txtCourriel.Text = "";
            txtNom.Text = "";
            txtPrenom.Text = "";
        }

        private void mettreTextBoxDisabled()
        {
            txtCourriel.Enabled = false;
            txtNom.Enabled = false;
            txtPrenom.Enabled = false;   
        }

        private void cmbRechercheEmploye_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cmbRechercheEmploye.SelectedItem is null)
                {
                    mettreTextBoxDisabled();
                }
                else
                {
                    txtCourriel.Enabled = true;
                    txtNom.Enabled = true;
                    txtPrenom.Enabled = true;
                }
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
                if (txtCourriel.Text is "" || txtNom.Text is "" || txtPrenom.Text is "")
                {
                    throw new Exception("Aucun champ(s) ne peut être vide");
                }
                tbl_Employe employeAModifier = new tbl_Employe();
                if (cmbRechercheEmploye.SelectedValue is null)
                {
                    throw new Exception("Vous n'avez aucun employé de sélectionné dans le combo box");
                }
                employeAModifier.no_Employe = (int)cmbRechercheEmploye.SelectedValue;
                employeAModifier.Nom = txtNom.Text;
                employeAModifier.Prénom = txtPrenom.Text;
                employeAModifier.Courriel = txtCourriel.Text;
                int nbreLigneAffectee = managerEmploye.ModifierEmploye(employeAModifier);
                if (nbreLigneAffectee > 0)
                {
                    MessageBox.Show("Modification effectuée avec succès " +nbreLigneAffectee + " de ligne(s) affectée");
                    //cmbRechercheEmploye.Invalidate();
                    return;
                }
                MessageBox.Show("Erreur, aucune ligne affectée");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RechercherMoficationEmploye_Load(object sender, EventArgs e)
        {
            mettreTextBoxDisabled();
            cmbRechercheEmploye.ValueMember = "no_Employe";
            cmbRechercheEmploye.DisplayMember = "InfoEmploye";
        }
    }
}
