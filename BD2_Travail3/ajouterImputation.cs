﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core;
using System.Data.SqlClient;
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
        ManagerEmploye managerEmploye;
        ManagerProjet managerProjet;
        public AjouterImputation()
        {
            InitializeComponent();
            managerProjet = new ManagerProjet();
            managerImputation = new ManagerImputation();
            managerInventaire = new ManagerInventaire();

            managerEmploye = new ManagerEmploye();  
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
       
        private void AjouterImputation_Load(object sender, EventArgs e)
        {
            dgvAfficherPiece.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cmbProjet.DataSource = managerProjet.TouteLesProjet();
            cmbProjet.ValueMember = "no_Projet";
            cmbProjet.DisplayMember = "nom_projet";
            cmbChoisirEmploye.ValueMember = "no_Employe";
            cmbChoisirEmploye.DisplayMember = "InfoEmploye";
        }

        private void checkForErrors()
        {
            if (dgvAfficherPiece.CurrentCell is null)
            {
                throw new Exception("Aucune pièce de sélectionné");
            }
            if (cmbProjet.SelectedValue is null)
            {
                throw new Exception("Aucun projet de sélectionné");
            }
            if (cmbChoisirEmploye.SelectedValue is null)
            {
                throw new Exception("Aucun employé de sélectionné");
            }
            if (nudQuantite.Value == 0)
            {
                throw new Exception("La quantité ne peut être 0");
            }
        }

        private void btnChoisirEmploye_Click(object sender, EventArgs e)
        {
            try
            {
                cmbChoisirEmploye.DataSource = managerEmploye.ListerEmployeQuiMatchLettresDonnees(cmbChoisirEmploye.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mettreAZero()
        {
            nudQuantite.Value = 0;
            cmbChoisirEmploye.SelectedValue = "";
            cmbProjet.SelectedValue = "";
            dgvAfficherPiece.DataSource = null;
            for (int i = 0; i < dgvAfficherPiece.Rows.Count; i++)
            {
                dgvAfficherPiece[0, dgvAfficherPiece.CurrentRow.Index].Dispose();
            }
        }

        private void btnAjouterImputation_Click(object sender, EventArgs e)
        {
            try
            {
                checkForErrors();

                tbl_Impute imputeAAjouter = new tbl_Impute();
                string no_Piece_Entreprise = (string)dgvAfficherPiece[0, dgvAfficherPiece.CurrentRow.Index].Value;
                imputeAAjouter.no_Employe = (int)cmbChoisirEmploye.SelectedValue;
                imputeAAjouter.no_Projet = (int)cmbProjet.SelectedValue;
                imputeAAjouter.date = DateTime.Now;
                imputeAAjouter.quantite_Retire = (int)nudQuantite.Value;
                int nbreLigneAffectee = managerImputation.AjouterUneImputation(imputeAAjouter, no_Piece_Entreprise);
                if (nbreLigneAffectee > 0)
                {
                    MessageBox.Show("Ajout effectué avec succès");
                    dgvAfficherPiece.DataSource = managerInventaire.listerInventaire(txtRechercheNumeroPiece.Text);
                    mettreAZero();
                    return;
                }
                throw new Exception("Erreur, aucun ajout effectué");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
