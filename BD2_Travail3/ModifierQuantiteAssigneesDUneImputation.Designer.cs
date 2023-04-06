namespace BD2_Travail3
{
    partial class ModifierQuantiteAssigneesDUneImputation
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
            this.dgvPieces = new System.Windows.Forms.DataGridView();
            this.lblPieces = new System.Windows.Forms.Label();
            this.grpChoisirProjet = new System.Windows.Forms.GroupBox();
            this.cmbListeProjets = new System.Windows.Forms.ComboBox();
            this.lblNomProjet = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPieces)).BeginInit();
            this.grpChoisirProjet.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPieces
            // 
            this.dgvPieces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPieces.Location = new System.Drawing.Point(16, 197);
            this.dgvPieces.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPieces.Name = "dgvPieces";
            this.dgvPieces.RowHeadersWidth = 51;
            this.dgvPieces.RowTemplate.Height = 24;
            this.dgvPieces.Size = new System.Drawing.Size(474, 152);
            this.dgvPieces.TabIndex = 12;
            // 
            // lblPieces
            // 
            this.lblPieces.AutoSize = true;
            this.lblPieces.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPieces.Location = new System.Drawing.Point(13, 159);
            this.lblPieces.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPieces.Name = "lblPieces";
            this.lblPieces.Size = new System.Drawing.Size(71, 25);
            this.lblPieces.TabIndex = 10;
            this.lblPieces.Text = "Pièces";
            // 
            // grpChoisirProjet
            // 
            this.grpChoisirProjet.Controls.Add(this.cmbListeProjets);
            this.grpChoisirProjet.Controls.Add(this.lblNomProjet);
            this.grpChoisirProjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChoisirProjet.Location = new System.Drawing.Point(16, 18);
            this.grpChoisirProjet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpChoisirProjet.Name = "grpChoisirProjet";
            this.grpChoisirProjet.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpChoisirProjet.Size = new System.Drawing.Size(474, 85);
            this.grpChoisirProjet.TabIndex = 13;
            this.grpChoisirProjet.TabStop = false;
            this.grpChoisirProjet.Text = "Rechercher un projet";
            // 
            // cmbListeProjets
            // 
            this.cmbListeProjets.FormattingEnabled = true;
            this.cmbListeProjets.Location = new System.Drawing.Point(164, 29);
            this.cmbListeProjets.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbListeProjets.Name = "cmbListeProjets";
            this.cmbListeProjets.Size = new System.Drawing.Size(300, 23);
            this.cmbListeProjets.TabIndex = 1;
            // 
            // lblNomProjet
            // 
            this.lblNomProjet.AutoSize = true;
            this.lblNomProjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomProjet.Location = new System.Drawing.Point(28, 28);
            this.lblNomProjet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomProjet.Name = "lblNomProjet";
            this.lblNomProjet.Size = new System.Drawing.Size(108, 20);
            this.lblNomProjet.TabIndex = 0;
            this.lblNomProjet.Text = "Nom du projet";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(505, 42);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 30);
            this.button1.TabIndex = 14;
            this.button1.Text = "Détruire ce projet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModifierQuantiteAssigneesDUneImputation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpChoisirProjet);
            this.Controls.Add(this.dgvPieces);
            this.Controls.Add(this.lblPieces);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ModifierQuantiteAssigneesDUneImputation";
            this.Text = "ModifierQuantiteAssigneesDUneImputation";
            this.Load += new System.EventHandler(this.ModifierQuantiteAssigneesDUneImputation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPieces)).EndInit();
            this.grpChoisirProjet.ResumeLayout(false);
            this.grpChoisirProjet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPieces;
        private System.Windows.Forms.Label lblPieces;
        private System.Windows.Forms.GroupBox grpChoisirProjet;
        private System.Windows.Forms.ComboBox cmbListeProjets;
        private System.Windows.Forms.Label lblNomProjet;
        private System.Windows.Forms.Button button1;
    }
}