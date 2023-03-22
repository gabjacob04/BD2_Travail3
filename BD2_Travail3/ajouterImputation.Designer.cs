namespace BD2_Travail3
{
    partial class AjouterImputation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpRechercherPiece = new System.Windows.Forms.GroupBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.dgvAfficherPiece = new System.Windows.Forms.DataGridView();
            this.txtRechercheNumeroPiece = new System.Windows.Forms.TextBox();
            this.lblSelectionPieceDesiree = new System.Windows.Forms.Label();
            this.lblNoPiece = new System.Windows.Forms.Label();
            this.grpProjet = new System.Windows.Forms.GroupBox();
            this.cmbProjet = new System.Windows.Forms.ComboBox();
            this.lblChoisirProjet = new System.Windows.Forms.Label();
            this.grpEmploye = new System.Windows.Forms.GroupBox();
            this.btnChoisirEmploye = new System.Windows.Forms.Button();
            this.cmbChoisirEmploye = new System.Windows.Forms.ComboBox();
            this.lblEmploye = new System.Windows.Forms.Label();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.btnAjouterImputation = new System.Windows.Forms.Button();
            this.nudQuantite = new System.Windows.Forms.NumericUpDown();
            this.grpRechercherPiece.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfficherPiece)).BeginInit();
            this.grpProjet.SuspendLayout();
            this.grpEmploye.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).BeginInit();
            this.SuspendLayout();
            // 
            // grpRechercherPiece
            // 
            this.grpRechercherPiece.Controls.Add(this.btnRechercher);
            this.grpRechercherPiece.Controls.Add(this.dgvAfficherPiece);
            this.grpRechercherPiece.Controls.Add(this.txtRechercheNumeroPiece);
            this.grpRechercherPiece.Controls.Add(this.lblSelectionPieceDesiree);
            this.grpRechercherPiece.Controls.Add(this.lblNoPiece);
            this.grpRechercherPiece.Location = new System.Drawing.Point(30, 12);
            this.grpRechercherPiece.Name = "grpRechercherPiece";
            this.grpRechercherPiece.Size = new System.Drawing.Size(735, 252);
            this.grpRechercherPiece.TabIndex = 0;
            this.grpRechercherPiece.TabStop = false;
            this.grpRechercherPiece.Text = "Rechercher une pièce avec ou sans scanneur";
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(505, 38);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(176, 29);
            this.btnRechercher.TabIndex = 3;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // dgvAfficherPiece
            // 
            this.dgvAfficherPiece.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAfficherPiece.Location = new System.Drawing.Point(37, 112);
            this.dgvAfficherPiece.Name = "dgvAfficherPiece";
            this.dgvAfficherPiece.RowHeadersWidth = 51;
            this.dgvAfficherPiece.RowTemplate.Height = 24;
            this.dgvAfficherPiece.Size = new System.Drawing.Size(644, 125);
            this.dgvAfficherPiece.TabIndex = 4;
            // 
            // txtRechercheNumeroPiece
            // 
            this.txtRechercheNumeroPiece.Location = new System.Drawing.Point(314, 39);
            this.txtRechercheNumeroPiece.Name = "txtRechercheNumeroPiece";
            this.txtRechercheNumeroPiece.Size = new System.Drawing.Size(170, 27);
            this.txtRechercheNumeroPiece.TabIndex = 2;
            // 
            // lblSelectionPieceDesiree
            // 
            this.lblSelectionPieceDesiree.AutoSize = true;
            this.lblSelectionPieceDesiree.Location = new System.Drawing.Point(37, 76);
            this.lblSelectionPieceDesiree.Name = "lblSelectionPieceDesiree";
            this.lblSelectionPieceDesiree.Size = new System.Drawing.Size(199, 20);
            this.lblSelectionPieceDesiree.TabIndex = 1;
            this.lblSelectionPieceDesiree.Text = "Sélectionner la pièce désirée";
            // 
            // lblNoPiece
            // 
            this.lblNoPiece.AutoSize = true;
            this.lblNoPiece.Location = new System.Drawing.Point(37, 42);
            this.lblNoPiece.Name = "lblNoPiece";
            this.lblNoPiece.Size = new System.Drawing.Size(271, 20);
            this.lblNoPiece.TabIndex = 0;
            this.lblNoPiece.Text = "numéro de pièce (ou partie de numéro)";
            // 
            // grpProjet
            // 
            this.grpProjet.Controls.Add(this.cmbProjet);
            this.grpProjet.Controls.Add(this.lblChoisirProjet);
            this.grpProjet.Location = new System.Drawing.Point(30, 279);
            this.grpProjet.Name = "grpProjet";
            this.grpProjet.Size = new System.Drawing.Size(735, 72);
            this.grpProjet.TabIndex = 1;
            this.grpProjet.TabStop = false;
            this.grpProjet.Text = "Projet";
            // 
            // cmbProjet
            // 
            this.cmbProjet.FormattingEnabled = true;
            this.cmbProjet.Location = new System.Drawing.Point(180, 30);
            this.cmbProjet.Name = "cmbProjet";
            this.cmbProjet.Size = new System.Drawing.Size(336, 28);
            this.cmbProjet.TabIndex = 1;
            // 
            // lblChoisirProjet
            // 
            this.lblChoisirProjet.AutoSize = true;
            this.lblChoisirProjet.Location = new System.Drawing.Point(37, 33);
            this.lblChoisirProjet.Name = "lblChoisirProjet";
            this.lblChoisirProjet.Size = new System.Drawing.Size(118, 20);
            this.lblChoisirProjet.TabIndex = 0;
            this.lblChoisirProjet.Text = "Choisir un projet";
            // 
            // grpEmploye
            // 
            this.grpEmploye.Controls.Add(this.btnChoisirEmploye);
            this.grpEmploye.Controls.Add(this.cmbChoisirEmploye);
            this.grpEmploye.Controls.Add(this.lblEmploye);
            this.grpEmploye.Location = new System.Drawing.Point(30, 372);
            this.grpEmploye.Name = "grpEmploye";
            this.grpEmploye.Size = new System.Drawing.Size(735, 72);
            this.grpEmploye.TabIndex = 2;
            this.grpEmploye.TabStop = false;
            this.grpEmploye.Text = "Employé";
            // 
            // btnChoisirEmploye
            // 
            this.btnChoisirEmploye.Location = new System.Drawing.Point(534, 29);
            this.btnChoisirEmploye.Name = "btnChoisirEmploye";
            this.btnChoisirEmploye.Size = new System.Drawing.Size(176, 29);
            this.btnChoisirEmploye.TabIndex = 2;
            this.btnChoisirEmploye.Text = "Choisir un employé";
            this.btnChoisirEmploye.UseVisualStyleBackColor = true;
            this.btnChoisirEmploye.Click += new System.EventHandler(this.btnChoisirEmploye_Click);
            // 
            // cmbChoisirEmploye
            // 
            this.cmbChoisirEmploye.FormattingEnabled = true;
            this.cmbChoisirEmploye.Location = new System.Drawing.Point(180, 30);
            this.cmbChoisirEmploye.Name = "cmbChoisirEmploye";
            this.cmbChoisirEmploye.Size = new System.Drawing.Size(336, 28);
            this.cmbChoisirEmploye.TabIndex = 1;
            // 
            // lblEmploye
            // 
            this.lblEmploye.AutoSize = true;
            this.lblEmploye.Location = new System.Drawing.Point(37, 33);
            this.lblEmploye.Name = "lblEmploye";
            this.lblEmploye.Size = new System.Drawing.Size(67, 20);
            this.lblEmploye.TabIndex = 0;
            this.lblEmploye.Text = "Employé";
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Location = new System.Drawing.Point(67, 464);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(66, 20);
            this.lblQuantite.TabIndex = 3;
            this.lblQuantite.Text = "Quantité";
            // 
            // btnAjouterImputation
            // 
            this.btnAjouterImputation.Location = new System.Drawing.Point(67, 517);
            this.btnAjouterImputation.Name = "btnAjouterImputation";
            this.btnAjouterImputation.Size = new System.Drawing.Size(302, 29);
            this.btnAjouterImputation.TabIndex = 7;
            this.btnAjouterImputation.Text = "Ajouter imputation";
            this.btnAjouterImputation.UseVisualStyleBackColor = true;
            // 
            // nudQuantite
            // 
            this.nudQuantite.Location = new System.Drawing.Point(210, 462);
            this.nudQuantite.Name = "nudQuantite";
            this.nudQuantite.Size = new System.Drawing.Size(159, 27);
            this.nudQuantite.TabIndex = 6;
            // 
            // AjouterImputation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this.nudQuantite);
            this.Controls.Add(this.btnAjouterImputation);
            this.Controls.Add(this.lblQuantite);
            this.Controls.Add(this.grpEmploye);
            this.Controls.Add(this.grpProjet);
            this.Controls.Add(this.grpRechercherPiece);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AjouterImputation";
            this.Text = "ajouterImputation";
            this.Load += new System.EventHandler(this.AjouterImputation_Load);
            this.grpRechercherPiece.ResumeLayout(false);
            this.grpRechercherPiece.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfficherPiece)).EndInit();
            this.grpProjet.ResumeLayout(false);
            this.grpProjet.PerformLayout();
            this.grpEmploye.ResumeLayout(false);
            this.grpEmploye.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRechercherPiece;
        private System.Windows.Forms.DataGridView dgvAfficherPiece;
        private System.Windows.Forms.TextBox txtRechercheNumeroPiece;
        private System.Windows.Forms.Label lblSelectionPieceDesiree;
        private System.Windows.Forms.Label lblNoPiece;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.GroupBox grpProjet;
        private System.Windows.Forms.ComboBox cmbProjet;
        private System.Windows.Forms.Label lblChoisirProjet;
        private System.Windows.Forms.GroupBox grpEmploye;
        private System.Windows.Forms.Button btnChoisirEmploye;
        private System.Windows.Forms.ComboBox cmbChoisirEmploye;
        private System.Windows.Forms.Label lblEmploye;
        private System.Windows.Forms.Label lblQuantite;
        private System.Windows.Forms.Button btnAjouterImputation;
        private System.Windows.Forms.NumericUpDown nudQuantite;
    }
}