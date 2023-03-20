namespace BD2_Travail3
{
    partial class rechercherMoficationEmploye
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
            this.grpRecherche = new System.Windows.Forms.GroupBox();
            this.lblNomPrenom = new System.Windows.Forms.Label();
            this.txtNomPrenom = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.cmbRechercheEmploye = new System.Windows.Forms.ComboBox();
            this.lblSelectionnerEMploye = new System.Windows.Forms.Label();
            this.grpEmploye = new System.Windows.Forms.GroupBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblCourriel = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtCourriel = new System.Windows.Forms.TextBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.grpRecherche.SuspendLayout();
            this.grpEmploye.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRecherche
            // 
            this.grpRecherche.Controls.Add(this.lblSelectionnerEMploye);
            this.grpRecherche.Controls.Add(this.cmbRechercheEmploye);
            this.grpRecherche.Controls.Add(this.btnRechercher);
            this.grpRecherche.Controls.Add(this.txtNomPrenom);
            this.grpRecherche.Controls.Add(this.lblNomPrenom);
            this.grpRecherche.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpRecherche.Location = new System.Drawing.Point(29, 24);
            this.grpRecherche.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpRecherche.Name = "grpRecherche";
            this.grpRecherche.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpRecherche.Size = new System.Drawing.Size(507, 175);
            this.grpRecherche.TabIndex = 0;
            this.grpRecherche.TabStop = false;
            this.grpRecherche.Text = "Rechercher un employé";
            // 
            // lblNomPrenom
            // 
            this.lblNomPrenom.AutoSize = true;
            this.lblNomPrenom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomPrenom.Location = new System.Drawing.Point(60, 40);
            this.lblNomPrenom.Name = "lblNomPrenom";
            this.lblNomPrenom.Size = new System.Drawing.Size(135, 20);
            this.lblNomPrenom.TabIndex = 0;
            this.lblNomPrenom.Text = "nom et/ou prenom";
            // 
            // txtNomPrenom
            // 
            this.txtNomPrenom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNomPrenom.Location = new System.Drawing.Point(201, 37);
            this.txtNomPrenom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomPrenom.Name = "txtNomPrenom";
            this.txtNomPrenom.Size = new System.Drawing.Size(270, 27);
            this.txtNomPrenom.TabIndex = 1;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercher.Location = new System.Drawing.Point(201, 82);
            this.btnRechercher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(270, 29);
            this.btnRechercher.TabIndex = 2;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            // 
            // cmbRechercheEmploye
            // 
            this.cmbRechercheEmploye.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRechercheEmploye.FormattingEnabled = true;
            this.cmbRechercheEmploye.Location = new System.Drawing.Point(201, 128);
            this.cmbRechercheEmploye.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbRechercheEmploye.Name = "cmbRechercheEmploye";
            this.cmbRechercheEmploye.Size = new System.Drawing.Size(270, 28);
            this.cmbRechercheEmploye.TabIndex = 3;
            // 
            // lblSelectionnerEMploye
            // 
            this.lblSelectionnerEMploye.AutoSize = true;
            this.lblSelectionnerEMploye.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectionnerEMploye.Location = new System.Drawing.Point(24, 131);
            this.lblSelectionnerEMploye.Name = "lblSelectionnerEMploye";
            this.lblSelectionnerEMploye.Size = new System.Drawing.Size(171, 20);
            this.lblSelectionnerEMploye.TabIndex = 4;
            this.lblSelectionnerEMploye.Text = "sélectionner un employé";
            // 
            // grpEmploye
            // 
            this.grpEmploye.Controls.Add(this.btnModifier);
            this.grpEmploye.Controls.Add(this.txtCourriel);
            this.grpEmploye.Controls.Add(this.txtNom);
            this.grpEmploye.Controls.Add(this.txtPrenom);
            this.grpEmploye.Controls.Add(this.lblCourriel);
            this.grpEmploye.Controls.Add(this.lblNom);
            this.grpEmploye.Controls.Add(this.lblPrenom);
            this.grpEmploye.Location = new System.Drawing.Point(29, 220);
            this.grpEmploye.Name = "grpEmploye";
            this.grpEmploye.Size = new System.Drawing.Size(507, 214);
            this.grpEmploye.TabIndex = 1;
            this.grpEmploye.TabStop = false;
            this.grpEmploye.Text = "Employé";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPrenom.Location = new System.Drawing.Point(100, 39);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(60, 20);
            this.lblPrenom.TabIndex = 0;
            this.lblPrenom.Text = "Prenom";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(100, 84);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(42, 20);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom";
            // 
            // lblCourriel
            // 
            this.lblCourriel.AutoSize = true;
            this.lblCourriel.Location = new System.Drawing.Point(100, 129);
            this.lblCourriel.Name = "lblCourriel";
            this.lblCourriel.Size = new System.Drawing.Size(61, 20);
            this.lblCourriel.TabIndex = 2;
            this.lblCourriel.Text = "Courriel";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(201, 36);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(169, 27);
            this.txtPrenom.TabIndex = 3;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(201, 81);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(169, 27);
            this.txtNom.TabIndex = 4;
            // 
            // txtCourriel
            // 
            this.txtCourriel.Location = new System.Drawing.Point(201, 126);
            this.txtCourriel.Name = "txtCourriel";
            this.txtCourriel.Size = new System.Drawing.Size(169, 27);
            this.txtCourriel.TabIndex = 5;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(201, 168);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(169, 29);
            this.btnModifier.TabIndex = 6;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // rechercherMoficationEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 460);
            this.Controls.Add(this.grpEmploye);
            this.Controls.Add(this.grpRecherche);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "rechercherMoficationEmploye";
            this.Text = "rechercherMoficationEmploye";
            this.grpRecherche.ResumeLayout(false);
            this.grpRecherche.PerformLayout();
            this.grpEmploye.ResumeLayout(false);
            this.grpEmploye.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRecherche;
        private System.Windows.Forms.Label lblSelectionnerEMploye;
        private System.Windows.Forms.ComboBox cmbRechercheEmploye;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.TextBox txtNomPrenom;
        private System.Windows.Forms.Label lblNomPrenom;
        private System.Windows.Forms.GroupBox grpEmploye;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.TextBox txtCourriel;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblCourriel;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
    }
}