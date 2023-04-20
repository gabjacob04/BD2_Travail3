namespace BD2_Travail3
{
    partial class ModifierProjetConcurrence
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
            this.btnModifier = new System.Windows.Forms.Button();
            this.grpChoisirProjet = new System.Windows.Forms.GroupBox();
            this.cmbListeProjets = new System.Windows.Forms.ComboBox();
            this.lblProjets = new System.Windows.Forms.Label();
            this.grpModifierProjet = new System.Windows.Forms.GroupBox();
            this.lblNoDeProjet = new System.Windows.Forms.Label();
            this.txtNoProjet = new System.Windows.Forms.TextBox();
            this.txtNomProjet = new System.Windows.Forms.TextBox();
            this.lblNomDuProjet = new System.Windows.Forms.Label();
            this.txtDescriptionProjet = new System.Windows.Forms.TextBox();
            this.lblDescriptionProjet = new System.Windows.Forms.Label();
            this.grpChoisirProjet.SuspendLayout();
            this.grpModifierProjet.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(286, 200);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(318, 37);
            this.btnModifier.TabIndex = 18;
            this.btnModifier.Text = "Modifier le projet";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // grpChoisirProjet
            // 
            this.grpChoisirProjet.Controls.Add(this.cmbListeProjets);
            this.grpChoisirProjet.Controls.Add(this.lblProjets);
            this.grpChoisirProjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChoisirProjet.Location = new System.Drawing.Point(23, 21);
            this.grpChoisirProjet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpChoisirProjet.Name = "grpChoisirProjet";
            this.grpChoisirProjet.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpChoisirProjet.Size = new System.Drawing.Size(632, 105);
            this.grpChoisirProjet.TabIndex = 19;
            this.grpChoisirProjet.TabStop = false;
            this.grpChoisirProjet.Text = "Rechercher un projet";
            // 
            // cmbListeProjets
            // 
            this.cmbListeProjets.FormattingEnabled = true;
            this.cmbListeProjets.Location = new System.Drawing.Point(205, 36);
            this.cmbListeProjets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbListeProjets.Name = "cmbListeProjets";
            this.cmbListeProjets.Size = new System.Drawing.Size(399, 26);
            this.cmbListeProjets.TabIndex = 1;
            this.cmbListeProjets.SelectionChangeCommitted += new System.EventHandler(this.cmbListeProjets_SelectionChangeCommitted_1);
            // 
            // lblProjets
            // 
            this.lblProjets.AutoSize = true;
            this.lblProjets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjets.Location = new System.Drawing.Point(37, 34);
            this.lblProjets.Name = "lblProjets";
            this.lblProjets.Size = new System.Drawing.Size(72, 25);
            this.lblProjets.TabIndex = 0;
            this.lblProjets.Text = "Projets";
            // 
            // grpModifierProjet
            // 
            this.grpModifierProjet.Controls.Add(this.txtDescriptionProjet);
            this.grpModifierProjet.Controls.Add(this.lblDescriptionProjet);
            this.grpModifierProjet.Controls.Add(this.btnModifier);
            this.grpModifierProjet.Controls.Add(this.txtNomProjet);
            this.grpModifierProjet.Controls.Add(this.lblNomDuProjet);
            this.grpModifierProjet.Controls.Add(this.txtNoProjet);
            this.grpModifierProjet.Controls.Add(this.lblNoDeProjet);
            this.grpModifierProjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpModifierProjet.Location = new System.Drawing.Point(23, 143);
            this.grpModifierProjet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpModifierProjet.Name = "grpModifierProjet";
            this.grpModifierProjet.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpModifierProjet.Size = new System.Drawing.Size(632, 270);
            this.grpModifierProjet.TabIndex = 20;
            this.grpModifierProjet.TabStop = false;
            this.grpModifierProjet.Text = "Modifier ce projet";
            // 
            // lblNoDeProjet
            // 
            this.lblNoDeProjet.AutoSize = true;
            this.lblNoDeProjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoDeProjet.Location = new System.Drawing.Point(37, 41);
            this.lblNoDeProjet.Name = "lblNoDeProjet";
            this.lblNoDeProjet.Size = new System.Drawing.Size(117, 25);
            this.lblNoDeProjet.TabIndex = 0;
            this.lblNoDeProjet.Text = "No du projet";
            // 
            // txtNoProjet
            // 
            this.txtNoProjet.Location = new System.Drawing.Point(286, 42);
            this.txtNoProjet.Name = "txtNoProjet";
            this.txtNoProjet.Size = new System.Drawing.Size(318, 24);
            this.txtNoProjet.TabIndex = 3;
            // 
            // txtNomProjet
            // 
            this.txtNomProjet.Location = new System.Drawing.Point(286, 94);
            this.txtNomProjet.Name = "txtNomProjet";
            this.txtNomProjet.Size = new System.Drawing.Size(318, 24);
            this.txtNomProjet.TabIndex = 5;
            // 
            // lblNomDuProjet
            // 
            this.lblNomDuProjet.AutoSize = true;
            this.lblNomDuProjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomDuProjet.Location = new System.Drawing.Point(37, 93);
            this.lblNomDuProjet.Name = "lblNomDuProjet";
            this.lblNomDuProjet.Size = new System.Drawing.Size(133, 25);
            this.lblNomDuProjet.TabIndex = 4;
            this.lblNomDuProjet.Text = "Nom du projet";
            // 
            // txtDescriptionProjet
            // 
            this.txtDescriptionProjet.Location = new System.Drawing.Point(286, 147);
            this.txtDescriptionProjet.Name = "txtDescriptionProjet";
            this.txtDescriptionProjet.Size = new System.Drawing.Size(318, 24);
            this.txtDescriptionProjet.TabIndex = 7;
            // 
            // lblDescriptionProjet
            // 
            this.lblDescriptionProjet.AutoSize = true;
            this.lblDescriptionProjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionProjet.Location = new System.Drawing.Point(37, 146);
            this.lblDescriptionProjet.Name = "lblDescriptionProjet";
            this.lblDescriptionProjet.Size = new System.Drawing.Size(189, 25);
            this.lblDescriptionProjet.TabIndex = 6;
            this.lblDescriptionProjet.Text = "Description du projet";
            // 
            // ModifierProjetConcurrence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 446);
            this.Controls.Add(this.grpModifierProjet);
            this.Controls.Add(this.grpChoisirProjet);
            this.Name = "ModifierProjetConcurrence";
            this.Text = "Modifier un projet";
            this.Load += new System.EventHandler(this.ModifierProjetConcurrence_Load);
            this.grpChoisirProjet.ResumeLayout(false);
            this.grpChoisirProjet.PerformLayout();
            this.grpModifierProjet.ResumeLayout(false);
            this.grpModifierProjet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.GroupBox grpChoisirProjet;
        private System.Windows.Forms.ComboBox cmbListeProjets;
        private System.Windows.Forms.Label lblProjets;
        private System.Windows.Forms.GroupBox grpModifierProjet;
        private System.Windows.Forms.Label lblNoDeProjet;
        private System.Windows.Forms.TextBox txtNoProjet;
        private System.Windows.Forms.TextBox txtNomProjet;
        private System.Windows.Forms.Label lblNomDuProjet;
        private System.Windows.Forms.TextBox txtDescriptionProjet;
        private System.Windows.Forms.Label lblDescriptionProjet;
    }
}